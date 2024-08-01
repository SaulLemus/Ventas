
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_ConsultaOP

    Dim txt_sql As String = ""


    Private Sub frm_ConsultaOP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
        llena_cmb_usuario()
    End Sub


    Private Sub inicializa()
        cmb_usuario.Items.Clear()
        dtp_del.Value = Now
        dtp_al.Value = Now
        dtg_log.Rows.Clear()
        txt_sql = ""
    End Sub

    Private Sub llena_cmb_usuario()
        Dim myconn As New SqlConnection(str_cnn)

        txt_sql = "select orden, usuario, nombre " _
           & "from tbl_usuario order by usuario"
        Try
            myconn.Open()
            Dim myCmd As New SqlCommand(txt_sql, myconn)
            Dim myReader As SqlDataReader
            myReader = myCmd.ExecuteReader()
            ' Always call Read before accessing data.
            If myReader.HasRows Then
                cmb_usuario.Items.Clear()
                cmb_usuario.Items.Add("Todos")
                cmb_orden_usr.Items.Add(0)
                While myReader.Read()
                    cmb_usuario.Items.Add(myReader.GetValue(1) & " - " & myReader.GetValue(2))
                    cmb_orden_usr.Items.Add(myReader.GetValue(0))
                End While
                cmb_usuario.SelectedIndex = 0
                cmb_orden_usr.SelectedIndex = 0
            Else
                MsgBox("No existe registro", MsgBoxStyle.Information, "Error en busqueda de datos de usuarios")
                inicializa()
            End If
            myReader.Close()
            myconn.Close()
        Catch
        End Try
    End Sub


    Private Sub btn_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actualizar.Click
        datos_registro()
    End Sub

    Private Sub datos_registro()
        crea_consulta()
        llena_registro()
    End Sub

    Private Sub crea_consulta()
        Dim fechadel As String = ""
        Dim fechaal As String = ""

        fechadel = fecha_string(dtp_del.Value)
        fechaal = fecha_string(dtp_al.Value)

        txt_sql = " select objeto, " _
                & " r.usuario, " _
                & " r.usuariow, " _
                & "(select u.nombre from tbl_usuario u where u.usuario = r.usuario), " _
                & "r.equipo, " _
                & "r.fecha, " _
                & "r.resultado " _
                & " from tbllog_operacion r " _
                & " where "
        txt_sql = txt_sql & " fecha between '" & fechadel & "' and '" & fechaal & "' "

        If rd_maestros.Checked = True Then
            txt_sql = txt_sql & " and objeto = 1 "
        End If

        If rd_documentos.Checked = True Then
            txt_sql = txt_sql & " and objeto in (31,32,41) "
        End If

        If rd_inventario.Checked = True Then
            txt_sql = txt_sql & " and objeto in (51,52) "
        End If


    End Sub


    Private Sub llena_registro()
        Dim myconn As New SqlConnection(str_cnn)
        Dim modulo As String = ""

        Try
            myconn.Open()
            Dim myCmd As New SqlCommand(txt_sql, myconn)
            Dim myReader As SqlDataReader
            myReader = myCmd.ExecuteReader()
            ' Always call Read before accessing data.
            If myReader.HasRows Then
                dtg_log.Rows.Clear()
                While myReader.Read()
                    Select Case myReader.GetValue(0)
                        Case Is = 1
                            modulo = "Cliente"
                        Case Is = 31
                            modulo = "Pedido"
                        Case Is = 32
                            modulo = "Factura"
                        Case Is = 41
                            modulo = "Ing.Proveedor"
                        Case Is = 51
                            modulo = "Ing.Manual"
                        Case Is = 52
                            modulo = "Sal.Manual"
                        Case Else
                            Debug.WriteLine("No identificado")
                    End Select
                    dtg_log.Rows.Add(myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), modulo, myReader.GetValue(5), myReader.GetValue(6))
                End While
                cmb_usuario.SelectedIndex = 0
                cmb_orden_usr.SelectedIndex = 0
            Else
                MsgBox("No existe registro", MsgBoxStyle.Information, "Error en busqueda de datos de usuarios")
                inicializa()
            End If
            myReader.Close()
            myconn.Close()
        Catch
        End Try
    End Sub


End Class