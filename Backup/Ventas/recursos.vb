
Imports System

Module recursos
    Public Function valida_clave(ByRef clave1 As String, ByRef clave2 As String, ByRef msg As String, ByRef err As Integer)
        Dim tamano1 As Integer = Len(clave1)
        Dim tamano2 As Integer = Len(clave2)
        Dim actual As Integer = 0
        Dim chrascii As Integer = 0
        If tamano1 = tamano2 Then
            For actual = 1 To tamano1
                msg = Mid(clave1, actual, 1) & " ascii: " & Asc(Mid(clave1, actual, 1))
                chrascii = Asc(Mid(clave1, actual, 1))
                If (chrascii >= 65 And chrascii <= 90) Or (chrascii >= 48 And chrascii <= 57) Or (chrascii >= 97 And chrascii <= 122) Then
                    clave1 = clave1
                Else
                    clave1 = "ERROR"
                    actual = tamano1
                End If
            Next
            'And (Asc(Mid(txtcodigo, actual, 1)) < 48 And Asc(Mid(txtcodigo, actual, 1)) > 57)
        Else
            msg = "ERROR confirmacion no coincide"
            err = 1
        End If
        Return err
    End Function

    Public Function identificar(ByRef str_id As String)

        str_id = "Equipo: " & Environment.MachineName & ": Usuario: " & Environment.UserName & ": Dominio: " & Environment.UserDomainName

        Return str_id
    End Function

    Public Function valida_codigo(ByRef txtcodigo As String)
        Dim tamano As Integer = Len(txtcodigo)
        Dim actual As Integer = 0
        Dim msg As String
        Dim chrascii As Integer = 0
        For actual = 1 To tamano
            msg = Mid(txtcodigo, actual, 1) & " ascii: " & Asc(Mid(txtcodigo, actual, 1))
            chrascii = Asc(Mid(txtcodigo, actual, 1))
            If (chrascii >= 65 And chrascii <= 90) Or (chrascii >= 48 And chrascii <= 57) Then
                txtcodigo = txtcodigo
            Else
                txtcodigo = "ERROR"
                actual = tamano
            End If
        Next
        'And (Asc(Mid(txtcodigo, actual, 1)) < 48 And Asc(Mid(txtcodigo, actual, 1)) > 57)
        Return txtcodigo
    End Function

End Module
