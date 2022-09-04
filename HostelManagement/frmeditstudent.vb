Imports System.Data.OleDb
Public Class frmeditstudent

    Private Sub frmedit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call cleartext()
        txtStudentUSN.Focus()
        frmstudent.lststudent.SelectedItems.Clear()
    End Sub

    Private Sub frmedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call openconnection()
        Call Initialized()
        txtStudentUSN.Text = CStr(frmstudent.lststudent.SelectedItems(0).Text)
        Call Fill()
        Call closeconnection()
    End Sub
    Private Sub cleartext()
        Me.txtStudentUSN.Clear()
        Me.txtfn.Clear()
        Me.txtln.Clear()
    End Sub
    Private Sub Fill()
        Dim OleDr As OleDbDataReader
        OleDa.SelectCommand = New OleDbCommand()
        OleDa.SelectCommand.CommandText = "SELECT * From tblstudent WHERE studentno = @studentno"
        OleDa.SelectCommand.Parameters.Add("@studentno", OleDbType.VarWChar, 50, "studentno").Value = txtStudentUSN.Text
        OleDa.SelectCommand.Connection = OleCn
        OleDr = OleDa.SelectCommand.ExecuteReader()

        If OleDr.HasRows() Then
            OleDr.Read()
            txtStudentUSN.Text = OleDr("studentno").ToString()
            txtfn.Text = OleDr("firstname").ToString()
            txtln.Text = OleDr("lastname").ToString()
            cmbcourse.Text = OleDr("course").ToString()
            txtmobileno.Text = OleDr("mobileno").ToString()
            txtroomno.Text = OleDr("roomno").ToString()
            cmbhostelname.Text = OleDr("hostelname").ToString()

        End If
        OleDr.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveStudent.Click
        If txtStudentUSN.Text = "" Or txtfn.Text = "" Or txtln.Text = "" Or cmbcourse.Text = "" Or txtmobileno.Text = "" Then
            MsgBox("Dont leave blank textfields")
            Exit Sub
        End If
        Try
            Call openconnection()
            OleDa.UpdateCommand = New OleDbCommand()
            OleDa.UpdateCommand.CommandText = "UPDATE tblstudent SET studentno = @studentno, firstname = @firstname, lastname = @lastname, course = @course, mobileno = @mobileno, roomno = @roomno, hostelname = @hostelname WHERE studentno = ?"
            OleDa.UpdateCommand.Connection = OleCn
            OleDa.UpdateCommand.Parameters.Add("@studentno", OleDbType.VarWChar, 50, "studentno").Value = txtStudentUSN.Text
            OleDa.UpdateCommand.Parameters.Add("@firstname", OleDbType.VarWChar, 50, "firstname").Value = txtfn.Text
            OleDa.UpdateCommand.Parameters.Add("@lastName", OleDbType.VarWChar, 50, "lastName").Value = txtln.Text
            OleDa.UpdateCommand.Parameters.Add("@Course", OleDbType.VarWChar, 50, "Course").Value = cmbcourse.Text
            OleDa.UpdateCommand.Parameters.Add("@mobileno", OleDbType.VarWChar, 50, "mobileno").Value = txtmobileno.Text
            OleDa.UpdateCommand.Parameters.Add("@roomno", OleDbType.VarWChar, 50, "roomno").Value = txtroomno.Text
            OleDa.UpdateCommand.Parameters.Add("@hostelname", OleDbType.VarWChar, 50, "hostelname").Value = cmbhostelname.Text



            OleDa.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("EmpID", System.Data.OleDb.OleDbType.VarWChar, 50,
                                                System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "studentno",
                                                System.Data.DataRowVersion.Original, Nothing)).Value = frmstudent.lststudent.SelectedItems(0).Text

            OleDa.UpdateCommand.ExecuteNonQuery()
            Call frmstudent.LoadListView()
            Call closeconnection()

            MsgBox("Records Updated")
            Me.Close()

        Catch ex As Exception
            MsgBox("Cannot Update StudentNo is present")
            Call closeconnection()
            txtStudentUSN.Focus()
            txtStudentUSN.SelectAll()
        End Try
    End Sub


End Class