Public Class frm_login
    Dim cusuario As New usuario
    Public acceso As Boolean
    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ingresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
        cusuario.valida_ingreso(txt_usuario.Text, txt_clave.Text, str_cnn)
        If cusuario.Aexiste = True Then
            acceso = True
            salida()
        Else
            acceso = False
            salida()
        End If
    End Sub

    Private Sub salida()
        Me.Close()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        salida()
    End Sub
End Class