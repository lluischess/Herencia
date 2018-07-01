<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Base
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.executar = New System.Windows.Forms.Button()
        Me.data = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.operacio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.el44 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'executar
        '
        Me.executar.Location = New System.Drawing.Point(446, 9)
        Me.executar.Name = "executar"
        Me.executar.Size = New System.Drawing.Size(87, 43)
        Me.executar.TabIndex = 9
        Me.executar.Text = "Executar Operació"
        Me.executar.UseVisualStyleBackColor = True
        '
        'data
        '
        Me.data.AutoSize = True
        Me.data.Location = New System.Drawing.Point(497, 373)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(13, 13)
        Me.data.TabIndex = 8
        Me.data.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(443, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hora:"
        '
        'operacio
        '
        Me.operacio.AutoSize = True
        Me.operacio.Location = New System.Drawing.Point(246, 9)
        Me.operacio.Name = "operacio"
        Me.operacio.Size = New System.Drawing.Size(13, 13)
        Me.operacio.TabIndex = 6
        Me.operacio.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Operacion"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'el44
        '
        Me.el44.AutoSize = True
        Me.el44.Location = New System.Drawing.Point(150, 9)
        Me.el44.Name = "el44"
        Me.el44.Size = New System.Drawing.Size(90, 13)
        Me.el44.TabIndex = 10
        Me.el44.Text = "Veces ejecutada:"
        '
        'Base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 395)
        Me.Controls.Add(Me.el44)
        Me.Controls.Add(Me.executar)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.operacio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Base"
        Me.Text = "Base"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Public WithEvents executar As Button
    Public WithEvents el44 As Label
    Public WithEvents operacio As Label
    Public WithEvents Label1 As Label
End Class
