
Imports System.Data
Imports System.Data.SqlClient

Public Class vendedor
    Public Tcodigo As String
    Public Pcodigo As String

    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean = False

    Private Torden As Integer
    Private Tnombre As String


    Private texto As String
    Private terror As Boolean
    Private txtmsg As String

    Public Sub buscar(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.nombre " _
                 & " from tbl_vendedor a " _
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
                        Pcodigo = Tcodigo
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
                  ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_vendedor " _
                   & " (" _
                   & "codigo," _
                   & "nombre" _
                   & ") " _
                   & "values('" & tcodigo & "'," _
                          & "'" & tnombre & "'" _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo vendedor; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub

    Public Sub DefineCorrelativo(ByVal serie As String, ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_correlativo " _
                   & " (" _
                   & "tipodocumento, " _
                   & "tipocorrelativo," _
                   & "seriedocumento," _
                   & "numeroinicial," _
                   & "numerofinal," _
                   & "numerosiguiente," _
                   & "nombredocumento," _
                   & "estado" _
                   & ") " _
                   & "values('PEDCLI'," _
                          & "'A'," _
                          & "'P" & Trim(serie) & "'," _
                          & 1 & "," _
                          & 99999 & "," _
                          & 1 & "," _
                          & "'Pedido de Cliente'," _
                          & "'A'" _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo correlativo de pedidos de vendedor; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub modifica(ByVal tcodigo As String, _
                      ByVal tnombre As String, _
                      ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "update tbl_vendedor set " _
                   & "nombre = '" & tnombre & "' " _
                   & "  where codigo = '" & tcodigo & "'"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se actualizo vendedor: " & ex.Message
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

            Ttxt_sql = "delete tbl_vendedor where orden = " & torden
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se elimino vendedor; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub


    Public Sub buscar_uso(ByVal Torden As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select top 1 orden_vendedor " _
                 & " from tbl_factura a " _
                 & " where orden_vendedor = '" & Torden & "'"
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

    Public Function Aerror() As Boolean
        Return terror
    End Function

    Public Function Aorden() As Integer
        Return Torden
    End Function

    Public Function Acodigo() As String
        Return Pcodigo
    End Function

    Public Function Anombre() As String
        Return Tnombre
    End Function


End Class
