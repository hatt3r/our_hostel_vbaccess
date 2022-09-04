Imports System.Data.OleDb
Public Class frmwardenedit

    Private Sub frmwardenedit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call cleartext()
        txtWardenNO.Focus()
        frmwarden.lstwarden.SelectedItems.Clear()
    End Sub

    Private Sub frmwardenedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call openconnection()
        Call Initialized()
        txtWardenNO.Text = CStr(frmwarden.lstwarden.SelectedItems(0).Text)
        Call Fill()
        Call closeconnection()
    End Sub
    Private Sub cleartext()
        Me.txtWardenNO.Clear()
        Me.txtfn.Clear()
        Me.txtln.Clear()
        Me.txtroomno.Clear()
        Me.txtemailid.Clear()
        Me.txtmobileno.Clear()

    End Sub
    Private Sub Fill()
        Dim OleDr As OleDbDataReader
        OleDa.SelectCommand = New OleDbCommand()
        OleDa.SelectCommand.CommandText = "SELECT * From tblwarden WHERE wardenno = @wardenno"
        OleDa.SelectCommand.Parameters.Add("@wardenno", OleDbType.VarWChar, 50, "wardenno").Value = txtWardenNO.Text
        OleDa.SelectCommand.Connection = OleCn
        OleDr = OleDa.SelectCommand.ExecuteReader()

        If OleDr.HasRows() Then
            OleDr.Read()
            txtWardenNO.Text = OleDr("wardenno").ToString()
            txtfn.Text = OleDr("firstname").ToString()
            txtln.Text = OleDr("lastname").ToString()
            txtroomno.Text = OleDr("roomno").ToString()
            txtemailid.Text = OleDr("emailid").ToString()
            txtmobileno.Text = OleDr("mobileno").ToString()
            cmbhostelname.Text = OleDr("hostelname").ToString()

        End If
        OleDr.Close()
    End Sub



    Private Sub btnSaveWarden_Click(sender As Object, e As EventArgs) Handles btnSaveWarden.Click
        If txtWardenNO.Text = "" Or txtfn.Text = "" Or txtln.Text = "" Or cmbhostelname.Text = "" Or txtmobileno.Text = "" Then
            MsgBox("Dont leave blank textfields")
            Exit Sub
        End If
        Try
            Call openconnection()
            OleDa.UpdateCommand = New OleDbCommand()
            OleDa.UpdateCommand.CommandText = "UPDATE tblwarden SET wardenno = @wardenno, firstname = @firstname, lastname = @lastname, roomno = @roomno, emailid= @emailid, mobileno = @mobileno, hostelname = @hostelname WHERE wardenno = ?"
            OleDa.UpdateCommand.Connection = OleCn
            OleDa.UpdateCommand.Parameters.Add("@wardenno", OleDbType.VarWChar, 50, "wardenno").Value = txtWardenNO.Text
            OleDa.UpdateCommand.Parameters.Add("@firstname", OleDbType.VarWChar, 50, "firstname").Value = txtfn.Text
            OleDa.UpdateCommand.Parameters.Add("@lastName", OleDbType.VarWChar, 50, "lastName").Value = txtln.Text
            OleDa.UpdateCommand.Parameters.Add("@roomno", OleDbType.VarWChar, 50, "roomno").Value = txtroomno.Text
            OleDa.UpdateCommand.Parameters.Add("@emailid", OleDbType.VarWChar, 50, "emailid").Value = txtemailid.Text
            OleDa.UpdateCommand.Parameters.Add("@mobileno", OleDbType.VarWChar, 50, "mobileno").Value = txtmobileno.Text
            OleDa.UpdateCommand.Parameters.Add("@hostelname", OleDbType.VarWChar, 50, "hostelname").Value = cmbhostelname.Text



            OleDa.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("EmpID", System.Data.OleDb.OleDbType.VarWChar, 50,
                                                System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "wardenno",
                                                System.Data.DataRowVersion.Original, Nothing)).Value = frmwarden.lstwarden.SelectedItems(0).Text

            OleDa.UpdateCommand.ExecuteNonQuery()
            Call frmwarden.LoadListView()
            Call closeconnection()

            MsgBox("Records Updated")
            Me.Close()

        Catch ex As Exception
            MsgBox("Cannot Update wardenNo is present")
            Call closeconnection()
            txtWardenNO.Focus()
            txtWardenNO.SelectAll()
        End Try
    End Sub

    Private Sub btnCancelWarden_Click(sender As Object, e As EventArgs) Handles btnCancelWarden.Click
        Me.Close()
    End Sub
End Class