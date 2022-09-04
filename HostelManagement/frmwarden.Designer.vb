<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwarden
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
        Me.btnRefreshWarden = New System.Windows.Forms.Button()
        Me.btnDeleteWarden = New System.Windows.Forms.Button()
        Me.btnEditWarden = New System.Windows.Forms.Button()
        Me.btnAddWarden = New System.Windows.Forms.Button()
        Me.lstwarden = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchWarden = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRefreshWarden
        '
        Me.btnRefreshWarden.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnRefreshWarden.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefreshWarden.Location = New System.Drawing.Point(675, 483)
        Me.btnRefreshWarden.Name = "btnRefreshWarden"
        Me.btnRefreshWarden.Size = New System.Drawing.Size(82, 30)
        Me.btnRefreshWarden.TabIndex = 13
        Me.btnRefreshWarden.Text = "REFRESH"
        Me.btnRefreshWarden.UseVisualStyleBackColor = False
        '
        'btnDeleteWarden
        '
        Me.btnDeleteWarden.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDeleteWarden.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteWarden.Location = New System.Drawing.Point(492, 483)
        Me.btnDeleteWarden.Name = "btnDeleteWarden"
        Me.btnDeleteWarden.Size = New System.Drawing.Size(82, 30)
        Me.btnDeleteWarden.TabIndex = 12
        Me.btnDeleteWarden.Text = "DELETE"
        Me.btnDeleteWarden.UseVisualStyleBackColor = False
        '
        'btnEditWarden
        '
        Me.btnEditWarden.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEditWarden.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditWarden.Location = New System.Drawing.Point(281, 483)
        Me.btnEditWarden.Name = "btnEditWarden"
        Me.btnEditWarden.Size = New System.Drawing.Size(82, 30)
        Me.btnEditWarden.TabIndex = 11
        Me.btnEditWarden.Text = "EDIT"
        Me.btnEditWarden.UseVisualStyleBackColor = False
        '
        'btnAddWarden
        '
        Me.btnAddWarden.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAddWarden.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddWarden.Location = New System.Drawing.Point(61, 483)
        Me.btnAddWarden.Name = "btnAddWarden"
        Me.btnAddWarden.Size = New System.Drawing.Size(82, 30)
        Me.btnAddWarden.TabIndex = 10
        Me.btnAddWarden.Text = "ADD"
        Me.btnAddWarden.UseVisualStyleBackColor = False
        '
        'lstwarden
        '
        Me.lstwarden.HideSelection = False
        Me.lstwarden.Location = New System.Drawing.Point(40, 133)
        Me.lstwarden.Name = "lstwarden"
        Me.lstwarden.Size = New System.Drawing.Size(1050, 232)
        Me.lstwarden.TabIndex = 9
        Me.lstwarden.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(110, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SEARCH"
        '
        'txtSearchWarden
        '
        Me.txtSearchWarden.Location = New System.Drawing.Point(295, 56)
        Me.txtSearchWarden.Name = "txtSearchWarden"
        Me.txtSearchWarden.Size = New System.Drawing.Size(153, 20)
        Me.txtSearchWarden.TabIndex = 7
        '
        'frmwarden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1117, 672)
        Me.Controls.Add(Me.btnRefreshWarden)
        Me.Controls.Add(Me.btnDeleteWarden)
        Me.Controls.Add(Me.btnEditWarden)
        Me.Controls.Add(Me.btnAddWarden)
        Me.Controls.Add(Me.lstwarden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchWarden)
        Me.Name = "frmwarden"
        Me.Text = "frmwarden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRefreshWarden As Button
    Friend WithEvents btnDeleteWarden As Button
    Friend WithEvents btnEditWarden As Button
    Friend WithEvents btnAddWarden As Button
    Friend WithEvents lstwarden As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchWarden As TextBox
End Class
