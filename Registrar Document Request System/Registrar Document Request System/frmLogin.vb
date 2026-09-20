Imports MySql.Data.MySqlClient

Public Class frmLogin

    Public Shared LoggedInUserID As Integer
    Public Shared LoggedInFullName As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter both Username and Password.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Try
            connection()

            sql = "SELECT UserID, FullName FROM tblusers WHERE Username = '" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "' AND Status = 'Active'"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                LoggedInUserID = dr("UserID")
                LoggedInFullName = dr("FullName").ToString()

                MsgBox("Login Successful! Welcome, " & LoggedInFullName & ".", MsgBoxStyle.Information, "Access Granted")

                dr.Close()
                cn.Close()

                Dim reqForm As New frmRequest()
                reqForm.Show()
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