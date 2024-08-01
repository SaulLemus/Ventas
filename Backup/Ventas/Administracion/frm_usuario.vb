
Imports System.Data
Imports System.Data.SqlClient


Public Class frm_usuario
    Dim cusuario As New usuario


    Dim modo As Byte = 0  '0 estado inicial, '1 agregando,  2 modificando  3 consultando  4 eliminando

    Dim datos_validos As Boolean = False

    Dim codigo As String = ""
    Dim orden As Integer = 0
    Dim orden_lista As Integer = 0
    Dim perfil As String = ""
    Dim estado As String = "N"


    Private Sub frm_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        modo = 0
        limpia_campos()
        botones_inicio()
        deshabilita_campos()
    End Sub

    Private Sub limpia_campos()
        Me.Text = "Usuario"
        txt_orden.Text = ""
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_clave.Text = ""
        txt_clave1.Text = ""
        rd_ventas.Checked = True
        chk_activo.Checked = False
    End Sub

    Private Sub botones_inicio()
        modo = 0
        ' botones al iniciar el formulario o despues de grabar, eliminar, buscar, o movimientos
        btn_nuevo.Enabled = True
        btn_modifica.Enabled = False
        btn_grabar.Enabled = False
        btn_eliminar.Enabled = False
        btn_cancelar.Enabled = False
        btn_buscar.Enabled = True
    End Sub

    Private Sub botones_agregar()
        Me.Text = "Agregando usuario"
        modo = 1
        ' botones al agregar 
        btn_nuevo.Enabled = False
        btn_modifica.Enabled = False
        btn_grabar.Enabled = True
        btn_eliminar.Enabled = False
        btn_cancelar.Enabled = True
        btn_buscar.Enabled = True
    End Sub

    Private Sub botones_editable()
        btn_nuevo.Enabled = True
        btn_modifica.Enabled = True
        btn_grabar.Enabled = False
        btn_eliminar.Enabled = True
        btn_buscar.Enabled = True
    End Sub

    Private Sub habilita_campos()
        txt_codigo.Enabled = True
        txt_nombre.Enabled = True
        txt_clave.Enabled = True
        txt_clave1.Enabled = True
        rd_ventas.Enabled = True
    End Sub

    Private Sub deshabilita_campos()
        txt_codigo.Enabled = False
        txt_nombre.Enabled = False
        txt_clave.Enabled = False
        txt_clave1.Enabled = False
    End Sub


    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        ' nuevo registro
        limpia_campos()
        habilita_campos()
        botones_agregar()
        chk_activo.Checked = False
        txt_codigo.Focus()
    End Sub



    Private Sub btn_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grabar.Click
        If modo = 1 Then
            valida_datos()
            If datos_validos = True Then
                asignaperfil()
                activado()
                graba_datos()
                deshabilita_campos()
                limpia_campos()
                botones_inicio()
            End If
        End If
        If modo = 2 Then
            asignaperfil()
            activado()
            actualiza_datos()
            deshabilita_campos()
            limpia_campos()
            botones_inicio()
        End If
    End Sub

    Private Sub valida_datos()
        datos_validos = False
        If txt_codigo.Text <> "" Then
            cusuario.buscar(txt_codigo.Text, str_cnn)
            If cusuario.Aexiste = False Then
                datos_validos = True
            Else
                MessageBox.Show("Ya existe codigo de usuario ", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_codigo.Text = ""
                txt_codigo.Focus()
                datos_validos = False
            End If
        Else
            MessageBox.Show("Debe especifica un codigo de usuario valido", "Error al intentar grabar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_codigo.Text = ""
            txt_codigo.Focus()
            datos_validos = False
        End If
    End Sub

    Private Sub graba_datos()
        cusuario.nuevo(txt_codigo.Text, _
                       txt_nombre.Text, _
                       txt_clave.Text, _
                       perfil, _
                       estado, _
                       str_cnn)
    End Sub


    Private Sub actualiza_datos()
        cusuario.modifica(Val(txt_orden.Text), _
                          txt_nombre.Text, _
                          txt_clave.Text, _
                          perfil, _
                          estado, _
                          str_cnn)
    End Sub

    Private Sub asignaperfil()
        If rd_admin.Checked = True Then
            perfil = "Admin"
        Else
            If rd_ventas.Checked = True Then
                perfil = "Ventas"
            Else
                If rd_bodega.Checked = True Then
                    perfil = "Bodega"
                Else
                    If rd_facturador.Checked = True Then
                        perfil = "Facturador"
                    Else
                        If rd_produccion.Checked = True Then
                            perfil = "Produccion"
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub activado()
        If chk_activo.Checked = True Then
            estado = "Activo"
        Else
            estado = "Bloqueado"
        End If
    End Sub



    Private Sub txt_codigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.LostFocus
        If modo = 1 Then
            txt_codigo.Text = UCase(txt_codigo.Text)
            valida_codigo(txt_codigo.Text)
            If txt_codigo.Text <> "ERROR" Then
                cusuario.buscar(Trim(txt_codigo.Text), str_cnn)
                If cusuario.Aexiste = True Then
                    MessageBox.Show("Ya existe ese codigo", "Verificando codigo ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt_codigo.Text = ""
                    txt_codigo.Focus()
                End If
            Else
                MessageBox.Show("Caracter no valido solo de A a Z y de 0 a 9 son validos", "Error ingresando valor para un codigo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                botones_inicio()
                inicializa()
            End If
        End If
    End Sub


    Private Sub btn_modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modifica.Click
        habilita_campos()
        botones_agregar()
        Me.Text = "Modificando usuario"
        modo = 2
        txt_codigo.Enabled = False
        txt_nombre.Focus()
    End Sub


    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        'llama ventana de busqueda de articulos
        limpia_campos()
        deshabilita_campos()
        botones_inicio()
        datos_validos = True
        codigo = ""
        Dim consulta As New frm_bus_usuario
        consulta.codigo = ""
        consulta.ShowDialog()
        datos_validos = consulta.resultado
        ' si no trae datos datos_validos  = false
        If datos_validos = True Then
            cusuario.buscar(consulta.codigo, str_cnn)
            If cusuario.Aexiste = True Then
                codigo = consulta.codigo
                muestra_datos()
                Me.Text = "Cliente: " & codigo & " " & cusuario.Anombre
                modo = 2 'editable
                botones_editable()
            End If
        End If
    End Sub

    Private Sub muestra_datos()
        txt_orden.Text = cusuario.Aorden
        orden = cusuario.Aorden
        txt_codigo.Text = codigo
        txt_nombre.Text = cusuario.Anombre
        txt_clave.Text = cusuario.Aclave
        txt_clave1.Text = cusuario.Aclave
        If cusuario.Aperfil = "Admin" Then
            rd_admin.Checked = True
        Else
            If cusuario.Aperfil = "Ventas" Then
                rd_ventas.Checked = True
            Else
                If cusuario.Aperfil = "Bodega" Then
                    rd_bodega.Checked = True
                Else
                    If cusuario.Aperfil = "Facturador" Then
                        rd_facturador.Checked = True
                    Else
                        If cusuario.Aperfil = "Produccion" Then
                            rd_produccion.Checked = True
                        End If
                    End If
                End If
            End If
        End If
        If cusuario.Aestado = "Activo" Then
            chk_activo.Checked = True
        Else
            chk_activo.Checked = False
        End If
    End Sub



    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        inicializa()
    End Sub

    Private Sub msg_error()
        MessageBox.Show("Error en validacion de clave de acceso", "Error ingresando clave de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        txt_clave.Text = ""
        txt_clave1.Text = ""
        txt_clave.Focus()
    End Sub


    Private Sub txt_clave1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_clave1.LostFocus
        Dim mensaje As String = ""
        Dim err As Integer = 0
        If Len(txt_clave1.Text) > 0 Then
            valida_clave(txt_clave.Text, txt_clave1.Text, mensaje, err)
            If err = 1 Then
                msg_error()
            Else
                If txt_clave.Text <> txt_clave1.Text Then
                    msg_error()
                End If
            End If
        End If
    End Sub

End Class