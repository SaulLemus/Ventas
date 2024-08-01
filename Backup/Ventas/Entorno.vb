
Module Entorno
    'Public srv_tmp As String = "(local)\SQLEXPRESS"
    Public srv_tmp As String = "."
    'Public srv_tmp As String = "192.168.1.150" 'Chun GT
    Public db_tmp As String = "Ventas"
    Public usr As String = "sa"
    Public psw As String = "Scjdc12345"
    Public str_cnn As String = "data source =" & srv_tmp & "; initial catalog =" & db_tmp & "; user id =" & usr & "; password = " & psw & ";"
    Public formula_tmp As String = ""
    Public MDL_impuesto As Decimal = 1.12
    Public factorIVA As Decimal = 0.12  ' Esto sirve para quitar el iva  valorconiva - (valorconiva*factorIVA)


    Public Function fecha_string(ByRef fechadate As Date)
        Dim dia As Byte = 0
        Dim diastr As String = ""
        Dim mes As Byte = 0
        Dim messtr As String = ""
        Dim ano As Integer = 0
        Dim fechastring As String = ""
        dia = Microsoft.VisualBasic.DateAndTime.Day(fechadate)
        If dia < 10 Then
            diastr = "0" & Trim(Str(dia))
        Else
            diastr = Trim(Str(dia))
        End If
        mes = Month(fechadate)
        If mes < 10 Then
            messtr = "0" & Trim(Str(mes))
        Else
            messtr = Trim(Str(mes))
        End If
        ano = Year(fechadate)
        fechastring = Str(ano) & messtr & diastr
        Return fechastring
    End Function

End Module


