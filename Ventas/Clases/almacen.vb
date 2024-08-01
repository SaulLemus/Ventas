

Imports System.Data
Imports System.Data.SqlClient

Public Class almacen
    Public Tcodigo As String

    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean = False

    Private Torden As Integer
    Private Tdescripcion As String


    Private texto As String
    Private terror As Boolean
    Private txtmsg As String

    Public Sub buscar(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.descripcion " _
                 & " from tbl_almacen a " _
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
                        Tdescripcion = Tdtr.Item(1)
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



    Public Sub busca_ultimo(ByRef Torden As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select isnull(max(orden),0) from tbl_almacen "
        Try
        Tcnn.Open()
        Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
        Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Torden = Tdtr.Item(0)
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
                  ByVal tdescripcion As String, _
                  ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_almacen " _
                   & " (" _
                   & "codigo," _
                   & "descripcion" _
                   & ") " _
                   & "values('" & tcodigo & "'," _
                          & "'" & tdescripcion & "'" _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo almacen; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub modifica(ByVal tcodigo As String, _
                      ByVal tdescripcion As String, _
                      ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "update tbl_almacen set " _
                   & "descripcion = '" & tdescripcion & "' " _
                   & "  where codigo = '" & tcodigo & "'"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se actualizo almacen: " & ex.Message
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

            Ttxt_sql = "delete tbl_almacen where orden = " & torden
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se elimino almacen; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub


    Public Sub buscar_uso(ByVal Torden As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select top 1 orden " _
                 & " from tbl_almacendet a " _
                 & " where orden_almacen = '" & Torden & "'"
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


    Public Sub inserta_detalle(ByVal tordenalm As Integer, ByVal tordenart As Integer, ByVal Tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(Tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_almacendet " _
                   & " (" _
                   & "orden_almacen," _
                   & "orden_articulo," _
                   & "existencia" _
                   & ") " _
                   & "values(" & tordenalm & "," _
                          & tordenart & "," _
                          & 0 _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabaron articulos de almacen; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
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

    Public Function Adescripcion() As String
        Return Tdescripcion
    End Function


End Class
