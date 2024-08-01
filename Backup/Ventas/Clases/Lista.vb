
Imports System.Data
Imports System.Data.SqlClient

Public Class Lista
    Public Tcodigo As String

    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean = False

    Private Torden As Integer
    Private Tdescripcion As String
    Private Ttipo As String
    Private Tpor As Decimal
    Private Porden As Integer
    Private texto As String
    Private terror As Boolean
    Private txtmsg As String

    Public Sub buscar(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.descripcion, " _
                 & "a.tipo, " _
                 & "a.porcentaje " _
                 & " from tbl_listaprecio a " _
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
                        Ttipo = Tdtr.Item(2)
                        Tpor = Tdtr.Item(3)
                        Porden = Torden
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



    Public Sub buscar_orden(ByVal Torden As Integer, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.descripcion, " _
                 & "a.tipo, " _
                 & "a.porcentaje " _
                 & " from tbl_listaprecio a " _
                 & " where orden = " & Torden
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Porden = Torden
                        Tdescripcion = Tdtr.Item(1)
                        Ttipo = Tdtr.Item(2)
                        Tpor = Tdtr.Item(3)
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
                  ByVal Ttipo As String, _
                  ByVal Tpor As Decimal, _
                  ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_listaprecio " _
                   & " (" _
                   & "codigo," _
                   & "descripcion," _
                   & "tipo, " _
                   & "porcentaje " _
                   & ") " _
                   & "values('" & tcodigo & "'," _
                          & "'" & tdescripcion & "'," _
                          & "'" & Ttipo & "', " _
                          & Tpor _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo listado; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub modifica(ByVal tcodigo As String, _
                      ByVal tdescripcion As String, _
                      ByVal Ttipo As String, _
                      ByVal Tpor As Decimal, _
                      ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "update tbl_listaprecio set " _
                   & "descripcion = '" & tdescripcion & "', " _
                   & "tipo = '" & Ttipo & "', " _
                   & "porcentaje = " & Tpor _
                   & "  where codigo = '" & tcodigo & "'"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se actualizo listado: " & ex.Message
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

            Ttxt_sql = "delete tbl_listapreciodo where orden = " & torden
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se elimino listado; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub


    'Public Sub buscar_detalle(ByVal Tcodigo As String, ByVal Tstc As String)
    '    Texiste = False
    '    'Tstc = cnn_stc
    '    Tcnn = New SqlConnection(Tstc)
    '    Ttxt_sql = "select a.orden, " _
    '             & "a.descripcion, " _
    '             & "a.tipo " _
    '             & " from tbl_listaprecio a " _
    '             & " where codigo = '" & Tcodigo & "'"
    '    Try
    '        Tcnn.Open()
    '        Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
    '        Tdtr = Tcmm.ExecuteReader()
    '        With Tdtr
    '            If .HasRows Then
    '                Texiste = True
    '                While .Read
    '                    CC_orden = Tdtr.Item(0)
    '                    CC_tipo_movimiento = Tdtr.Item(1)
    '                    cc_orden_documento = Tdtr.Item(2)
    '                    cc_fecha_transaccionad = Tdtr.Item(3)
    '                    cc_monto_transaccion = Tdtr.Item(4)
    '                    cc_obs = Tdtr.Item(5)
    '                End While
    '            End If
    '        End With
    '        Tcnn.Close()
    '    Catch ex As SqlException
    '        terror = True
    '        txtmsg = "Error verificando movimientos: " & ex.Message
    '        MsgBox(txtmsg, MsgBoxStyle.Information)
    '    End Try
    'End Sub


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
        Return Porden
    End Function

    Public Function Adescripcion() As String
        Return Tdescripcion
    End Function

    Public Function Atipo() As String
        Return Ttipo
    End Function

    Public Function Apor() As String
        Return Tpor
    End Function

End Class
