Imports System.Data
Imports System.Data.SqlClient

Public Class frm_bus_pedidocli

    Public orden As Integer
    Public resultado As Boolean
    Public factura As Boolean
    Dim cnn As SqlConnection
    Dim txt_sql As String


    Private Sub frm_bus_pedidocli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resultado = False
        inicializa()
        llenado()
    End Sub


    Private Sub inicializa()
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_sql = ""
        If factura = True Then
            rd_pendientes.Visible = False
            rd_todos.Visible = False
        Else
            rd_pendientes.Visible = True
            rd_todos.Visible = True
        End If
        rd_pendientes.Checked = True
    End Sub

    Private Sub llenado()
        crea_qry()
        llena_grid()
    End Sub

    Private Sub crea_qry()
        ' EStado (A)ctivo (C)errado despacho  a(N)nulado
        ' Facturas 0 no ha sido facturado   1 ya fue facturado
        txt_sql = ""
        If txt_nombre.Text = "" Then
            If txt_codigo.Text = "" Then
                txt_sql = "select c.codigo," _
                        & "c.nombre," _
                        & "z.numero_documento," _
                        & "z.fecha_documento," _
                        & "z.total_con_impuesto," _
                        & "z.orden, " _
                        & "z.estado " _
                        & " from tbl_cli_pedido z inner join tbl_cliente c on c.orden= z.orden_cp "
                If rd_pendientes.Checked = True Then
                    txt_sql = txt_sql & " where z.estado = 'A' and z.facturado = 0 order by z.fecha_documento desc"
                Else
                    txt_sql = txt_sql & " order by fecha_documento desc"
                End If
            Else
                txt_sql = "select c.codigo," _
                        & "c.nombre," _
                        & "z.numero_documento," _
                        & "z.fecha_documento," _
                        & "z.total_con_impuesto," _
                        & "z.orden, " _
                        & "z.estado " _
                        & " from tbl_cli_pedido z inner join tbl_cliente c on c.orden= z.orden_cp " _
                        & "where c.codigo like '%" & txt_codigo.Text & "%'"
                If rd_pendientes.Checked = True Then
                    txt_sql = txt_sql & " and estado = 'A' and facturado = 0 order by fecha_documento desc"
                Else
                    txt_sql = txt_sql & "  order by fecha_documento desc"
                End If
            End If
        Else
            If txt_nombre.Text <> "" Then

                txt_sql = "select c.codigo," _
                        & "c.nombre," _
                        & "z.numero_documento," _
                        & "z.fecha_documento," _
                        & "z.total_con_impuesto," _
                        & "z.orden, " _
                        & "z.estado " _
                        & " from tbl_cli_pedido z inner join tbl_cliente c on c.orden= z.orden_cp " _
                        & "where c.nombre like '%" & txt_nombre.Text & "%'"
                If rd_pendientes.Checked = True Then
                    txt_sql = txt_sql & " and estado = 'A' and facturado = 0 order by fecha_documento desc "
                Else
                    txt_sql = txt_sql & "  order by fecha_documento desc"
                End If
            End If
        End If
    End Sub

    Private Sub llena_grid()
        Dim myconn As New SqlConnection(str_cnn)
        Dim estado As String = ""
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            dtg.Rows.Clear()
            While myReader.Read()
                If myReader.GetValue(6) = "A" Then
                    estado = "Activo"
                Else
                    If myReader.GetValue(6) = "C" Then
                        estado = "Cerrado"
                    Else
                        If myReader.GetValue(6) = "N" Then
                            estado = "*aNulado*"
                        End If
                    End If
                End If
                dtg.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5), estado)
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
        orden = dtg.CurrentRow.Cells(5).Value
        resultado = True
        salida()
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        txt_codigo.Text = ""
        crea_qry()
        llena_grid()
    End Sub

    Private Sub rd_todos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rd_todos.CheckedChanged
        llenado()
    End Sub


End Class