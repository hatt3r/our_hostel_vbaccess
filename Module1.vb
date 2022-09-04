Imports System.Data.OleDb
Module Module1
    Dim Provider As String
    Public OleCn As New OleDbConnection()
    Public OleDa As New OleDbDataAdapter()
    Public Function OledbConnectionString() As String
        Provider = "Provider= Microsoft.Jet.oledb.4.0; Data Source = ..\Hostel.mdb"
        Return Provider
    End Function
    Public Sub ListStudentColumns(ByVal Lv As ListView)
        With Lv
            .Columns.Add("studentno", 120)
            .Columns.Add("firstname", 150)
            .Columns.Add("lastname", 180)
            .Columns.Add("course", 120)
            .Columns.Add("mobileno", 120)
            .Columns.Add("roomno", 120)
            .Columns.Add("hostelname", 120)
            .FullRowSelect = True
            .MultiSelect = True
            .GridLines = True
            .HideSelection = False
            .View = View.Details
        End With
    End Sub
    Public Sub ListWardenColumns(ByVal Lv1 As ListView)
        With Lv1
            .Columns.Add("wardenno", 120)
            .Columns.Add("firstname", 150)
            .Columns.Add("lastname", 180)
            .Columns.Add("roomno", 120)
            .Columns.Add("emailid", 120)
            .Columns.Add("mobileno", 120)
            .Columns.Add("hostelname", 120)
            .FullRowSelect = True
            .MultiSelect = True
            .GridLines = True
            .HideSelection = False
            .View = View.Details
        End With
    End Sub
    Public Sub ListFeesColumns(ByVal Lv2 As ListView)
        With Lv2
            .Columns.Add("studentno", 120)
            .Columns.Add("firstname", 150)
            .Columns.Add("lastname", 180)
            .Columns.Add("course", 120)
            .Columns.Add("roomno", 120)
            .Columns.Add("hostelname", 120)
            .Columns.Add("feespaid", 120)

            .Columns.Add("feesremaining", 120)
            .FullRowSelect = True
            .MultiSelect = True
            .GridLines = True
            .HideSelection = False
            .View = View.Details
        End With
    End Sub
    Public Sub openconnection()
        If OleCn.State <> ConnectionState.Open Then
            OleCn.ConnectionString = OledbConnectionString()
            OleCn.Open()
        End If
    End Sub
    Public Sub closeconnection()
        OleCn.Close()
    End Sub
    Public Sub Initialized()
        OleDa.SelectCommand = New OleDbCommand()
        OleDa.SelectCommand.CommandText = "Select * from tblstudent"

        OleDa.SelectCommand.Connection = OleCn
    End Sub
    Public Sub Initialized1()
        OleDa.SelectCommand = New OleDbCommand()
        OleDa.SelectCommand.CommandText = "Select * from tblwarden"

        OleDa.SelectCommand.Connection = OleCn
    End Sub
    Public Sub Initialized2()
        OleDa.SelectCommand = New OleDbCommand()
        OleDa.SelectCommand.CommandText = "Select * from tblfees"

        OleDa.SelectCommand.Connection = OleCn
    End Sub
End Module
