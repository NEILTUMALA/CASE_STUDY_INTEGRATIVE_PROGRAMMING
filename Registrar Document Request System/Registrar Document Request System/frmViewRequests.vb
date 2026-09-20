Imports MySql.Data.MySqlClient

Public Class frmViewRequests

    Private Sub frmViewRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllRequests()
    End Sub

    Public Sub LoadAllRequests()
        Try
            connection()

            sql = "SELECT r.RequestID, r.RequestNo, r.StudentID, CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, " &
                  "r.RequestDate, r.TotalAmount, r.PaymentStatus, r.Status " &
                  "FROM tblrequest r " &
                  "INNER JOIN tblstudents s ON r.StudentID = s.StudentID " &
                  "ORDER BY r.RequestID DESC"

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dgvRequests.DataSource = dt

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading requests: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            MsgBox("Please enter a Request No or Student ID to search.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            connection()

            sql = "SELECT r.RequestID, r.RequestNo, r.StudentID, CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, " &
                  "r.RequestDate, r.TotalAmount, r.PaymentStatus, r.Status " &
                  "FROM tblrequest r " &
                  "INNER JOIN tblstudents s ON r.StudentID = s.StudentID " &
                  "WHERE r.RequestNo LIKE '%" & txtSearch.Text & "%' OR r.StudentID LIKE '%" & txtSearch.Text & "%' " &
                  "ORDER BY r.RequestID DESC"

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dgvRequests.DataSource = dt

            dr.Close()
        Catch ex As Exception
            MsgBox("Error searching requests: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
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
        If txtSelectedReqNo.Text = "" Then
            MsgBox("Please select a request from the list first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            connection()

            sql = "UPDATE tblrequest SET PaymentStatus = '" & cboUpdatePayment.Text & "', " &
                  "Status = '" & cboUpdateStatus.Text & "' " &
                  "WHERE RequestNo = '" & txtSelectedReqNo.Text & "'"

            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            MsgBox("Request status updated successfully!", MsgBoxStyle.Information)

            LoadAllRequests()
            txtSelectedReqNo.Text = ""
            cboUpdatePayment.SelectedIndex = -1
            cboUpdateStatus.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Error updating status: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

End Class