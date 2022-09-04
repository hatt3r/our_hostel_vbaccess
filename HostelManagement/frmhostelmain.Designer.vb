<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhostelmain
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
        Me.btnstudent = New System.Windows.Forms.Button()
        Me.btnWardens = New System.Windows.Forms.Button()
        Me.btnFee = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnstudent
        '
        Me.btnstudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnstudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnstudent.Location = New System.Drawing.Point(3, 3)
        Me.btnstudent.Name = "btnstudent"
        Me.btnstudent.Size = New System.Drawing.Size(174, 155)
        Me.btnstudent.TabIndex = 0
        Me.btnstudent.Text = "Student"
        Me.btnstudent.UseVisualStyleBackColor = False
        '
        'btnWardens
        '
        Me.btnWardens.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnWardens.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnWardens.Location = New System.Drawing.Point(183, 3)
        Me.btnWardens.Name = "btnWardens"
        Me.btnWardens.Size = New System.Drawing.Size(171, 155)
        Me.btnWardens.TabIndex = 1
        Me.btnWardens.Text = "Wardens"
        Me.btnWardens.UseVisualStyleBackColor = False
        '
        'btnFee
        '
        Me.btnFee.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnFee.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFee.Location = New System.Drawing.Point(3, 3)
        Me.btnFee.Name = "btnFee"
        Me.btnFee.Size = New System.Drawing.Size(174, 147)
        Me.btnFee.TabIndex = 3
        Me.btnFee.Text = "Fees"
        Me.btnFee.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnstudent)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnWardens)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(189, 85)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(371, 159)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnFee)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(286, 260)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 147)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'frmhostelmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Name = "frmhostelmain"
        Me.Text = "frmhostelmain"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnstudent As Button
    Friend WithEvents btnWardens As Button
    Friend WithEvents btnFee As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
End Class
