<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'executar
        '
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.Text = "Invertir paraula"
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(314, 192)
        Me.Button25.Margin = New System.Windows.Forms.Padding(2)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(68, 24)
        Me.Button25.TabIndex = 20
        Me.Button25.Text = "Cerrar"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(314, 165)
        Me.Button26.Margin = New System.Windows.Forms.Padding(2)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(68, 24)
        Me.Button26.TabIndex = 19
        Me.Button26.Text = "Reset"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(116, 187)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 13)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Palabra invertida"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(163, 165)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Palabra"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(207, 187)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(76, 20)
        Me.TextBox15.TabIndex = 15
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(207, 165)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(76, 20)
        Me.TextBox16.TabIndex = 14
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(545, 395)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox16)
        Me.Name = "Form9"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.operacio, 0)
        Me.Controls.SetChildIndex(Me.el44, 0)
        Me.Controls.SetChildIndex(Me.executar, 0)
        Me.Controls.SetChildIndex(Me.TextBox16, 0)
        Me.Controls.SetChildIndex(Me.TextBox15, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.Label24, 0)
        Me.Controls.SetChildIndex(Me.Button26, 0)
        Me.Controls.SetChildIndex(Me.Button25, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
End Class
