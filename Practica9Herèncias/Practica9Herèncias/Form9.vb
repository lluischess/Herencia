Public Class Form9
    Private cont As String = 0

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox15.Text = ""
        TextBox16.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        TextBox15.Text = StrReverse(TextBox16.Text)

        cont = cont + 1
        operacio.Text = cont
    End Sub
End Class
