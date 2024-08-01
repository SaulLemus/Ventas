
Imports System.Data
Imports System.Data.SqlClient

Public Class articulo

    Public Tcodigo As String
    Public Pcodigo As String

    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean

    Private Torden As Integer
    Private Tdescripcion As String
    Private Tprecio_ult_compra As Decimal
    Private Tprecio_costo As Decimal
    Private Texistencia As Decimal
    Private Teximin As Decimal
    Private Teximax As Decimal
    Private Tunidades As Decimal

    Private texto As String
    Private terror As Byte
    Private txtmsg As String


    ' Formque en que se manejan los precios para las librerias
    ' el precio_ult_compra es el precio al que santillana le vende a los ditribuidores con un X%+
    ' el precio_costo si es el precio costo real para el distribuidor que es el precio_ult_compra sin el X%+
    ' el precio 1 es el precio que debe vender el distribuidor que es el precio costo + el X%+ (o el precio ultima compra)



    Public Sub buscar(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.descripcion, " _
                 & "a.precio_ult_compra, " _
                 & "a.precio_costo, " _
                 & "a.existencia, " _
                 & "a.eximin, " _
                 & "a.eximax, " _
                 & "a.unidades_empaque " _
                 & " from tbl_articulo a " _
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
                        Tprecio_ult_compra = Tdtr.Item(2)
                        Tprecio_costo = Tdtr.Item(3)
                        Texistencia = Tdtr.Item(4)
                        Teximin = Tdtr.Item(5)
                        Teximax = Tdtr.Item(6)
                        Tunidades = Tdtr.Item(7)
                        Pcodigo = Tcodigo
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = False
        End Try
    End Sub

    Public Sub buscar_orden(ByVal Torden As Integer, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.descripcion, " _
                 & "a.precio_ult_compra, " _
                 & "a.precio_costo, " _
                 & "a.existencia, " _
                 & "a.eximin, " _
                 & "a.eximax, " _
                 & "a.unidades_empaque " _
                 & " from tbl_articulo a " _
                 & " where a.orden = '" & Torden & "'"
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Tdescripcion = Tdtr.Item(1)
                        Tprecio_ult_compra = Tdtr.Item(2)
                        Tprecio_costo = Tdtr.Item(3)
                        Texistencia = Tdtr.Item(4)
                        Teximin = Tdtr.Item(5)
                        Teximax = Tdtr.Item(6)
                        Tunidades = Tdtr.Item(7)
                        Pcodigo = Tcodigo
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = False
        End Try
    End Sub

    Public Sub buscar_almacenX(ByVal TordenArt As Integer, ByVal TordenAlm As Integer, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select orden " _
                 & " from tbl_almacendet  " _
                 & " where orden_almacen = " & TordenAlm & " and orden_articulo = " & TordenArt
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
            texto = ex.Message
            txtmsg = "Error buscando articulo en almacen "
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = False
        End Try
    End Sub

    Public Sub nuevo(ByVal tcodigo As String, _
                      ByVal tnombre As String, _
                      ByVal Tprecio_ult_compra As Decimal, _
                      ByVal Tprecio_costo As Decimal, _
                      ByVal Texistencia As Decimal, _
                      ByVal TexiMin As Decimal, _
                      ByVal TexiMax As Decimal, _
                      ByVal Tunidades As Integer, _
                      ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_articulo " _
                   & " (" _
                   & "codigo," _
                   & "descripcion," _
                   & "eximin," _
                   & "eximax," _
                   & "unidades_empaque" _
                   & ") " _
                   & "values('" & tcodigo & "'," _
                          & "'" & tnombre & "'," _
                          & TexiMin & "," _
                          & TexiMax & "," _
                          & Tunidades _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo articulo; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub agrega_almacenX(ByVal TordenAlm As Integer, ByVal TordenArt As Integer, _
                      ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_almacendet " _
                   & " (" _
                   & "orden_almacen," _
                   & "orden_articulo," _
                   & "existencia" _
                   & ") " _
                   & "values(" & TordenAlm & "," _
                          & TordenArt & "," _
                          & 0.0 _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo articulo en almacen; " & TordenAlm & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub modifica(ByVal tcodigo As String, _
                      ByVal tnombre As String, _
                      ByVal TexiMin As Decimal, _
                      ByVal TexiMax As Decimal, _
                      ByVal Tunidades As Integer, _
                      ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "update tbl_articulo set " _
                   & "descripcion = '" & tnombre & "', " _
                   & "precio_costo =" & Tprecio_costo & ", " _
                   & "eximin = " & TexiMin & "," _
                   & "eximax = " & TexiMax & "," _
                   & "unidades_empaque = " & Tunidades _
                   & " where codigo = '" & tcodigo & "'"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo articulo; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub elimina(ByVal torden As Integer, _
                  ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "delete tbl_articulo where orden = " & torden
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se elimino articulo; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub



    Public Sub movimiento_nuevo(ByVal tcodigo As String, _
                      ByVal tnombre As String, _
                      ByVal Tprecio_ult_compra As Decimal, _
                      ByVal Tprecio_costo As Decimal, _
                      ByVal Texistencia As Decimal, _
                      ByVal TexiMin As Decimal, _
                      ByVal TexiMax As Decimal, _
                      ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            'Ttxt_sql = "INSERT INTO tbl_movart " _
            '       & " (" _
            '       & "orden_articulo," _
            '       & "tipo_movimiento," _
            '       & "cantidad," _
            '       & "fecha," _
            '       & "tipo_documento," _
            '       & "orden_documento," _
            '       & "orden_almacen," _
            '       & "existencia" _
            '       & ") " _
            '       & "values(" & Tordenart & "," _
            '              & ttipomov & "," _
            '              & Tcantidad & "," _
            '              & Tfecha & "," _
            '              & Ttipodoc & "," _
            '              & Tordendoc & "," _
            '              & Tordenalmacen & "," _
            '              & Texistencia & "," _
            '              & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            'Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo articulo; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub


    Public Sub movimiento_busca(ByVal torden As Integer, _
              ByVal tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(tstc)
        Ttxt_sql = "select top 1 orden_articulo " _
                 & " from tbl_movart  " _
                 & " where orden_Articulo = '" & torden & "'"
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
            texto = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
    End Sub


    Public Sub buscar_almacen1(ByVal Torden As Integer, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select existencia " _
                 & " from tbl_almacendet  " _
                 & " where orden_almacen = 1 and orden_articulo = " & Torden
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Texistencia = Tdtr.Item(0)
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = False
        End Try
    End Sub


    Public Sub buscar_existencia(ByVal Torden As Integer, ByVal TordenAlm As Integer, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select existencia " _
                 & " from tbl_almacendet  " _
                 & " where orden_almacen = " & TordenAlm & " and orden_articulo = " & Torden
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Texistencia = Tdtr.Item(0)
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = False
        End Try
    End Sub



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

    Public Function Adescripcion() As String
        Return Tdescripcion
    End Function

    Public Function Aprecio_ult_compra() As Decimal
        Return Tprecio_ult_compra
    End Function

    Public Function Aprecio_costo() As Decimal
        Return Tprecio_costo
    End Function

    Public Function Aexistencia() As Decimal
        Return Texistencia
    End Function

    Public Function Aeximin() As Decimal
        Return Teximin
    End Function

    Public Function Aeximax() As Decimal
        Return Teximax
    End Function

    Public Function Aunidades() As Integer
        Return Tunidades
    End Function


End Class
