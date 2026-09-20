Imports MySql.Data.MySqlClient

Public Class frmRequest

    Dim SelectedDocID As Integer = 0
    Dim SelectedDocFee As Decimal = 0.00

    Private Sub frmRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateRequestNo()
        LoadDocuments()

        cboPaymentStatus.Text = "Unpaid"
        cboRequestStatus.Text = "Pending"

        ' Set processed user name safely
        If Not String.IsNullOrEmpty(frmLogin.LoggedInFullName) Then
            txtProcessed.Text = frmLogin.LoggedInFullName
        Else
            txtProcessed.Text = "System Administrator"
        End If
    End Sub

    Private Sub GenerateRequestNo()
        Try
            connection()
            sql = "SELECT COUNT(*) FROM tblrequest"
            cmd = New MySqlCommand(sql, cn)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar()) + 1
            txtRequestNo.Text = "REQ-" & DateTime.Now.Year.ToString() & "-" & count.ToString("D5")
        Catch ex As Exception
            MsgBox("Error generating Request No: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Public Sub LoadDocuments()
        Try
            connection()
            sql = "SELECT DocumentName FROM tbldocuments WHERE Status = 'Active' ORDER BY DocumentName ASC"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            cmbDocument.Items.Clear()
            While dr.Read()
                cmbDocument.Items.Add(dr("DocumentName").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading documents: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            MsgBox("Please enter a Student ID.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Try
            connection()
            sql = "SELECT FirstName, LastName, Course, YearLevel FROM tblstudents WHERE StudentID = @StudentID"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text.Trim())

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtStudentName.Text = dr("FirstName").ToString() & " " & dr("LastName").ToString()
                txtCourse.Text = dr("Course").ToString()
                txtYearLevel.Text = dr("YearLevel").ToString()
            Else
                MsgBox("Student ID not found.", MsgBoxStyle.Exclamation, "Search Result")
                txtStudentName.Text = ""
                txtCourse.Text = ""
                txtYearLevel.Text = ""
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error searching student: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub cmbDocument_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDocument.SelectedIndexChanged
        If String.IsNullOrEmpty(cmbDocument.Text) Then Exit Sub

        Try
            connection()
            sql = "SELECT DocumentID, Fee FROM tbldocuments WHERE DocumentName = @DocName AND Status = 'Active'"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@DocName", cmbDocument.Text)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                SelectedDocID = Convert.ToInt32(dr("DocumentID"))
                SelectedDocFee = Convert.ToDecimal(dr("Fee"))
                txtAmount.Text = SelectedDocFee.ToString("0.00")
                CalculateTotal()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error fetching document fee: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub numQuantity_ValueChanged(sender As Object, e As EventArgs) Handles numQuantity.ValueChanged
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        Dim qty As Decimal = numQuantity.Value
        Dim total As Decimal = SelectedDocFee * qty
        txtTotalAmount.Text = total.ToString("0.00")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtStudentName.Text) Or String.IsNullOrEmpty(cmbDocument.Text) Then
            MsgBox("Please complete student search and document selection first.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Try
            connection()

            sql = "INSERT INTO tblrequest (RequestNo, StudentID, RequestDate, TotalAmount, PaymentStatus, Status, CreatedBy) " &
                  "VALUES (@RequestNo, @StudentID, @RequestDate, @TotalAmount, @PaymentStatus, @Status, @CreatedBy)"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@RequestNo", txtRequestNo.Text)
            cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text.Trim())
            cmd.Parameters.AddWithValue("@RequestDate", dtpRequestDate.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@TotalAmount", txtTotalAmount.Text)
            cmd.Parameters.AddWithValue("@PaymentStatus", cboPaymentStatus.Text)
            cmd.Parameters.AddWithValue("@Status", cboRequestStatus.Text)
            cmd.Parameters.AddWithValue("@CreatedBy", If(frmLogin.LoggedInUserID > 0, frmLogin.LoggedInUserID, 1))

            cmd.ExecuteNonQuery()

            Dim newRequestID As Long = cmd.LastInsertedId

            sql = "INSERT INTO tblrequestdetails (RequestID, DocumentID, Quantity, Amount, SubTotal) " &
                  "VALUES (@RequestID, @DocumentID, @Quantity, @Amount, @SubTotal)"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@RequestID", newRequestID)
            cmd.Parameters.AddWithValue("@DocumentID", SelectedDocID)
            cmd.Parameters.AddWithValue("@Quantity", numQuantity.Value)
            cmd.Parameters.AddWithValue("@Amount", SelectedDocFee)
            cmd.Parameters.AddWithValue("@SubTotal", txtTotalAmount.Text)

            cmd.ExecuteNonQuery()

            MsgBox("Request saved successfully!", MsgBoxStyle.Information, "Success")

            ' Reset Form Inputs
            GenerateRequestNo()
            txtStudentID.Text = ""
            txtStudentName.Text = ""
            txtCourse.Text = ""
            txtYearLevel.Text = ""
            cmbDocument.SelectedIndex = -1
            txtAmount.Text = ""
            txtTotalAmount.Text = ""
            numQuantity.Value = 1
            SelectedDocID = 0
            SelectedDocFee = 0.00

        Catch ex As Exception
            MsgBox("Error saving request: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If String.IsNullOrWhiteSpace(txtStudentName.Text) Or String.IsNullOrEmpty(cmbDocument.Text) Then
            MsgBox("Please select a student and document first before printing.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Using dlg As New PrintPreviewDialog()
            dlg.Document = PrintDocument1
            dlg.ShowDialog()
        End Using
    End Sub

    ' Receipt Layout & Graphics Design
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 12, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 10, FontStyle.Regular)

        Dim startX As Integer = 50
        Dim startY As Integer = 50

        ' Header
        e.Graphics.DrawString("LYCEUM OF ALABANG", fontTitle, Brushes.Black, startX, startY)
        e.Graphics.DrawString("Registrar Document Request Receipt", fontHeader, Brushes.Black, startX, startY + 30)
        e.Graphics.DrawString("------------------------------------------------------------------", fontBody, Brushes.Black, startX, startY + 50)

        ' Details
        e.Graphics.DrawString("Request No: " & txtRequestNo.Text, fontBody, Brushes.Black, startX, startY + 70)
        e.Graphics.DrawString("Date: " & dtpRequestDate.Value.ToString("yyyy-MM-dd"), fontBody, Brushes.Black, startX, startY + 90)
        e.Graphics.DrawString("Student Name: " & txtStudentName.Text, fontBody, Brushes.Black, startX, startY + 110)
        e.Graphics.DrawString("Course & Year: " & txtCourse.Text & " - " & txtYearLevel.Text, fontBody, Brushes.Black, startX, startY + 130)

        e.Graphics.DrawString("------------------------------------------------------------------", fontBody, Brushes.Black, startX, startY + 150)

        ' Items
        e.Graphics.DrawString("Document: " & cmbDocument.Text, fontBody, Brushes.Black, startX, startY + 170)
        e.Graphics.DrawString("Unit Price: P " & txtAmount.Text, fontBody, Brushes.Black, startX, startY + 190)
        e.Graphics.DrawString("Quantity: " & numQuantity.Value.ToString(), fontBody, Brushes.Black, startX, startY + 210)
        e.Graphics.DrawString("Total Amount: P " & txtTotalAmount.Text, fontHeader, Brushes.Black, startX, startY + 230)

        e.Graphics.DrawString("------------------------------------------------------------------", fontBody, Brushes.Black, startX, startY + 250)

        ' Footer
        e.Graphics.DrawString("Payment Status: " & cboPaymentStatus.Text, fontBody, Brushes.Black, startX, startY + 270)
        e.Graphics.DrawString("Processed By: " & txtProcessed.Text, fontBody, Brushes.Black, startX, startY + 290)
        e.Graphics.DrawString("Thank you!", fontHeader, Brushes.Black, startX + 100, startY + 330)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim viewForm As New frmViewRequests()
        viewForm.Show()
    End Sub

End Class