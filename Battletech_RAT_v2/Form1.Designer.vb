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
        Me.ComboBoxBook = New System.Windows.Forms.ComboBox()
        Me.LabelBook = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxMechs
        '
        Me.ListBoxMechs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxMechs.FormattingEnabled = True
        Me.ListBoxMechs.Location = New System.Drawing.Point(184, 12)
        Me.ListBoxMechs.Name = "ListBoxMechs"
        Me.ListBoxMechs.Size = New System.Drawing.Size(172, 290)
        Me.ListBoxMechs.TabIndex = 0
        '
        'ComboBoxFaction
        '
        Me.ComboBoxFaction.FormattingEnabled = True
        Me.ComboBoxFaction.Location = New System.Drawing.Point(12, 70)
        Me.ComboBoxFaction.Name = "ComboBoxFaction"
        Me.ComboBoxFaction.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxFaction.TabIndex = 1
        '
        'ComboBoxTech
        '
        Me.ComboBoxTech.FormattingEnabled = True
        Me.ComboBoxTech.Location = New System.Drawing.Point(12, 110)
        Me.ComboBoxTech.Name = "ComboBoxTech"
        Me.ComboBoxTech.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxTech.TabIndex = 2
        '
        'ComboBoxWeight
        '
        Me.ComboBoxWeight.FormattingEnabled = True
        Me.ComboBoxWeight.Location = New System.Drawing.Point(12, 150)
        Me.ComboBoxWeight.Name = "ComboBoxWeight"
        Me.ComboBoxWeight.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxWeight.TabIndex = 3
        '
        'LabelFaction
        '
        Me.LabelFaction.AutoSize = True
        Me.LabelFaction.Location = New System.Drawing.Point(12, 54)
        Me.LabelFaction.Name = "LabelFaction"
        Me.LabelFaction.Size = New System.Drawing.Size(45, 13)
        Me.LabelFaction.TabIndex = 4
        Me.LabelFaction.Text = "Faction:"
        '
        'LabelTech
        '
        Me.LabelTech.AutoSize = True
        Me.LabelTech.Location = New System.Drawing.Point(12, 94)
        Me.LabelTech.Name = "LabelTech"
        Me.LabelTech.Size = New System.Drawing.Size(35, 13)
        Me.LabelTech.TabIndex = 5
        Me.LabelTech.Text = "Tech:"
        '
        'LabelWeight
        '
        Me.LabelWeight.AutoSize = True
        Me.LabelWeight.Location = New System.Drawing.Point(13, 134)
        Me.LabelWeight.Name = "LabelWeight"
        Me.LabelWeight.Size = New System.Drawing.Size(44, 13)
        Me.LabelWeight.TabIndex = 6
        Me.LabelWeight.Text = "Weight:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelDebugCounter})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 310)
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
        'ComboBoxBook
        '
        Me.ComboBoxBook.FormattingEnabled = True
        Me.ComboBoxBook.Location = New System.Drawing.Point(12, 30)
        Me.ComboBoxBook.Name = "ComboBoxBook"
        Me.ComboBoxBook.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxBook.TabIndex = 8
        '
        'LabelBook
        '
        Me.LabelBook.AutoSize = True
        Me.LabelBook.Location = New System.Drawing.Point(12, 12)
        Me.LabelBook.Name = "LabelBook"
        Me.LabelBook.Size = New System.Drawing.Size(35, 13)
        Me.LabelBook.TabIndex = 9
        Me.LabelBook.Text = "Book:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 332)
        Me.Controls.Add(Me.LabelBook)
        Me.Controls.Add(Me.ComboBoxBook)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LabelWeight)
        Me.Controls.Add(Me.LabelTech)
        Me.Controls.Add(Me.LabelFaction)
        Me.Controls.Add(Me.ComboBoxWeight)
        Me.Controls.Add(Me.ComboBoxTech)
        Me.Controls.Add(Me.ComboBoxFaction)
        Me.Controls.Add(Me.ListBoxMechs)
        Me.Name = "MainForm"
        Me.Text = "Battletech RAT v2"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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

End Class
