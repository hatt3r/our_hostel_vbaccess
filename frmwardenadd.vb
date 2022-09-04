Imports System.Data.OleDb
Public Class frmwardenadd
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub frmwardenadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaveWarden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveWarden.Click
        If txtWardenNO.Text = "" Or txtfn.Text = "" Or cmbhostelname.Text = "" Or txtln.Text = "" Or txtemailid.Text = "" Or txtmobileno.Text = "" Or txtroomno.Text = "" Then
            MsgBox("Please don't leave blank textfields", MsgBoxStyle.Information, "Missing data")
            Exit Sub
        End If
        Try
            Call openconnection()
            OleDa.InsertCommand = New OleDbCommand()
            OleDa.InsertCommand.CommandText = "INSERT INTO tblwarden (wardenno, firstname, lastname,roomno , emailid , mobileno, hostelname)" &
            "VALUES (@wardenono , @firstname, @lastname,  @roomno,@emailid , @mobileno, @hostelname)"
            OleDa.InsertCommand.Connection = OleCn
            OleDa.InsertCommand.Parameters.Add("@wardenno", OleDbType.VarWChar, 50, "wardenno").Value = txtWardenNO.Text
            OleDa.InsertCommand.Parameters.Add("@firstname", OleDbType.VarWChar, 50, "firstname").Value = txtfn.Text
            OleDa.InsertCommand.Parameters.Add("@lastname", OleDbType.VarWChar, 50, "lastname").Value = txtln.Text
            OleDa.InsertCommand.Parameters.Add("@emailid", OleDbType.VarWChar, 50, "emailid").Value = txtemailid.Text
            OleDa.InsertCommand.Parameters.Add("@roomno", OleDbType.VarWChar, 50, "roomno").Value = txtroomno.Text
            OleDa.InsertCommand.Parameters.Add("@mobileno", OleDbType.VarWChar, 50, "mobileno").Value = txtmobileno.Text
            OleDa.InsertCommand.Parameters.Add("@hostelname", OleDbType.VarWChar, 50, "hostelname").Value = cmbhostelname.Text


            OleDa.InsertCommand.ExecuteNonQuery()
            Call frmwarden.LoadListView()
            Call closeconnection()

            MsgBox("Records Saved", MsgBoxStyle.Information, "Saved")
            Me.Close()

        Catch ex As Exception
            MsgBox("Cannot Save this record, Existing Warden Number", MsgBoxStyle.Information, "Error")

            Call closeconnection()

            txtWardenNO.Focus()
            txtWardenNO.SelectAll()

        End Try
    End Sub
End Class