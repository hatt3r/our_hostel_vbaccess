<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmeditstudent
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
        Me.txtStudentUSN = New System.Windows.Forms.TextBox()
        Me.txtfn = New System.Windows.Forms.TextBox()
        Me.txtln = New System.Windows.Forms.TextBox()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSaveStudent = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtmobileno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbhostelname = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtroomno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtStudentUSN
        '
        Me.txtStudentUSN.Location = New System.Drawing.Point(248, 47)
        Me.txtStudentUSN.Name = "txtStudentUSN"
        Me.txtStudentUSN.Size = New System.Drawing.Size(123, 20)
        Me.txtStudentUSN.TabIndex = 0
        '
        'txtfn
        '
        Me.txtfn.Location = New System.Drawing.Point(248, 135)
        Me.txtfn.Name = "txtfn"
        Me.txtfn.Size = New System.Drawing.Size(123, 20)
        Me.txtfn.TabIndex = 1
        '
        'txtln
        '
        Me.txtln.Location = New System.Drawing.Point(248, 215)
        Me.txtln.Name = "txtln"
        Me.txtln.Size = New System.Drawing.Size(123, 20)
        Me.txtln.TabIndex = 2
        '
        'cmbcourse
        '
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"BCA", "BBA", "BCOM", "MBA", "MCA", "MCOM"})
        Me.cmbcourse.Location = New System.Drawing.Point(248, 269)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(123, 21)
        Me.cmbcourse.TabIndex = 3
        Me.cmbcourse.Text = "Pick One"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(80, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Student USN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(80, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(80, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(80, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Course"
        '
        'btnSaveStudent
        '
        Me.btnSaveStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSaveStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSaveStudent.Location = New System.Drawing.Point(176, 371)
        Me.btnSaveStudent.Name = "btnSaveStudent"
        Me.btnSaveStudent.Size = New System.Drawing.Size(82, 45)
        Me.btnSaveStudent.TabIndex = 8
        Me.btnSaveStudent.Text = "UPDATE"
        Me.btnSaveStudent.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(522, 371)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 45)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtmobileno
        '
        Me.txtmobileno.Location = New System.Drawing.Point(248, 325)
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(123, 20)
        Me.txtmobileno.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(80, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Mobile NO"
        '
        'cmbhostelname
        '
        Me.cmbhostelname.FormattingEnabled = True
        Me.cmbhostelname.Items.AddRange(New Object() {"SVN", "SBS", "SVM"})
        Me.cmbhostelname.Location = New System.Drawing.Point(618, 119)
        Me.cmbhostelname.Name = "cmbhostelname"
        Me.cmbhostelname.Size = New System.Drawing.Size(114, 21)
        Me.cmbhostelname.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(480, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Hostel Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(480, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Room NO"
        '
        'txtroomno
        '
        Me.txtroomno.Location = New System.Drawing.Point(610, 44)
        Me.txtroomno.Name = "txtroomno"
        Me.txtroomno.Size = New System.Drawing.Size(122, 20)
        Me.txtroomno.TabIndex = 18
        '
        'frmeditstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbhostelname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtroomno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmobileno)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveStudent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.txtln)
        Me.Controls.Add(Me.txtfn)
        Me.Controls.Add(Me.txtStudentUSN)
        Me.Name = "frmeditstudent"
        Me.Text = "frmeditstudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStudentUSN As TextBox
    Friend WithEvents txtfn As TextBox
    Friend WithEvents txtln As TextBox
    Friend WithEvents cmbcourse As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSaveStudent As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtmobileno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbhostelname As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtroomno As TextBox
End Class
