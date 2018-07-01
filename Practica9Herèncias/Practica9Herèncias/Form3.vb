Public Class Form3
    Private cont As Integer = 0
    Dim PI As Double = Math.PI
    'LONGITUT DE LA CIRCUMFERÊNCIA
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox5.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        'LONGITUT DE LA CIRCUMFERÊNCIA
        Dim Radio As Double
        Dim Res As Double

        cont = cont + 1
        operacio.Text = cont
        Try
            Radio = CDbl(TextBox5.Text)
            Res = 2 * PI * Radio
            MsgBox("La longitud de la circunferencia : " + CStr(Res))
        Catch ex As Exception
            MsgBox("Introduce un número")
        End Try
    End Sub
End Class
