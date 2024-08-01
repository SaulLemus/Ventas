
Imports System.Data
Imports System.Data.SqlClient


Public Class documento
    Public Tcodigo As String

    Private Tcnn As SqlConnection
    Private Tdtr As SqlDataReader
    Private Tcmm As SqlCommand
    Private Ttxt_sql As String
    Private Texiste As Boolean = False

    Private Torden As Integer
    Private Tdescripcion As String
    Private ttpomov As String
    Private Tcantidad As Decimal
    Private Texistencia As Decimal
    Private Tpreciocompra As Decimal
    Private Tprecioventa As Decimal
    Private Tcostoanterior As Decimal
    Private Texistenciaanterior As Decimal
    Private Tfecha As Date


    Private texto As String
    Private terror As Byte
    Private txtmsg As String
    Private tnumero As Integer

    Private Taleatorio As New Random
    Private TblNombre As String



    Public Sub buscar(ByVal Tcodigo As String, ByVal Tstc As String)
        Texiste = True
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden, " _
                 & "a.tipo_movimiento, " _
                 & "a.cantidad, " _
                 & "a.precio_compra, " _
                 & "a.precio_venta, " _
                 & "a.costo_anterior, " _
                 & "a.existencia_anterior, " _
                 & "a.fecha, " _
                 & "b.descripcion " _
                 & " from tbl_movimiento a inner join tbl_articulo b on b.codigo = a.codigo " _
                 & " where codigo = '" & Tcodigo & "'"
        Try
            Texiste = 0
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = 1
                    While .Read
                        Torden = Tdtr.Item(0)
                        ttpomov = Tdtr.Item(1)
                        Tcantidad = Tdtr.Item(2)
                        Tpreciocompra = Tdtr.Item(3)
                        Tprecioventa = Tdtr.Item(4)
                        Tcostoanterior = Tdtr.Item(5)
                        Texistenciaanterior = Tdtr.Item(6)
                        Tfecha = Tdtr.Item(7)
                        Tdescripcion = Tdtr.Item(8)
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            Texiste = False
        End Try
    End Sub

    Public Sub buscar_serie(ByRef Tdtr As SqlDataReader, ByVal Tcodigo As String, ByRef ThayDatos As Boolean, ByVal Tstc As String)
        Texiste = True
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select a.orden_correlativo, " _
                 & "a.tipodocumento, " _
                 & "a.tipocorrelativo, " _
                 & "a.seriedocumento, " _
                 & "a.numeroinicial, " _
                 & "a.numerofinal, " _
                 & "a.numerosiguiente, " _
                 & "a.estado, " _
                 & "a.nombredocumento " _
                 & " from tbl_correlativo a " _
                 & " where tipodocumento = '" & Tcodigo & "' and estado <> 'B' order by orden_correlativo desc "
        Try
            Texiste = 0
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    ThayDatos = True
                Else
                    ThayDatos = False
                End If
            End With
            'Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            Texiste = False
            ThayDatos = False
        End Try
    End Sub

    Public Function Aexiste() As Boolean
        Return Texiste
    End Function


    Public Sub buscar_ultima_factura(ByRef Torden As Integer, ByVal Tstc As String)
        Texiste = True
        'Tstc = cnn_stc
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "select max(orden) from tbl_faccenc "

        Try
            Texiste = 0
            Tcnn.Open()
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tdtr = Tcmm.ExecuteReader()
            With Tdtr
                If .HasRows Then
                    Texiste = 1
                    While .Read
                        Torden = Tdtr.Item(0)
                    End While
                End If
            End With
            Tcnn.Close()
        Catch ex As SqlException
            texto = ex.Message
            Texiste = False
        End Try
    End Sub

    'genera nombre de tabla pide el nombre base y a ese le agrega un numero random
    Public Sub genera_nombre(ByVal Tnombre As String)
        Tnumero = Taleatorio.Next(100, 200)
        TblNombre = Tnombre & Tnumero
    End Sub

    'Regresa el nombre para la tabla temporal
    Public Function AnombreTBL() As String
        Return TblNombre
    End Function


    Public Sub movimiento_tmp_crea(ByVal Tnombre As String, ByVal Tstc As String)
        terror = 0
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "CREATE TABLE [dbo].[" & Tnombre & "](" & _
                   "	[serie] [nvarchar](15) COLLATE Modern_Spanish_CI_AS NOT NULL ," & _
                   "	[codigo_cp] [nvarchar](15) COLLATE Modern_Spanish_CI_AS NOT NULL," & _
                   "	[nombre_cp] [nvarchar](100) COLLATE Modern_Spanish_CI_AS NOT NULL ," & _
                   "	[fecha_requerida] [datetime] NOT NULL," & _
                   "	[fecha_pago] [datetime] NOT NULL," & _
                   "	[tipo_movimiento] [nvarchar](6) COLLATE Modern_Spanish_CI_AS NOT NULL," & _
                   "	[total] [money] NOT NULL ," & _
                   "	[obs] [nvarchar](350) COLLATE Modern_Spanish_CI_AS NOT NULL," & _
                   "	[linea] [int] NOT NULL," & _
                   "	[codigo] [nvarchar](15) COLLATE Modern_Spanish_CI_AS NOT NULL," & _
                   "	[descripcion] [nvarchar](100) COLLATE Modern_Spanish_CI_AS NOT NULL," & _
                   "	[exi_actual] [money] NOT NULL ," & _
                   "	[costo_actual] [money] NOT NULL ," & _
                   "	[cantidad_pedida] [money] NOT NULL ," & _
                   "	[cantidad_entregada] [money] NOT NULL," & _
                   "	[precio] [money] NOT NULL ," & _
                   "	[subtotal] [money] NOT NULL, " & _
                   "	[condicion] [nvarchar](15) COLLATE Modern_Spanish_CI_AS NOT NULL, " & _
                   "	[sueldo] [money] NOT NULL ," & _
                   "	[decreto] [money] NOT NULL ," & _
                   "	[pasivo] [money] NOT NULL " & _
                   ") ON [PRIMARY]"

        'MsgBox(txtsql)
        Tcnn.Open()
        Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
        Tcmm.CommandText = Ttxt_sql
        Try
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = 1
            txtmsg = "No se creo tabla   " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        'botones_campos()
        Tcnn.Close()
    End Sub


    Public Sub movimiento_tmp_graba(ByVal tserie As String, _
                      ByVal tcodigo_cp As String, _
                      ByVal tnombre_cp As String, _
                      ByVal tfrequerida As String, _
                      ByVal tfpago As String, _
                      ByVal ttpomov As String, _
                      ByVal tobs As String, _
                      ByVal ttotal As Decimal, _
                      ByVal tlinea As Integer, _
                      ByVal tcodigo As String, _
                      ByVal tdescripcion As String, _
                      ByVal texiactual As Decimal, _
                      ByVal tcostoactual As Decimal, _
                      ByVal tcantpedida As Decimal, _
                      ByVal tcantntrega As Decimal, _
                      ByVal tprecio As Decimal, _
                      ByVal tsubtotal As Decimal, _
                      ByVal tcondicion As String, _
                      ByVal tsueldo As Decimal, _
                      ByVal tdecreto As Decimal, _
                      ByVal tpasivo As Decimal, _
                      ByVal tstc As String, _
                      ByVal tnombretbl As String)
        terror = 0
        Try
            Tcnn = New SqlConnection(tstc)
            Tcnn.Open()

            Ttxt_sql = "SET DATEFORMAT ymd  " _
                   & "INSERT INTO " & tnombretbl _
                   & " (" _
                   & "serie," _
                   & "codigo_cp," _
                   & "nombre_cp," _
                   & "fecha_requerida," _
                   & "fecha_pago," _
                   & "tipo_movimiento," _
                   & "total," _
                   & "obs," _
                   & "linea," _
                   & "codigo," _
                   & "descripcion," _
                   & "exi_actual," _
                   & "costo_actual," _
                   & "cantidad_pedida," _
                   & "cantidad_entregada," _
                   & "precio," _
                   & "subtotal," _
                   & "condicion," _
                   & "sueldo," _
                   & "decreto," _
                   & "pasivo" _
                   & ") " _
                   & "values('" & tserie & "'," _
                          & "'" & tcodigo_cp & "'," _
                          & "'" & tnombre_cp & "'," _
                          & "'" & tfrequerida & "'," _
                          & "'" & tfpago & "'," _
                          & "'" & ttpomov & "'," _
                          & ttotal & "," _
                          & "'" & tobs & "'," _
                          & tlinea & "," _
                          & "'" & tcodigo & "'," _
                          & "'" & tdescripcion & "'," _
                          & texiactual & "," _
                          & tcostoactual & "," _
                          & tcantpedida & "," _
                          & tcantntrega & "," _
                          & tprecio & "," _
                          & tsubtotal & "," _
                          & "'" & tcondicion & "'," _
                          & tsueldo & "," _
                          & tdecreto & "," _
                          & tpasivo _
                          & ")"
            'MsgBox(Ttxt_sql)
            Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
            Tcmm.CommandText = Ttxt_sql
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = 1
            txtmsg = "No se grabo documento tmp, no se altero ninguna informacion; " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
            terror = 1
        End Try
        Tcnn.Close()
    End Sub


    Public Sub documento_sp(ByVal tnombretbl As String, ByVal ttpomov As String, ByVal Tstc As String)
        terror = 0
        If ttpomov = "COTCLI" Then
            Ttxt_sql = "exec dbo.ins_movcotcli " & tnombretbl & "," & ttpomov
        End If
        If ttpomov = "FACCLI" Then
            Ttxt_sql = "exec dbo.ins_movfaccli " & tnombretbl & "," & ttpomov
        End If
        If ttpomov = "DEVCLI" Then
            Ttxt_sql = "exec dbo.ins_movdevcli " & tnombretbl & "," & ttpomov
        End If
        If ttpomov = "PEDPRV" Then
            Ttxt_sql = "exec dbo.ins_movpedprv " & tnombretbl & "," & ttpomov
        End If
        If ttpomov = "INGPRV" Then
            Ttxt_sql = "exec dbo.ins_movingprv " & tnombretbl & "," & ttpomov
        End If
        If ttpomov = "DEVPRV" Then
            Ttxt_sql = "exec dbo.ins_movdevprv " & tnombretbl & "," & ttpomov
        End If
        If ttpomov = "NTCPRV" Then
            Ttxt_sql = "exec dbo.ins_movntcprv " & tnombretbl & "," & ttpomov
        End If
        If ttpomov = "NTDPRV" Then
            Ttxt_sql = "exec dbo.ins_movntdprv " & tnombretbl & "," & ttpomov
        End If
        If ttpomov = "NTCCLI" Then
            Ttxt_sql = "exec dbo.ins_movntccli " & tnombretbl & "," & ttpomov
        End If
        If ttpomov = "NTDCLI" Then
            Ttxt_sql = "exec dbo.ins_movntdcli " & tnombretbl & "," & ttpomov
        End If
        Tcnn = New SqlConnection(Tstc)
        Tcnn.Open()
        'MsgBox(Ttxt_sql)
        Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
        Tcmm.CommandText = Ttxt_sql
        Try
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = 1
            txtmsg = "No se grabo movimiento " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        Tcnn.Close()
    End Sub


    Public Sub movimiento_tmp_elimina(ByVal Tnombre As String, ByVal Tstc As String)
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "DROP TABLE [dbo]." & Tnombre
        'MsgBox(txtsql)
        Tcnn.Open()
        Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
        Tcmm.CommandText = Ttxt_sql
        Try
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = 1
            txtmsg = "No se ELIMINO tabla   " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        'botones_campos()
        Tcnn.Close()
    End Sub


    Public Function Aerror() As Byte
        Return Terror
    End Function

    Public Sub actuaiza_estado_ing(ByVal torden As Integer, ByVal tfecha As String, ByVal Tstc As String)
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "update tbl_ingpenc set estado ='Pagado' , fecha_pago = '" & tfecha & "' where orden = " & torden
        'MsgBox(txtsql)
        Tcnn.Open()
        Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
        Tcmm.CommandText = Ttxt_sql
        Try
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = 1
            txtmsg = "No se actualizo estado   " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        'botones_campos()
        Tcnn.Close()
    End Sub


    Public Sub actuaiza_estado_faccli(ByVal torden As Integer, ByVal tfecha As String, ByVal Tstc As String)
        Tcnn = New SqlConnection(Tstc)
        Ttxt_sql = "update tbl_faccenc set estado ='Pagado' , fecha_pago = '" & Tfecha & "' where orden = " & torden
        'MsgBox(txtsql)
        Tcnn.Open()
        Tcmm = New SqlCommand(Ttxt_sql, Tcnn)
        Tcmm.CommandText = Ttxt_sql
        Try
            Tcmm.ExecuteNonQuery()
        Catch ex As Exception
            terror = 1
            txtmsg = "No se actulizo estado   " & ex.Message
            MsgBox(txtmsg, MsgBoxStyle.Information)
        End Try
        'botones_campos()
        Tcnn.Close()
    End Sub


End Class
