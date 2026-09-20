Imports MySql.Data.MySqlClient

Public Class frmMainMenu

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = "Username: " & frmLogin.LoggedInUsername
        lblEmployeeName.Text = "Employee Name: " & frmLogin.LoggedInFullName
        lblPosition.Text = "Position: " & frmLogin.LoggedInRole
        lblDate.Text = "Today Is: " & DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub btnDocumentRequests_Click(sender As Object, e As EventArgs) Handles btnDocumentRequests.Click
        Dim reqForm As New frmRequest()
        reqForm.ShowDialog()
    End Sub

    Private Sub btnStudentManagement_Click(sender As Object, e As EventArgs) Handles btnStudentManagement.Click
        Dim studentForm As New frmStudents()
        studentForm.ShowDialog()
    End Sub

    Private Sub btnDocumentManagement_Click(sender As Object, e As EventArgs) Handles btnDocumentManagement.Click
        Dim docForm As New frmDocuments()
        docForm.ShowDialog()
    End Sub

    'not finish
    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        MsgBox("User Management module selected.", MsgBoxStyle.Information)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim viewForm As New frmViewRequests()
        viewForm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Logout Confirmation")
        If ask = MsgBoxResult.Yes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

End Class