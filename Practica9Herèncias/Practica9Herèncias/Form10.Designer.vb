<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'executar
        '
        '
        'el44
        '
        Me.el44.Location = New System.Drawing.Point(174, 9)
        '
        'operacio
        '
        Me.operacio.Location = New System.Drawing.Point(270, 9)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.Text = "Numero de vocals i consonants"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(106, 201)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(95, 13)
        Me.Label29.TabIndex = 27
        Me.Label29.Text = "Total consonantes"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(204, 201)
        Me.TextBox19.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(76, 20)
        Me.TextBox19.TabIndex = 26
        '
        'Button28
        '
        Me.Button28.Location = New System.Drawing.Point(311, 185)
        Me.Button28.Margin = New System.Windows.Forms.Padding(2)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(68, 24)
        Me.Button28.TabIndex = 25
        Me.Button28.Text = "Cerrar"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(311, 158)
        Me.Button29.Margin = New System.Windows.Forms.Padding(2)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(68, 24)
        Me.Button29.TabIndex = 24
        Me.Button29.Text = "Reset"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(130, 180)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 13)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "Total vocales"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(106, 154)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 13)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Palabra"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(204, 180)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(76, 20)
        Me.TextBox17.TabIndex = 20
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(153, 154)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(127, 20)
        Me.TextBox18.TabIndex = 19
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(545, 395)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox18)
        Me.Name = "Form10"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.operacio, 0)
        Me.Controls.SetChildIndex(Me.el44, 0)
        Me.Controls.SetChildIndex(Me.executar, 0)
        Me.Controls.SetChildIndex(Me.TextBox18, 0)
        Me.Controls.SetChildIndex(Me.TextBox17, 0)
        Me.Controls.SetChildIndex(Me.Label28, 0)
        Me.Controls.SetChildIndex(Me.Label27, 0)
        Me.Controls.SetChildIndex(Me.Button29, 0)
        Me.Controls.SetChildIndex(Me.Button28, 0)
        Me.Controls.SetChildIndex(Me.TextBox19, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
End Class
