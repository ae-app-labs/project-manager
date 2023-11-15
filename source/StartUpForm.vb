Public Class StartUpForm
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Timer1 As System.Timers.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDocumentation As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWebsite As System.Windows.Forms.MenuItem
    Friend WithEvents mnuShowVersion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(StartUpForm))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.mnuDocumentation = New System.Windows.Forms.MenuItem
        Me.mnuWebsite = New System.Windows.Forms.MenuItem
        Me.mnuShowVersion = New System.Windows.Forms.MenuItem
        Me.mnuAbout = New System.Windows.Forms.MenuItem
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.Timer1 = New System.Timers.Timer
        Me.lblTime = New System.Windows.Forms.Label
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem6, Me.MenuItem10})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem14, Me.MenuItem5})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MenuItem2.Text = "&New Project"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.MenuItem3.Text = "&Welcome Page"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlW
        Me.MenuItem4.Text = "&Close Window"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItem5.Text = "E&xit"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem20, Me.MenuItem9, Me.MenuItem15})
        Me.MenuItem6.Text = "&Options"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18, Me.MenuItem26, Me.MenuItem25, Me.MenuItem19, Me.MenuItem23})
        Me.MenuItem7.Text = "Project &Options"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MenuItem17.Text = "&Manually Edit Version"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.MenuItem18.Text = "&Generate Report"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.CtrlG
        Me.MenuItem26.Text = "Generate Version File"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 3
        Me.MenuItem25.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftH
        Me.MenuItem19.Text = "View Work History"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftR
        Me.MenuItem23.Text = "View Project Report"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.MenuItem9.Text = "Always on &Top"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem22})
        Me.MenuItem15.Text = "Debug"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Text = "bFormActive"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "WriteBinaryFile"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 2
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDocumentation, Me.mnuWebsite, Me.mnuShowVersion, Me.mnuAbout})
        Me.MenuItem10.Text = "&Help"
        '
        'mnuDocumentation
        '
        Me.mnuDocumentation.Index = 0
        Me.mnuDocumentation.Text = "&Documentation"
        '
        'mnuWebsite
        '
        Me.mnuWebsite.Index = 1
        Me.mnuWebsite.Text = "&Website"
        '
        'mnuShowVersion
        '
        Me.mnuShowVersion.Index = 2
        Me.mnuShowVersion.Text = "Version &Info"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 3
        Me.mnuAbout.Text = "&About"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 365)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.Size = New System.Drawing.Size(314, 22)
        Me.StatusBar1.TabIndex = 1
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "Status"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.SynchronizingObject = Me
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.Control
        Me.lblTime.Location = New System.Drawing.Point(200, 368)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 20)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Label1"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StartUpForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(314, 387)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.StatusBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "StartUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Manager"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public iePath As String
    Private Sub StartUpForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' load the WelcomeForm at first
        loadForm(New Welcome, Me)
        frmMain = Me
        Me.Text = Me.Text + pmVersion.ToString
        '    MenuItem7.Enabled = False ' disable the projectSettings Menu Item, it will be enabled when 
        iePath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Internet Explorer\iexplore.exe"

        'If ColorDialog1.ShowDialog <> DialogResult.Cancel Then
        'MsgBox(ColorDialog1.Color.ToString)
        'End If


    End Sub

    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        lblTime.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        ' load newProjectForm
        loadForm(New CreateNewProject, Me)
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        ' load WelcomeForm on Demand
        loadForm(New Welcome, Me)
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If (bFormActive = True) Then
            frmCurr.Close()
            bFormActive = False
        End If
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        MsgBox(bFormActive.ToString, MsgBoxStyle.Information, "Variable Value")
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click


    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Application.Exit() ' end of programRunnig
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If (Me.TopMost) Then
            Me.TopMost = False
            Me.MenuItem9.Checked = False
        Else
            Me.TopMost = True
            Me.MenuItem9.Checked = True
        End If
    End Sub

    Private Sub mnuShowVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowVersion.Click
        MsgBox(versionInfo, MsgBoxStyle.Information, "Pm Version Info")
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        ' create a new process and run notepad with the argument as the work history.

        Dim myProcess As Process = New Process
        Dim notepadPath As String = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\notepad.exe"
        Dim ds As DataSet = New DataSet
        If (bFormActive And frmCurr.Name = "projectMonitor") Then
            ds.ReadXml(dataFileXML)
            Try
                myProcess.StartInfo.FileName = notepadPath ' possibly launches notepad
                myProcess.StartInfo.Arguments = ds.Tables(0).Rows(currProjIdx).Item(11) ' give the path as argument
                myProcess.StartInfo.UseShellExecute = True
                myProcess.StartInfo.CreateNoWindow = False
                myProcess.Start()
            Catch ex As Exception
                ' notepad is propably in %windir%\ not in %windir%\systme32\
                MsgBox("Exception..." + ex.Message, MsgBoxStyle.Critical, "Runtime exception caught")
            End Try
        Else
            MsgBox(MSG_NO_PROJ_OPEN, MsgBoxStyle.Information, "No Projects Open")
        End If
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If (bFormActive And frmCurr.Name = "projectMonitor") Then
            Dim frmVersion As Form = New manualVersionInfo
            frmVersion.ShowInTaskbar = False
            frmVersion.StartPosition = FormStartPosition.CenterParent
            frmVersion.MdiParent = Me
            frmVersion.Show()
        Else
            MsgBox(MSG_NO_PROJ_OPEN, MsgBoxStyle.Information, "No Projects Open")
        End If
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim frmBinWriter As Form = New binaryTextWriter
        frmBinWriter.StartPosition = FormStartPosition.CenterParent
        frmBinWriter.Show()
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim frmReport As Form = New GererateProjectReport
        frmReport.StartPosition = FormStartPosition.CenterScreen
        frmReport.Show()
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Dim proc As New Process
        Dim ds As New DataSet
        If (bFormActive And frmCurr.Name = "projectMonitor") Then
            ds.ReadXml(dataFileXML)
            Try
                proc.StartInfo.FileName = iePath
                proc.StartInfo.Arguments = ds.Tables(0).Rows(currProjIdx).Item(9)
                proc.StartInfo.UseShellExecute = True
                proc.Start()
            Catch ex As Exception
                MsgBox("Exception..." + ex.Message, MsgBoxStyle.Critical, "Runtime Exception Caught")
            End Try
        Else
            MsgBox(MSG_NO_PROJ_OPEN, MsgBoxStyle.Information, "No Project Open")
        End If
    End Sub

    Private Sub mnuWebsite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWebsite.Click
        Dim proc As New Process
        Try
            proc.StartInfo.FileName = iePath
            proc.StartInfo.Arguments = "http://www.midhunhk.blogspot.com"
            proc.StartInfo.UseShellExecute = True
            proc.Start()
        Catch ex As Exception
            MsgBox("Exception..." + ex.Message, MsgBoxStyle.Critical, "Runtime Exception Caught")
        End Try

    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        ' Generate Version info file
        Dim ds As New DataSet
        Dim versionFilePath As String
        Dim projectVersion As Double
        Dim currDateTime As String = getMonthName(Date.Now.Month.ToString) + " " + Date.Now.Year.ToString
        Dim fileWriter As System.IO.StreamWriter
        If (bFormActive And frmCurr.Name = "projectMonitor") Then
            ds.ReadXml(dataFileXML)
            projectVersion = ds.Tables(0).Rows(currProjIdx).Item(1)
            Try
                versionFilePath = ds.Tables(0).Rows(currProjIdx).Item(10)
                fileWriter = New System.IO.StreamWriter(versionFilePath)
                ' reformat or add additional information to the 
                With (fileWriter)
                    .WriteLine(ds.Tables(0).Rows(currProjIdx).Item(0)) ' project title
                    .WriteLine("")
                    .WriteLine("[Version]")
                    .WriteLine(getReleaseVersionString(projectVersion)) ' stringized version 
                    .WriteLine("")
                    .WriteLine("[Date]")
                    .WriteLine(currDateTime)                            ' current date time - release date
                    .WriteLine("")
                    .WriteLine("(c) Centrum inc Software Solutions R & D") ' version file copyright
                    .Close()
                End With
                MsgBox("Successfully wrote the project Version file", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                MsgBox("Exception..." + ex.Message, MsgBoxStyle.Critical, "Runtime Exception Caught")
            End Try
        Else
            MsgBox("Please open a project first", MsgBoxStyle.Information, "No Project Open")
        End If
    End Sub

    Private Sub lblTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTime.Click

    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        ' Show information about project here.
        Try
            Dim sAbout As String = readFileData(g_resourceDir + "\pmAboutText.tres")    ' Text Resource
            MsgBox(sAbout, MsgBoxStyle.Information, "About Project Manager")
        Catch ex As Exception
            MsgBox("Resource not found", MsgBoxStyle.Exclamation, "No Resource")
        End Try

    End Sub

    Private Sub mnuDocumentation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDocumentation.Click
        Dim proc As New Process
        Try
            proc.StartInfo.FileName = iePath
            proc.StartInfo.Arguments = g_projectPath + "\help\index.html"
            proc.StartInfo.UseShellExecute = True
            proc.Start()
        Catch ex As Exception
            MsgBox("Exception..." + ex.Message, MsgBoxStyle.Critical, "Runtime Exception Caught")
        End Try
    End Sub
End Class
