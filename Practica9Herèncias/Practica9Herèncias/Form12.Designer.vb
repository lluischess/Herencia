<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'executar
        '
        '
        'el44
        '
        Me.el44.Location = New System.Drawing.Point(170, 9)
        '
        'operacio
        '
        Me.operacio.Location = New System.Drawing.Point(266, 9)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.Text = "Transformar de numeros a letras"
        '
        'Button34
        '
        Me.Button34.Location = New System.Drawing.Point(331, 198)
        Me.Button34.Margin = New System.Windows.Forms.Padding(2)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(68, 24)
        Me.Button34.TabIndex = 20
        Me.Button34.Text = "Cerrar"
        Me.Button34.UseVisualStyleBackColor = True
        '
        'Button35
        '
        Me.Button35.Location = New System.Drawing.Point(331, 171)
        Me.Button35.Margin = New System.Windows.Forms.Padding(2)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(68, 24)
        Me.Button35.TabIndex = 19
        Me.Button35.Text = "Reset"
        Me.Button35.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(82, 196)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(81, 13)
        Me.Label36.TabIndex = 17
        Me.Label36.Text = "Número en ltras"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(129, 174)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(44, 13)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "Número"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(173, 196)
        Me.TextBox24.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(142, 20)
        Me.TextBox24.TabIndex = 15
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(173, 174)
        Me.TextBox25.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(96, 20)
        Me.TextBox25.TabIndex = 14
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(545, 395)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.TextBox24)
        Me.Controls.Add(Me.TextBox25)
        Me.Name = "Form12"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.operacio, 0)
        Me.Controls.SetChildIndex(Me.el44, 0)
        Me.Controls.SetChildIndex(Me.executar, 0)
        Me.Controls.SetChildIndex(Me.TextBox25, 0)
        Me.Controls.SetChildIndex(Me.TextBox24, 0)
        Me.Controls.SetChildIndex(Me.Label37, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.Button35, 0)
        Me.Controls.SetChildIndex(Me.Button34, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button34 As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox25 As TextBox
End Class
