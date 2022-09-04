
Imports System.Data.OleDb
Public Class frmfees
    Dim Oledr As OleDbDataReader
    Dim Item As New ListViewItem()
    Dim ItemSearch As New ListViewItem
    Private Sub frmfees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ListFeesColumns(lstfees)
        Call openconnection()
        Call Initialized2()
        Call LoadListView()
        Call closeconnection()
    End Sub
    Public Sub LoadListView()
        lstfees.Items.Clear()
        Call Initialized2()
        Oledr = OleDa.SelectCommand.ExecuteReader()
        Do While Oledr.Read()
            Item = lstfees.Items.Add(Oledr("studentno").ToString())
            Item.SubItems.Add(Oledr("firstname").ToString())
            Item.SubItems.Add(Oledr("lastname").ToString())
            Item.SubItems.Add(Oledr("course").ToString())
            Item.SubItems.Add(Oledr("roomno").ToString())
            Item.SubItems.Add(Oledr("hostelname").ToString())
            Item.SubItems.Add(Oledr("feespaid").ToString())
            Item.SubItems.Add(Oledr("feesremaining").ToString())
        Loop
        Oledr.Close()
    End Sub

    Private Sub btnAddFees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFees.Click
        frmfeesadd.Show()
    End Sub


    Private Sub btnDeleteFees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteFees.Click


        If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete?") = MsgBoxResult.No Then
            MsgBox("Delete Cancelled.", MsgBoxStyle.Information)
            lstfees.SelectedItems.Clear()
            Exit Sub
        End If
        For Each Item As ListViewItem In lstfees.SelectedItems
            Item.Remove()
            OleDa.DeleteCommand = New OleDbCommand()
            Call openconnection()
            OleDa.DeleteCommand.CommandText = "DELETE FROM tblfees WHERE studentno = @studentno"
            OleDa.DeleteCommand.Connection = OleCn
            OleDa.DeleteCommand.Parameters.Add("@studentno", OleDbType.VarChar, 50, "studentno").Value = Item.Text.ToString()
            OleDa.DeleteCommand.ExecuteNonQuery()
            Call LoadListView()
            Call closeconnection()
        Next
        MsgBox("Record Deleted")
        lstfees.SelectedItems.Clear()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshFees.Click
        Call openconnection()
        Call Initialized2()
        Call LoadListView()
        Call closeconnection()
        txtSearchFees.Clear()
        MsgBox("Total Records = " & lstfees.Items.Count, MsgBoxStyle.Information, "Record")
    End Sub
    Private Sub Searchfees()
        lstfees.Items.Clear()
        Call Initialized2()
        OleDa.SelectCommand.CommandText = "SELECT * FROM tblfees WHERE studentno Like '%%" & txtSearchFees.Text.Trim.ToString() & "%%'"

        OleDa.SelectCommand.Connection = OleCn
        Oledr = OleDa.SelectCommand.ExecuteReader()
        Do While Oledr.Read()
            ItemSearch = lstfees.Items.Add(Oledr("studentno").ToString())
            ItemSearch.SubItems.Add(Oledr("firstname").ToString())
            ItemSearch.SubItems.Add(Oledr("lastname").ToString())
            ItemSearch.SubItems.Add(Oledr("course").ToString())

            ItemSearch.SubItems.Add(Oledr("roomno").ToString())
            ItemSearch.SubItems.Add(Oledr("hostelname").ToString())
            ItemSearch.SubItems.Add(Oledr("feespaid").ToString())
            ItemSearch.SubItems.Add(Oledr("feesremaining").ToString())
        Loop
        Oledr.Close()
    End Sub

    Private Sub txtSearchFees_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchFees.TextChanged
        OleDa.SelectCommand = New OleDbCommand()
        OleDa.SelectCommand.CommandText = "SELECT * FROM tblfees WHERE studentno Like '%%'"
        OleDa.SelectCommand.Connection = OleCn
        Call openconnection()
        OleDa.SelectCommand.ExecuteNonQuery()
        Call Searchfees()
        Call closeconnection()
    End Sub

    Private Sub btnEditFees_Click(sender As Object, e As EventArgs) Handles btnEditFees.Click
        frmfeesedit.Show()
    End Sub
End Class
