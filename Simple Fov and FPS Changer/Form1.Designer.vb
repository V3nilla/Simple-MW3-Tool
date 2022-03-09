<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MW3Tool
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MW3Tool))
        Me.FOV1 = New System.Windows.Forms.TrackBar()
        Me.FOV1Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FOV = New System.Windows.Forms.CheckBox()
        Me.FPS = New System.Windows.Forms.CheckBox()
        Me.FPS1Label = New System.Windows.Forms.Label()
        Me.FPS1 = New System.Windows.Forms.TrackBar()
        CType(Me.FOV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FPS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FOV1
        '
        Me.FOV1.Location = New System.Drawing.Point(108, 19)
        Me.FOV1.Maximum = 120
        Me.FOV1.Minimum = 65
        Me.FOV1.Name = "FOV1"
        Me.FOV1.Size = New System.Drawing.Size(243, 37)
        Me.FOV1.TabIndex = 3
        Me.FOV1.Value = 65
        '
        'FOV1Label
        '
        Me.FOV1Label.AutoSize = True
        Me.FOV1Label.Location = New System.Drawing.Point(348, 23)
        Me.FOV1Label.Name = "FOV1Label"
        Me.FOV1Label.Size = New System.Drawing.Size(19, 13)
        Me.FOV1Label.TabIndex = 9
        Me.FOV1Label.Text = "65"
        '
        'Timer1
        '
        '
        'FOV
        '
        Me.FOV.AutoSize = True
        Me.FOV.Location = New System.Drawing.Point(12, 19)
        Me.FOV.Name = "FOV"
        Me.FOV.Size = New System.Drawing.Size(47, 17)
        Me.FOV.TabIndex = 10
        Me.FOV.Text = "FOV"
        Me.FOV.UseVisualStyleBackColor = True
        '
        'FPS
        '
        Me.FPS.AutoSize = True
        Me.FPS.Location = New System.Drawing.Point(12, 66)
        Me.FPS.Name = "FPS"
        Me.FPS.Size = New System.Drawing.Size(85, 17)
        Me.FPS.TabIndex = 11
        Me.FPS.Text = "Jump Height"
        Me.FPS.UseVisualStyleBackColor = True
        '
        'FPS1Label
        '
        Me.FPS1Label.AutoSize = True
        Me.FPS1Label.Location = New System.Drawing.Point(348, 66)
        Me.FPS1Label.Name = "FPS1Label"
        Me.FPS1Label.Size = New System.Drawing.Size(25, 13)
        Me.FPS1Label.TabIndex = 13
        Me.FPS1Label.Text = "125"
        '
        'FPS1
        '
        Me.FPS1.Location = New System.Drawing.Point(108, 62)
        Me.FPS1.Maximum = 1000
        Me.FPS1.Minimum = 40
        Me.FPS1.Name = "FPS1"
        Me.FPS1.Size = New System.Drawing.Size(243, 37)
        Me.FPS1.TabIndex = 14
        Me.FPS1.Value = 40
        '
        'MW3Tool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 105)
        Me.Controls.Add(Me.FPS1)
        Me.Controls.Add(Me.FPS1Label)
        Me.Controls.Add(Me.FPS)
        Me.Controls.Add(Me.FOV)
        Me.Controls.Add(Me.FOV1Label)
        Me.Controls.Add(Me.FOV1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MW3Tool"
        Me.Text = "MW3 Tool SP 1.0"
        CType(Me.FOV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FPS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FOV1 As TrackBar
    Friend WithEvents FOV1Label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FOV As CheckBox
    Friend WithEvents FPS As CheckBox
    Friend WithEvents FPS1Label As Label
    Friend WithEvents FPS1 As TrackBar
End Class
