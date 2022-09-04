Imports System.Data.OleDb
Public Class frmwarden
    Dim Oledr As OleDbDataReader
    Dim Item As New ListViewItem()
    Dim ItemSearch As New ListViewItem
    Private Sub frmwarden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ListWardenColumns(lstwarden)
        Call openconnection()
        Call Initialized1()
        Call LoadListView()
        Call closeconnection()
    End Sub
    Public Sub LoadListView()
        lstwarden.Items.Clear()
        Call Initialized1()
        Oledr = OleDa.SelectCommand.ExecuteReader()
        Do While Oledr.Read()
            Item = lstwarden.Items.Add(Oledr("wardenno").ToString())
            Item.SubItems.Add(Oledr("firstname").ToString())
            Item.SubItems.Add(Oledr("lastname").ToString())
            Item.SubItems.Add(Oledr("roomno").ToString())
            Item.SubItems.Add(Oledr("emailid").ToString())
            Item.SubItems.Add(Oledr("mobileno").ToString())
            Item.SubItems.Add(Oledr("hostelname").ToString())
        Loop
        Oledr.Close()
    End Sub

    Private Sub btnAddWarden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWarden.Click
        frmwardenadd.Show()
    End Sub


    Private Sub btnEditwarden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditWarden.Click

        frmwardenedit.Show()
    End Sub


    Private Sub btnDeleteWarden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteWarden.Click


        If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete?") = MsgBoxResult.No Then
            MsgBox("Delete Cancelled.", MsgBoxStyle.Information)
            lstwarden.SelectedItems.Clear()
            Exit Sub
        End If
        For Each Item As ListViewItem In lstwarden.SelectedItems
            Item.Remove()
            OleDa.DeleteCommand = New OleDbCommand()
            Call openconnection()
            OleDa.DeleteCommand.CommandText = "DELETE FROM tblwarden WHERE wardenno = @wardenno"
            OleDa.DeleteCommand.Connection = OleCn
            OleDa.DeleteCommand.Parameters.Add("@wardenno", OleDbType.VarChar, 50, "wardenno").Value = Item.Text.ToString()
            OleDa.DeleteCommand.ExecuteNonQuery()
            Call LoadListView()
            Call closeconnection()
        Next
        MsgBox("Record Deleted")
        lstwarden.SelectedItems.Clear()
    End Sub

    Private Sub btnRefreshWWarden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshWarden.Click
        Call openconnection()
        Call Initialized1()
        Call LoadListView()
        Call closeconnection()
        txtSearchWarden.Clear()
        MsgBox("Total Records = " & lstwarden.Items.Count, MsgBoxStyle.Information, "Record")
    End Sub
    Private Sub SearchWarden()
        lstwarden.Items.Clear()
        Call Initialized1()
        OleDa.SelectCommand.CommandText = "SELECT * FROM tblwarden WHERE wardenno Like '%%" & txtSearchWarden.Text.Trim.ToString() & "%%'"

        OleDa.SelectCommand.Connection = OleCn
        Oledr = OleDa.SelectCommand.ExecuteReader()
        Do While Oledr.Read()
            ItemSearch = lstwarden.Items.Add(Oledr("wardenno").ToString())
            ItemSearch.SubItems.Add(Oledr("firstname").ToString())
            ItemSearch.SubItems.Add(Oledr("lastname").ToString())
            ItemSearch.SubItems.Add(Oledr("emailid").ToString())
            ItemSearch.SubItems.Add(Oledr("roomno").ToString())
            ItemSearch.SubItems.Add(Oledr("mobileno").ToString())
            ItemSearch.SubItems.Add(Oledr("hostelname").ToString())
        Loop
        Oledr.Close()
    End Sub

    Private Sub txtSearchWarden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchWarden.TextChanged
        OleDa.SelectCommand = New OleDbCommand()
        OleDa.SelectCommand.CommandText = "SELECT * FROM tblwarden WHERE warden Like '%%'"
        OleDa.SelectCommand.Connection = OleCn
        Call openconnection()
        OleDa.SelectCommand.ExecuteNonQuery()
        Call SearchWarden()
        Call closeconnection()
    End Sub
End Class
