Public Class Form7
    Private cont As Integer = 0

    'DIVISION DE DOS NUMEROS
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox12.Text = ""
        TextBox11.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        Dim valor1 As Double
        Dim valor2 As Double
        Dim Res As Double

        cont = cont + 1
        operacio.Text = cont
        Try
            valor1 = CDbl(TextBox12.Text)
            valor2 = CDbl(TextBox11.Text)
            If (valor2 <> 0) Then
                Res = valor1 / valor2
                MsgBox("Resultado de la división: " + CStr(Res))
            Else
                MsgBox("En el segundo textbox no se puede introducir 0")
            End If
        Catch ex As Exception
            MsgBox("Introduce un número")
        End Try
    End Sub
End Class
