<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TwinRadioButton = New System.Windows.Forms.RadioButton()
        Me.SizeGroupBox = New System.Windows.Forms.GroupBox()
        Me.KingRadioButton = New System.Windows.Forms.RadioButton()
        Me.QueenRadioButton = New System.Windows.Forms.RadioButton()
        Me.FullRadioButton = New System.Windows.Forms.RadioButton()
        Me.PickUpInStoreCheckBox = New System.Windows.Forms.CheckBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.DisplayCostButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SizeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TwinRadioButton
        '
        Me.TwinRadioButton.AutoSize = True
        Me.TwinRadioButton.Location = New System.Drawing.Point(6, 37)
        Me.TwinRadioButton.Name = "TwinRadioButton"
        Me.TwinRadioButton.Size = New System.Drawing.Size(60, 24)
        Me.TwinRadioButton.TabIndex = 0
        Me.TwinRadioButton.TabStop = True
        Me.TwinRadioButton.Text = "&Twin"
        Me.TwinRadioButton.UseVisualStyleBackColor = True
        '
        'SizeGroupBox
        '
        Me.SizeGroupBox.Controls.Add(Me.KingRadioButton)
        Me.SizeGroupBox.Controls.Add(Me.QueenRadioButton)
        Me.SizeGroupBox.Controls.Add(Me.FullRadioButton)
        Me.SizeGroupBox.Controls.Add(Me.TwinRadioButton)
        Me.SizeGroupBox.Location = New System.Drawing.Point(41, 37)
        Me.SizeGroupBox.Name = "SizeGroupBox"
        Me.SizeGroupBox.Size = New System.Drawing.Size(95, 210)
        Me.SizeGroupBox.TabIndex = 1
        Me.SizeGroupBox.TabStop = False
        Me.SizeGroupBox.Text = "Size"
        '
        'KingRadioButton
        '
        Me.KingRadioButton.AutoSize = True
        Me.KingRadioButton.Location = New System.Drawing.Point(6, 155)
        Me.KingRadioButton.Name = "KingRadioButton"
        Me.KingRadioButton.Size = New System.Drawing.Size(60, 24)
        Me.KingRadioButton.TabIndex = 3
        Me.KingRadioButton.TabStop = True
        Me.KingRadioButton.Text = "&King"
        Me.KingRadioButton.UseVisualStyleBackColor = True
        '
        'QueenRadioButton
        '
        Me.QueenRadioButton.AutoSize = True
        Me.QueenRadioButton.Location = New System.Drawing.Point(6, 116)
        Me.QueenRadioButton.Name = "QueenRadioButton"
        Me.QueenRadioButton.Size = New System.Drawing.Size(73, 24)
        Me.QueenRadioButton.TabIndex = 2
        Me.QueenRadioButton.TabStop = True
        Me.QueenRadioButton.Text = "&Queen"
        Me.QueenRadioButton.UseVisualStyleBackColor = True
        '
        'FullRadioButton
        '
        Me.FullRadioButton.AutoSize = True
        Me.FullRadioButton.Location = New System.Drawing.Point(6, 77)
        Me.FullRadioButton.Name = "FullRadioButton"
        Me.FullRadioButton.Size = New System.Drawing.Size(53, 24)
        Me.FullRadioButton.TabIndex = 1
        Me.FullRadioButton.TabStop = True
        Me.FullRadioButton.Text = "&Full"
        Me.FullRadioButton.UseVisualStyleBackColor = True
        '
        'PickUpInStoreCheckBox
        '
        Me.PickUpInStoreCheckBox.AutoSize = True
        Me.PickUpInStoreCheckBox.Location = New System.Drawing.Point(226, 39)
        Me.PickUpInStoreCheckBox.Name = "PickUpInStoreCheckBox"
        Me.PickUpInStoreCheckBox.Size = New System.Drawing.Size(131, 24)
        Me.PickUpInStoreCheckBox.TabIndex = 2
        Me.PickUpInStoreCheckBox.Text = "&Pick up in store"
        Me.PickUpInStoreCheckBox.UseVisualStyleBackColor = True
        '
        'CostTextBox
        '
        Me.CostTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CostTextBox.Enabled = False
        Me.CostTextBox.Location = New System.Drawing.Point(226, 111)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(125, 27)
        Me.CostTextBox.TabIndex = 3
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Location = New System.Drawing.Point(224, 88)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(41, 20)
        Me.CostLabel.TabIndex = 4
        Me.CostLabel.Text = "Cost:"
        '
        'DisplayCostButton
        '
        Me.DisplayCostButton.Location = New System.Drawing.Point(228, 168)
        Me.DisplayCostButton.Name = "DisplayCostButton"
        Me.DisplayCostButton.Size = New System.Drawing.Size(123, 29)
        Me.DisplayCostButton.TabIndex = 5
        Me.DisplayCostButton.Text = "&Display cost"
        Me.DisplayCostButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(228, 219)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(123, 29)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 311)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayCostButton)
        Me.Controls.Add(Me.CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Me.PickUpInStoreCheckBox)
        Me.Controls.Add(Me.SizeGroupBox)
        Me.Name = "frmMain"
        Me.Text = "Hales Department Store"
        Me.SizeGroupBox.ResumeLayout(False)
        Me.SizeGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TwinRadioButton As RadioButton
    Friend WithEvents SizeGroupBox As GroupBox
    Friend WithEvents KingRadioButton As RadioButton
    Friend WithEvents QueenRadioButton As RadioButton
    Friend WithEvents FullRadioButton As RadioButton
    Friend WithEvents PickUpInStoreCheckBox As CheckBox
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents CostLabel As Label
    Friend WithEvents DisplayCostButton As Button
    Friend WithEvents ExitButton As Button
End Class
