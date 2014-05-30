<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitDesigner
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
        Me.GroupBoxUnitStructure = New System.Windows.Forms.GroupBox()
        Me.TextBoxAssault = New System.Windows.Forms.TextBox()
        Me.LabelAssault = New System.Windows.Forms.Label()
        Me.TextBoxHeavy = New System.Windows.Forms.TextBox()
        Me.LabelHeavy = New System.Windows.Forms.Label()
        Me.TextBoxMedium = New System.Windows.Forms.TextBox()
        Me.LabelMedium = New System.Windows.Forms.Label()
        Me.TextBoxLights = New System.Windows.Forms.TextBox()
        Me.LabelLights = New System.Windows.Forms.Label()
        Me.ListBoxUnits = New System.Windows.Forms.ListBox()
        Me.ComboBoxUnit = New System.Windows.Forms.ComboBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonUnit = New System.Windows.Forms.Button()
        Me.ButtonMoveUp = New System.Windows.Forms.Button()
        Me.ButtonMoveDown = New System.Windows.Forms.Button()
        Me.GroupBoxUnitStructure.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxUnitStructure
        '
        Me.GroupBoxUnitStructure.Controls.Add(Me.TextBoxAssault)
        Me.GroupBoxUnitStructure.Controls.Add(Me.LabelAssault)
        Me.GroupBoxUnitStructure.Controls.Add(Me.TextBoxHeavy)
        Me.GroupBoxUnitStructure.Controls.Add(Me.LabelHeavy)
        Me.GroupBoxUnitStructure.Controls.Add(Me.TextBoxMedium)
        Me.GroupBoxUnitStructure.Controls.Add(Me.LabelMedium)
        Me.GroupBoxUnitStructure.Controls.Add(Me.TextBoxLights)
        Me.GroupBoxUnitStructure.Controls.Add(Me.LabelLights)
        Me.GroupBoxUnitStructure.Location = New System.Drawing.Point(12, 19)
        Me.GroupBoxUnitStructure.Name = "GroupBoxUnitStructure"
        Me.GroupBoxUnitStructure.Size = New System.Drawing.Size(156, 150)
        Me.GroupBoxUnitStructure.TabIndex = 0
        Me.GroupBoxUnitStructure.TabStop = False
        Me.GroupBoxUnitStructure.Text = "Unit Structure"
        '
        'TextBoxAssault
        '
        Me.TextBoxAssault.Location = New System.Drawing.Point(65, 118)
        Me.TextBoxAssault.Name = "TextBoxAssault"
        Me.TextBoxAssault.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxAssault.TabIndex = 7
        '
        'LabelAssault
        '
        Me.LabelAssault.AutoSize = True
        Me.LabelAssault.Location = New System.Drawing.Point(6, 121)
        Me.LabelAssault.Name = "LabelAssault"
        Me.LabelAssault.Size = New System.Drawing.Size(44, 13)
        Me.LabelAssault.TabIndex = 6
        Me.LabelAssault.Text = "Assault:"
        '
        'TextBoxHeavy
        '
        Me.TextBoxHeavy.Location = New System.Drawing.Point(65, 84)
        Me.TextBoxHeavy.Name = "TextBoxHeavy"
        Me.TextBoxHeavy.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxHeavy.TabIndex = 5
        '
        'LabelHeavy
        '
        Me.LabelHeavy.AutoSize = True
        Me.LabelHeavy.Location = New System.Drawing.Point(6, 87)
        Me.LabelHeavy.Name = "LabelHeavy"
        Me.LabelHeavy.Size = New System.Drawing.Size(41, 13)
        Me.LabelHeavy.TabIndex = 4
        Me.LabelHeavy.Text = "Heavy:"
        '
        'TextBoxMedium
        '
        Me.TextBoxMedium.Location = New System.Drawing.Point(65, 51)
        Me.TextBoxMedium.Name = "TextBoxMedium"
        Me.TextBoxMedium.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxMedium.TabIndex = 3
        '
        'LabelMedium
        '
        Me.LabelMedium.AutoSize = True
        Me.LabelMedium.Location = New System.Drawing.Point(6, 54)
        Me.LabelMedium.Name = "LabelMedium"
        Me.LabelMedium.Size = New System.Drawing.Size(47, 13)
        Me.LabelMedium.TabIndex = 2
        Me.LabelMedium.Text = "Medium:"
        '
        'TextBoxLights
        '
        Me.TextBoxLights.Location = New System.Drawing.Point(65, 19)
        Me.TextBoxLights.Name = "TextBoxLights"
        Me.TextBoxLights.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxLights.TabIndex = 1
        '
        'LabelLights
        '
        Me.LabelLights.AutoSize = True
        Me.LabelLights.Location = New System.Drawing.Point(6, 22)
        Me.LabelLights.Name = "LabelLights"
        Me.LabelLights.Size = New System.Drawing.Size(38, 13)
        Me.LabelLights.TabIndex = 0
        Me.LabelLights.Text = "Lights:"
        '
        'ListBoxUnits
        '
        Me.ListBoxUnits.FormattingEnabled = True
        Me.ListBoxUnits.Location = New System.Drawing.Point(255, 46)
        Me.ListBoxUnits.Name = "ListBoxUnits"
        Me.ListBoxUnits.Size = New System.Drawing.Size(191, 212)
        Me.ListBoxUnits.TabIndex = 1
        '
        'ComboBoxUnit
        '
        Me.ComboBoxUnit.FormattingEnabled = True
        Me.ComboBoxUnit.Location = New System.Drawing.Point(255, 19)
        Me.ComboBoxUnit.Name = "ComboBoxUnit"
        Me.ComboBoxUnit.Size = New System.Drawing.Size(191, 21)
        Me.ComboBoxUnit.TabIndex = 2
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(174, 48)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 3
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonUnit
        '
        Me.ButtonUnit.Location = New System.Drawing.Point(174, 19)
        Me.ButtonUnit.Name = "ButtonUnit"
        Me.ButtonUnit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUnit.TabIndex = 4
        Me.ButtonUnit.Text = "New Unit"
        Me.ButtonUnit.UseVisualStyleBackColor = True
        '
        'ButtonMoveUp
        '
        Me.ButtonMoveUp.Location = New System.Drawing.Point(174, 77)
        Me.ButtonMoveUp.Name = "ButtonMoveUp"
        Me.ButtonMoveUp.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMoveUp.TabIndex = 5
        Me.ButtonMoveUp.Text = "▲"
        Me.ButtonMoveUp.UseVisualStyleBackColor = True
        '
        'ButtonMoveDown
        '
        Me.ButtonMoveDown.Location = New System.Drawing.Point(174, 106)
        Me.ButtonMoveDown.Name = "ButtonMoveDown"
        Me.ButtonMoveDown.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMoveDown.TabIndex = 6
        Me.ButtonMoveDown.Text = "▼"
        Me.ButtonMoveDown.UseVisualStyleBackColor = True
        '
        'UnitDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 270)
        Me.Controls.Add(Me.ButtonMoveDown)
        Me.Controls.Add(Me.ButtonMoveUp)
        Me.Controls.Add(Me.ButtonUnit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ComboBoxUnit)
        Me.Controls.Add(Me.ListBoxUnits)
        Me.Controls.Add(Me.GroupBoxUnitStructure)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UnitDesigner"
        Me.Text = "Unit Designer"
        Me.GroupBoxUnitStructure.ResumeLayout(False)
        Me.GroupBoxUnitStructure.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxUnitStructure As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxAssault As System.Windows.Forms.TextBox
    Friend WithEvents LabelAssault As System.Windows.Forms.Label
    Friend WithEvents TextBoxHeavy As System.Windows.Forms.TextBox
    Friend WithEvents LabelHeavy As System.Windows.Forms.Label
    Friend WithEvents TextBoxMedium As System.Windows.Forms.TextBox
    Friend WithEvents LabelMedium As System.Windows.Forms.Label
    Friend WithEvents TextBoxLights As System.Windows.Forms.TextBox
    Friend WithEvents LabelLights As System.Windows.Forms.Label
    Friend WithEvents ListBoxUnits As System.Windows.Forms.ListBox
    Friend WithEvents ComboBoxUnit As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonUnit As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveUp As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveDown As System.Windows.Forms.Button
End Class
