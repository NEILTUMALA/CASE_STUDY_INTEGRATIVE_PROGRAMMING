Imports MySql.Data.MySqlClient

Public Class frmViewRequests

    Private Sub frmViewRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboUpdatePayment.Items.Clear()
        cboUpdatePayment.Items.AddRange(New String() {"Unpaid", "Paid"})

        cboUpdateStatus.Items.Clear()
        cboUpdateStatus.Items.AddRange(New String() {"Pending", "Processing", "Ready for Pickup", "Completed"})

        LoadAllRequests()
    End Sub

    Public Sub LoadAllRequests()
        Try
            connection()

            ' Match exact column names: Firstname and Lastname (no camelCase N)
            sql = "SELECT r.RequestID, r.RequestNo, r.StudentID AS StudentNo, " &
              "CONCAT(IFNULL(s.Firstname, ''), ' ', IFNULL(s.Lastname, '')) AS StudentName, " &
              "r.RequestDate, r.TotalAmount, r.PaymentStatus, r.Status " &
              "FROM tblrequest r " &
              "LEFT JOIN tblstudents s ON TRIM(r.StudentID) = TRIM(s.StudentNo) " &
              "ORDER BY r.RequestID DESC"

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dgvRequests.DataSource = dt

            dr.Close()

            If dgvRequests.Columns.Count > 0 Then
                If dgvRequests.Columns.Contains("RequestID") Then dgvRequests.Columns("RequestID").Visible = False
                If dgvRequests.Columns.Contains("RequestNo") Then dgvRequests.Columns("RequestNo").HeaderText = "Request No"
                If dgvRequests.Columns.Contains("StudentNo") Then dgvRequests.Columns("StudentNo").HeaderText = "Student No"
                If dgvRequests.Columns.Contains("StudentName") Then dgvRequests.Columns("StudentName").HeaderText = "Student Name"
                If dgvRequests.Columns.Contains("RequestDate") Then dgvRequests.Columns("RequestDate").HeaderText = "Date"
                If dgvRequests.Columns.Contains("TotalAmount") Then dgvRequests.Columns("TotalAmount").HeaderText = "Total (P)"
                If dgvRequests.Columns.Contains("PaymentStatus") Then dgvRequests.Columns("PaymentStatus").HeaderText = "Payment Status"
                If dgvRequests.Columns.Contains("Status") Then dgvRequests.Columns("Status").HeaderText = "Request Status"
            End If

        Catch ex As Exception
            MsgBox("Error loading requests: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            MsgBox("Please enter a Request No or Student No to search.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            connection()

            ' Updated search query to check s.StudentNo
            sql = "SELECT r.RequestID, r.RequestNo, s.StudentNo, CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, " &
                  "r.RequestDate, r.TotalAmount, r.PaymentStatus, r.Status " &
                  "FROM tblrequest r " &
                  "INNER JOIN tblstudents s ON r.StudentID = s.StudentID " &
                  "WHERE r.RequestNo LIKE @Search OR s.StudentNo LIKE @Search " &
                  "ORDER BY r.RequestID DESC"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim() & "%")

            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dgvRequests.DataSource = dt

            dr.Close()

        Catch ex As Exception
            MsgBox("Error searching requests: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        LoadAllRequests()
    End Sub

    Private Sub dgvRequests_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequests.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRequests.Rows(e.RowIndex)
            txtSelectedReqNo.Text = row.Cells("RequestNo").Value.ToString()
            cboUpdatePayment.Text = row.Cells("PaymentStatus").Value.ToString()
            cboUpdateStatus.Text = row.Cells("Status").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtSelectedReqNo.Text) Then
            MsgBox("Please select a request from the list first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            connection()

            sql = "UPDATE tblrequest SET PaymentStatus = @PaymentStatus, Status = @Status WHERE RequestNo = @RequestNo"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@PaymentStatus", cboUpdatePayment.Text)
            cmd.Parameters.AddWithValue("@Status", cboUpdateStatus.Text)
            cmd.Parameters.AddWithValue("@RequestNo", txtSelectedReqNo.Text.Trim())

            cmd.ExecuteNonQuery()

            MsgBox("Request status updated successfully!", MsgBoxStyle.Information)

            LoadAllRequests()
            txtSelectedReqNo.Text = ""
            cboUpdatePayment.SelectedIndex = -1
            cboUpdateStatus.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Error updating status: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class