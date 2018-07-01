Public Class Form4
    Private cont As Integer = 0

    'AREA DEL RECTNGLE
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox6.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click
        Dim Base As Double
        Dim Altura As Double
        Dim Res As Double
        cont = cont + 1
        operacio.Text = cont

        Try
            Base = CDbl(TextBox6.Text)
            Altura = CDbl(TextBox3.Text)
            Res = Base * Altura
            MsgBox("Area del rectangle: " + CStr(Res))
        Catch ex As Exception
            MsgBox("Introduce un número")
        End Try
    End Sub
End Class
