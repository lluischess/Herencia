<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baseprimaria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea del triangle")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea de la rodona")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Longitud de la Circumferència")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrea Rectangle")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Àrees i Longituds", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Suma de dos números")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Resta de dos números")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Divisió de dos números")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Multiplicació de dos números")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aritmètica", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Invertir")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Número de vocales y consonantes")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2 caracteres que se repiten")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cadenes", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transformar de números a letra")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fibornacci")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Taula de múltiplicar")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Altres", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Nodo1"
        TreeNode1.Tag = "1"
        TreeNode1.Text = "Àrea del triangle"
        TreeNode2.Name = "Nodo2"
        TreeNode2.Tag = "2"
        TreeNode2.Text = "Àrea de la rodona"
        TreeNode3.Name = "Nodo3"
        TreeNode3.Tag = "3"
        TreeNode3.Text = "Longitud de la Circumferència"
        TreeNode4.Name = "Nodo4"
        TreeNode4.Tag = "4"
        TreeNode4.Text = "Àrea Rectangle"
        TreeNode5.Name = "Nodo0"
        TreeNode5.Tag = "-1"
        TreeNode5.Text = "Àrees i Longituds"
        TreeNode6.Name = "Nodo6"
        TreeNode6.Tag = "5"
        TreeNode6.Text = "Suma de dos números"
        TreeNode7.Name = "Nodo7"
        TreeNode7.Tag = "6"
        TreeNode7.Text = "Resta de dos números"
        TreeNode8.Name = "Nodo8"
        TreeNode8.Tag = "7"
        TreeNode8.Text = "Divisió de dos números"
        TreeNode9.Name = "Nodo9"
        TreeNode9.Tag = "8"
        TreeNode9.Text = "Multiplicació de dos números"
        TreeNode10.Name = "Nodo5"
        TreeNode10.Tag = "-1"
        TreeNode10.Text = "Aritmètica"
        TreeNode11.Name = "Nodo11"
        TreeNode11.Tag = "9"
        TreeNode11.Text = "Invertir"
        TreeNode12.Name = "Nodo12"
        TreeNode12.Tag = "10"
        TreeNode12.Text = "Número de vocales y consonantes"
        TreeNode13.Name = "Nodo13"
        TreeNode13.Tag = "11"
        TreeNode13.Text = "2 caracteres que se repiten"
        TreeNode14.Name = "Nodo10"
        TreeNode14.Tag = "-1"
        TreeNode14.Text = "Cadenes"
        TreeNode15.Name = "Nodo15"
        TreeNode15.Tag = "12"
        TreeNode15.Text = "Transformar de números a letra"
        TreeNode16.Name = "Nodo16"
        TreeNode16.Tag = "13"
        TreeNode16.Text = "Fibornacci"
        TreeNode17.Name = "Nodo17"
        TreeNode17.Tag = "14"
        TreeNode17.Text = "Taula de múltiplicar"
        TreeNode18.Name = "Nodo14"
        TreeNode18.Tag = "-1"
        TreeNode18.Text = "Altres"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode10, TreeNode14, TreeNode18})
        Me.TreeView1.Size = New System.Drawing.Size(224, 363)
        Me.TreeView1.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Baseprimaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 363)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Baseprimaria"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Timer1 As Timer
End Class
