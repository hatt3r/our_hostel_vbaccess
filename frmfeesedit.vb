Imports System.Data.OleDb
Public Class frmfeesedit

    Private Sub frmfeesedit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call cleartext()
        txtStudentUSN.Focus()
        frmfees.lstfees.SelectedItems.Clear()
    End Sub

    Private Sub frmfeesedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call openconnection()
        Call Initialized2()
        txtStudentUSN.Text = CStr(frmfees.lstfees.SelectedItems(0).Text)
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
        OleDa.SelectCommand.CommandText = "SELECT * From tblfees WHERE studentno = @studentno"
        OleDa.SelectCommand.Parameters.Add("@studentno", OleDbType.VarWChar, 50, "studentno").Value = txtStudentUSN.Text
        OleDa.SelectCommand.Connection = OleCn
        OleDr = OleDa.SelectCommand.ExecuteReader()

        If OleDr.HasRows() Then
            OleDr.Read()
            txtStudentUSN.Text = OleDr("studentno").ToString()
            txtfn.Text = OleDr("firstname").ToString()
            txtln.Text = OleDr("lastname").ToString()
            cmbcourse.Text = OleDr("course").ToString()

            txtroomno.Text = OleDr("roomno").ToString()
            cmbhostelname.Text = OleDr("hostelname").ToString()
            txtfeespaid.Text = OleDr("feespaid").ToString
            txtfeesremaining.Text = OleDr("feesremaining").ToString


        End If
        OleDr.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSaveFees_Click(sender As Object, e As EventArgs) Handles btnSaveFees.Click
        If txtStudentUSN.Text = "" Or txtfn.Text = "" Or txtln.Text = "" Or cmbcourse.Text = "" Or txtroomno.Text = "" Then
            MsgBox("Dont leave blank textfields")
            Exit Sub
        End If
        Try
            Call openconnection()
            OleDa.UpdateCommand = New OleDbCommand()
            OleDa.UpdateCommand.CommandText = "UPDATE tblfees SET studentno = @studentno, firstname = @firstname, lastname = @lastname, course = @course, mobileno = @mobileno, roomno = @roomno, hostelname = @hostelname, feespaid = @feespaid, feesremaining = @feesremaining WHERE studentno = ? "
            OleDa.UpdateCommand.Connection = OleCn
            OleDa.UpdateCommand.Parameters.Add("@studentno", OleDbType.VarWChar, 50, "studentno").Value = txtStudentUSN.Text
            OleDa.UpdateCommand.Parameters.Add("@firstname", OleDbType.VarWChar, 50, "firstname").Value = txtfn.Text
            OleDa.UpdateCommand.Parameters.Add("@lastName", OleDbType.VarWChar, 50, "lastName").Value = txtln.Text
            OleDa.UpdateCommand.Parameters.Add("@course", OleDbType.VarWChar, 50, "course").Value = cmbcourse.Text
            OleDa.UpdateCommand.Parameters.Add("@roomno", OleDbType.VarWChar, 50, "roomno").Value = txtroomno.Text
            OleDa.UpdateCommand.Parameters.Add("@hostelname", OleDbType.VarWChar, 50, "hostelname").Value = cmbhostelname.Text
            OleDa.UpdateCommand.Parameters.Add("@feespaid", OleDbType.VarWChar, 50, "feespaid").Value = txtfeespaid.Text
            OleDa.UpdateCommand.Parameters.Add("@feesremaining", OleDbType.VarWChar, 50, "feesremaining").Value = txtfeesremaining.Text
            OleDa.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("EmpID", System.Data.OleDb.OleDbType.VarWChar, 50,
                                                System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "studentno",
                                                System.Data.DataRowVersion.Original, Nothing)).Value = frmfees.lstfees.SelectedItems(0).Text

            OleDa.UpdateCommand.ExecuteNonQuery()
            Call frmfees.LoadListView()
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