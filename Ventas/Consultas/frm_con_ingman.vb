
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_con_ingman

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

    Private Sub frm_con_ingman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        crea_qry_ingman()
        llena_kardex()
    End Sub


    Private Sub crea_qry_ingman()
        txt_sql = "select a.codigo as codigo, " _
                  & "a.descripcion as descripcion, " _
                  & "'IngresoMAN' as tipo, " _
                  & "p.orden as Numero, " _
                  & "p.fecha_sistema as fsistema, " _
                  & "p.cantidad as cantidad " _
                  & " from tbl_ingreso p inner join tbl_articulo a on a.orden = p.orden_articulo "
        If txt_ref1.Text <> "" Then
            txt_sql = txt_sql & " where "
            txt_sql = txt_sql & " a.codigo = '" & txt_ref1.Text & "'"
            txtR1 = txt_ref1.Text
        End If
        txt_sql = txt_sql & " order by a.codigo, p.fecha_sistema "
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


    Private Sub busca_art()
        Carticulo.buscar(codigo, str_cnn)
    End Sub

End Class