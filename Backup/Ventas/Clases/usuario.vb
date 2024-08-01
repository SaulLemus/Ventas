
Imports System.Data
Imports System.Data.SqlClient


Public Class usuario
    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean = False
    Private texto As String
    Private terror As Boolean
    Private txtmsg As String

    Private Torden As Integer
    Private Tnombre As String
    Private Tcodigo As String
    Private Pusuario As String
    Private Tclave As String
    Private Testado As String
    Private Tperfil As String

    Public Sub buscar(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.nombre, " _
                 & "a.clave, " _
                 & "a.perfil, " _
                 & "a.estado " _
                 & " from tbl_usuario a " _
                 & " where a.usuario = '" & Tcodigo & "'"
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Torden = Tdtr.Item(0)
                        Tnombre = Tdtr.Item(1)
                        Tclave = Tdtr.Item(2)
                        Tperfil = Tdtr.Item(3)
                        Testado = Tdtr.Item(4)
                        Pusuario = Tcodigo
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
    End Sub

    Public Sub nuevo(ByVal tusuario As String, _
          ByVal tnombre As String, _
          ByVal tclave As String, _
          ByVal tperfil As String, _
          ByVal testado As String, _
          ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_usuario " _
                   & " (" _
                   & "usuario," _
                   & "nombre," _
                   & "clave," _
                   & "perfil," _
                   & "estado" _
                   & ") " _
                   & "values('" & tusuario & "'," _
                          & "'" & tnombre & "'," _
                          & "'" & tclave & "'," _
                          & "'" & tperfil & "'," _
                          & "'" & testado & "'" _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo USUARIO; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub




    Public Sub buscar_permiso(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.nombre, " _
                 & "a.clave, " _
                 & "a.estado " _
                 & " from tbl_usuario a " _
                 & " where codigo = '" & Tcodigo & "'"
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Torden = Tdtr.Item(0)
                        Tnombre = Tdtr.Item(1)
                        Tclave = Tdtr.Item(2)
                        Testado = Tdtr.Item(3)
                        Pusuario = Tcodigo
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
    End Sub

    Public Sub nuevo_permiso(ByVal tordenusr As String, _
          ByVal tfrm As String, _
          ByVal tpermiso As String, _
          ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()
            'Todo Lectura Nada
            Ttxt_sql = "INSERT INTO tbl_usuario_permiso " _
                   & " (" _
                   & "orden_usuario," _
                   & "formulario," _
                   & "permiso " _
                   & ") " _
                   & "values('" & tordenusr & "'," _
                          & "'" & tfrm & "'," _
                          & "'" & tpermiso & "'" _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo permiso de USUARIO; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub modifica(ByVal torden As String, _
                  ByVal tnombre As String, _
                  ByVal tclave As String, _
                  ByVal tperfil As String, _
                  ByVal testado As String, _
                  ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "update tbl_usuario set " _
                   & "nombre = '" & tnombre & "', " _
                   & "clave = '" & tclave & "', " _
                   & "perfil = '" & tperfil & "', " _
                   & "estado = '" & testado & "' " _
                   & "  where orden = '" & torden & "'"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se actualizo usuario: " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub


    Public Sub modifica_permiso(ByVal tordenUsr As String, _
              ByVal tfrm As String, _
              ByVal tpermiso As String, _
              ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "update tbl_usuario_permiso set " _
                   & "permiso = '" & tpermiso & "', " _
                   & "  where orden_usuario = '" & tordenUsr & "' and formulario = '" & tfrm & "'"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se actualizo usuario: " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub


    Public Sub valida_ingreso(ByVal Tcodigo As String, ByVal Tclave As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.nombre, " _
                 & "a.clave, " _
                 & "a.perfil, " _
                 & "a.estado " _
                 & " from tbl_usuario a " _
                 & " where a.usuario = '" & Tcodigo & "' and clave = '" & Tclave & "' and estado ='Activo'"
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Torden = Tdtr.Item(0)
                        Tnombre = Tdtr.Item(1)
                        Tclave = Tdtr.Item(2)
                        Tperfil = Tdtr.Item(3)
                        Testado = Tdtr.Item(4)
                        Pusuario = Tcodigo
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
    End Sub


    ' *************************************
    ' *************  SALIDA ***************
    ' *************************************

    Public Function Aexiste() As Boolean
        Return Texiste
    End Function

    Public Function Aerror() As Boolean
        Return terror
    End Function

    Public Function Aorden() As Integer
        Return Torden
    End Function

    Public Function Ausuario() As String
        Return Pusuario
    End Function

    Public Function Anombre() As String
        Return Tnombre
    End Function


    Public Function Aclave() As String
        Return Tclave
    End Function


    Public Function Aperfil() As String
        Return Tperfil
    End Function

    Public Function Aestado() As String
        Return Testado
    End Function
End Class
