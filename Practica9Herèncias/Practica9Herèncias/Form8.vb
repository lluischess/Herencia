Public Class Form8
    Private cont As String = 0

    'MULTIPLICAR DOS NUMEROS
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox14.Text = ""
        TextBox13.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        Dim valor1 As Double
        Dim valor2 As Double
        Dim Res As Double

        cont = cont + 1
        operacio.Text = cont

        Try
            valor1 = CDbl(TextBox14.Text)
            valor2 = CDbl(TextBox13.Text)
            Res = valor1 * valor2
            MsgBox("Resultado de la multiplicación: " + CStr(Res))
        Catch ex As Exception
            MsgBox("Introduce un número")
        End Try
    End Sub
End Class
