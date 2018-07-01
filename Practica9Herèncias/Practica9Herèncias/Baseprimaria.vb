Imports System.Windows
Imports System.Windows.Forms

Public Class Baseprimaria

    Private frm1 As New _1triangulo
    Private frm2 As New form2
    Private frm3 As New Form3
    Private frm4 As New Form4
    Private frm5 As New Form5
    Private frm6 As New Form6
    Private frm7 As New Form7
    Private frm8 As New Form8
    Private frm9 As New Form9
    Private frm10 As New Form10
    Private frm11 As New Form11
    Private frm12 As New Form12
    Private frm13 As New Form13
    Private frm14 As New Form14



    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Select Case e.Node.Tag
            Case 1
                frm1.ShowDialog()


            Case 2
                frm2.ShowDialog()
            Case 3
                frm3.ShowDialog()
            Case 4
                frm4.ShowDialog()
            Case 5
                frm5.ShowDialog()
            Case 6
                frm6.ShowDialog()
            Case 7
                frm7.ShowDialog()
            Case 8
                frm8.ShowDialog()
            Case 9
                frm9.ShowDialog()
            Case 10
                frm10.ShowDialog()
            Case 11
                frm11.ShowDialog()
            Case 12
                frm12.ShowDialog()
            Case 13
                frm13.ShowDialog()
            Case 14
                frm14.ShowDialog()


        End Select


    End Sub

End Class
