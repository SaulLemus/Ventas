
Imports System.Data
Imports System.Data.SqlClient

Public Class Cliente
    Public Tcodigo As String

    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean = False

    Private Xcodigo As String
    Private Torden As Integer
    Private Tultimo As Integer
    Private Tnombre As String
    Private Tdireccion As String
    Private Ttelefono As String
    Private Tcorreo As String
    Private Tsaldo As Decimal
    Private Tnit As String
    Private Tlista As Integer
    Private Tdescripcion As String

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
                 & "a.nit, " _
                 & " isnull((select x.descripcion from tbl_listaprecio x where x.orden = a.lista),'No asignado'), " _
                 & "a.lista " _
                 & " from tbl_cliente a " _
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
                        Tdescripcion = Tdtr.Item(7)
                        Tlista = Tdtr(8)
                        Xcodigo = Tcodigo
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            txtmsg = ex.Message
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
                   & "INSERT INTO tbl_cliente " _
                   & " (" _
                   & "codigo," _
                   & "nombre," _
                   & "direccion," _
                   & "telefono," _
                   & "nit," _
                   & "correo," _
                   & "Lista, " _
                   & "saldo " _
                   & ") " _
                   & "values('" & tcodigo & "'," _
                          & "'" & tnombre & "'," _
                          & "'" & Tdireccion & "'," _
                          & "'" & Ttelefono & "'," _
                          & "'" & Tnit & "'," _
                          & "'" & Tcorreo & "'," _
                          & Tlista & "," _
                          & Tsaldo _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo cliente; " & ex.Message
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
                      ByVal Tlista As Integer, _
                      ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "SET DATEFORMAT ymd  " _
                   & "update tbl_cliente set " _
                   & "nombre = '" & tnombre & "', " _
                   & "direccion = '" & Tdireccion & "', " _
                   & "telefono = '" & Ttelefono & "'," _
                   & "nit = '" & Tnit & "'," _
                   & "correo = '" & Tcorreo & "', " _
                   & "lista = " & Tlista & " " _
                   & "where codigo = '" & tcodigo & "'"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se actualizo cliente: " & ex.Message
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

            Ttxt_sql = "delete tbl_cliente where orden = " & torden
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se elimino cliente; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub


    Public Sub buscar_cc(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.tipo_movimiento, " _
                 & "a.orden_documento, " _
                 & "a.fecha_transaccion, " _
                 & "a.monto_transaccion, " _
                 & "a.obs " _
                 & " from tbl_cccliente a " _
                 & " where codigo_cp = '" & Tcodigo & "'"
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        CC_orden = Tdtr.Item(0)
                        CC_tipo_movimiento = Tdtr.Item(1)
                        cc_orden_documento = Tdtr.Item(2)
                        cc_fecha_transaccionad = Tdtr.Item(3)
                        cc_monto_transaccion = Tdtr.Item(4)
                        cc_obs = Tdtr.Item(5)
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            terror = True
            txtmsg = "Error verificando movimientos: " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
    End Sub


    Public Sub ultimo(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden " _
                 & " from tbl_cliente a " _
                 & " where codigo = '" & Tcodigo & "'"
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Tultimo = Tdtr.Item(0)
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            txtmsg = ex.Message
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

    Public Function Aorden() As Integer
        Return Torden
    End Function

    Public Function Acodigo() As String
        Return Xcodigo
    End Function

    Public Function Aultimo() As Integer
        Return Tultimo
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

    Public Function Adescripcion() As String
        Return Tdescripcion
    End Function


    Public Function Aerror() As Boolean
        Return terror
    End Function

    Public Function AMsgError() As String
        Return txtmsg
    End Function


End Class
