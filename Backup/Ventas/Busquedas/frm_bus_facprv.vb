
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_bus_facprv

    Public orden As Integer
    Public resultado As Boolean
    Dim cnn As SqlConnection
    Dim txt_sql As String

    Private Sub frm_bus_facprv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resultado = False
        inicializa()
        crea_qry()
        llena_grid()
    End Sub

    Private Sub inicializa()
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_sql = ""
    End Sub

    Private Sub crea_qry()
        If txt_nombre.Text = "" Then
            If txt_codigo.Text = "" Then
                txt_sql = "select c.codigo," _
                        & "c.nombre," _
                        & "z.numero_documento," _
                        & "z.fecha_documento," _
                        & "z.total_con_impuesto," _
                        & "z.orden " _
                        & " from tbl_prv_factura z inner join tbl_proveedor c on c.orden= z.orden_cp"
            Else
                txt_sql = "select c.codigo," _
                        & "c.nombre," _
                        & "z.numero_documento," _
                        & "z.fecha_documento," _
                        & "z.total_con_impuesto," _
                        & "z.orden " _
                        & " from tbl_prv_factura z inner join tbl_proveedor c on c.orden= z.orden_cp " _
                        & "where c.codigo like '%" & txt_codigo.Text & "%' order by c.codigo"
            End If
        Else
            If txt_nombre.Text <> "" Then

                txt_sql = "select c.codigo," _
                        & "c.nombre," _
                        & "z.numero_documento," _
                        & "z.fecha_documento," _
                        & "z.total_con_impuesto," _
                        & "z.orden " _
                        & " from tbl_prv_factura z inner join tbl_proveedor c on c.orden= z.orden_cp " _
                        & "where c.nombre like '%" & txt_nombre.Text & "%' order by c.nombre"

            End If
        End If
    End Sub

    Private Sub llena_grid()
        Dim myconn As New SqlConnection(str_cnn)
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            dtg.Rows.Clear()
            While myReader.Read()
                dtg.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5))
            End While
            'comboproveedor.SelectedIndex = -1
        Else
            dtg.Rows.Clear()
        End If
        myReader.Close()
        myconn.Close()
    End Sub

    Private Sub salida()
        Me.Close()
    End Sub


    Private Sub dtg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg.DoubleClick
        orden = dtg.CurrentRow.Cells(5).Value
        resultado = True
        salida()
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        txt_codigo.Text = ""
        crea_qry()
        llena_grid()
    End Sub


    Private Sub txt_codigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        txt_nombre.Text = ""
        crea_qry()
        llena_grid()
    End Sub


End Class