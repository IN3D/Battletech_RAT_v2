<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CssSelector
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonSteiner = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMarik = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLiao = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKurita = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDavion = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDefault = New System.Windows.Forms.RadioButton()
        Me.ButtonSet = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonSteiner)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMarik)
        Me.GroupBox1.Controls.Add(Me.RadioButtonLiao)
        Me.GroupBox1.Controls.Add(Me.RadioButtonKurita)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDavion)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDefault)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(141, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Style Selector"
        '
        'RadioButtonSteiner
        '
        Me.RadioButtonSteiner.AutoSize = True
        Me.RadioButtonSteiner.Location = New System.Drawing.Point(6, 134)
        Me.RadioButtonSteiner.MinimumSize = New System.Drawing.Size(58, 17)
        Me.RadioButtonSteiner.Name = "RadioButtonSteiner"
        Me.RadioButtonSteiner.Size = New System.Drawing.Size(58, 17)
        Me.RadioButtonSteiner.TabIndex = 6
        Me.RadioButtonSteiner.TabStop = True
        Me.RadioButtonSteiner.Text = "Steiner"
        Me.RadioButtonSteiner.UseVisualStyleBackColor = True
        '
        'RadioButtonMarik
        '
        Me.RadioButtonMarik.AutoSize = True
        Me.RadioButtonMarik.Location = New System.Drawing.Point(6, 111)
        Me.RadioButtonMarik.Name = "RadioButtonMarik"
        Me.RadioButtonMarik.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonMarik.TabIndex = 5
        Me.RadioButtonMarik.TabStop = True
        Me.RadioButtonMarik.Text = "Marik"
        Me.RadioButtonMarik.UseVisualStyleBackColor = True
        '
        'RadioButtonLiao
        '
        Me.RadioButtonLiao.AutoSize = True
        Me.RadioButtonLiao.Location = New System.Drawing.Point(6, 88)
        Me.RadioButtonLiao.Name = "RadioButtonLiao"
        Me.RadioButtonLiao.Size = New System.Drawing.Size(45, 17)
        Me.RadioButtonLiao.TabIndex = 4
        Me.RadioButtonLiao.TabStop = True
        Me.RadioButtonLiao.Text = "Liao"
        Me.RadioButtonLiao.UseVisualStyleBackColor = True
        '
        'RadioButtonKurita
        '
        Me.RadioButtonKurita.AutoSize = True
        Me.RadioButtonKurita.Location = New System.Drawing.Point(6, 65)
        Me.RadioButtonKurita.Name = "RadioButtonKurita"
        Me.RadioButtonKurita.Size = New System.Drawing.Size(52, 17)
        Me.RadioButtonKurita.TabIndex = 3
        Me.RadioButtonKurita.TabStop = True
        Me.RadioButtonKurita.Text = "Kurita"
        Me.RadioButtonKurita.UseVisualStyleBackColor = True
        '
        'RadioButtonDavion
        '
        Me.RadioButtonDavion.AutoSize = True
        Me.RadioButtonDavion.Location = New System.Drawing.Point(6, 42)
        Me.RadioButtonDavion.Name = "RadioButtonDavion"
        Me.RadioButtonDavion.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonDavion.TabIndex = 2
        Me.RadioButtonDavion.TabStop = True
        Me.RadioButtonDavion.Text = "Davion"
        Me.RadioButtonDavion.UseVisualStyleBackColor = True
        '
        'RadioButtonDefault
        '
        Me.RadioButtonDefault.AutoSize = True
        Me.RadioButtonDefault.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonDefault.Name = "RadioButtonDefault"
        Me.RadioButtonDefault.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonDefault.TabIndex = 1
        Me.RadioButtonDefault.TabStop = True
        Me.RadioButtonDefault.Text = "Default"
        Me.RadioButtonDefault.UseVisualStyleBackColor = True
        '
        'ButtonSet
        '
        Me.ButtonSet.Location = New System.Drawing.Point(187, 149)
        Me.ButtonSet.Name = "ButtonSet"
        Me.ButtonSet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSet.TabIndex = 1
        Me.ButtonSet.Text = "Set"
        Me.ButtonSet.UseVisualStyleBackColor = True
        '
        'CssSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 184)
        Me.Controls.Add(Me.ButtonSet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CssSelector"
        Me.Text = "CssSelector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonSteiner As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMarik As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonLiao As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonKurita As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDavion As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDefault As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonSet As System.Windows.Forms.Button
End Class
