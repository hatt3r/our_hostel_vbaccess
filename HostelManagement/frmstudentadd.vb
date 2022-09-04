Imports System.Data.OleDb
Public Class frmstudentadd
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub frmstudentadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaveStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveStudent.Click
        If txtStudentUSN.Text = "" Or txtfn.Text = "" Or cmbcourse.Text = "" Or txtln.Text = "" Then
            MsgBox("Please don't leave blank textfields", MsgBoxStyle.Information, "Missing data")
            Exit Sub
        End If
        Try
            Call openconnection()
            OleDa.InsertCommand = New OleDbCommand()
            OleDa.InsertCommand.CommandText = "INSERT INTO tblstudent (studentno, firstname, lastname, course, mobileno, roomno, hostelname)" &
            "VALUES (@studentno , @firstname, @lastname, @course, @mobileno, @roomno, @hostelname)"
            OleDa.InsertCommand.Connection = OleCn
            OleDa.InsertCommand.Parameters.Add("@studentno", OleDbType.VarWChar, 50, "studentno").Value = txtStudentUSN.Text
            OleDa.InsertCommand.Parameters.Add("@firstname", OleDbType.VarWChar, 50, "firstname").Value = txtfn.Text
            OleDa.InsertCommand.Parameters.Add("@lastname", OleDbType.VarWChar, 50, "lastname").Value = txtln.Text
            OleDa.InsertCommand.Parameters.Add("@course", OleDbType.VarWChar, 50, "course").Value = cmbcourse.Text
            OleDa.InsertCommand.Parameters.Add("@mobileno", OleDbType.VarWChar, 50, "mobileno").Value = txtmobileno.Text
            OleDa.InsertCommand.Parameters.Add("@roomno", OleDbType.VarWChar, 50, "roomno").Value = txtroomno.Text
            OleDa.InsertCommand.Parameters.Add("@hostelname", OleDbType.VarWChar, 50, "hostelname").Value = cmbhostelname.Text

            OleDa.InsertCommand.ExecuteNonQuery()
            Call frmstudent.LoadListView()
            Call closeconnection()

            MsgBox("Records Saved", MsgBoxStyle.Information, "Saved")
            Me.Close()

        Catch ex As Exception
            MsgBox("Cannot Save this record, Existing Student Number", MsgBoxStyle.Information, "Error")

            Call closeconnection()

            txtStudentUSN.Focus()
            txtStudentUSN.SelectAll()

        End Try
    End Sub
End Class