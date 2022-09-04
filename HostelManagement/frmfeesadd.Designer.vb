<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfeesadd
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
        Me.cmbhostelname = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtroomno = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveFees = New System.Windows.Forms.Button()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtln = New System.Windows.Forms.TextBox()
        Me.txtfn = New System.Windows.Forms.TextBox()
        Me.txtStudentUSN = New System.Windows.Forms.TextBox()
        Me.txtfeespaid = New System.Windows.Forms.TextBox()
        Me.txtfeesremaining = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbhostelname
        '
        Me.cmbhostelname.FormattingEnabled = True
        Me.cmbhostelname.Items.AddRange(New Object() {"SVN", "SBS", "SVM"})
        Me.cmbhostelname.Location = New System.Drawing.Point(593, 129)
        Me.cmbhostelname.Name = "cmbhostelname"
        Me.cmbhostelname.Size = New System.Drawing.Size(114, 21)
        Me.cmbhostelname.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(463, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Hostel Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(463, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Room NO"
        '
        'txtroomno
        '
        Me.txtroomno.Location = New System.Drawing.Point(593, 54)
        Me.txtroomno.Name = "txtroomno"
        Me.txtroomno.Size = New System.Drawing.Size(122, 20)
        Me.txtroomno.TabIndex = 30
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(383, 336)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(173, 59)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSaveFees
        '
        Me.btnSaveFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSaveFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSaveFees.Location = New System.Drawing.Point(167, 336)
        Me.btnSaveFees.Name = "btnSaveFees"
        Me.btnSaveFees.Size = New System.Drawing.Size(155, 55)
        Me.btnSaveFees.TabIndex = 26
        Me.btnSaveFees.Text = "SAVE"
        Me.btnSaveFees.UseVisualStyleBackColor = False
        '
        'cmbcourse
        '
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"BCA", "BBA", "BCOM", "MCA", "MCOM", "MBA"})
        Me.cmbcourse.Location = New System.Drawing.Point(236, 258)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(117, 21)
        Me.cmbcourse.TabIndex = 25
        Me.cmbcourse.Text = "Pick One"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(85, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(85, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(85, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(85, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Student USN"
        '
        'txtln
        '
        Me.txtln.Location = New System.Drawing.Point(236, 199)
        Me.txtln.Name = "txtln"
        Me.txtln.Size = New System.Drawing.Size(130, 20)
        Me.txtln.TabIndex = 20
        '
        'txtfn
        '
        Me.txtfn.Location = New System.Drawing.Point(236, 125)
        Me.txtfn.Name = "txtfn"
        Me.txtfn.Size = New System.Drawing.Size(130, 20)
        Me.txtfn.TabIndex = 19
        '
        'txtStudentUSN
        '
        Me.txtStudentUSN.Location = New System.Drawing.Point(236, 57)
        Me.txtStudentUSN.Name = "txtStudentUSN"
        Me.txtStudentUSN.Size = New System.Drawing.Size(130, 20)
        Me.txtStudentUSN.TabIndex = 18
        '
        'txtfeespaid
        '
        Me.txtfeespaid.Location = New System.Drawing.Point(600, 194)
        Me.txtfeespaid.Name = "txtfeespaid"
        Me.txtfeespaid.Size = New System.Drawing.Size(106, 20)
        Me.txtfeespaid.TabIndex = 34
        '
        'txtfeesremaining
        '
        Me.txtfeesremaining.Location = New System.Drawing.Point(600, 254)
        Me.txtfeesremaining.Name = "txtfeesremaining"
        Me.txtfeesremaining.Size = New System.Drawing.Size(106, 20)
        Me.txtfeesremaining.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(469, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Fees Paid"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(463, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 18)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Fees Remaining"
        '
        'frmfeesadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtfeesremaining)
        Me.Controls.Add(Me.txtfeespaid)
        Me.Controls.Add(Me.cmbhostelname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtroomno)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveFees)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtln)
        Me.Controls.Add(Me.txtfn)
        Me.Controls.Add(Me.txtStudentUSN)
        Me.Name = "frmfeesadd"
        Me.Text = "frmfeesadd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbhostelname As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtroomno As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveFees As Button
    Friend WithEvents cmbcourse As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtln As TextBox
    Friend WithEvents txtfn As TextBox
    Friend WithEvents txtStudentUSN As TextBox
    Friend WithEvents txtfeespaid As TextBox
    Friend WithEvents txtfeesremaining As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
End Class
