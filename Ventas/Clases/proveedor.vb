

Imports System.Data
Imports System.Data.SqlClient

Public Class proveedor
    Public Tcodigo As String

    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean = False

    Private Xcodigo As String
    Private Torden As Integer
    Private Tnombre As String
    Private Tdireccion As String
    Private Ttelefono As String
    Private Tcorreo As String
    Private Tsaldo As Decimal
    Private Tnit As String
    Private Tlista As Integer

    Private CC_orden As Integer
    Private CC_tipo_movimiento As String
    Private cc_orden_documento As Integer
    Private cc_fecha_transaccionad As Date
    Private cc_monto_transaccion As Decimal
    Private cc_obs As String


    Private texto As String
    Private terror As Boolean
    Private txtmsg As String

    Public Sub buscar(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.nombre, " _
                 & "a.direccion, " _
                 & "a.telefono, " _
                 & "a.correo, " _
                 & "a.saldo, " _
                 & "a.nit " _
                 & " from tbl_proveedor a " _
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
                        Tdireccion = Tdtr.Item(2)
                        Ttelefono = Tdtr.Item(3)
                        Tcorreo = Tdtr.Item(4)
                        Tsaldo = Tdtr.Item(5)
                        Tnit = Tdtr.Item(6)
                        Xcodigo = Tcodigo
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


    Public Sub nuevo(ByVal tcodigo As String, _
                  ByVal tnombre As String, _
                  ByVal Tdireccion As String, _
                  ByVal Ttelefono As String, _
                  ByVal Tnit As String, _
                  ByVal Tcorreo As String, _
                  ByVal Tlista As Integer, _
                  ByVal Tsaldo As Integer, _
                  ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "SET DATEFORMAT ymd  " _
                   & "INSERT INTO tbl_proveedor " _
                   & " (" _
                   & "codigo," _
                   & "nombre," _
                   & "direccion," _
                   & "telefono," _
                   & "nit," _
                   & "correo," _
                   & "saldo " _
                   & ") " _
                   & "values('" & tcodigo & "'," _
                          & "'" & tnombre & "'," _
                          & "'" & Tdireccion & "'," _
                          & "'" & Ttelefono & "'," _
                          & "'" & Tnit & "'," _
                          & "'" & Tcorreo & "'," _
                          & Tsaldo _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo proveedor; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub modifica(ByVal tcodigo As String, _
                      ByVal tnombre As String, _
                      ByVal Tdireccion As String, _
                      ByVal Ttelefono As String, _
                      ByVal Tnit As String, _
                      ByVal Tcorreo As String, _
                      ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "SET DATEFORMAT ymd  " _
                   & "update tbl_proveedor set " _
                   & "nombre = '" & tnombre & "', " _
                   & "direccion = '" & Tdireccion & "', " _
                   & "telefono = '" & Ttelefono & "'," _
                   & "nit = '" & Tnit & "'," _
                   & "correo = '" & Tcorreo & "' " _
                   & "where codigo = '" & tcodigo & "'"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se actualizo proveedor: " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub


    Public Sub elimina(ByVal torden As Integer, _
          ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "delete tbl_proveedor where orden = " & torden
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se elimino proveedor; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub


    Public Sub buscar_cc(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select top 1 a.orden, " _
                 & " from tbl_ccproveedor a " _
                 & " where codigo_cp = '" & Tcodigo & "'"
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            terror = True
            txtmsg = "Error verificando movimientos: " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
    End Sub






    ' *************************************
    ' *************  SALIDA ***************
    ' *************************************

    Public Function Aexiste() As Boolean
        Return Texiste
    End Function

    Public Function Acodigo() As String
        Return Xcodigo
    End Function

    Public Function Aorden() As Integer
        Return Torden
    End Function

    Public Function Anombre() As String
        Return Tnombre
    End Function

    Public Function Adireccion() As String
        Return Tdireccion
    End Function

    Public Function Atelefono() As String
        Return Ttelefono
    End Function

    Public Function Acorreo() As String
        Return Tcorreo
    End Function

    Public Function Asaldo() As Decimal
        Return Tsaldo
    End Function

    Public Function Anit() As String
        Return Tnit
    End Function

    Public Function Alista() As Integer
        Return Tlista
    End Function

End Class
