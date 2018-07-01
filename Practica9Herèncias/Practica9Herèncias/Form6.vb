Public Class Form6
    Private cont As Integer = 0

    'RESTA DE DOS NUMEROS
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox10.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        Dim valor1 As Double
        Dim valor2 As Double
        Dim Res As Double

        cont = cont + 1
        operacio.Text = cont
        Try
            valor1 = CDbl(TextBox10.Text)
            valor2 = CDbl(TextBox9.Text)
            Res = valor1 - valor2
            MsgBox("Resultado: " + CStr(Res))
        Catch ex As Exception
            MsgBox("Introduce números")
        End Try

    End Sub
End Class
