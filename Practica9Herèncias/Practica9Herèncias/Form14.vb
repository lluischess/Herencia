Public Class Form14
    Private cont As String = 0

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        TextBox26.Text = ""
        TextBox28.Text = ""
        ListBox2.Items.Clear()
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        Dim numero As Integer
        Dim numeroMultiplicar As Integer
        Dim multiplicar As Integer

        cont = cont + 1
        operacio.Text = cont
        Try
            numero = TextBox26.Text
            numeroMultiplicar = TextBox28.Text
            ListBox2.Items.Clear()

            For c = 0 To numeroMultiplicar
                multiplicar = numero * c
                ListBox2.Items.Add(multiplicar)
            Next
        Catch ex As Exception
            MsgBox("Introduce un número entero")
        End Try
    End Sub
End Class
