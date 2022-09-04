Imports System.Data.OleDb
Public Class frmfeesadd
    Private Sub btnSaveFees_Click(sender As Object, e As EventArgs) Handles btnSaveFees.Click
        If txtStudentUSN.Text = "" Or txtfn.Text = "" Or cmbcourse.Text = "" Or txtln.Text = "" Then
            MsgBox("Please don't leave blank textfields", MsgBoxStyle.Information, "Missing data")
            Exit Sub
        End If
        Try
            Call openconnection()
            OleDa.InsertCommand = New OleDbCommand()
            OleDa.InsertCommand.CommandText = "INSERT INTO tblfees (studentno, firstname, lastname, course, roomno, hostelname, feespaid, feesremaining)" &
            "VALUES (@studentno , @firstname, @lastname, @course, @roomno, @hostelname, @feespaid, @feesremaining)"
            OleDa.InsertCommand.Connection = OleCn
            OleDa.InsertCommand.Parameters.Add("@studentno", OleDbType.VarWChar, 50, "studentno").Value = txtStudentUSN.Text
            OleDa.InsertCommand.Parameters.Add("@firstname", OleDbType.VarWChar, 50, "firstname").Value = txtfn.Text
            OleDa.InsertCommand.Parameters.Add("@lastname", OleDbType.VarWChar, 50, "lastname").Value = txtln.Text
            OleDa.InsertCommand.Parameters.Add("@course", OleDbType.VarWChar, 50, "course").Value = cmbcourse.Text
            OleDa.InsertCommand.Parameters.Add("@roomno", OleDbType.VarWChar, 50, "roomno").Value = txtroomno.Text
            OleDa.InsertCommand.Parameters.Add("@hostelname", OleDbType.VarWChar, 50, "hostelname").Value = cmbhostelname.Text
            OleDa.InsertCommand.Parameters.Add("@feespaid", OleDbType.VarWChar, 50, "feespaid").Value = txtfeespaid.Text
            OleDa.InsertCommand.Parameters.Add("@feesremaining", OleDbType.VarWChar, 50, "feesremaining").Value = txtfeesremaining.Text
            OleDa.InsertCommand.ExecuteNonQuery()
            Call frmfees.LoadListView()
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

    Private Sub frmfeesadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class