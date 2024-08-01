
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_cons_existencia
    Public codigo As String
    Public resultado As Boolean
    Dim cnn As SqlConnection
    Dim txt_sql As String

    Private Sub frm_cons_existencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                txt_sql = "select a.codigo," _
                        & " a.descripcion," _
                        & "a.eximin," _
                        & "a.eximax," _
                        & "a.precio_costo," _
                        & "c.existencia, " _
                        & " (select codigo from tbl_almacen where orden = c.orden_almacen) " _
                        & " from tbl_almacendet c inner join tbl_articulo a on a.orden = c.orden_articulo"
            Else
                txt_sql = "select   a.codigo," _
                        & " a.descripcion," _
                        & "a.eximin," _
                        & "a.eximax," _
                        & "a.precio_costo," _
                        & "c.existencia, " _
                        & " (select codigo from tbl_almacen where orden = c.orden_almacen) " _
                        & " from tbl_almacendet c inner join tbl_articulo a on a.orden = c.orden_articulo" _
                        & " where a.codigo like '%" & txt_codigo.Text & "%' order by codigo"

            End If
        Else
            If txt_nombre.Text <> "" Then
                txt_sql = "select   a.codigo," _
                        & " a.descripcion," _
                        & "a.eximin," _
                        & "a.eximax," _
                        & "a.precio_costo," _
                        & "c.existencia, " _
                        & " (select codigo from tbl_almacen where orden = c.orden_almacen) " _
                        & " from tbl_almacendet c inner join tbl_articulo a on a.orden = c.orden_articulo" _
                        & " where a.descripcion like '%" & txt_nombre.Text & "%' order by codigo"
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
            dtg_articulos.Rows.Clear()
            While myReader.Read()
                dtg_articulos.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5), myReader.GetValue(6))
            End While
            'comboproveedor.SelectedIndex = -1
        Else
            dtg_articulos.Rows.Clear()
        End If
        myReader.Close()
        myconn.Close()
    End Sub

    Private Sub salida()
        Me.Close()
    End Sub

    Private Sub dtg_articulos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_articulos.DoubleClick
        codigo = dtg_articulos.CurrentRow.Cells(0).Value
        resultado = True
        salida()
    End Sub

    Private Sub txt_codigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        txt_nombre.Text = ""
        crea_qry()
        llena_grid()
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        txt_codigo.Text = ""
        crea_qry()
        llena_grid()
    End Sub

End Class