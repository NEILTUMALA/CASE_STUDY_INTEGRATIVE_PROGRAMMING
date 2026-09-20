<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(450, 248)
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
        Me.Label4.Location = New System.Drawing.Point(524, 208)
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
        Me.Label3.Location = New System.Drawing.Point(511, 168)
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
        Me.btnDocumentManagement.Location = New System.Drawing.Point(210, 327)
        Me.btnDocumentManagement.Name = "btnDocumentManagement"
        Me.btnDocumentManagement.Size = New System.Drawing.Size(308, 88)
        Me.btnDocumentManagement.TabIndex = 14
        Me.btnDocumentManagement.Text = "Document Management"
        Me.btnDocumentManagement.UseVisualStyleBackColor = False
        '
        'btnDocumentRequests
        '
        Me.btnDocumentRequests.BackColor = System.Drawing.Color.Goldenrod
        Me.btnDocumentRequests.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumentRequests.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDocumentRequests.Location = New System.Drawing.Point(348, 440)
        Me.btnDocumentRequests.Name = "btnDocumentRequests"
        Me.btnDocumentRequests.Size = New System.Drawing.Size(308, 88)
        Me.btnDocumentRequests.TabIndex = 15
        Me.btnDocumentRequests.Text = "Document Requests "
        Me.btnDocumentRequests.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.Goldenrod
        Me.btnReports.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReports.Location = New System.Drawing.Point(692, 440)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(308, 88)
        Me.btnReports.TabIndex = 16
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnStudentManagement
        '
        Me.btnStudentManagement.BackColor = System.Drawing.Color.Goldenrod
        Me.btnStudentManagement.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStudentManagement.Location = New System.Drawing.Point(545, 327)
        Me.btnStudentManagement.Name = "btnStudentManagement"
        Me.btnStudentManagement.Size = New System.Drawing.Size(308, 88)
        Me.btnStudentManagement.TabIndex = 17
        Me.btnStudentManagement.Text = "Student Management"
        Me.btnStudentManagement.UseVisualStyleBackColor = False
        '
        'btnUserManagement
        '
        Me.btnUserManagement.BackColor = System.Drawing.Color.Goldenrod
        Me.btnUserManagement.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUserManagement.Location = New System.Drawing.Point(880, 327)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(308, 88)
        Me.btnUserManagement.TabIndex = 18
        Me.btnUserManagement.Text = "User Management"
        Me.btnUserManagement.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Location = New System.Drawing.Point(1099, 600)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(259, 59)
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
        Me.lblDate.Location = New System.Drawing.Point(455, 597)
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
        Me.lblEmployeeName.Location = New System.Drawing.Point(455, 631)
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
        Me.lblPosition.Location = New System.Drawing.Point(12, 631)
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
        Me.lblUsername.Location = New System.Drawing.Point(12, 597)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(149, 28)
        Me.lblUsername.TabIndex = 22
        Me.lblUsername.Text = "Username:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Registrar_Document_Request_System.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(530, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Registrar_Document_Request_System.My.Resources.Resources._91e0436a341ea9b64d6a6e91a9b32ba0
        Me.PictureBox2.Location = New System.Drawing.Point(-6, 583)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1378, 87)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(1370, 668)
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
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
