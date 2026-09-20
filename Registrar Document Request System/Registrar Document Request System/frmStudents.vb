Imports MySql.Data.MySqlClient

Public Class frmStudents

    Dim SelectedStudentID As Integer = 0

    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(New String() {"Enrolled", "Graduated", "Inactive"})
        cboStatus.SelectedIndex = 0

        LoadStudents()
    End Sub

    Public Sub LoadStudents(Optional searchQuery As String = "")
        Try
            connection()

            sql = "SELECT StudentID, StudentNo, Firstname, Middlename, Lastname, Course, YearLevel, Section, Contactnumber, Status FROM tblstudents "
            If searchQuery <> "" Then
                sql &= "WHERE StudentNo LIKE '%" & searchQuery & "%' " &
                       "OR Firstname LIKE '%" & searchQuery & "%' " &
                       "OR Lastname LIKE '%" & searchQuery & "%' "
            End If
            sql &= "ORDER BY StudentID DESC"

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dgvStudents.DataSource = dt

            dr.Close()

            If dgvStudents.Columns.Count > 0 Then
                dgvStudents.Columns("StudentID").Visible = False
                dgvStudents.Columns("StudentNo").HeaderText = "Student No"
                dgvStudents.Columns("Firstname").HeaderText = "First Name"
                dgvStudents.Columns("Middlename").HeaderText = "Middle Name"
                dgvStudents.Columns("Lastname").HeaderText = "Last Name"
                dgvStudents.Columns("Course").HeaderText = "Course"
                dgvStudents.Columns("YearLevel").HeaderText = "Year Level"
                dgvStudents.Columns("Section").HeaderText = "Section"
                dgvStudents.Columns("Contactnumber").HeaderText = "Contact Number"
                dgvStudents.Columns("Status").HeaderText = "Status"
            End If

        Catch ex As Exception
            MsgBox("Error loading student records: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtStudentNo.Text) OrElse
           String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           cboCourse.Text = "" OrElse cboYearLevel.Text = "" Then
            MsgBox("Please fill in all required student details.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Try
            connection()

            sql = "INSERT INTO tblstudents (StudentNo, Firstname, Middlename, Lastname, Course, YearLevel, Section, Contactnumber, Status) " &
                  "VALUES (@StudentNo, @FirstName, @MiddleName, @LastName, @Course, @YearLevel, @Section, @Contactnumber, @Status)"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text.Trim())
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
            cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim())
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
            cmd.Parameters.AddWithValue("@Course", cboCourse.Text)
            cmd.Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
            cmd.Parameters.AddWithValue("@Section", txtSection.Text.Trim())
            cmd.Parameters.AddWithValue("@Contactnumber", txtContactNumber.Text.Trim())
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text)

            cmd.ExecuteNonQuery()

            MsgBox("Student record saved successfully!", MsgBoxStyle.Information, "Success")

            ClearFields()
            LoadStudents()

        Catch ex As Exception
            MsgBox("Error saving student record: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)
            SelectedStudentID = Convert.ToInt32(row.Cells("StudentID").Value)
            txtStudentNo.Text = row.Cells("StudentNo").Value.ToString()
            txtFirstName.Text = row.Cells("Firstname").Value.ToString()
            txtMiddleName.Text = row.Cells("Middlename").Value.ToString()
            txtLastName.Text = row.Cells("Lastname").Value.ToString()
            cboCourse.Text = row.Cells("Course").Value.ToString()
            cboYearLevel.Text = row.Cells("YearLevel").Value.ToString()
            txtSection.Text = row.Cells("Section").Value.ToString()
            txtContactNumber.Text = row.Cells("Contactnumber").Value.ToString()
            cboStatus.Text = row.Cells("Status").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If SelectedStudentID = 0 Then
            MsgBox("Please select a student from the table list to update.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Try
            connection()

            sql = "UPDATE tblstudents SET StudentNo = @StudentNo, Firstname = @FirstName, " &
                  "Middlename = @MiddleName, Lastname = @LastName, " &
                  "Course = @Course, YearLevel = @YearLevel, Section = @Section, " &
                  "Contactnumber = @Contactnumber, Status = @Status WHERE StudentID = @StudentID"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text.Trim())
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
            cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim())
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
            cmd.Parameters.AddWithValue("@Course", cboCourse.Text)
            cmd.Parameters.AddWithValue("@YearLevel", cboYearLevel.Text)
            cmd.Parameters.AddWithValue("@Section", txtSection.Text.Trim())
            cmd.Parameters.AddWithValue("@Contactnumber", txtContactNumber.Text.Trim())
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text)
            cmd.Parameters.AddWithValue("@StudentID", SelectedStudentID)

            cmd.ExecuteNonQuery()

            MsgBox("Student record updated successfully!", MsgBoxStyle.Information, "Success")

            ClearFields()
            LoadStudents()

        Catch ex As Exception
            MsgBox("Error updating student record: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If SelectedStudentID = 0 Then
            MsgBox("Please select a student from the table list to delete.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to delete Student No: " & txtStudentNo.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")

        If confirm = MsgBoxResult.Yes Then
            Try
                connection()

                sql = "DELETE FROM tblstudents WHERE StudentID = @StudentID"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@StudentID", SelectedStudentID)
                cmd.ExecuteNonQuery()

                MsgBox("Student deleted successfully!", MsgBoxStyle.Information, "Success")

                ClearFields()
                LoadStudents()

            Catch ex As Exception
                MsgBox("Error deleting student record: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
            Finally
                If cn.State = ConnectionState.Open Then cn.Close()
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadStudents(txtSearch.Text.Trim())
    End Sub

    Private Sub ClearFields()
        SelectedStudentID = 0
        txtStudentNo.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        cboCourse.SelectedIndex = -1
        cboYearLevel.SelectedIndex = -1
        txtSection.Text = ""
        txtContactNumber.Text = ""
        cboStatus.SelectedIndex = -1
        txtSearch.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class