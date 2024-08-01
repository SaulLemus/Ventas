
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_bus_almacen

    Public codigo As String
    Public resultado As Boolean
    Public conexistencia As Boolean
    Public ordenart As Integer
    Public existencia As Decimal
    Public ordenalm As Integer


    Dim cnn As SqlConnection
    Dim txt_sql As String

    Private Sub frm_bus_almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resultado = False
        inicializa()
        If conexistencia = False Then
            crea_qry()
        Else
            crea_qry_exi()
        End If
        llena_grid()
    End Sub

    Private Sub inicializa()
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_sql = ""
        If conexistencia = True Then
            dtg.Columns(2).Visible = True
            lbl_codigo.Visible = False
            lbl_descripcion.Visible = False
            txt_codigo.Visible = False
            txt_nombre.Visible = False
        End If
    End Sub


    Private Sub crea_qry_exi()
        txt_sql = "select a.codigo, " _
                        & "a.descripcion, " _
                        & "d.existencia, " _
                        & "d.orden_almacen " _
                        & " from tbl_almacen a " _
                        & " inner join tbl_almacendet d on d.orden_articulo = " & ordenart & " and d.orden_almacen= a.orden " _
                        & " order by codigo"
    End Sub

    Private Sub crea_qry()
        If txt_nombre.Text = "" Then
            If txt_codigo.Text = "" Then
                txt_sql = "select codigo, descripcion from tbl_almacen order by codigo"
            Else
                txt_sql = "select codigo, descripcion from tbl_almacen where codigo like '%" & txt_codigo.Text & "%' order by codigo"
            End If
        Else
            If txt_nombre.Text <> "" Then
                txt_sql = "select codigo, descripcion from tbl_almance where nombre like '%" & txt_nombre.Text & "%' order by nombre"
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
                If conexistencia = False Then
                    dtg.Rows.Add(myReader.GetValue(0), myReader.GetValue(1))
                Else
                    dtg.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3))
                End If
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
        txt_nombre.Text = ""
        crea_qry()
        llena_grid()
    End Sub

    Private Sub dtg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg.DoubleClick
        codigo = dtg.CurrentRow.Cells(0).Value
        If conexistencia = True Then
            existencia = dtg.CurrentRow.Cells(2).Value
        End If
        resultado = True
        ordenalm = dtg.CurrentRow.Cells(3).Value
        salida()
    End Sub


End Class