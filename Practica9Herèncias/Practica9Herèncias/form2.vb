Public Class form2
    Private cont As Integer = 0
    Dim PI As Double = Math.PI

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'AREA DEL RECTANGULO
        TextBox4.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        'AREA DEL RECTANGULO
        Dim Radio As Double
        Dim Res As Double

        cont = cont + 1
        operacio.Text = cont
        Try
            Radio = CDbl(TextBox4.Text)
            Res = PI * (Radio * Radio)
            MsgBox("Area del rectangulo : " + CStr(Res))
        Catch ex As Exception
            MsgBox("Introduce un número")
        End Try
    End Sub
End Class
