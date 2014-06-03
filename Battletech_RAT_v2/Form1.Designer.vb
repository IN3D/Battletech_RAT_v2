<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.ListBoxMechs = New System.Windows.Forms.ListBox()
        Me.ComboBoxFaction = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTech = New System.Windows.Forms.ComboBox()
        Me.ComboBoxWeight = New System.Windows.Forms.ComboBox()
        Me.LabelFaction = New System.Windows.Forms.Label()
        Me.LabelTech = New System.Windows.Forms.Label()
        Me.LabelWeight = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelDebugCounter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelDiceRoll = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ComboBoxBook = New System.Windows.Forms.ComboBox()
        Me.LabelBook = New System.Windows.Forms.Label()
        Me.ButtonRoll = New System.Windows.Forms.Button()
        Me.TextBoxModifier = New System.Windows.Forms.TextBox()
        Me.LabelModifier = New System.Windows.Forms.Label()
        Me.LabelJoke = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenUnitMakerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDiceTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxMechs
        '
        Me.ListBoxMechs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxMechs.FormattingEnabled = True
        Me.ListBoxMechs.Location = New System.Drawing.Point(184, 48)
        Me.ListBoxMechs.Name = "ListBoxMechs"
        Me.ListBoxMechs.Size = New System.Drawing.Size(172, 303)
        Me.ListBoxMechs.TabIndex = 0
        '
        'ComboBoxFaction
        '
        Me.ComboBoxFaction.FormattingEnabled = True
        Me.ComboBoxFaction.Location = New System.Drawing.Point(12, 104)
        Me.ComboBoxFaction.Name = "ComboBoxFaction"
        Me.ComboBoxFaction.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxFaction.TabIndex = 1
        '
        'ComboBoxTech
        '
        Me.ComboBoxTech.FormattingEnabled = True
        Me.ComboBoxTech.Location = New System.Drawing.Point(12, 144)
        Me.ComboBoxTech.Name = "ComboBoxTech"
        Me.ComboBoxTech.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxTech.TabIndex = 2
        '
        'ComboBoxWeight
        '
        Me.ComboBoxWeight.FormattingEnabled = True
        Me.ComboBoxWeight.Location = New System.Drawing.Point(12, 184)
        Me.ComboBoxWeight.Name = "ComboBoxWeight"
        Me.ComboBoxWeight.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxWeight.TabIndex = 3
        '
        'LabelFaction
        '
        Me.LabelFaction.AutoSize = True
        Me.LabelFaction.Location = New System.Drawing.Point(12, 88)
        Me.LabelFaction.Name = "LabelFaction"
        Me.LabelFaction.Size = New System.Drawing.Size(45, 13)
        Me.LabelFaction.TabIndex = 4
        Me.LabelFaction.Text = "Faction:"
        '
        'LabelTech
        '
        Me.LabelTech.AutoSize = True
        Me.LabelTech.Location = New System.Drawing.Point(12, 128)
        Me.LabelTech.Name = "LabelTech"
        Me.LabelTech.Size = New System.Drawing.Size(35, 13)
        Me.LabelTech.TabIndex = 5
        Me.LabelTech.Text = "Tech:"
        '
        'LabelWeight
        '
        Me.LabelWeight.AutoSize = True
        Me.LabelWeight.Location = New System.Drawing.Point(13, 168)
        Me.LabelWeight.Name = "LabelWeight"
        Me.LabelWeight.Size = New System.Drawing.Size(44, 13)
        Me.LabelWeight.TabIndex = 6
        Me.LabelWeight.Text = "Weight:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelDebugCounter, Me.ToolStripStatusLabelDiceRoll})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 364)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(368, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelDebugCounter
        '
        Me.ToolStripStatusLabelDebugCounter.Name = "ToolStripStatusLabelDebugCounter"
        Me.ToolStripStatusLabelDebugCounter.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabelDebugCounter.Text = "0"
        '
        'ToolStripStatusLabelDiceRoll
        '
        Me.ToolStripStatusLabelDiceRoll.Name = "ToolStripStatusLabelDiceRoll"
        Me.ToolStripStatusLabelDiceRoll.Size = New System.Drawing.Size(30, 17)
        Me.ToolStripStatusLabelDiceRoll.Text = "Roll:"
        '
        'ComboBoxBook
        '
        Me.ComboBoxBook.FormattingEnabled = True
        Me.ComboBoxBook.Location = New System.Drawing.Point(12, 64)
        Me.ComboBoxBook.Name = "ComboBoxBook"
        Me.ComboBoxBook.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxBook.TabIndex = 8
        '
        'LabelBook
        '
        Me.LabelBook.AutoSize = True
        Me.LabelBook.Location = New System.Drawing.Point(12, 48)
        Me.LabelBook.Name = "LabelBook"
        Me.LabelBook.Size = New System.Drawing.Size(35, 13)
        Me.LabelBook.TabIndex = 9
        Me.LabelBook.Text = "Book:"
        '
        'ButtonRoll
        '
        Me.ButtonRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRoll.Location = New System.Drawing.Point(103, 333)
        Me.ButtonRoll.Name = "ButtonRoll"
        Me.ButtonRoll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRoll.TabIndex = 10
        Me.ButtonRoll.Text = "Roll"
        Me.ButtonRoll.UseVisualStyleBackColor = True
        '
        'TextBoxModifier
        '
        Me.TextBoxModifier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxModifier.Location = New System.Drawing.Point(12, 335)
        Me.TextBoxModifier.Name = "TextBoxModifier"
        Me.TextBoxModifier.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxModifier.TabIndex = 11
        '
        'LabelModifier
        '
        Me.LabelModifier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelModifier.AutoSize = True
        Me.LabelModifier.Location = New System.Drawing.Point(13, 319)
        Me.LabelModifier.Name = "LabelModifier"
        Me.LabelModifier.Size = New System.Drawing.Size(71, 13)
        Me.LabelModifier.TabIndex = 12
        Me.LabelModifier.Text = "Dice modifier:"
        '
        'LabelJoke
        '
        Me.LabelJoke.AutoSize = True
        Me.LabelJoke.ForeColor = System.Drawing.Color.Red
        Me.LabelJoke.Location = New System.Drawing.Point(181, 32)
        Me.LabelJoke.Name = "LabelJoke"
        Me.LabelJoke.Size = New System.Drawing.Size(0, 13)
        Me.LabelJoke.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(368, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.OpenUnitMakerToolStripMenuItem, Me.SetDiceTypeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'OpenUnitMakerToolStripMenuItem
        '
        Me.OpenUnitMakerToolStripMenuItem.Name = "OpenUnitMakerToolStripMenuItem"
        Me.OpenUnitMakerToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.OpenUnitMakerToolStripMenuItem.Text = "Open unit maker"
        '
        'SetDiceTypeToolStripMenuItem
        '
        Me.SetDiceTypeToolStripMenuItem.Name = "SetDiceTypeToolStripMenuItem"
        Me.SetDiceTypeToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SetDiceTypeToolStripMenuItem.Text = "Set dice type"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 386)
        Me.Controls.Add(Me.LabelJoke)
        Me.Controls.Add(Me.LabelModifier)
        Me.Controls.Add(Me.TextBoxModifier)
        Me.Controls.Add(Me.ButtonRoll)
        Me.Controls.Add(Me.LabelBook)
        Me.Controls.Add(Me.ComboBoxBook)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelWeight)
        Me.Controls.Add(Me.LabelTech)
        Me.Controls.Add(Me.LabelFaction)
        Me.Controls.Add(Me.ComboBoxWeight)
        Me.Controls.Add(Me.ComboBoxTech)
        Me.Controls.Add(Me.ComboBoxFaction)
        Me.Controls.Add(Me.ListBoxMechs)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(384, 425)
        Me.Name = "MainForm"
        Me.Text = "Battletech RAT v2"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxMechs As System.Windows.Forms.ListBox
    Friend WithEvents ComboBoxFaction As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTech As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxWeight As System.Windows.Forms.ComboBox
    Friend WithEvents LabelFaction As System.Windows.Forms.Label
    Friend WithEvents LabelTech As System.Windows.Forms.Label
    Friend WithEvents LabelWeight As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelDebugCounter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ComboBoxBook As System.Windows.Forms.ComboBox
    Friend WithEvents LabelBook As System.Windows.Forms.Label
    Friend WithEvents ButtonRoll As System.Windows.Forms.Button
    Friend WithEvents TextBoxModifier As System.Windows.Forms.TextBox
    Friend WithEvents LabelModifier As System.Windows.Forms.Label
    Friend WithEvents LabelJoke As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetDiceTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabelDiceRoll As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenUnitMakerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
