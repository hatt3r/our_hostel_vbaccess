<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfees
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
        Me.btnRefreshFees = New System.Windows.Forms.Button()
        Me.btnDeleteFees = New System.Windows.Forms.Button()
        Me.btnEditFees = New System.Windows.Forms.Button()
        Me.btnAddFees = New System.Windows.Forms.Button()
        Me.lstfees = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchFees = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRefreshFees
        '
        Me.btnRefreshFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRefreshFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefreshFees.Location = New System.Drawing.Point(847, 567)
        Me.btnRefreshFees.Name = "btnRefreshFees"
        Me.btnRefreshFees.Size = New System.Drawing.Size(133, 63)
        Me.btnRefreshFees.TabIndex = 13
        Me.btnRefreshFees.Text = "REFRESH"
        Me.btnRefreshFees.UseVisualStyleBackColor = False
        '
        'btnDeleteFees
        '
        Me.btnDeleteFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteFees.Location = New System.Drawing.Point(628, 567)
        Me.btnDeleteFees.Name = "btnDeleteFees"
        Me.btnDeleteFees.Size = New System.Drawing.Size(133, 63)
        Me.btnDeleteFees.TabIndex = 12
        Me.btnDeleteFees.Text = "DELETE"
        Me.btnDeleteFees.UseVisualStyleBackColor = False
        '
        'btnEditFees
        '
        Me.btnEditFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEditFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditFees.Location = New System.Drawing.Point(406, 567)
        Me.btnEditFees.Name = "btnEditFees"
        Me.btnEditFees.Size = New System.Drawing.Size(133, 63)
        Me.btnEditFees.TabIndex = 11
        Me.btnEditFees.Text = "EDIT"
        Me.btnEditFees.UseVisualStyleBackColor = False
        '
        'btnAddFees
        '
        Me.btnAddFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddFees.Location = New System.Drawing.Point(184, 567)
        Me.btnAddFees.Name = "btnAddFees"
        Me.btnAddFees.Size = New System.Drawing.Size(133, 63)
        Me.btnAddFees.TabIndex = 10
        Me.btnAddFees.Text = "ADD"
        Me.btnAddFees.UseVisualStyleBackColor = False
        '
        'lstfees
        '
        Me.lstfees.HideSelection = False
        Me.lstfees.Location = New System.Drawing.Point(92, 200)
        Me.lstfees.Name = "lstfees"
        Me.lstfees.Size = New System.Drawing.Size(1050, 232)
        Me.lstfees.TabIndex = 9
        Me.lstfees.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(180, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SEARCH"
        '
        'txtSearchFees
        '
        Me.txtSearchFees.Location = New System.Drawing.Point(354, 106)
        Me.txtSearchFees.Name = "txtSearchFees"
        Me.txtSearchFees.Size = New System.Drawing.Size(153, 20)
        Me.txtSearchFees.TabIndex = 7
        '
        'frmfees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1160, 742)
        Me.Controls.Add(Me.btnRefreshFees)
        Me.Controls.Add(Me.btnDeleteFees)
        Me.Controls.Add(Me.btnEditFees)
        Me.Controls.Add(Me.btnAddFees)
        Me.Controls.Add(Me.lstfees)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchFees)
        Me.Name = "frmfees"
        Me.Text = "frmfees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRefreshFees As Button
    Friend WithEvents btnDeleteFees As Button
    Friend WithEvents btnEditFees As Button
    Friend WithEvents btnAddFees As Button
    Friend WithEvents lstfees As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchFees As TextBox
End Class
