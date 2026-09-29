Imports MySql.Data.MySqlClient

Public Class frmMainMenu

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display logged-in user information
        lblUsername.Text = "Username: " & frmLogin.LoggedInUsername
        lblEmployeeName.Text = "Employee Name: " & frmLogin.LoggedInFullName
        lblPosition.Text = "Position: " & frmLogin.LoggedInRole
        lblDate.Text = "Today Is: " & DateTime.Now.ToString("MMMM dd, yyyy")

        ApplyRolePermissions()
    End Sub

    Private Sub ApplyRolePermissions()
        ' Get the logged-in role
        Dim userRole As String = frmLogin.LoggedInRole.Trim()

        If userRole.Equals("Staff", StringComparison.OrdinalIgnoreCase) OrElse
           userRole.Equals("Registrar Staff", StringComparison.OrdinalIgnoreCase) Then

            ' REGISTRAR STAFF PERMISSIONS:
            ' - Search students check 
            ' - Create document requests check 
            ' - View requests / Record payments / Update request status check
            ' - View reports

            btnDocumentRequests.Visible = True   ' Create document requests
            btnStudentManagement.Visible = True  ' Search students
            btnReports.Visible = True            ' View requests and reports

            ' RESTRICTED MODULES FOR STAFF:
            btnDocumentManagement.Visible = False ' Hidden for Staff
            btnUserManagement.Visible = False     ' Hidden for Staff (Admin only)

        ElseIf userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
            ' ADMIN: Full access to all forms
            btnDocumentRequests.Visible = True
            btnStudentManagement.Visible = True
            btnDocumentManagement.Visible = True
            btnUserManagement.Visible = True
            btnReports.Visible = True
        End If
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
        ' Admin Only Check Guard
        If Not frmLogin.LoggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
            MsgBox("Access Denied: Only Admins can manage document types.", MsgBoxStyle.Exclamation, "Access Restricted")
            Exit Sub
        End If

        Dim docForm As New frmDocuments()
        docForm.ShowDialog()
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        ' Admin Only Check Guard
        If Not frmLogin.LoggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
            MsgBox("Access Denied: Only Admins can access User Management.", MsgBoxStyle.Exclamation, "Access Restricted")
            Exit Sub
        End If

        Dim userForm As New frmUsers() ' Name matched to your frmUser form
        userForm.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim viewForm As New frmViewRequests()
        viewForm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Logout Confirmation")
        If ask = MsgBoxResult.Yes Then
            frmLogin.LoggedInUserID = 0
            frmLogin.LoggedInFullName = ""
            frmLogin.LoggedInUsername = ""
            frmLogin.LoggedInRole = ""

            frmLogin.Show()
            Me.Close()
        End If
    End Sub

End Class