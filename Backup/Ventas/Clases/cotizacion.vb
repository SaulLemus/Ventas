

Imports System.Data
Imports System.Data.SqlClient


Public Class cotizacion

    Public Tcodigo As String
    Public Tcodigovnd As String

    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean = False
    Private tultima As Integer

    Private Torden As Integer
    Private Tnumero As Integer
    Private Tcorrelativo As Integer
    Private Tdireccion As String
    Private Ttelefono As String
    Private Tcorreo As String
    Private Tsaldo As Decimal
    Private Tnit As String
    Private Tlista As Integer
    Private Tdescripcion As String
    Private Tvendedor As String
    Private Tnumerdoc As Integer
    Private Tnombrecp As String
    Private Tfechadoc As Date
    Private Tfechaven As Date
    Private Tobs As String




    Private texto As String
    Private terror As Boolean
    Private txtmsg As String

    Public Sub correlativo_siguiente(ByVal Ttipo As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select top 1 numerosiguiente " _
                 & " from tbl_correlativo " _
                 & " where tipodocumento = '" & Ttipo & "' order by orden desc"
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Tcorrelativo = Tdtr.Item(0)
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

    Public Sub nuevo(ByVal tnumero As Integer, _
              ByVal torden_cp As String, _
              ByVal tnombre As String, _
              ByVal tdireccion As String, _
              ByVal tnit As String, _
              ByVal tserie As String, _
              ByVal tfechdoc As String, _
              ByVal tfechavence As String, _
              ByVal tvendedor As Integer, _
              ByVal ttotsinimpuesto As Decimal, _
              ByVal tporcDesc As Decimal, _
              ByVal tmontoDesc As Decimal, _
              ByVal tmontoimpuesto As Decimal, _
              ByVal totalconimpuesto As Decimal, _
              ByVal tobs As String, _
              ByVal tstc As String)
        terror = False
        Dim Tfechasistema As Date = Now
        Dim fechastr As String = fecha_string(Tfechasistema)
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_cli_cotiza " _
                   & " (" _
                   & "orden_cp," _
                   & "nombre_cp," _
                   & "direccion," _
                   & "nit_cp," _
                   & "serie_documento," _
                   & "numero_documento," _
                   & "fecha_documento," _
                   & "fecha_vence," _
                   & "orden_vendedor," _
                   & "total_sin_impuesto," _
                   & "porcentaje_desc," _
                   & "monto_descuento," _
                   & "monto_impuesto," _
                   & "total_con_impuesto," _
                   & "Observaciones," _
                   & "estado " _
                   & ") " _
                   & "values('" & torden_cp & "'," _
                          & "'" & tnombre & "'," _
                          & "'" & tdireccion & "'," _
                          & "'" & tnit & "'," _
                          & "'" & tserie & "'," _
                          & "'" & tnumero & "'," _
                          & "'" & tfechdoc & "'," _
                          & "'" & tfechavence & "'," _
                          & "'" & tvendedor & "'," _
                          & "'" & ttotsinimpuesto & "'," _
                          & "'" & tporcDesc & "'," _
                          & "'" & tmontoDesc & "'," _
                          & "'" & tmontoimpuesto & "'," _
                          & "'" & totalconimpuesto & "'," _
                          & "'" & tobs & "'," _
                          & "'A'" _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo encabezado de documento; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub




    Public Sub buscar_ultima(ByVal Torden As Integer, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select max(orden) " _
                 & " from tbl_cli_cotiza " _
                 & " where orden_cp = '" & Torden & "'"
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        tultima = Tdtr.Item(0)
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

    Public Sub nuevo_detalle(ByVal tultimo As Integer, _
              ByVal torden_Art As Integer, _
              ByVal tdescripcion As String, _
              ByVal tordenalmacen As Integer, _
              ByVal tcosto_articulo As Decimal, _
              ByVal texistencia As Decimal, _
              ByVal tcantidad As Decimal, _
              ByVal timpuesto As Decimal, _
              ByVal ttotallinea As Decimal, _
              ByVal tprecio As Decimal, _
              ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "INSERT INTO tbl_cli_cotiza_det " _
                   & " (" _
                   & "orden_doc," _
                   & "orden_articulo," _
                   & "descripcion," _
                   & "orden_almacen," _
                   & "costo_unitario," _
                   & "existencia," _
                   & "cantidad," _
                   & "impuesto," _
                   & "total_linea," _
                   & "precio_venta" _
                   & ") " _
                   & "values(" & tultimo & "," _
                          & torden_Art & "," _
                          & "'" & tdescripcion & "'," _
                          & tordenalmacen & "," _
                          & tcosto_articulo & "," _
                          & texistencia & "," _
                          & tcantidad & "," _
                          & timpuesto & "," _
                          & ttotallinea & "," _
                          & tprecio _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            txtmsg = "No se grabo linea de detalle; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = True
        End Try
        Tcnn.Close()
    End Sub



    Public Sub actualiza_correlativo(ByVal ttipodoc As String, _
                  ByVal tstc As String)
        terror = False
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "update tbl_correlativo set numerosiguiente = numerosiguiente + 1 " _
                   & "  where tipodocumento = 'COTCLI'"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = True
            txtmsg = "No se actualizo correlativo: " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub

    Public Sub busca(ByVal Torden As String, ByVal Tstc As String)
        Texiste = False
        terror = False
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select z.orden," _
                 & "z.numero_documento," _
                 & "z.nombre_cp," _
                 & "z.direccion," _
                 & "z.nit_cp," _
                 & "z.fecha_documento," _
                 & "z.fecha_vence," _
                 & "z.observaciones," _
                 & "isnull((select codigo from tbl_vendedor y where y.orden = z.orden_vendedor),'0'), " _
                 & "isnull((select codigo from tbl_cliente x where x.orden = z.orden),'0'), " _
                 & "z.numero_documento " _
                 & " from tbl_cli_cotiza z " _
                 & " where z.orden = " & Torden
        Try
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = True
                    While .Read
                        Tnumerdoc = Tdtr.Item(1)
                        Tnombrecp = Tdtr.Item(2)
                        Tdireccion = Tdtr.Item(3)
                        Tnit = Tdtr.Item(4)
                        Tfechadoc = Tdtr.Item(5)
                        Tfechaven = Tdtr.Item(5)
                        Tobs = Tdtr.Item(7)
                        Tcodigovnd = Tdtr.Item(8)
                        Tcodigo = Tdtr.Item(9)
                        Tnumerdoc = Tdtr.Item(10)
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

    Public Function Acorrelativo() As Integer
        Return Tcorrelativo
    End Function

    Public Function Aultima() As Integer
        Return tultima
    End Function


    Public Function Anumerdoc() As Integer
        Return Tnumerdoc
    End Function

    Public Function acodigovnd() As String
        Return Tcodigovnd
    End Function

    Public Function acodigo() As String
        Return Tcodigo
    End Function


    Public Function anombrecp() As String
        Return Tnombrecp
    End Function

    Public Function afechadoc() As Date
        Return Tfechadoc
    End Function

    Public Function Afechaven() As Date
        Return Tfechaven
    End Function

    Public Function Aobs() As String
        Return Tobs
    End Function

    Public Function Anit() As String
        Return Tnit
    End Function

    Public Function Adireccion() As String
        Return Tdireccion
    End Function


End Class
