Imports MySql.Data.MySqlClient

Public Class frmLogin

    ' Shared variables to pass user details to frmMainMenu
    Public Shared LoggedInUserID As Integer
    Public Shared LoggedInFullName As String
    Public Shared LoggedInUsername As String
    Public Shared LoggedInRole As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter both Username and Password.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Try
            connection()

            ' Fetch Username, FullName, and Role to pass to Main Menu
            sql = "SELECT UserID, FullName, Username, Role FROM tblusers WHERE Username = '" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "' AND Status = 'Active'"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                ' Store user details in shared variables
                LoggedInUserID = dr("UserID")
                LoggedInFullName = dr("FullName").ToString()
                LoggedInUsername = dr("Username").ToString()
                LoggedInRole = dr("Role").ToString()

                MsgBox("Login Successful! Welcome, " & LoggedInFullName & ".", MsgBoxStyle.Information, "Access Granted")

                dr.Close()
                cn.Close()

                ' Open Dashboard / Main Menu
                Dim mainForm As New frmMainMenu()
                mainForm.Show()
                Me.Hide()
            Else
                MsgBox("Invalid Username or Password.", MsgBoxStyle.Critical, "Access Denied")
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

End Class