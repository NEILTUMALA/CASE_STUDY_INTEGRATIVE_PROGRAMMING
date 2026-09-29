Imports MySql.Data.MySqlClient

Public Class frmLogin

    Public Shared LoggedInUserID As Integer = 0
    Public Shared LoggedInFullName As String = ""
    Public Shared LoggedInUsername As String = ""
    Public Shared LoggedInRole As String = ""

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter both Username and Password.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Try
            connection()

            ' Parameterized query with exact column name Fullname
            sql = "SELECT UserID, Fullname, Username, Role, Status FROM tblusers " &
                  "WHERE Username = @Username AND Password = @Password"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                ' Check status before granting access
                Dim status As String = dr("Status").ToString()
                If status.Equals("Inactive", StringComparison.OrdinalIgnoreCase) Then
                    dr.Close()
                    MsgBox("Your account is INACTIVE. Please contact the Administrator.", MsgBoxStyle.Critical, "Access Denied")
                    Exit Sub
                End If

                ' Store global user details
                LoggedInUserID = Convert.ToInt32(dr("UserID"))
                LoggedInFullName = dr("Fullname").ToString()
                LoggedInUsername = dr("Username").ToString()
                LoggedInRole = dr("Role").ToString()

                dr.Close()

                MsgBox("Login Successful! Welcome, " & LoggedInFullName & " (" & LoggedInRole & ").", MsgBoxStyle.Information, "Access Granted")

                ' Open Dashboard
                Dim mainForm As New frmMainMenu()
                mainForm.Show()
                Me.Hide()
            Else
                dr.Close()
                MsgBox("Invalid Username or Password.", MsgBoxStyle.Critical, "Access Denied")
            End If

        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

End Class