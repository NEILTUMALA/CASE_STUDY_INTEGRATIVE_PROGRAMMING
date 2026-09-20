Imports MySql.Data.MySqlClient

Public Class frmDocuments

    Dim SelectedDocID As Integer = 0

    Private Sub frmDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.Items.Clear()
        cboStatus.Items.AddRange(New String() {"Active", "Inactive"})
        cboStatus.SelectedIndex = 0

        LoadDocuments()
    End Sub

    Public Sub LoadDocuments(Optional searchQuery As String = "")
        Try
            connection()

            sql = "SELECT DocumentID, DocumentName, Fee, Status FROM tbldocuments "
            If searchQuery <> "" Then
                sql &= "WHERE DocumentName LIKE '%" & searchQuery & "%' "
            End If
            sql &= "ORDER BY DocumentID DESC"

            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(dr)
            dgvDocuments.DataSource = dt

            dr.Close()

            If dgvDocuments.Columns.Count > 0 Then
                dgvDocuments.Columns("DocumentID").Visible = False
                dgvDocuments.Columns("DocumentName").HeaderText = "Document Name"
                dgvDocuments.Columns("Fee").HeaderText = "Fee (P)"
                dgvDocuments.Columns("Status").HeaderText = "Status"
            End If

        Catch ex As Exception
            MsgBox("Error loading documents: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDocumentName.Text = "" Or txtFee.Text = "" Or cboStatus.Text = "" Then
            MsgBox("Please fill in all document details.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim feeValue As Decimal
        If Not Decimal.TryParse(txtFee.Text, feeValue) Then
            MsgBox("Please enter a valid numeric fee.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Try
            connection()

            sql = "INSERT INTO tbldocuments (DocumentName, Fee, Status) " &
                  "VALUES ('" & txtDocumentName.Text & "', '" & feeValue & "', '" & cboStatus.Text & "')"

            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            MsgBox("Document saved successfully!", MsgBoxStyle.Information, "Success")

            ClearFields()
            LoadDocuments()

        Catch ex As Exception
            MsgBox("Error saving document: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub dgvDocuments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocuments.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDocuments.Rows(e.RowIndex)
            SelectedDocID = Convert.ToInt32(row.Cells("DocumentID").Value)
            txtDocumentName.Text = row.Cells("DocumentName").Value.ToString()
            txtFee.Text = Convert.ToDecimal(row.Cells("Fee").Value).ToString("0.00")
            cboStatus.Text = row.Cells("Status").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If SelectedDocID = 0 Then
            MsgBox("Please select a document from the list to update.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim feeValue As Decimal
        If Not Decimal.TryParse(txtFee.Text, feeValue) Then
            MsgBox("Please enter a valid numeric fee.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Try
            connection()

            sql = "UPDATE tbldocuments SET DocumentName = '" & txtDocumentName.Text & "', " &
                  "Fee = '" & feeValue & "', Status = '" & cboStatus.Text & "' " &
                  "WHERE DocumentID = '" & SelectedDocID & "'"

            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            MsgBox("Document updated successfully!", MsgBoxStyle.Information, "Success")

            ClearFields()
            LoadDocuments()

        Catch ex As Exception
            MsgBox("Error updating document: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadDocuments(txtSearch.Text.Trim())
    End Sub

    Private Sub ClearFields()
        SelectedDocID = 0
        txtDocumentName.Text = ""
        txtFee.Text = ""
        cboStatus.SelectedIndex = 0
        txtSearch.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If SelectedDocID = 0 Then
            MsgBox("Please select a document from the list to delete.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to delete '" & txtDocumentName.Text & "'?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")

        If confirm = MsgBoxResult.Yes Then
            Try
                connection()

                sql = "DELETE FROM tbldocuments WHERE DocumentID ss= '" & SelectedDocID & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                MsgBox("Document deleted successfully!", MsgBoxStyle.Information, "Success")

                ClearFields()
                LoadDocuments()

            Catch ex As Exception
                MsgBox("Error deleting document: " & ex.Message, MsgBoxStyle.Critical, "Error")
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