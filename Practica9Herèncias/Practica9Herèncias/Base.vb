Public Class Base
    ' Mostra l'hora, minuts i segons actuals
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        data.Text = TimeOfDay
    End Sub

    Private Sub executar_Click(sender As Object, e As EventArgs) Handles executar.Click

    End Sub
End Class