
Imports System.Data
Imports System.Data.SqlClient

Public Class traslado


    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean
    Private Terror As Boolean
    Private txtmsg As String
    Private tultimo As Integer

    Public Sub agrega_traslado(ByVal TordenArt As Integer, _
                               ByVal TordenAOri As Integer, _
                               ByVal TordenADes As Integer, _
                               ByVal Tcantidad As Integer, _
                  ByVal tstc As String)
        Terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_traslado " _
                   & " (" _
                   & "orden_articulo," _
                   & "orden_almOrigen," _
                   & "orden_almDestino," _
                   & "cantidad" _
                   & ") " _
                   & "values(" & TordenArt & "," _
                          & TordenAOri & "," _
                          & TordenADes & "," _
                          & Tcantidad _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo traslado de articulo " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            Terror = True
        End Try
        Tcnn.Close()
    End Sub

    Public Sub act_existencia(ByVal TordenArt As Integer, _
                               ByVal TordenAlm As Integer, _
                               ByVal Tcantidad As Integer, _
                               ByVal Tsuma As Boolean, _
                  ByVal tstc As String)
        Terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            If Tsuma = True Then
                Ttxt_sql = "update tbl_almacendet set " _
                       & "existencia = existencia + " & Tcantidad _
                       & " where orden_articulo = " & TordenArt & " and orden_almacen = " & TordenAlm
            Else
                Ttxt_sql = "update tbl_almacendet set " _
                       & "existencia = existencia - " & Tcantidad _
                       & " where orden_articulo = " & TordenArt & " and orden_almacen = " & TordenAlm
            End If
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se actualizo existencia en almacen; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            Terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub agrega_ingreso(ByVal TordenArt As Integer, _
                           ByVal TordenADes As Integer, _
                           ByVal Tcantidad As Integer, _
              ByVal tstc As String)
        Terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_ingreso " _
                   & " (" _
                   & "orden_articulo," _
                   & "orden_almDestino," _
                   & "cantidad" _
                   & ") " _
                   & "values(" & TordenArt & "," _
                          & TordenADes & "," _
                          & Tcantidad _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo ingreso de articulo " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            Terror = True
        End Try
        Tcnn.Close()
    End Sub



    Public Sub agrega_salida(ByVal TordenArt As Integer, _
                           ByVal TordenADes As Integer, _
                           ByVal Tcantidad As Integer, _
              ByVal tstc As String)
        Terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_salida " _
                   & " (" _
                   & "orden_articulo," _
                   & "orden_almOrigen," _
                   & "cantidad" _
                   & ") " _
                   & "values(" & TordenArt & "," _
                          & TordenADes & "," _
                          & Tcantidad _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo salida de articulo " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            Terror = True
        End Try
        Tcnn.Close()
    End Sub

    Public Sub buscar_ultimo_ingman(ByVal Torden As Integer, ByVal TordAlm As Integer, ByVal Tstc As String)
        Texiste = False
        Terror = False
        'Tstc = cnn_stc
        tultimo = 1
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select max(orden) " _
                 & " from tbl_ingreso " _
                 & " where orden_articulo = " & Torden & " and orden_almDestino = " & TordAlm
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        tultimo = Tdtr.Item(0)
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            txtmsg = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            Terror = True
        End Try
    End Sub

    Public Sub buscar_ultimo_salman(ByVal Torden As Integer, ByVal TordAlm As Integer, ByVal Tstc As String)
        Texiste = False
        Terror = False
        'Tstc = cnn_stc
        tultimo = 1
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select max(orden) " _
                 & " from tbl_salida " _
                 & " where orden_articulo = " & Torden & " and orden_almOrigen = " & TordAlm
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        tultimo = Tdtr.Item(0)
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            txtmsg = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            Terror = True
        End Try
    End Sub


    Public Function Aerror() As Boolean
        Return Terror
    End Function

    Public Function Aexiste() As Boolean
        Return Texiste
    End Function

    Public Function Aultimo() As Integer
        Return tultimo
    End Function

End Class


