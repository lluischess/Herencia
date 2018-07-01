Public Class Form12
    Private cont As String = 0

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        TextBox25.Text = ""
        TextBox24.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        TextBox25.Text = "0"
        TextBox24.Text = "0"
        cont = cont + 1
        operacio.Text = cont

    End Sub
End Class
