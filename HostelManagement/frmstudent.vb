
Imports System.Data.OleDb
Public Class frmstudent
    Dim Oledr As OleDbDataReader
    Dim Item As New ListViewItem()
    Dim ItemSearch As New ListViewItem
    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ListStudentColumns(lststudent)
        Call openconnection()
        Call Initialized()
        Call LoadListView()
        Call closeconnection()
    End Sub
    Public Sub LoadListView()
        lststudent.Items.Clear()
        Call Initialized()
        Oledr = OleDa.SelectCommand.ExecuteReader()
        Do While Oledr.Read()
            Item = lststudent.Items.Add(Oledr("studentno").ToString())
            Item.SubItems.Add(Oledr("firstname").ToString())
            Item.SubItems.Add(Oledr("lastname").ToString())
            Item.SubItems.Add(Oledr("course").ToString())
            Item.SubItems.Add(Oledr("mobileno").ToString())
            Item.SubItems.Add(Oledr("roomno").ToString())
            Item.SubItems.Add(Oledr("hostelname").ToString())
        Loop
        Oledr.Close()
    End Sub

    Private Sub btnAddSudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        frmstudentadd.Show()
    End Sub

    Private Sub btnEditStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStudent.Click

        frmeditstudent.ShowDialog()
    End Sub


    Private Sub btnDeleteSudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteStudent.Click


        If MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Delete?") = MsgBoxResult.No Then
            MsgBox("Delete Cancelled.", MsgBoxStyle.Information)
            lststudent.SelectedItems.Clear()
            Exit Sub
        End If
        For Each Item As ListViewItem In lststudent.SelectedItems
            Item.Remove()
            OleDa.DeleteCommand = New OleDbCommand()
            Call openconnection()
            OleDa.DeleteCommand.CommandText = "DELETE FROM tblstudent WHERE studentno = @studentno"
            OleDa.DeleteCommand.Connection = OleCn
            OleDa.DeleteCommand.Parameters.Add("@studentno", OleDbType.VarChar, 50, "studentno").Value = Item.Text.ToString()
            OleDa.DeleteCommand.ExecuteNonQuery()
            Call LoadListView()
            Call closeconnection()
        Next
        MsgBox("Record Deleted")
        lststudent.SelectedItems.Clear()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshStudent.Click
        Call openconnection()
        Call Initialized()
        Call LoadListView()
        Call closeconnection()
        txtSearchStudent.Clear()
        MsgBox("Total Records = " & lststudent.Items.Count, MsgBoxStyle.Information, "Record")
    End Sub
    Private Sub SearchStudent()
        lststudent.Items.Clear()
        Call Initialized()
        OleDa.SelectCommand.CommandText = "SELECT * FROM tblstudent WHERE studentno Like '%%" & txtSearchStudent.Text.Trim.ToString() & "%%'"

        OleDa.SelectCommand.Connection = OleCn
        Oledr = OleDa.SelectCommand.ExecuteReader()
        Do While Oledr.Read()
            ItemSearch = lststudent.Items.Add(Oledr("studentno").ToString())
            ItemSearch.SubItems.Add(Oledr("firstname").ToString())
            ItemSearch.SubItems.Add(Oledr("lastname").ToString())
            ItemSearch.SubItems.Add(Oledr("course").ToString())
            ItemSearch.SubItems.Add(Oledr("mobileno").ToString())
            ItemSearch.SubItems.Add(Oledr("roomno").ToString())
            ItemSearch.SubItems.Add(Oledr("hostelname").ToString())
        Loop
        Oledr.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchStudent.TextChanged
        OleDa.SelectCommand = New OleDbCommand()
        OleDa.SelectCommand.CommandText = "SELECT * FROM tblstudent WHERE studentno Like '%%'"
        OleDa.SelectCommand.Connection = OleCn
        Call openconnection()
        OleDa.SelectCommand.ExecuteNonQuery()
        Call SearchStudent()
        Call closeconnection()
    End Sub
End Class
