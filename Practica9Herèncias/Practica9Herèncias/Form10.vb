Public Class Form10
    Private cont As String = 0

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        Dim frase As String
        Dim letras As Integer = 0
        Dim Vocales As Integer = 0
        Dim Consonantes As Integer = 0
        Dim Espacios As Integer = 0

        cont = cont + 1
        operacio.Text = cont

        frase = TextBox18.Text
        letras = frase.Length

        For c = 0 To letras - 1
            Select Case frase.ElementAt(c)
                Case "a"
                    Vocales = Vocales + 1
                Case "e"
                    Vocales = Vocales + 1
                Case "i"
                    Vocales = Vocales + 1
                Case "o"
                    Vocales = Vocales + 1
                Case "u"
                    Vocales = Vocales + 1
                Case " "
                    Espacios = Espacios + 1
            End Select
        Next

        Consonantes = letras - Vocales - Espacios
        TextBox17.Text = Vocales
        TextBox19.Text = Consonantes

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        TextBox18.Text = ""
        TextBox17.Text = ""
        TextBox19.Text = ""
    End Sub

End Class
