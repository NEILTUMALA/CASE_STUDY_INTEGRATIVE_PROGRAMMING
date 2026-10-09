Imports MySql.Data.MySqlClient

Public Class frmMainMenu

    Private connStr As String = "Server=127.0.0.1;Port=3307;Database=student_db;Uid=root;Pwd=;"
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Greeting based on log in role
        Dim role As String = frmLogin.LoggedInRole.Trim()

        If role.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
            lblWelcome.Text = "Welcome, Admin!"
        Else
            lblWelcome.Text = "Welcome, Staff!"
        End If

        ' Display logged-in user information
        lblUsername.Text = "Username: " & frmLogin.LoggedInUsername
        lblEmployeeName.Text = "Employee Name: " & frmLogin.LoggedInFullName
        lblPosition.Text = "Position: " & frmLogin.LoggedInRole
        lblDate.Text = "Today Is: " & DateTime.Now.ToString("MMMM dd, yyyy")
        lblTime.Text = "Current Time: " & DateTime.Now.ToString("hh:mm tt")

        ApplyRolePermissions()

        LoadDashboardMetrics()
        LoadRecentRequests()
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        UpdateDateTime()
    End Sub

    Private Sub UpdateDateTime()
        lblDate.Text = "Today Is: " & DateTime.Now.ToString("MMMM dd, yyyy")
        lblTime.Text = "Current Time: " & DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub ApplyRolePermissions()
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

    Public Sub LoadDashboardMetrics()
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                ' 1. New Requests (Today)
                Dim queryToday As String = "SELECT COUNT(*) FROM tblrequest WHERE DATE(RequestDate) = CURDATE()"
                Using cmd As New MySqlCommand(queryToday, conn)
                    lblNewRequests.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' 2. Pending Process (Matches Status = 'Pending')
                Dim queryPending As String = "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Pending'"
                Using cmd As New MySqlCommand(queryPending, conn)
                    lblPending.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' 3. Ready for Release (Matches Status = 'Ready for Release' or 'Ready')
                Dim queryReady As String = "SELECT COUNT(*) FROM tblrequest WHERE Status LIKE '%Ready%'"
                Using cmd As New MySqlCommand(queryReady, conn)
                    lblReadyForRelease.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' 4. Completed this Week (Matches Completed status within the last 7 days)
                Dim queryCompleted As String = "SELECT COUNT(*) FROM tblrequest WHERE Status = 'Completed' AND RequestDate >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)"
                Using cmd As New MySqlCommand(queryCompleted, conn)
                    lblCompletedThisWeek.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' 5. Total Number of Students (Pulls from tblstudents)
                Dim queryStudents As String = "SELECT COUNT(*) FROM tblstudents"
                Using cmd As New MySqlCommand(queryStudents, conn)
                    lblTotalStudents.Text = cmd.ExecuteScalar().ToString()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading metrics: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Public Sub loadRecentRequests()
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT RequestNo AS 'Request No.', " &
                                 "StudentID AS 'Student ID', " &
                                 "document_type AS 'Document Name', " &
                                 "Reason AS 'Reason', " &
                                 "Status AS 'Status', " &
                                 "DATE_FORMAT(RequestDate, '%Y-%m-%d') AS 'Requested Date' " &
                                 "FROM tblrequest " &
                                 "ORDER BY RequestDate DESC LIMIT 100"

                Using adapter As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvRecentRequests.DataSource = dt
                End Using

                FormatGrid()

            Catch ex As Exception
                MessageBox.Show("Error loading recent requests: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub FormatGrid()
        With dgvRecentRequests
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
        End With
    End Sub

    Private Sub btnDocumentRequests_Click(sender As Object, e As EventArgs) Handles btnDocumentRequests.Click
        Dim reqForm As New frmRequest()
        reqForm.ShowDialog()
        LoadDashboardMetrics()
        loadrecentrequests()
    End Sub

    Private Sub btnStudentManagement_Click(sender As Object, e As EventArgs) Handles btnStudentManagement.Click
        Dim studentForm As New frmStudents()
        studentForm.ShowDialog()
        LoadDashboardMetrics()
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
        LoadDashboardMetrics()
        loadrecentrequests()
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