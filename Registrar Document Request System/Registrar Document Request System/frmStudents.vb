Imports MySql.Data.MySqlClient

Public Class frmStudents

    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    Public Sub LoadStudents(Optional searchQuery As String = "")
        Try
            connection()

            sql = "SELECT StudentID, FirstName, LastName, Course, YearLevel FROM tblstudents "
            If searchQuery <> "" Then
                sql &= "WHERE StudentID LIKE '%" & searchQuery & "%' OR LastName LIKE '%" & searchQuery & "%' "
            End If
            sql &= "ORDER BY StudentID DESC"

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dgvStudents.DataSource = dt

            dr.Close()

            If dgvStudents.Columns.Count > 0 Then
                dgvStudents.Columns("StudentID").HeaderText = "Student ID"
                dgvStudents.Columns("FirstName").HeaderText = "First Name"
                dgvStudents.Columns("LastName").HeaderText = "Last Name"
                dgvStudents.Columns("Course").HeaderText = "Course"
                dgvStudents.Columns("YearLevel").HeaderText = "Year Level"
            End If

        Catch ex As Exception
            MsgBox("Error loading students: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtStudentID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or cboCourse.Text = "" Or cboYearLevel.Text = "" Then
            MsgBox("Please fill in all required student details.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            connection()

            sql = "INSERT INTO tblstudents (StudentID, FirstName, LastName, Course, YearLevel) " &
                  "VALUES ('" & txtStudentID.Text & "', '" & txtFirstName.Text & "', '" & txtLastName.Text & "', '" & cboCourse.Text & "', '" & cboYearLevel.Text & "')"

            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            MsgBox("Student registered successfully!", MsgBoxStyle.Information)

            ClearFields()
            LoadStudents()

        Catch ex As Exception
            MsgBox("Error saving student: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)
            txtStudentID.Text = row.Cells("StudentID").Value.ToString()
            txtFirstName.Text = row.Cells("FirstName").Value.ToString()
            txtLastName.Text = row.Cells("LastName").Value.ToString()
            cboCourse.Text = row.Cells("Course").Value.ToString()
            cboYearLevel.Text = row.Cells("YearLevel").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtStudentID.Text = "" Then
            MsgBox("Please select a student from the list to update.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            connection()

            sql = "UPDATE tblstudents SET FirstName = '" & txtFirstName.Text & "', LastName = '" & txtLastName.Text & "', " &
                  "Course = '" & cboCourse.Text & "', YearLevel = '" & cboYearLevel.Text & "' " &
                  "WHERE StudentID = '" & txtStudentID.Text & "'"

            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            MsgBox("Student details updated successfully!", MsgBoxStyle.Information)

            ClearFields()
            LoadStudents()

        Catch ex As Exception
            MsgBox("Error updating student: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadStudents(txtSearch.Text.Trim())
    End Sub

    Private Sub ClearFields()
        txtStudentID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        cboCourse.SelectedIndex = -1
        cboYearLevel.SelectedIndex = -1
        txtSearch.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtStudentID.Text = "" Then
            MsgBox("Please select a student from the list to delete.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim dialogResult As MsgBoxResult = MsgBox("Are you sure you want to delete student " & txtStudentID.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")

        If dialogResult = MsgBoxResult.Yes Then
            Try
                connection()

                sql = "DELETE FROM tblstudents WHERE StudentID = '" & txtStudentID.Text & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                MsgBox("Student record deleted successfully!", MsgBoxStyle.Information, "Success")

                ClearFields()
                LoadStudents()

            Catch ex As Exception
                MsgBox("Error deleting student: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class