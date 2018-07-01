Public Class Form13
    Private cont As String = 0

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        TextBox27.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        ListBox1.Items.Clear()
        Dim numero As Integer
        Dim actual As Integer = 1
        Dim anterior As Integer = 1
        Dim suma As Integer

        cont = cont + 1
        operacio.Text = cont
        Try
            numero = CUInt(TextBox27.Text)
            ListBox1.Items.Add(1)
            ListBox1.Items.Add(1)
            For c = 2 To numero - 1
                suma = anterior + actual
                anterior = actual
                actual = suma
                ListBox1.Items.Add(suma)
            Next
        Catch
            MsgBox("Introduce un número entero")
        End Try

    End Sub
End Class
