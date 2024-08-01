
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_cons_ventas_gen

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

    Private Sub frm_cons_ventas_gen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        limpia_campos()
    End Sub

    Private Sub limpia_campos()
        rd_resumen.Checked = True
        dtg_ventas.Rows.Clear()
        dtp_del.Value = Now
        dtp_al.Value = Now
        ord_ref1 = 0
        ord_ref2 = 99999
        txtR1 = ""
        txtR2 = ""
        formulavnd = " "
    End Sub

    Private Sub btn_actualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actualiza.Click
        configura_grid()
    End Sub

    Private Sub configura_grid()
        qry_vendedor()
        llena_ventas()
    End Sub


    Private Sub qry_vendedor()


        Dim fec_del As String = fecha_string(dtp_del.Value) & " 00:00:00.000"
        Dim fec_al As String = fecha_string(dtp_al.Value) & " 23:59:59.999"

        txt_sql = "select distinct f.numero_documento," _
                & "f.fecha_sistema," _
                & "c.codigo," _
                & "f.nombre_cp," _
                & " f.total_con_impuesto " _
                & " from tbl_cli_factura f inner join tbl_vendedor v on v.orden = f.orden_vendedor " _
                & "inner join tbl_cliente c on c.orden = f.orden_cp " _
                & " where f.fecha_sistema between '" & fec_del & "' and '" & fec_al & "' and estado <> 'N'"

    End Sub

    Private Sub llena_ventas()
        Dim myconn As New SqlConnection(str_cnn)
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            dtg_ventas.Rows.Clear()
            While myReader.Read()
                dtg_ventas.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4))
            End While
            'comboproveedor.SelectedIndex = -1
        Else
            dtg_ventas.Rows.Clear()
        End If
        myReader.Close()
        myconn.Close()
    End Sub


    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        Dim reporte As New frm_Rvgen
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