Public Class Form11
    Private cont As String = 0

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        TextBox21.Text = ""
        TextBox20.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        Dim caracter1 As Char
        Dim caracter2 As Char
        Dim frase As String
        Dim contador As Integer = 0
        Dim Repeticiones As Integer = 0

        cont = cont + 1
        operacio.Text = cont

        caracter1 = CChar(TextBox21.Text)
        caracter2 = CChar(TextBox20.Text)
        frase = TextBox22.Text

        While contador < frase.Length - 1
            If caracter1 = frase.ElementAt(contador) Then
                contador = contador + 1
                If caracter2 = frase.ElementAt(contador) Then
                    Repeticiones = Repeticiones + 1
                End If
            End If
            contador = contador + 1
        End While
        TextBox23.Text = Repeticiones
    End Sub
End Class
