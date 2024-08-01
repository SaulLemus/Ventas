
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_cons_kardex

    ' Clases
    Dim Carticulo As New articulo
    Dim codigo As String = ""
    Dim txt_sql As String = ""
    Dim ref1 As Boolean = False
    Dim ref2 As Boolean = False

    Dim ord_ref1 As Integer = 0
    Dim ord_ref2 As Integer = 0
    Dim txtR1 As String = ""
    Dim txtR2 As String = ""
    Dim formulavnd As String = ""

    Private Sub frm_cons_kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa()
    End Sub

    Private Sub inicializa()
        limpia_campos()
    End Sub

    Private Sub limpia_campos()
        txt_ref1.Text = ""
        txt_ref2.Text = ""
        lbl_ref1.Text = ""
        lbl_ref2.Text = ""
        txtR1 = ""
        txtR2 = ""
        formulavnd = ""
        dtg_kardex.Rows.Clear()

    End Sub

    Private Sub btn_actualiza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_actualiza.Click
        crea_qry_kardex()
        llena_kardex()
    End Sub

    Private Sub crea_qry_kardex()

        txt_sql = "select d.codigo,d.descripcion,d.tipo,d.numero, d.fsistema, d.cantidad from " _
                  & "(" _
                  & "select a.codigo as codigo, " _
                  & "a.descripcion as descripcion," _
                  & "'Pedido' as tipo," _
                  & "numero_documento as Numero," _
                  & "p.fecha_sistema as fsistema," _
                  & "-d.cantidad as cantidad " _
                  & " from tbl_cli_pedido p inner join tbl_cli_pedido_det d on d.orden_doc = p.orden " _
                  & " inner join tbl_articulo a on a.orden = d.orden_articulo  " _
                  & " union all " _
                  & "select a.codigo as codigo, " _
                  & "a.descripcion as descripcion," _
                  & "'AnlPedido' as tipo," _
                  & "numero_documento as Numero," _
                  & "p.fecha_anulacion as fsistema," _
                  & "d.cantidad as cantidad " _
                  & " from tbl_cli_pedido p inner join tbl_cli_pedido_det d on d.orden_doc = p.orden " _
                  & " inner join tbl_articulo a on a.orden = d.orden_articulo where estado = 'N'" _
                  & " union all " _
                  & " select a.codigo as codigo," _
                  & " a.descripcion as descripcion," _
                  & " 'IngresoPRV' as tipo, " _
                  & "numero_documento as Numero," _
                  & " p.fecha_sistema as fsistema, " _
                  & " d.cantidad as cantidad " _
                  & " from tbl_prv_ingreso p inner join tbl_prv_ingreso_det d on d.orden_doc = p.orden " _
                  & " inner join tbl_articulo a on a.orden = d.orden_articulo " _
                  & " union all " _
                  & " select a.codigo as codigo," _
                  & " a.descripcion as descripcion," _
                  & " 'IngresoMAN' as tipo," _
                  & " p.orden as Numero," _
                  & " p.fecha_sistema as fsistema," _
                  & " d.cantidad as cantidad " _
                  & " from tbl_ingreso p inner join tbl_prv_ingreso_det d on d.orden_doc = p.orden " _
                  & " inner join tbl_articulo a on a.orden = d.orden_articulo " _
                  & " union all " _
                  & " select a.codigo as codigo," _
                  & " a.descripcion as descripcion, " _
                  & " 'SalidaMAN' as tipo," _
                  & " p.orden as Numero," _
                  & " p.fecha as fsistema," _
                  & "-p.cantidad as cantidad " _
                  & " from tbl_salida p " _
                  & " inner join tbl_articulo a on a.orden = p.orden_articulo " _
                  & ") d "
        If txt_ref1.Text <> "" Or txt_ref2.Text <> "" Then
            txt_sql = txt_sql & " where "
            If txt_ref1.Text <> "" Then
                txt_sql = txt_sql & " d.codigo >= '" & txt_ref1.Text & "'"
                txtR1 = txt_ref1.Text
            Else
                txt_sql = txt_sql & " d.codigo >= '0'"
                txtR1 = "0"
            End If
            txt_sql = txt_sql & " and "
            If txt_ref2.Text = "" Then
                txt_sql = txt_sql & " d.codigo <= 'zzzzzzzzzzzzzzz'"
                txtR2 = "zzzzzzzzzzzzzzz"
            Else
                txt_sql = txt_sql & " d.codigo <= '" & txt_ref2.Text & "'"
                txtR2 = txt_ref2.Text
            End If
            formulavnd = " and {tbl_articulo.codigo} >= '" & txtR1 & "' and {tbl_articulo.codigo} <= '" & txtR2 & "'"
        End If
        txt_sql = txt_sql & " order by d.codigo, d.fsistema"
    End Sub

    Private Sub llena_kardex()
        Dim myconn As New SqlConnection(str_cnn)
        myconn.Open()
        Dim myCmd As New SqlCommand(txt_sql, myconn)
        Dim myReader As SqlDataReader
        myReader = myCmd.ExecuteReader()
        If myReader.HasRows Then
            dtg_kardex.Rows.Clear()
            While myReader.Read()
                dtg_kardex.Rows.Add(myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5))
            End While
            'comboproveedor.SelectedIndex = -1
        Else
            dtg_kardex.Rows.Clear()
        End If
        myReader.Close()
        myconn.Close()
    End Sub

    Private Sub txt_ref1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ref1.LostFocus
        ord_ref1 = 0
        If txt_ref1.Text = "*" Then
            Dim consulta As New frm_bus_articulo
            consulta.codigo = ""
            consulta.ShowDialog()
            If consulta.resultado = True Then
                codigo = consulta.codigo
                busca_art()
                If Carticulo.Aexiste = True Then
                    ord_ref1 = Carticulo.Aorden
                    txt_ref1.Text = Carticulo.Acodigo
                    lbl_ref1.Text = Carticulo.Adescripcion
                End If
            End If
        End If
    End Sub

    Private Sub txt_ref2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ref2.LostFocus
        ord_ref2 = 0
        If txt_ref2.Text = "*" Then
            Dim consulta As New frm_bus_articulo
            consulta.codigo = ""
            consulta.ShowDialog()
            If consulta.resultado = True Then
                codigo = consulta.codigo
                busca_art()
                If Carticulo.Aexiste = True Then
                    ord_ref2 = Carticulo.Aorden
                    txt_ref2.Text = Carticulo.Acodigo
                    lbl_ref2.Text = Carticulo.Adescripcion
                End If
            End If
        End If
    End Sub

    Private Sub busca_art()
        Carticulo.buscar(codigo, str_cnn)
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click

    End Sub

    Private Sub lbl_ref1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_ref1.Click

    End Sub
End Class