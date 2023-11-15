Imports System.Xml
Public Class CreateNewProject
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblWorkingDir As System.Windows.Forms.Label
    Friend WithEvents lblCurrVersion As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtSelectedFolder As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrVersion As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblDesc = New System.Windows.Forms.Label
        Me.lblWorkingDir = New System.Windows.Forms.Label
        Me.lblCurrVersion = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.txtCurrVersion = New System.Windows.Forms.TextBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.txtSelectedFolder = New System.Windows.Forms.TextBox
        Me.btnClearForm = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(8, 48)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(88, 23)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Title"
        '
        'lblDesc
        '
        Me.lblDesc.Location = New System.Drawing.Point(8, 80)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(88, 16)
        Me.lblDesc.TabIndex = 2
        Me.lblDesc.Text = "Description"
        '
        'lblWorkingDir
        '
        Me.lblWorkingDir.Location = New System.Drawing.Point(8, 192)
        Me.lblWorkingDir.Name = "lblWorkingDir"
        Me.lblWorkingDir.Size = New System.Drawing.Size(96, 23)
        Me.lblWorkingDir.TabIndex = 3
        Me.lblWorkingDir.Text = "Working Directory"
        '
        'lblCurrVersion
        '
        Me.lblCurrVersion.Location = New System.Drawing.Point(8, 272)
        Me.lblCurrVersion.Name = "lblCurrVersion"
        Me.lblCurrVersion.Size = New System.Drawing.Size(88, 23)
        Me.lblCurrVersion.TabIndex = 4
        Me.lblCurrVersion.Text = "Current Version"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(104, 48)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(192, 20)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = ""
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(104, 80)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(192, 96)
        Me.txtDesc.TabIndex = 2
        Me.txtDesc.Text = ""
        '
        'txtCurrVersion
        '
        Me.txtCurrVersion.Location = New System.Drawing.Point(104, 272)
        Me.txtCurrVersion.Name = "txtCurrVersion"
        Me.txtCurrVersion.Size = New System.Drawing.Size(192, 20)
        Me.txtCurrVersion.TabIndex = 4
        Me.txtCurrVersion.Text = ""
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.LightGray
        Me.btnBrowse.Location = New System.Drawing.Point(104, 192)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse..."
        '
        'txtSelectedFolder
        '
        Me.txtSelectedFolder.BackColor = System.Drawing.Color.LightGray
        Me.txtSelectedFolder.Location = New System.Drawing.Point(8, 224)
        Me.txtSelectedFolder.Name = "txtSelectedFolder"
        Me.txtSelectedFolder.ReadOnly = True
        Me.txtSelectedFolder.Size = New System.Drawing.Size(288, 20)
        Me.txtSelectedFolder.TabIndex = 9
        Me.txtSelectedFolder.Text = ""
        '
        'btnClearForm
        '
        Me.btnClearForm.BackColor = System.Drawing.Color.LightGray
        Me.btnClearForm.Location = New System.Drawing.Point(8, 312)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(64, 23)
        Me.btnClearForm.TabIndex = 6
        Me.btnClearForm.Text = "Reset"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.LightGray
        Me.btnStart.Location = New System.Drawing.Point(88, 312)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(136, 23)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Save and Start Project"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGray
        Me.btnExit.Location = New System.Drawing.Point(240, 312)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Close"
        '
        'CreateNewProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(310, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.txtSelectedFolder)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtCurrVersion)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblCurrVersion)
        Me.Controls.Add(Me.lblWorkingDir)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateNewProject"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CreateNewProject"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CreateNewProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = 310
        Me.Height = 360
        setBackgroundImage(Me, iresNewProjFormBg)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        Dim res As DialogResult
        res = FolderBrowserDialog1.ShowDialog()
        If (res) Then
            txtSelectedFolder.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearForm.Click
        'Resets all the user input
        txtTitle.Text = ""
        txtDesc.Text = ""
        txtCurrVersion.Text = ""
        txtSelectedFolder.Text = ""

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'variables
        Dim ds As New DataSet
        Dim dr As DataRow
'        Dim dt As DataTable

        Dim d1 As Date
        Dim projTitle As String
        Dim projDir As String
        Dim baseDir As String
        Dim reportFile As String
        Dim versionFile As String
        Dim workHistFile As String
        Dim sZeroDateString As String = d1.Subtract(d1).ToString()

        If (isStrEmpty(txtTitle.Text) Or isStrEmpty(txtSelectedFolder.Text) Or isStrEmpty(txtCurrVersion.Text) Or isStrEmpty(txtDesc.Text)) Then
            MsgBox("One or more required fields are missing." + Chr(13) + "Please enter all fields.", MsgBoxStyle.Information, "Required data fields empty.")
        Else
            projTitle = txtTitle.Text.Trim
            projDir = txtSelectedFolder.Text.Trim
            If (projDir.Length = 3) Then
                baseDir = projDir
            Else
                baseDir = projDir + "\"
            End If
            reportFile = baseDir + projTitle + "_report.html"
            versionFile = baseDir + "version.txt"
            workHistFile = baseDir + "work_history.txt"

            ds.ReadXml(dataFileXML)
            dr = ds.Tables(0).NewRow()

            dr(0) = projTitle
            dr(1) = txtCurrVersion.Text.Trim
            dr(2) = txtDesc.Text.Trim
            dr(3) = projDir
            dr(4) = Date.Now                    'startDate
            dr(5) = sZeroDateString             'designTime
            dr(6) = sZeroDateString             'codingTime
            dr(7) = sZeroDateString             'tesingTime
            dr(8) = sZeroDateString             'documentation
            dr(9) = reportFile                  'reportFile
            dr(10) = versionFile                'versionInfoFile
            dr(11) = workHistFile               'workHistoryFile
            dr(12) = 0                          'totalTimeOverflow

            ds.Tables(0).Rows.Add(dr)
            'dt.ImportRow(dr)
            'ds.Tables.Add(dt)

            ds.WriteXml(dataFileXML, XmlWriteMode.WriteSchema)

            MsgBox("Saved Project Information.", MsgBoxStyle.Information, "Save XML Info")
            currProject = projTitle
            loadForm(New projectMonitor, frmMain)
        End If

    End Sub

    Private Sub CreateNewProject_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        bFormActive = False
    End Sub
End Class
