Imports System.Data.OleDb
Public Class frmlogin
    Dim con As New OleDbConnection
    Dim passwordtrials As Integer
    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider= Microsoft.Jet.oledb.4.0; Data Source = ..\Hostel.mdb"   '.. means the database is in the bin folder
    End Sub
    Public Function verify()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        con.Open() 'open the connection
        Dim da As New OleDbDataAdapter("select * from tbluser", con) 'tbluser is the name of the table that contains username and password
        da.Fill(dt)

        For Each DataRow In dt.Rows
            If txtuser.Text = DataRow.Item(0) And txtpass.Text = DataRow(1) Then   'Row 0 = username Row 1 = password
                con.Close() 'close the connection
                Return True
            End If
        Next
        con.Close()
        Return False
    End Function

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If verify() = True Then 'if the username and password are correct, the main form will appear
            frmhostelmain.Show()
            Me.Hide()

        Else
            MessageBox.Show("INVALID USERNAME OR PASSWORD") 'if the username and password are incorrect, this message box will appear
            passwordtrials = passwordtrials + 1
            txtuser.Text = ""
            txtpass.Text = ""
            If passwordtrials >= 3 Then 'the user can input 3 invalid username and password, if the user teached 3 times the program will close
                MsgBox("You have reached 3 login attempts. This program will be terminated.")
                End
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close() 'close the program
    End Sub
End Class
