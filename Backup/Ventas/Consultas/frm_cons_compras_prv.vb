
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_cons_compras_prv

    ' Clases
    Dim Cproveedor As New proveedor

    Dim codigo As String = ""

    Dim txt_sql As String = ""

    Dim ref1 As Boolean = False
    Dim ref2 As Boolean = False
    Dim txtR1 As String = ""
    Dim txtR2 As String = ""

    Dim ord_ref1 As Integer = 0
    Dim ord_ref2 As Integer = 0
    Dim formulavnd As String = ""

    Private Sub frm_cons_compras_prv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        dtg_ventas.Rows.Clear()
        rd_resumen.Checked = True
        dtp_del.Value = Now
        dtp_al.Value = Now
        ord_ref1 = 0
        ord_ref2 = 99999
        txtR1 = ""
        txtR2 = ""
        formulavnd = " "
    End Sub

    Private Sub btn_actualiza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_actualiza.Click
        configura_grid()
    End Sub

    Private Sub configura_grid()
        qry_cliente()
        llena_cliente()
    End Sub



    Private Sub qry_cliente()


        Dim fec_del As String = fecha_string(dtp_del.Value) & " 00:00:00.000"
        Dim fec_al As String = fecha_string(dtp_al.Value) & " 23:59:59.999"

        txt_sql = "select f.orden_vendedor," _
                & "f.orden_cp," _
                & "c.nombre," _
                & "f.numero_documento," _
                & "f.fecha_documento," _
                & "f.nombre_cp," _
                & " f.total_con_impuesto, " _
                & " c.codigo " _
                & " from tbl_prv_ingreso f inner join tbl_proveedor c on c.orden = f.orden_cp " _
                & " where f.fecha_documento between '" & fec_del & "' and '" & fec_al & "'"

        If txt_ref1.Text <> "" Or txt_ref2.Text <> "" Then
            txt_sql = txt_sql & " and "
            If txt_ref1.Text <> "" Then
                txt_sql = txt_sql & " c.codigo >= '" & txt_ref1.Text & "'"
                txtR1 = txt_ref1.Text
            Else
                txt_sql = txt_sql & " c.codigo >= '0'"
                txtR1 = "0"
            End If
            txt_sql = txt_sql & " and "
            If txt_ref2.Text = "" Then
                txt_sql = txt_sql & " c.codigo <= 'zzzzzzzzzzzzzzz'"
                txtR2 = "zzzzzzzzzzzzzzz"
            Else
                txt_sql = txt_sql & " c.codigo <= '" & txt_ref2.Text & "'"
                txtR2 = txt_ref2.Text
            End If
            formulavnd = " and {tbl_proveedor.codigo} >= '" & txtR1 & "' and {tbl_proveedor.codigo} <= '" & txtR2 & "'"
        End If
    End Sub

    Private Sub llena_cliente()
        Dim myconn As New SqlConnection(str_cnn)
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            dtg_ventas.Rows.Clear()
            While myReader.Read()
                dtg_ventas.Rows.Add(myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(7), myReader.GetValue(5), myReader.GetValue(6))
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
            Dim consulta As New frm_bus_proveedor
            consulta.codigo = ""
            consulta.ShowDialog()
            If consulta.resultado = True Then
                codigo = consulta.codigo
                busca_vnd()
                If Cproveedor.Aexiste = True Then
                    ord_ref1 = Cproveedor.Aorden
                    txt_ref1.Text = Cproveedor.Acodigo
                    lbl_ref1.Text = Cproveedor.Anombre
                End If
            End If
        End If
    End Sub



    Private Sub txt_ref2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ref2.LostFocus
        ord_ref2 = 0
        If txt_ref2.Text = "*" Then
            Dim consulta As New frm_bus_proveedor
            consulta.codigo = ""
            consulta.ShowDialog()
            If consulta.resultado = True Then
                codigo = consulta.codigo
                busca_vnd()
                If Cproveedor.Aexiste = True Then
                    ord_ref2 = Cproveedor.Aorden
                    txt_ref2.Text = Cproveedor.Acodigo
                    lbl_ref2.Text = Cproveedor.Anombre
                End If
            End If
        End If
    End Sub


    Private Sub busca_vnd()
        Cproveedor.buscar(codigo, str_cnn)
    End Sub


    Private Sub btn_imprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        If rd_resumen.Checked = True Then
            resumen()
        End If
        If rd_detalle.Checked = True Then
            detalle()
        End If
    End Sub

    Private Sub resumen()
        Dim reporte As New frm_RcPrv
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
        reporte.formula = "{tbl_prv_ingreso.fecha_documento} >= DateValue ('" & fec_del & "') and {tbl_prv_ingreso.fecha_documento} <= DateValue ('" & fec_al & "') " & formulavnd
        reporte.Show()
    End Sub

    Private Sub detalle()
        Dim reporte As New frm_RvCli_det
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
        reporte.formula = "{tbl_prv_ingreso.fecha_documento} >= DateValue ('" & fec_del & "') and {tbl_prv_ingreso.fecha_documento} <= DateValue ('" & fec_al & "') " & formulavnd
        reporte.Show()
    End Sub

End Class