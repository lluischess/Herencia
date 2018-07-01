<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'executar
        '
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.Text = "Fibonacci"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(227, 175)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(91, 108)
        Me.ListBox1.TabIndex = 22
        '
        'Button37
        '
        Me.Button37.Location = New System.Drawing.Point(331, 207)
        Me.Button37.Margin = New System.Windows.Forms.Padding(2)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(68, 21)
        Me.Button37.TabIndex = 21
        Me.Button37.Text = "Cerrar"
        Me.Button37.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.Location = New System.Drawing.Point(331, 180)
        Me.Button38.Margin = New System.Windows.Forms.Padding(2)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(68, 21)
        Me.Button38.TabIndex = 20
        Me.Button38.Text = "Reset"
        Me.Button38.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(146, 175)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(77, 13)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "Serie fibonacci"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(182, 152)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(44, 13)
        Me.Label40.TabIndex = 17
        Me.Label40.Text = "Número"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(227, 152)
        Me.TextBox27.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(91, 20)
        Me.TextBox27.TabIndex = 16
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(545, 395)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button37)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.TextBox27)
        Me.Name = "Form13"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.operacio, 0)
        Me.Controls.SetChildIndex(Me.el44, 0)
        Me.Controls.SetChildIndex(Me.executar, 0)
        Me.Controls.SetChildIndex(Me.TextBox27, 0)
        Me.Controls.SetChildIndex(Me.Label40, 0)
        Me.Controls.SetChildIndex(Me.Label39, 0)
        Me.Controls.SetChildIndex(Me.Button38, 0)
        Me.Controls.SetChildIndex(Me.Button37, 0)
        Me.Controls.SetChildIndex(Me.ListBox1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button37 As Button
    Friend WithEvents Button38 As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents TextBox27 As TextBox
End Class
