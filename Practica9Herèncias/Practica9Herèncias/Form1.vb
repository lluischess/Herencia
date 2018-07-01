Public Class _1triangulo
    Private cont As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'AREA DEL TRIANGULO
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        'AREA DEL TRIANGULO
        Dim Base As Double
        Dim Altura As Double
        Dim Res As Double

        cont = cont + 1
        operacio.Text = cont

        Try
            Base = CDbl(TextBox1.Text)
            Altura = CDbl(TextBox2.Text)
            Res = Base * Altura / 2
            MsgBox("Area del triangulo : " + CStr(Res))
        Catch ex As Exception
            MsgBox("Introduce números.")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub operacio_Click(sender As Object, e As EventArgs) Handles operacio.Click

    End Sub
End Class
