<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDocumentManagement = New System.Windows.Forms.Button()
        Me.btnDocumentRequests = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnStudentManagement = New System.Windows.Forms.Button()
        Me.btnUserManagement = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvRecentRequests = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNewRequests = New System.Windows.Forms.Label()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblReadyForRelease = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCompletedThisWeek = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(20, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(433, 37)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Registrar Information System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(93, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 31)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "km 30. Road Muntinlupa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(80, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 40)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Lyceum of Alabang"
        '
        'btnDocumentManagement
        '
        Me.btnDocumentManagement.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDocumentManagement.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumentManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDocumentManagement.Location = New System.Drawing.Point(88, 337)
        Me.btnDocumentManagement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDocumentManagement.Name = "btnDocumentManagement"
        Me.btnDocumentManagement.Size = New System.Drawing.Size(308, 89)
        Me.btnDocumentManagement.TabIndex = 14
        Me.btnDocumentManagement.Text = "Document Management"
        Me.btnDocumentManagement.UseVisualStyleBackColor = False
        '
        'btnDocumentRequests
        '
        Me.btnDocumentRequests.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDocumentRequests.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumentRequests.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDocumentRequests.Location = New System.Drawing.Point(88, 549)
        Me.btnDocumentRequests.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDocumentRequests.Name = "btnDocumentRequests"
        Me.btnDocumentRequests.Size = New System.Drawing.Size(308, 89)
        Me.btnDocumentRequests.TabIndex = 15
        Me.btnDocumentRequests.Text = "Document Requests "
        Me.btnDocumentRequests.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.Goldenrod
        Me.btnReports.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReports.Location = New System.Drawing.Point(88, 654)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(308, 89)
        Me.btnReports.TabIndex = 16
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnStudentManagement
        '
        Me.btnStudentManagement.BackColor = System.Drawing.Color.Goldenrod
        Me.btnStudentManagement.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStudentManagement.Location = New System.Drawing.Point(88, 443)
        Me.btnStudentManagement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStudentManagement.Name = "btnStudentManagement"
        Me.btnStudentManagement.Size = New System.Drawing.Size(308, 89)
        Me.btnStudentManagement.TabIndex = 17
        Me.btnStudentManagement.Text = "Student Management"
        Me.btnStudentManagement.UseVisualStyleBackColor = False
        '
        'btnUserManagement
        '
        Me.btnUserManagement.BackColor = System.Drawing.Color.Goldenrod
        Me.btnUserManagement.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUserManagement.Location = New System.Drawing.Point(88, 758)
        Me.btnUserManagement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(308, 89)
        Me.btnUserManagement.TabIndex = 18
        Me.btnUserManagement.Text = "User Management"
        Me.btnUserManagement.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Location = New System.Drawing.Point(1609, 934)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(259, 68)
        Me.btnLogout.TabIndex = 20
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDate.Image = Global.Registrar_Document_Request_System.My.Resources.Resources._91e0436a341ea9b64d6a6e91a9b32ba0
        Me.lblDate.Location = New System.Drawing.Point(534, 922)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(131, 28)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Today Is:"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblEmployeeName.Image = Global.Registrar_Document_Request_System.My.Resources.Resources._91e0436a341ea9b64d6a6e91a9b32ba0
        Me.lblEmployeeName.Location = New System.Drawing.Point(1025, 922)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(224, 28)
        Me.lblEmployeeName.TabIndex = 24
        Me.lblEmployeeName.Text = "Employee Name:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPosition.Image = Global.Registrar_Document_Request_System.My.Resources.Resources._91e0436a341ea9b64d6a6e91a9b32ba0
        Me.lblPosition.Location = New System.Drawing.Point(15, 972)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(121, 28)
        Me.lblPosition.TabIndex = 23
        Me.lblPosition.Text = "Position:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblUsername.Image = Global.Registrar_Document_Request_System.My.Resources.Resources._91e0436a341ea9b64d6a6e91a9b32ba0
        Me.lblUsername.Location = New System.Drawing.Point(15, 922)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(149, 28)
        Me.lblUsername.TabIndex = 22
        Me.lblUsername.Text = "Username:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Registrar_Document_Request_System.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(100, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'dgvRecentRequests
        '
        Me.dgvRecentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecentRequests.Location = New System.Drawing.Point(512, 150)
        Me.dgvRecentRequests.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRecentRequests.Name = "dgvRecentRequests"
        Me.dgvRecentRequests.RowHeadersWidth = 51
        Me.dgvRecentRequests.Size = New System.Drawing.Size(1356, 510)
        Me.dgvRecentRequests.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(1470, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 37)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Recent Request Overview"
        '
        'tmrClock
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTime.Image = Global.Registrar_Document_Request_System.My.Resources.Resources._91e0436a341ea9b64d6a6e91a9b32ba0
        Me.lblTime.Location = New System.Drawing.Point(534, 972)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(83, 28)
        Me.lblTime.TabIndex = 28
        Me.lblTime.Text = "Time:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Registrar_Document_Request_System.My.Resources.Resources._91e0436a341ea9b64d6a6e91a9b32ba0
        Me.PictureBox2.Location = New System.Drawing.Point(-10, 886)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1914, 148)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(588, 703)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 74)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "New Requests" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     (Today)"
        '
        'lblNewRequests
        '
        Me.lblNewRequests.AutoSize = True
        Me.lblNewRequests.BackColor = System.Drawing.Color.DarkBlue
        Me.lblNewRequests.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewRequests.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNewRequests.Location = New System.Drawing.Point(667, 786)
        Me.lblNewRequests.Name = "lblNewRequests"
        Me.lblNewRequests.Size = New System.Drawing.Size(34, 37)
        Me.lblNewRequests.TabIndex = 31
        Me.lblNewRequests.Text = "0"
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.BackColor = System.Drawing.Color.DarkBlue
        Me.lblPending.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPending.Location = New System.Drawing.Point(921, 786)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(34, 37)
        Me.lblPending.TabIndex = 33
        Me.lblPending.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(884, 703)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 74)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Pending" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Process" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblReadyForRelease
        '
        Me.lblReadyForRelease.AutoSize = True
        Me.lblReadyForRelease.BackColor = System.Drawing.Color.DarkBlue
        Me.lblReadyForRelease.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReadyForRelease.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblReadyForRelease.Location = New System.Drawing.Point(1177, 786)
        Me.lblReadyForRelease.Name = "lblReadyForRelease"
        Me.lblReadyForRelease.Size = New System.Drawing.Size(34, 37)
        Me.lblReadyForRelease.TabIndex = 35
        Me.lblReadyForRelease.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DarkBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(1133, 703)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 74)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Ready for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Release"
        '
        'lblCompletedThisWeek
        '
        Me.lblCompletedThisWeek.AutoSize = True
        Me.lblCompletedThisWeek.BackColor = System.Drawing.Color.DarkBlue
        Me.lblCompletedThisWeek.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletedThisWeek.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCompletedThisWeek.Location = New System.Drawing.Point(1410, 786)
        Me.lblCompletedThisWeek.Name = "lblCompletedThisWeek"
        Me.lblCompletedThisWeek.Size = New System.Drawing.Size(34, 37)
        Me.lblCompletedThisWeek.TabIndex = 37
        Me.lblCompletedThisWeek.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DarkBlue
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(1346, 703)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 74)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Completed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this Week"
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.AutoSize = True
        Me.lblTotalStudents.BackColor = System.Drawing.Color.DarkBlue
        Me.lblTotalStudents.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalStudents.Location = New System.Drawing.Point(1673, 786)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(34, 37)
        Me.lblTotalStudents.TabIndex = 39
        Me.lblTotalStudents.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.DarkBlue
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(1602, 703)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(214, 74)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Total Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of Student"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.DarkBlue
        Me.lblWelcome.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblWelcome.Location = New System.Drawing.Point(504, 61)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(374, 48)
        Me.lblWelcome.TabIndex = 40
        Me.lblWelcome.Text = "Welcome, Admin!"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DarkBlue
        Me.PictureBox3.Location = New System.Drawing.Point(489, 26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1398, 836)
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(1899, 1029)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTotalStudents)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblCompletedThisWeek)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblReadyForRelease)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblPending)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNewRequests)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvRecentRequests)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnUserManagement)
        Me.Controls.Add(Me.btnStudentManagement)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnDocumentRequests)
        Me.Controls.Add(Me.btnDocumentManagement)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDocumentManagement As Button
    Friend WithEvents btnDocumentRequests As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnStudentManagement As Button
    Friend WithEvents btnUserManagement As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvRecentRequests As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrClock As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNewRequests As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblReadyForRelease As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCompletedThisWeek As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTotalStudents As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
