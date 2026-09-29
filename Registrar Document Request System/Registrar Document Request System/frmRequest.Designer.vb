<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequest))
        Me.txtRequestNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpRequestDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtYearLevel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDocument = New System.Windows.Forms.ComboBox()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.cboPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboRequestStatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProcessed = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRequestNo
        '
        Me.txtRequestNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestNo.Location = New System.Drawing.Point(953, 446)
        Me.txtRequestNo.Name = "txtRequestNo"
        Me.txtRequestNo.ReadOnly = True
        Me.txtRequestNo.Size = New System.Drawing.Size(276, 34)
        Me.txtRequestNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(689, 446)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request Details:"
        '
        'dtpRequestDate
        '
        Me.dtpRequestDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRequestDate.Location = New System.Drawing.Point(953, 495)
        Me.dtpRequestDate.Name = "dtpRequestDate"
        Me.dtpRequestDate.Size = New System.Drawing.Size(276, 22)
        Me.dtpRequestDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student Details:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(339, 45)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(572, 34)
        Me.txtStudentID.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearch.Location = New System.Drawing.Point(969, 48)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(127, 50)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(339, 95)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.Size = New System.Drawing.Size(572, 34)
        Me.txtStudentName.TabIndex = 6
        '
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(339, 149)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(572, 34)
        Me.txtCourse.TabIndex = 7
        '
        'txtYearLevel
        '
        Me.txtYearLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearLevel.Location = New System.Drawing.Point(339, 202)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.ReadOnly = True
        Me.txtYearLevel.Size = New System.Drawing.Size(572, 34)
        Me.txtYearLevel.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 28)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Student Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 28)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Course:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "YearLevel:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(258, 28)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Documents Details:"
        '
        'cmbDocument
        '
        Me.cmbDocument.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDocument.FormattingEnabled = True
        Me.cmbDocument.Items.AddRange(New Object() {"Transcript of Records", "Certificate of Enrollment", "Certificate of Good Moral", "Certification", "Honorable Dismissal"})
        Me.cmbDocument.Location = New System.Drawing.Point(340, 292)
        Me.cmbDocument.Name = "cmbDocument"
        Me.cmbDocument.Size = New System.Drawing.Size(320, 37)
        Me.cmbDocument.TabIndex = 13
        '
        'numQuantity
        '
        Me.numQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numQuantity.Location = New System.Drawing.Point(340, 341)
        Me.numQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(320, 34)
        Me.numQuantity.TabIndex = 14
        Me.numQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 28)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Quantity:"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(340, 388)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(320, 34)
        Me.txtAmount.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 28)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Amount:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 440)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 28)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total Amount:"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(340, 437)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(320, 34)
        Me.txtTotalAmount.TabIndex = 19
        '
        'cboPaymentStatus
        '
        Me.cboPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentStatus.FormattingEnabled = True
        Me.cboPaymentStatus.Items.AddRange(New Object() {"Unpaid", "Paid"})
        Me.cboPaymentStatus.Location = New System.Drawing.Point(953, 292)
        Me.cboPaymentStatus.Name = "cboPaymentStatus"
        Me.cboPaymentStatus.Size = New System.Drawing.Size(276, 37)
        Me.cboPaymentStatus.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(689, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(222, 28)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Payment Status:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(689, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(214, 28)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Request Status:"
        '
        'cboRequestStatus
        '
        Me.cboRequestStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRequestStatus.FormattingEnabled = True
        Me.cboRequestStatus.Items.AddRange(New Object() {"Unpaid", "Paid"})
        Me.cboRequestStatus.Location = New System.Drawing.Point(953, 344)
        Me.cboRequestStatus.Name = "cboRequestStatus"
        Me.cboRequestStatus.Size = New System.Drawing.Size(276, 37)
        Me.cboRequestStatus.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(689, 394)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(189, 28)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Processed By:"
        '
        'txtProcessed
        '
        Me.txtProcessed.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessed.Location = New System.Drawing.Point(953, 394)
        Me.txtProcessed.Name = "txtProcessed"
        Me.txtProcessed.ReadOnly = True
        Me.txtProcessed.Size = New System.Drawing.Size(276, 34)
        Me.txtProcessed.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Registrar_Document_Request_System.My.Resources.Resources._91e0436a341ea9b64d6a6e91a9b32ba0
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 559)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1271, 117)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(794, 589)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 54)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1004, 589)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(160, 54)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Registrar_Document_Request_System.My.Resources.Resources._91e0436a341ea9b64d6a6e91a9b32ba0
        Me.PictureBox2.Image = Global.Registrar_Document_Request_System.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(12, 575)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(94, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.Blue
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOpen.Location = New System.Drawing.Point(969, 116)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(227, 50)
        Me.btnOpen.TabIndex = 30
        Me.btnOpen.Text = "View All Request "
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Blue
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrint.Location = New System.Drawing.Point(969, 186)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(227, 50)
        Me.btnPrint.TabIndex = 33
        Me.btnPrint.Text = "Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(53, 489)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(262, 28)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Reason for request:"
        '
        'txtReason
        '
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(340, 486)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(320, 34)
        Me.txtReason.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(336, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(367, 23)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Search by: Student Number, Name."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.MediumBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(112, 591)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(439, 57)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Document Request"
        '
        'frmRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(1263, 671)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtProcessed)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboRequestStatus)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboPaymentStatus)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numQuantity)
        Me.Controls.Add(Me.cmbDocument)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtYearLevel)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpRequestDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRequestNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRequest"
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRequestNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpRequestDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtYearLevel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbDocument As ComboBox
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents cboPaymentStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboRequestStatus As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtProcessed As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnOpen As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label15 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
End Class
