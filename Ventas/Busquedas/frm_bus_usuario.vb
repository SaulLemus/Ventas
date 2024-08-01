
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_bus_usuario

    Public codigo As String
    Public resultado As Boolean
    Dim cnn As SqlConnection
    Dim txt_sql As String


    Private Sub frm_bus_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                txt_sql = "select usuario, nombre from tbl_usuario order by usuario"
            Else
                txt_sql = "select usuario, nombre from tbl_usuario where usuario like '%" & txt_codigo.Text & "%' order by codigo"
            End If
        Else
            If txt_nombre.Text <> "" Then
                txt_sql = "select usuario, nombre from tbl_usuario where nombre like '%" & txt_nombre.Text & "%' order by nombre"
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
                dtg.Rows.Add(myReader.GetValue(0), myReader.GetValue(1))
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

    Private Sub txt_codigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        txt_codigo.Text = ""
        crea_qry()
        llena_grid()
    End Sub


    Private Sub dtg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg.DoubleClick
        codigo = dtg.CurrentRow.Cells(0).Value
        resultado = True
        salida()
    End Sub


    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        txt_codigo.Text = ""
        crea_qry()
        llena_grid()
    End Sub


End Class