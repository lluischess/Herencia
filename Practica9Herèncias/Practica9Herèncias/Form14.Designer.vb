<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
    Inherits Practica9Herèncias.Base

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.Button41 = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'executar
        '
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.Text = "Tabla de multiplicar"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(138, 96)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(83, 13)
        Me.Label44.TabIndex = 28
        Me.Label44.Text = "Multiplicar hasta"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(225, 96)
        Me.TextBox28.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(91, 20)
        Me.TextBox28.TabIndex = 27
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(148, 159)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.ScrollAlwaysVisible = True
        Me.ListBox2.Size = New System.Drawing.Size(138, 173)
        Me.ListBox2.TabIndex = 26
        '
        'Button40
        '
        Me.Button40.Location = New System.Drawing.Point(338, 120)
        Me.Button40.Margin = New System.Windows.Forms.Padding(2)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(68, 24)
        Me.Button40.TabIndex = 25
        Me.Button40.Text = "Cerrar"
        Me.Button40.UseVisualStyleBackColor = True
        '
        'Button41
        '
        Me.Button41.Location = New System.Drawing.Point(338, 92)
        Me.Button41.Margin = New System.Windows.Forms.Padding(2)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(68, 24)
        Me.Button41.TabIndex = 24
        Me.Button41.Text = "Reset"
        Me.Button41.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(142, 143)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(98, 13)
        Me.Label42.TabIndex = 22
        Me.Label42.Text = "Tabla de multiplicar"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(139, 68)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(44, 13)
        Me.Label43.TabIndex = 21
        Me.Label43.Text = "Número"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(225, 68)
        Me.TextBox26.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(91, 20)
        Me.TextBox26.TabIndex = 20
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(545, 395)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.TextBox28)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Me.Button41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.TextBox26)
        Me.Name = "Form14"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.operacio, 0)
        Me.Controls.SetChildIndex(Me.el44, 0)
        Me.Controls.SetChildIndex(Me.executar, 0)
        Me.Controls.SetChildIndex(Me.TextBox26, 0)
        Me.Controls.SetChildIndex(Me.Label43, 0)
        Me.Controls.SetChildIndex(Me.Label42, 0)
        Me.Controls.SetChildIndex(Me.Button41, 0)
        Me.Controls.SetChildIndex(Me.Button40, 0)
        Me.Controls.SetChildIndex(Me.ListBox2, 0)
        Me.Controls.SetChildIndex(Me.TextBox28, 0)
        Me.Controls.SetChildIndex(Me.Label44, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label44 As Label
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button40 As Button
    Friend WithEvents Button41 As Button
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents TextBox26 As TextBox
End Class
