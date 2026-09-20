Imports MySql.Data.MySqlClient

Public Class frmRequest

    Dim SelectedDocID As Integer = 0
    Dim SelectedDocFee As Decimal = 0.00

    Private Sub frmRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateRequestNo()
        LoadDocuments()

        cboPaymentStatus.Text = "Unpaid"
        cboRequestStatus.Text = "Pending"
        txtProcessed.Text = frmLogin.LoggedInFullName
    End Sub

    Private Sub GenerateRequestNo()
        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblrequest"
            cmd = New MySqlCommand(sql, cn)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar()) + 1
            txtRequestNo.Text = "REQ-" & DateTime.Now.Year.ToString() & "-" & count.ToString("D5")
        Catch ex As Exception
            MsgBox("Error generating Request No: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub LoadDocuments()
        Try
            connection()
            sql = "SELECT DocumentName FROM tbldocuments WHERE Status = 'Active'"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            cmbDocument.Items.Clear()
            While dr.Read()
                cmbDocument.Items.Add(dr("DocumentName").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading documents: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtStudentID.Text = "" Then
            MsgBox("Please enter a Student ID.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            connection()
            sql = "SELECT FirstName, LastName, Course, YearLevel FROM tblstudents WHERE StudentID = '" & txtStudentID.Text & "'"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtStudentName.Text = dr("FirstName").ToString() & " " & dr("LastName").ToString()
                txtCourse.Text = dr("Course").ToString()
                txtYearLevel.Text = dr("YearLevel").ToString()
            Else
                MsgBox("Student ID not found.", MsgBoxStyle.Exclamation)
                txtStudentName.Text = ""
                txtCourse.Text = ""
                txtYearLevel.Text = ""
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error searching student: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub cmbDocument_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDocument.SelectedIndexChanged
        Try
            connection()
            sql = "SELECT DocumentID, Fee FROM tbldocuments WHERE DocumentName = '" & cmbDocument.Text & "'"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                SelectedDocID = dr("DocumentID")
                SelectedDocFee = dr("Fee")
                txtAmount.Text = SelectedDocFee.ToString("0.00")
                CalculateTotal()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error getting fee: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub numQuantity_ValueChanged(sender As Object, e As EventArgs) Handles numQuantity.ValueChanged
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        Dim total As Decimal = SelectedDocFee * numQuantity.Value
        txtTotalAmount.Text = total.ToString("0.00")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtStudentName.Text = "" Or cmbDocument.Text = "" Then
            MsgBox("Please complete student search and document selection first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            connection()

            sql = "INSERT INTO tblrequest (RequestNo, StudentID, RequestDate, TotalAmount, PaymentStatus, Status, CreatedBy) " &
                  "VALUES ('" & txtRequestNo.Text & "', '" & txtStudentID.Text & "', '" & dtpRequestDate.Value.ToString("yyyy-MM-dd HH:mm:ss") & "', " &
                  "'" & txtTotalAmount.Text & "', '" & cboPaymentStatus.Text & "', '" & cboRequestStatus.Text & "', '" & frmLogin.LoggedInUserID & "')"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            Dim newRequestID As Integer = cmd.LastInsertedId

            sql = "INSERT INTO tblrequestdetails (RequestID, DocumentID, Quantity, Amount, SubTotal) " &
                  "VALUES ('" & newRequestID & "', '" & SelectedDocID & "', '" & numQuantity.Value & "', '" & SelectedDocFee & "', '" & txtTotalAmount.Text & "')"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            MsgBox("Request saved successfully!", MsgBoxStyle.Information)

            ' Reset Form Controls
            GenerateRequestNo()
            txtStudentID.Text = ""
            txtStudentName.Text = ""
            txtCourse.Text = ""
            txtYearLevel.Text = ""
            cmbDocument.SelectedIndex = -1
            txtAmount.Text = ""
            txtTotalAmount.Text = ""
            numQuantity.Value = 1

        Catch ex As Exception
            MsgBox("Error saving request: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim viewForm As New frmViewRequests()
        viewForm.Show()
    End Sub
End Class