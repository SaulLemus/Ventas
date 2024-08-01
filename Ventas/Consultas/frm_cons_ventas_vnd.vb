
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_cons_ventas_vnd

    ' Clases
    Dim Cvendedor As New vendedor

    Dim codigo As String = ""

    Dim txt_sql As String = ""

    Dim ref1 As Boolean = False
    Dim ref2 As Boolean = False
    Dim txtR1 As String = ""
    Dim txtR2 As String = ""

    Dim ord_ref1 As Integer = 0
    Dim ord_ref2 As Integer = 0
    Dim formulavnd As String = ""
    Dim tipo_factura As String = ""


    Private Sub frm_cons_ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        limpia_campos()
    End Sub

    Private Sub limpia_campos()
        txt_ref1.Text = ""
        txt_ref2.Text = ""
        lbl_ref1.Text = ""
        lbl_ref2.Text = ""
        rd_resumen.Checked = True
        dtg_ventas.Rows.Clear()
        dtp_del.Value = Now
        dtp_al.Value = Now
        ord_ref1 = 0
        ord_ref2 = 99999
        txtR1 = ""
        txtR2 = ""
        rd_todo.Checked = True
        formulavnd = " "
    End Sub

    Private Sub btn_actualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actualiza.Click
        configura_grid()
    End Sub

    Private Sub configura_grid()
        qry_vendedor()
        llena_vendedor()
    End Sub


    Private Sub qry_vendedor()


        Dim fec_del As String = fecha_string(dtp_del.Value) & " 00:00:00.000"
        Dim fec_al As String = fecha_string(dtp_al.Value) & " 23:59:59.999"
        tipo_factura = ""

        txt_sql = "select f.orden_vendedor," _
                & "f.orden_cp," _
                & "v.nombre," _
                & "f.numero_documento," _
                & "f.fecha_sistema," _
                & "f.nombre_cp," _
                & " f.total_con_impuesto, " _
                & " v.codigo " _
                & " from tbl_cli_factura f inner join tbl_vendedor v on v.orden = f.orden_vendedor " _
                & " where f.fecha_sistema between '" & fec_del & "' and '" & fec_al & "' and f.estado <> 'N'"
        If rd_a.Checked = True Then
            txt_sql = txt_sql & " and f.tipo_factura = 'A' "
            tipo_factura = "A"
        Else
            If rd_b.Checked = True Then
                txt_sql = txt_sql & " and f.tipo_factura = 'B' "
                tipo_factura = "B"
            End If
        End If

        If txt_ref1.Text <> "" Or txt_ref2.Text <> "" Then
            txt_sql = txt_sql & " and "
            If txt_ref1.Text <> "" Then
                txt_sql = txt_sql & " v.codigo >= '" & txt_ref1.Text & "'"
                txtR1 = txt_ref1.Text
            Else
                txt_sql = txt_sql & " v.codigo >= '0'"
                txtR1 = "0"
            End If
            txt_sql = txt_sql & " and "
            If txt_ref2.Text = "" Then
                txt_sql = txt_sql & " v.codigo <= 'zzzzzzzzzzzzzzz'"
                txtR2 = "zzzzzzzzzzzzzzz"
            Else
                txt_sql = txt_sql & " v.codigo <= '" & txt_ref2.Text & "'"
                txtR2 = txt_ref2.Text
            End If
            formulavnd = " and {tbl_vendedor.codigo} >= '" & txtR1 & "' and {tbl_vendedor.codigo} <= '" & txtR2 & "'"
        End If
    End Sub

    Private Sub llena_vendedor()
        Dim myconn As New SqlConnection(str_cnn)
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            dtg_ventas.Rows.Clear()
            While myReader.Read()
                dtg_ventas.Rows.Add(myReader.GetValue(7), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5), myReader.GetValue(6))
            End While
            'comboproveedor.SelectedIndex = -1
        Else
            dtg_ventas.Rows.Clear()
        End If
        myReader.Close()
        myconn.Close()
    End Sub

    Private Sub txt_ref1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ref1.LostFocus
        ord_ref1 = 0
        If txt_ref1.Text = "*" Then
            Dim consulta As New frm_bus_vendedor
            consulta.codigo = ""
            consulta.ShowDialog()
            If consulta.resultado = True Then
                codigo = consulta.codigo
                busca_vnd()
                If Cvendedor.Aexiste = True Then
                    ord_ref1 = Cvendedor.Aorden
                    txt_ref1.Text = Cvendedor.Acodigo
                    lbl_ref1.Text = Cvendedor.Anombre
                End If
            End If
        End If
    End Sub


    Private Sub txt_ref2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ref2.LostFocus
        ord_ref2 = 0
        If txt_ref2.Text = "*" Then
            Dim consulta As New frm_bus_vendedor
            consulta.codigo = ""
            consulta.ShowDialog()
            If consulta.resultado = True Then
                codigo = consulta.codigo
                busca_vnd()
                If Cvendedor.Aexiste = True Then
                    ord_ref2 = Cvendedor.Aorden
                    txt_ref2.Text = Cvendedor.Acodigo
                    lbl_ref2.Text = Cvendedor.Anombre
                End If
            End If
        End If
    End Sub

    Private Sub busca_vnd()
        Cvendedor.buscar(codigo, str_cnn)
    End Sub


    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click

        If rd_resumen.Checked = True Then
            resumen()
        End If
        If rd_detalle.Checked = True Then
            detalle()
        End If
    End Sub

    Private Sub resumen()
        Dim reporte As New frm_Rvvnd
        Dim fec_del As String = ""
        Dim fec_al As String = ""
        reporte.fec_del = dtp_del.Value
        reporte.fec_al = dtp_al.Value
        fec_del = Year(dtp_del.Value) & "," _
                & Month(dtp_del.Value) & "," _
                & Microsoft.VisualBasic.DateAndTime.Day(dtp_del.Value)

        ' Nota evaluar si es necesario 00:00:00.000 en fechas

        fec_al = Year(dtp_al.Value) & "," _
        & Month(dtp_al.Value) & "," _
        & Microsoft.VisualBasic.DateAndTime.Day(dtp_al.Value)
        reporte.formula = "{tbl_cli_factura.fecha_sistema} >= DateValue ('" & fec_del & "') and {tbl_cli_factura.fecha_sistema} <= DateValue ('" & fec_al & "')  and {tbl_cli_factura.estado} <> 'N' " & formulavnd
        If rd_a.Checked = True Then
            reporte.formula = reporte.formula & " and {tbl_cli_factura.tipo_factura} = 'A' "
        Else
            If rd_b.Checked = True Then
                reporte.formula = reporte.formula & " and {tbl_cli_factura.tipo_factura} = 'B' "
            End If
        End If
        reporte.Show()
    End Sub

    Private Sub detalle()
        Dim reporte As New frm_Rvvnd_det
        Dim fec_del As String = ""
        Dim fec_al As String = ""
        reporte.fec_del = dtp_del.Value
        reporte.fec_al = dtp_al.Value
        fec_del = Year(dtp_del.Value) & "," _
                & Month(dtp_del.Value) & "," _
                & Microsoft.VisualBasic.DateAndTime.Day(dtp_del.Value)

        ' Nota evaluar si es necesario 00:00:00.000 en fechas

        fec_al = Year(dtp_al.Value) & "," _
        & Month(dtp_al.Value) & "," _
        & Microsoft.VisualBasic.DateAndTime.Day(dtp_al.Value)

        reporte.formula = "{tbl_cli_factura.fecha_sistema} >= DateValue ('" & fec_del & "') and {tbl_cli_factura.fecha_sistema} <= DateValue ('" & fec_al & "')  and {tbl_cli_factura.estado} <> 'N' " & formulavnd
        If rd_a.Checked = True Then
            reporte.formula = reporte.formula & " and {tbl_cli_factura.tipo_factura} = 'A' "
        Else
            If rd_b.Checked = True Then
                reporte.formula = reporte.formula & " and {tbl_cli_factura.tipo_factura} = 'B' "
            End If
        End If
        reporte.Show()
    End Sub


End Class