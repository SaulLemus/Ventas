
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_cons_ventas_art

    ' Clases
    Dim Carticulo As New articulo


    ' Tipos de columnas
    Dim colVnd As New DataGridViewTextBoxColumn
    Dim colFac As New DataGridViewTextBoxColumn
    Dim colFec As New DataGridViewTextBoxColumn
    Dim colCli As New DataGridViewTextBoxColumn
    Dim colTot As New DataGridViewTextBoxColumn

    Dim codigo As String = ""

    Dim txt_sql As String = ""

    Dim ref1 As Boolean = False
    Dim ref2 As Boolean = False
    Dim txtR1 As String = ""
    Dim txtR2 As String = ""
    Dim formulavnd As String = ""

    Dim ord_ref1 As Integer = 0
    Dim ord_ref2 As Integer = 0

    Private Sub frm_cons_ventas_art_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtR1 = ""
        txtR2 = ""
        formulavnd = ""
        dtg_ventas.Rows.Clear()
        dtp_del.Value = Now
        dtp_al.Value = Now
    End Sub

    Private Sub btn_actualiza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_actualiza.Click
        configura_grid()
    End Sub

    Private Sub configura_grid()
        qry_articulo()
        llena_articulo()
    End Sub


    Private Sub qry_articulo()

        Dim fec_del As String = fecha_string(dtp_del.Value) & " 00:00:00.000"
        Dim fec_al As String = fecha_string(dtp_al.Value) & " 23:59:59.999"


        txt_sql = " select v.nombre, " _
                & "f.numero_documento," _
                & "f.fecha_sistema," _
                & "f.nombre_cp," _
                & "a.codigo," _
                & "d.descripcion," _
                & "d.cantidad," _
                & "d.total_linea " _
                & " from tbl_cli_factura f inner join tbl_cliente c on c.orden = f.orden_cp " _
                & " inner join tbl_cli_factura_det d on d.orden_doc = f.orden " _
                & " inner join tbl_articulo a on a.orden = d.orden_articulo " _
                & " inner join tbl_vendedor v on v.orden = f.orden_vendedor " _
                & " where f.fecha_sistema between '" & fec_del & "' and '" & fec_al & "' and f.estado <> 'N'"

        If txt_ref1.Text <> "" Or txt_ref2.Text <> "" Then
            txt_sql = txt_sql & " and "
            If txt_ref1.Text <> "" Then
                txt_sql = txt_sql & " a.codigo >= '" & txt_ref1.Text & "'"
                txtR1 = txt_ref1.Text
            Else
                txt_sql = txt_sql & " a.codigo >= '0'"
                txtR1 = "0"
            End If
            txt_sql = txt_sql & " and "
            If txt_ref2.Text = "" Then
                txt_sql = txt_sql & " c.codigo <= 'zzzzzzzzzzzzzzz'"
                txtR2 = "zzzzzzzzzzzzzzz"
            Else
                txt_sql = txt_sql & " a.codigo <= '" & txt_ref2.Text & "'"
                txtR2 = txt_ref2.Text
            End If
            formulavnd = " and {tbl_articulo.codigo} >= '" & txtR1 & "' and {tbl_articulo.codigo} <= '" & txtR2 & "'"
        End If

    End Sub

    Private Sub llena_articulo()
        Dim myconn As New SqlConnection(str_cnn)
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            dtg_ventas.Rows.Clear()
            While myReader.Read()
                dtg_ventas.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5), myReader.GetValue(6), myReader.GetValue(7))
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
            Dim consulta As New frm_bus_articulo
            consulta.codigo = ""
            consulta.ShowDialog()
            If consulta.resultado = True Then
                codigo = consulta.codigo
                busca_vnd()
                If Carticulo.Aexiste = True Then
                    ord_ref1 = Carticulo.Aorden
                    txt_ref1.Text = Carticulo.Acodigo
                    lbl_ref1.Text = Carticulo.Adescripcion
                End If
            End If
        End If
    End Sub


    Private Sub txt_ref2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ref2.LostFocus
        ord_ref2 = 0
        If txt_ref2.Text = "*" Then
            Dim consulta As New frm_bus_articulo
            consulta.codigo = ""
            consulta.ShowDialog()
            If consulta.resultado = True Then
                codigo = consulta.codigo
                busca_vnd()
                If Carticulo.Aexiste = True Then
                    ord_ref2 = Carticulo.Aorden
                    txt_ref2.Text = Carticulo.Acodigo
                    lbl_ref2.Text = Carticulo.Adescripcion
                End If
            End If
        End If
    End Sub

    Private Sub busca_vnd()
        Carticulo.buscar(codigo, str_cnn)
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        resumen()
    End Sub

    Private Sub resumen()
        Dim reporte As New frm_RvArt
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
        reporte.formula = "{tbl_cli_factura.fecha_sistema} >= DateValue ('" & fec_del & "') and {tbl_cli_factura.fecha_sistema} <= DateValue ('" & fec_al & "') and {tbl_cli_factura.estado} <> 'N' " & formulavnd
        reporte.Show()
    End Sub



End Class