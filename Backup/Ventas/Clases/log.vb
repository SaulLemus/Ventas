
Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class log

    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean = False
    Private Terror As Boolean = False
    Private txtmsg As String = ""

    Public Sub registrar(ByVal Tobjeto As Byte, ByVal Torden_objeto As Integer, ByRef resultado As String, ByVal tstc As String)
        Dim Tusuario As String = Ventas.txt_usrgen.Text
        Dim Wusuario As String = Environment.UserName
        Dim Tequipo As String = Environment.MachineName
        Ttxt_sql = "insert into tbllog_operacion " _
               & "(objeto,orden_objeto,resultado,usuario,usuariow,equipo) values (" _
               & Tobjeto & ", " _
               & Torden_objeto & ", " _
               & "'" & resultado & "', " _
               & "'" & Tusuario & "', " _
               & "'" & Wusuario & "', " _
               & "'" & Tequipo & "')"
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo registro de operacion;  " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            Terror = True
        End Try
        Tcnn.Close()
    End Sub


End Class
