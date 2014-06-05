<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetMech
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
        Me.LabelMechName = New System.Windows.Forms.Label()
        Me.LabelPilotName = New System.Windows.Forms.Label()
        Me.LabelPilotGunnery = New System.Windows.Forms.Label()
        Me.LabelPilotPiloting = New System.Windows.Forms.Label()
        Me.ButtonSet = New System.Windows.Forms.Button()
        Me.TextBoxMechName = New System.Windows.Forms.TextBox()
        Me.TextBoxPilotName = New System.Windows.Forms.TextBox()
        Me.TextBoxPilotGunnery = New System.Windows.Forms.TextBox()
        Me.TextBoxPilotPiloting = New System.Windows.Forms.TextBox()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelMechName
        '
        Me.LabelMechName.AutoSize = True
        Me.LabelMechName.Location = New System.Drawing.Point(12, 9)
        Me.LabelMechName.Name = "LabelMechName"
        Me.LabelMechName.Size = New System.Drawing.Size(68, 13)
        Me.LabelMechName.TabIndex = 0
        Me.LabelMechName.Text = "Mech Name:"
        '
        'LabelPilotName
        '
        Me.LabelPilotName.AutoSize = True
        Me.LabelPilotName.Location = New System.Drawing.Point(12, 47)
        Me.LabelPilotName.Name = "LabelPilotName"
        Me.LabelPilotName.Size = New System.Drawing.Size(61, 13)
        Me.LabelPilotName.TabIndex = 1
        Me.LabelPilotName.Text = "Pilot Name:"
        '
        'LabelPilotGunnery
        '
        Me.LabelPilotGunnery.AutoSize = True
        Me.LabelPilotGunnery.Location = New System.Drawing.Point(7, 82)
        Me.LabelPilotGunnery.Name = "LabelPilotGunnery"
        Me.LabelPilotGunnery.Size = New System.Drawing.Size(73, 13)
        Me.LabelPilotGunnery.TabIndex = 2
        Me.LabelPilotGunnery.Text = "Pilot Gunnery:"
        '
        'LabelPilotPiloting
        '
        Me.LabelPilotPiloting.AutoSize = True
        Me.LabelPilotPiloting.Location = New System.Drawing.Point(151, 82)
        Me.LabelPilotPiloting.Name = "LabelPilotPiloting"
        Me.LabelPilotPiloting.Size = New System.Drawing.Size(67, 13)
        Me.LabelPilotPiloting.TabIndex = 3
        Me.LabelPilotPiloting.Text = "Pilot Piloting:"
        '
        'ButtonSet
        '
        Me.ButtonSet.Location = New System.Drawing.Point(335, 77)
        Me.ButtonSet.Name = "ButtonSet"
        Me.ButtonSet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSet.TabIndex = 4
        Me.ButtonSet.Text = "Set"
        Me.ButtonSet.UseVisualStyleBackColor = True
        '
        'TextBoxMechName
        '
        Me.TextBoxMechName.Location = New System.Drawing.Point(86, 6)
        Me.TextBoxMechName.Name = "TextBoxMechName"
        Me.TextBoxMechName.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxMechName.TabIndex = 5
        '
        'TextBoxPilotName
        '
        Me.TextBoxPilotName.Location = New System.Drawing.Point(86, 44)
        Me.TextBoxPilotName.Name = "TextBoxPilotName"
        Me.TextBoxPilotName.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxPilotName.TabIndex = 6
        '
        'TextBoxPilotGunnery
        '
        Me.TextBoxPilotGunnery.Location = New System.Drawing.Point(86, 79)
        Me.TextBoxPilotGunnery.Name = "TextBoxPilotGunnery"
        Me.TextBoxPilotGunnery.Size = New System.Drawing.Size(53, 20)
        Me.TextBoxPilotGunnery.TabIndex = 7
        '
        'TextBoxPilotPiloting
        '
        Me.TextBoxPilotPiloting.Location = New System.Drawing.Point(224, 79)
        Me.TextBoxPilotPiloting.Name = "TextBoxPilotPiloting"
        Me.TextBoxPilotPiloting.Size = New System.Drawing.Size(53, 20)
        Me.TextBoxPilotPiloting.TabIndex = 8
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(283, 9)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(0, 13)
        Me.LabelError.TabIndex = 9
        '
        'SetMech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 113)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.TextBoxPilotPiloting)
        Me.Controls.Add(Me.TextBoxPilotGunnery)
        Me.Controls.Add(Me.TextBoxPilotName)
        Me.Controls.Add(Me.TextBoxMechName)
        Me.Controls.Add(Me.ButtonSet)
        Me.Controls.Add(Me.LabelPilotPiloting)
        Me.Controls.Add(Me.LabelPilotGunnery)
        Me.Controls.Add(Me.LabelPilotName)
        Me.Controls.Add(Me.LabelMechName)
        Me.Name = "SetMech"
        Me.Text = "Set Mech Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMechName As System.Windows.Forms.Label
    Friend WithEvents LabelPilotName As System.Windows.Forms.Label
    Friend WithEvents LabelPilotGunnery As System.Windows.Forms.Label
    Friend WithEvents LabelPilotPiloting As System.Windows.Forms.Label
    Friend WithEvents ButtonSet As System.Windows.Forms.Button
    Friend WithEvents TextBoxMechName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPilotName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPilotGunnery As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPilotPiloting As System.Windows.Forms.TextBox
    Friend WithEvents LabelError As System.Windows.Forms.Label
End Class
