<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PilotAdditionForm
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
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelGunnery = New System.Windows.Forms.Label()
        Me.LabelPiloting = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxGunnery = New System.Windows.Forms.TextBox()
        Me.TextBoxPiloting = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(12, 9)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(38, 13)
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "Name:"
        '
        'LabelGunnery
        '
        Me.LabelGunnery.AutoSize = True
        Me.LabelGunnery.Location = New System.Drawing.Point(12, 36)
        Me.LabelGunnery.Name = "LabelGunnery"
        Me.LabelGunnery.Size = New System.Drawing.Size(50, 13)
        Me.LabelGunnery.TabIndex = 1
        Me.LabelGunnery.Text = "Gunnery:"
        '
        'LabelPiloting
        '
        Me.LabelPiloting.AutoSize = True
        Me.LabelPiloting.Location = New System.Drawing.Point(124, 36)
        Me.LabelPiloting.Name = "LabelPiloting"
        Me.LabelPiloting.Size = New System.Drawing.Size(44, 13)
        Me.LabelPiloting.TabIndex = 2
        Me.LabelPiloting.Text = "Piloting:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(68, 6)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxName.TabIndex = 3
        '
        'TextBoxGunnery
        '
        Me.TextBoxGunnery.Location = New System.Drawing.Point(68, 32)
        Me.TextBoxGunnery.Name = "TextBoxGunnery"
        Me.TextBoxGunnery.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxGunnery.TabIndex = 4
        '
        'TextBoxPiloting
        '
        Me.TextBoxPiloting.Location = New System.Drawing.Point(174, 32)
        Me.TextBoxPiloting.Name = "TextBoxPiloting"
        Me.TextBoxPiloting.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxPiloting.TabIndex = 5
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(79, 67)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 6
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'PilotAdditionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 102)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxPiloting)
        Me.Controls.Add(Me.TextBoxGunnery)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.LabelPiloting)
        Me.Controls.Add(Me.LabelGunnery)
        Me.Controls.Add(Me.LabelName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PilotAdditionForm"
        Me.Text = "Pilot Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents LabelGunnery As System.Windows.Forms.Label
    Friend WithEvents LabelPiloting As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGunnery As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPiloting As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
End Class
