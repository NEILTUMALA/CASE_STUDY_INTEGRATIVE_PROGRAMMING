Imports MySql.Data.MySqlClient

Public Class frmUsers

    Dim SelectedUserID As Integer = 0

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Role ComboBox
        cboRole.Items.Clear()
        cboRole.Items.AddRange(New String() {"Admin", "Staff"})
        cboRole.SelectedIndex = 0

        ' Setup Status ComboBox
        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(New String() {"Active", "Inactive"})
        cboStatus.SelectedIndex = 0

        LoadUsers()
    End Sub

    Public Sub LoadUsers(Optional searchQuery As String = "")
        Try
            connection()

            ' Included Status column in SQL query
            sql = "SELECT UserID, Username, Password, FullName, Role, Status FROM tblusers "
            If Not String.IsNullOrWhiteSpace(searchQuery) Then
                sql &= "WHERE Username LIKE @Search OR FullName LIKE @Search "
            End If
            sql &= "ORDER BY UserID DESC"

            cmd = New MySqlCommand(sql, cn)
            If Not String.IsNullOrWhiteSpace(searchQuery) Then
                cmd.Parameters.AddWithValue("@Search", "%" & searchQuery & "%")
            End If

            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dgvUsers.DataSource = dt

            dr.Close()

            ' Column Headers Setup
            If dgvUsers.Columns.Count > 0 Then
                If dgvUsers.Columns.Contains("UserID") Then dgvUsers.Columns("UserID").Visible = False
                If dgvUsers.Columns.Contains("Username") Then dgvUsers.Columns("Username").HeaderText = "Username"
                If dgvUsers.Columns.Contains("Password") Then dgvUsers.Columns("Password").HeaderText = "Password"
                If dgvUsers.Columns.Contains("FullName") Then dgvUsers.Columns("FullName").HeaderText = "Full Name"
                If dgvUsers.Columns.Contains("Role") Then dgvUsers.Columns("Role").HeaderText = "Role"
                If dgvUsers.Columns.Contains("Status") Then dgvUsers.Columns("Status").HeaderText = "Status"
            End If

            ' Grid Formatting
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvUsers.RowHeadersVisible = False

        Catch ex As Exception
            MsgBox("Error loading users: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' 1. Check for empty required fields including Status
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtFullname.Text) OrElse
           String.IsNullOrWhiteSpace(cboRole.Text) OrElse
           String.IsNullOrWhiteSpace(cboStatus.Text) Then

            MsgBox("Please fill in all user details.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        ' 2. Enforce minimum password length of 5 characters
        If txtPassword.Text.Trim().Length < 5 Then
            MsgBox("Password must be at least 5 characters long.", MsgBoxStyle.Exclamation, "Validation Error")
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            connection()

            ' Parameterized Insert Query with Status
            sql = "INSERT INTO tblusers (Username, Password, FullName, Role, Status) " &
                  "VALUES (@Username, @Password, @FullName, @Role, @Status)"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
            cmd.Parameters.AddWithValue("@FullName", txtFullname.Text.Trim())
            cmd.Parameters.AddWithValue("@Role", cboRole.Text)
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text)

            cmd.ExecuteNonQuery()

            MsgBox("User account created successfully!", MsgBoxStyle.Information, "Success")

            ClearFields()
            LoadUsers()

        Catch ex As Exception
            MsgBox("Error saving user: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            SelectedUserID = Convert.ToInt32(row.Cells("UserID").Value)
            txtUsername.Text = row.Cells("Username").Value.ToString()
            txtPassword.Text = row.Cells("Password").Value.ToString()
            txtFullname.Text = row.Cells("FullName").Value.ToString()
            cboRole.Text = row.Cells("Role").Value.ToString()

            ' Populate Status ComboBox when clicking a row
            If dgvUsers.Columns.Contains("Status") AndAlso row.Cells("Status").Value IsNot DBNull.Value Then
                cboStatus.Text = row.Cells("Status").Value.ToString()
            Else
                cboStatus.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If SelectedUserID = 0 Then
            MsgBox("Please select a user account from the list to update.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        ' Enforce minimum password length on Update
        If txtPassword.Text.Trim().Length < 5 Then
            MsgBox("Password must be at least 5 characters long.", MsgBoxStyle.Exclamation, "Validation Error")
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            connection()

            ' Parameterized Update Query with Status
            sql = "UPDATE tblusers SET Username = @Username, Password = @Password, " &
                  "FullName = @FullName, Role = @Role, Status = @Status WHERE UserID = @UserID"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
            cmd.Parameters.AddWithValue("@FullName", txtFullname.Text.Trim())
            cmd.Parameters.AddWithValue("@Role", cboRole.Text)
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text)
            cmd.Parameters.AddWithValue("@UserID", SelectedUserID)

            cmd.ExecuteNonQuery()

            MsgBox("User details updated successfully!", MsgBoxStyle.Information, "Success")

            ClearFields()
            LoadUsers()

        Catch ex As Exception
            MsgBox("Error updating user: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If SelectedUserID = 0 Then
            MsgBox("Please select a user account from the list to delete.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to delete user '" & txtUsername.Text & "'?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")

        If confirm = MsgBoxResult.Yes Then
            Try
                connection()

                sql = "DELETE FROM tblusers WHERE UserID = @UserID"

                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@UserID", SelectedUserID)
                cmd.ExecuteNonQuery()

                MsgBox("User account deleted successfully!", MsgBoxStyle.Information, "Success")

                ClearFields()
                LoadUsers()

            Catch ex As Exception
                MsgBox("Error deleting user: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                If cn.State = ConnectionState.Open Then cn.Close()
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadUsers(txtSearch.Text.Trim())
    End Sub

    Private Sub ClearFields()
        SelectedUserID = 0
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtFullname.Text = ""
        cboRole.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        txtSearch.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class