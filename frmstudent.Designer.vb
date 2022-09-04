<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudent
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
        Me.txtSearchStudent = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lststudent = New System.Windows.Forms.ListView()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnEditStudent = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.btnRefreshStudent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSearchStudent
        '
        Me.txtSearchStudent.Location = New System.Drawing.Point(216, 44)
        Me.txtSearchStudent.Name = "txtSearchStudent"
        Me.txtSearchStudent.Size = New System.Drawing.Size(153, 20)
        Me.txtSearchStudent.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(80, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SEARCH"
        '
        'lststudent
        '
        Me.lststudent.HideSelection = False
        Me.lststudent.Location = New System.Drawing.Point(83, 121)
        Me.lststudent.Name = "lststudent"
        Me.lststudent.Size = New System.Drawing.Size(1050, 232)
        Me.lststudent.TabIndex = 2
        Me.lststudent.UseCompatibleStateImageBehavior = False
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddStudent.Location = New System.Drawing.Point(200, 474)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(82, 30)
        Me.btnAddStudent.TabIndex = 3
        Me.btnAddStudent.Text = "ADD"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'btnEditStudent
        '
        Me.btnEditStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEditStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditStudent.Location = New System.Drawing.Point(411, 474)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(82, 30)
        Me.btnEditStudent.TabIndex = 4
        Me.btnEditStudent.Text = "EDIT"
        Me.btnEditStudent.UseVisualStyleBackColor = False
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteStudent.Location = New System.Drawing.Point(671, 474)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(82, 30)
        Me.btnDeleteStudent.TabIndex = 5
        Me.btnDeleteStudent.Text = "DELETE"
        Me.btnDeleteStudent.UseVisualStyleBackColor = False
        '
        'btnRefreshStudent
        '
        Me.btnRefreshStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnRefreshStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefreshStudent.Location = New System.Drawing.Point(903, 474)
        Me.btnRefreshStudent.Name = "btnRefreshStudent"
        Me.btnRefreshStudent.Size = New System.Drawing.Size(82, 30)
        Me.btnRefreshStudent.TabIndex = 6
        Me.btnRefreshStudent.Text = "REFRESH"
        Me.btnRefreshStudent.UseVisualStyleBackColor = False
        '
        'frmstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1188, 628)
        Me.Controls.Add(Me.btnRefreshStudent)
        Me.Controls.Add(Me.btnDeleteStudent)
        Me.Controls.Add(Me.btnEditStudent)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.lststudent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchStudent)
        Me.Name = "frmstudent"
        Me.Text = "frmstudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchStudent As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lststudent As ListView
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnEditStudent As Button
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents btnRefreshStudent As Button

    Private Sub frmstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lststudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lststudent.SelectedIndexChanged

    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        frmstudentadd.Show()
    End Sub
End Class
