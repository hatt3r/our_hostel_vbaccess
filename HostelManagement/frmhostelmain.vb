Public Class frmhostelmain
    Private Sub btnstudent_Click(sender As Object, e As EventArgs) Handles btnstudent.Click
        frmstudent.Show()
    End Sub

    Private Sub btnWardens_Click(sender As Object, e As EventArgs) Handles btnWardens.Click
        frmwarden.Show()
    End Sub

    Private Sub btnFee_Click(sender As Object, e As EventArgs) Handles btnFee.Click
        frmfees.Show()
    End Sub

    Private Sub frmhostelmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class