Public Class GererateProjectReport
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Options As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReportFilePath As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomStyles As System.Windows.Forms.TextBox
    Friend WithEvents rbCust As System.Windows.Forms.RadioButton
    Friend WithEvents rbGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlue As System.Windows.Forms.RadioButton
    Friend WithEvents cbAddWorkHist As System.Windows.Forms.CheckBox
    Friend WithEvents rbRed As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GererateProjectReport))
        Me.txtReportFilePath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.Options = New System.Windows.Forms.GroupBox
        Me.cbAddWorkHist = New System.Windows.Forms.CheckBox
        Me.txtCustomStyles = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbCust = New System.Windows.Forms.RadioButton
        Me.rbGreen = New System.Windows.Forms.RadioButton
        Me.rbBlue = New System.Windows.Forms.RadioButton
        Me.rbRed = New System.Windows.Forms.RadioButton
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Options.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtReportFilePath
        '
        Me.txtReportFilePath.Location = New System.Drawing.Point(8, 32)
        Me.txtReportFilePath.Name = "txtReportFilePath"
        Me.txtReportFilePath.Size = New System.Drawing.Size(288, 20)
        Me.txtReportFilePath.TabIndex = 0
        Me.txtReportFilePath.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Report File Path (You can Change if you want)"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(216, 296)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Write"
        '
        'Options
        '
        Me.Options.Controls.Add(Me.cbAddWorkHist)
        Me.Options.Controls.Add(Me.txtCustomStyles)
        Me.Options.Controls.Add(Me.Label2)
        Me.Options.Controls.Add(Me.rbCust)
        Me.Options.Controls.Add(Me.rbGreen)
        Me.Options.Controls.Add(Me.rbBlue)
        Me.Options.Controls.Add(Me.rbRed)
        Me.Options.Location = New System.Drawing.Point(4, 64)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(296, 224)
        Me.Options.TabIndex = 3
        Me.Options.TabStop = False
        Me.Options.Text = "Options"
        '
        'cbAddWorkHist
        '
        Me.cbAddWorkHist.Checked = True
        Me.cbAddWorkHist.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAddWorkHist.Location = New System.Drawing.Point(8, 184)
        Me.cbAddWorkHist.Name = "cbAddWorkHist"
        Me.cbAddWorkHist.Size = New System.Drawing.Size(88, 32)
        Me.cbAddWorkHist.TabIndex = 5
        Me.cbAddWorkHist.Text = "Include Work History"
        '
        'txtCustomStyles
        '
        Me.txtCustomStyles.Enabled = False
        Me.txtCustomStyles.Location = New System.Drawing.Point(96, 16)
        Me.txtCustomStyles.Multiline = True
        Me.txtCustomStyles.Name = "txtCustomStyles"
        Me.txtCustomStyles.Size = New System.Drawing.Size(192, 200)
        Me.txtCustomStyles.TabIndex = 4
        Me.txtCustomStyles.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Choose Theme..."
        '
        'rbCust
        '
        Me.rbCust.Location = New System.Drawing.Point(8, 104)
        Me.rbCust.Name = "rbCust"
        Me.rbCust.TabIndex = 2
        Me.rbCust.Text = "Custom Styles"
        '
        'rbGreen
        '
        Me.rbGreen.Location = New System.Drawing.Point(8, 56)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.TabIndex = 1
        Me.rbGreen.Text = "Autumn Green"
        '
        'rbBlue
        '
        Me.rbBlue.Checked = True
        Me.rbBlue.Location = New System.Drawing.Point(8, 32)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.TabIndex = 0
        Me.rbBlue.TabStop = True
        Me.rbBlue.Text = "Pleasant Blue"
        '
        'rbRed
        '
        Me.rbRed.Location = New System.Drawing.Point(8, 80)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.TabIndex = 6
        Me.rbRed.Text = "Cherry Red"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(128, 296)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'GererateProjectReport
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(302, 323)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReportFilePath)
        Me.Controls.Add(Me.btnGenerate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GererateProjectReport"
        Me.ShowInTaskbar = False
        Me.Text = "GererateProjectReport"
        Me.Options.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet ' global variable for loading the data into the xml db
    Dim sDfltStyles As String
    Private Sub GererateProjectReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (bFormActive And frmCurr.Name = "projectMonitor") Then
            Dim sReportFilePath As String
            ds.ReadXml(dataFileXML) ' we will only be reading data frm the db
            sReportFilePath = ds.Tables(0).Rows(currProjIdx).Item(9)
            txtReportFilePath.Text = sReportFilePath
            sDfltStyles = readFileData("data\pmReport_ssTt.rps")
        Else
            MsgBox("Please open a project first.", MsgBoxStyle.Information, "No Project Open")
            Me.Close()
        End If
    End Sub


    Private Sub rbCust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCust.CheckedChanged
        If (rbCust.Checked) Then
            txtCustomStyles.Text = sDfltStyles
            txtCustomStyles.Enabled = True
        Else
            txtCustomStyles.Text = ""
            txtCustomStyles.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim sStylesBuffer As String
        Dim sContentExtra As String
        Dim HTMLHeader, HTMLFooter As String
        Dim reportFile As System.IO.StreamWriter
        Dim dateStr1, dateStr2, totalTimeString As String
        Dim t1, t2, t3, t4, t5 As Double
        Dim dt1, dt2 As Date
        Dim totalTimeOverflow As Integer
        
        sStylesBuffer = ""

        ' we are going to calculate the total development time 
        totalTimeOverflow = ds.Tables(0).Rows(currProjIdx).Item(12) ' read the total time overflow
        dt1 = Date.Parse(ds.Tables(0).Rows(currProjIdx).Item(5))
        dt2 = Date.Parse(ds.Tables(0).Rows(currProjIdx).Item(6))
        t1 = getHashedTime(dt1)
        t2 = getHashedTime(dt2)
        dateStr1 = Date.Parse(getAddedTime(dt1, dt2))
        dt1 = Date.Parse(ds.Tables(0).Rows(currProjIdx).Item(7))
        dt2 = Date.Parse(ds.Tables(0).Rows(currProjIdx).Item(8))
        t3 = getHashedTime(dt1)
        t4 = getHashedTime(dt2)
        dateStr2 = Date.Parse(getAddedTime(dt1, dt2))
        dt1 = Date.Parse(dateStr1)
        dt2 = Date.Parse(dateStr2)
        totalTimeString = getAddedTime(dt1, dt2)
        Try
            t5 = getHashedTime(Date.Parse(totalTimeString))
        Catch ex As Exception
            ' exception could be the overflow
            totalTimeOverflow = totalTimeOverflow + 1

            ' Update the database as well
            ds.Tables(0).Rows(currProjIdx).Item(12) = totalTimeOverflow
            ds.WriteXml(dataFileXML)
        End Try

        ' end of calculating total time

        If (txtReportFilePath.Text.Length) Then
            If (rbBlue.Checked) Then
                sStylesBuffer = readFileData("data\pmReport_ssTb.rps")  ' Blue Theme
            End If
            If (rbGreen.Checked) Then
                sStylesBuffer = readFileData("data\pmReport_ssTg.rps")  ' Green Theme
            End If
            If (rbRed.Checked) Then
                sStylesBuffer = readFileData("data\pmReport_ssTr.rps")  ' Red Theme
            End If
            If (rbCust.Checked) Then
                sStylesBuffer = txtCustomStyles.Text.Trim               ' Show Style Template
            End If
            If (cbAddWorkHist.Checked) Then
                sContentExtra = "<h3>Project Work History</h3>"
                sContentExtra = sContentExtra + textToHTML(ds.Tables(0).Rows(currProjIdx).Item(11))
            Else
                sContentExtra = "<hr noshade='noshade' />"
            End If
            ' now sStyles would contain the styles defined for writing to the report file
            ' read HTML File header and footer
            HTMLHeader = readFileData("data\pmReport_Hdr.rdt")
            HTMLFooter = readFileData("data\pmReport_Ftr.rdt")

            reportFile = New System.IO.StreamWriter(txtReportFilePath.Text.Trim)
            'Dim dblTemp465 As Double = 
            Dim strTemp123 As String = getReleaseVersionString(ds.Tables(0).Rows(currProjIdx).Item(1))
            With (reportFile)
                .WriteLine(HTMLHeader)       ' writes file header
                .WriteLine("<!--")           ' start css comment
                .WriteLine(sStylesBuffer)    ' write the style
                .WriteLine("-->")            ' ending comment
                .WriteLine("</style></head><body>")
                .WriteLine("<div id='content'>")
                .WriteLine("<h3>" + currProject + "</h3>")

                .WriteLine("<table width=700 border=0 cellspacing=4 cellpadding=2>")
                .WriteLine("<tr><td align='right' width='300'>Project Start Date : </td>")
                .WriteLine("<td align='left' colspan=2>" + ds.Tables(0).Rows(currProjIdx).Item(4) + "</td></tr>")
                .WriteLine("<tr><td align='right'>Current Version : </td>")
                .WriteLine("<td align='left' colspan=2>" + strTemp123 + "</td></tr>")
                .WriteLine("<tr><td align='right'>Project Description : </td>")
                .WriteLine("<td align='left' colspan=2>" + ds.Tables(0).Rows(currProjIdx).Item(2) + "</td></tr>")
                .WriteLine("<tr><td align='right'>Report Generation Date : </td>")
                .WriteLine("<td align='left' colspan=2>" + Date.Now.ToShortDateString + "</td></tr>")
                .WriteLine("<tr><td align='right'>Username : </td>")
                .WriteLine("<td align='left' colspan=2>" + Environment.UserName + "</td></tr>")

                .WriteLine("<tr><td colspan=3>&nbsp</td></tr>")
                .WriteLine("<tr><td align='right'><b>Development Times</b></td>")
                .WriteLine("<td colspan=2>&nbsp;</td></tr>")
                .WriteLine("<tr><td align='right'>Project Design Time : </td>")
                .WriteLine("<td align='left'>" + ds.Tables(0).Rows(currProjIdx).Item(5) + "</td>")
                .WriteLine("<td><div id=id1 style=width:" + ((t1 * 100) / t5).ToString + "px>&nbsp;</div></td></tr>")
                .WriteLine("<tr><td align='right'>Project Coding : </td>")
                .WriteLine("<td align='left'>" + ds.Tables(0).Rows(currProjIdx).Item(6) + "</td>")
                .WriteLine("<td><div id=id2 style=width:" + ((t2 * 100) / t5).ToString + "px>&nbsp;</div></td></tr>")
                .WriteLine("<tr><td align='right'>Project Testing : </td>")
                .WriteLine("<td align='left'>" + ds.Tables(0).Rows(currProjIdx).Item(7) + "</td>")
                .WriteLine("<td><div id=id3 style=width:" + ((t3 * 100) / t5).ToString + "px>&nbsp;</div></td></tr>")
                .WriteLine("<tr><td align='right'>Project Documentation Time : </td>")
                .WriteLine("<td align='left'>" + ds.Tables(0).Rows(currProjIdx).Item(8) + "</td>")
                .WriteLine("<td><div id=id4 style=width:" + ((t4 * 100) / t5).ToString + "px></div></td></tr>")
                .WriteLine("<tr><td>&nbsp;</td><td align='left' colspan=2>------------</td></tr>")
                .WriteLine("<tr><td align='right'>Project Total Time : </td>")
                .WriteLine("<td align='left' colspan=2>" + totalTimeString + "</td></tr>")
                .WriteLine("</table><br>")

                .WriteLine(sContentExtra)
                .WriteLine(HTMLFooter)
                .Close()
            End With

            MsgBox("Successfully wrote the report file.", MsgBoxStyle.Information, "Wrote Report File")
            Me.Close()
        Else
            MsgBox("The report file path is empty", MsgBoxStyle.Information, "No Output file specified")
        End If
    End Sub

    Private Sub Options_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options.Enter

    End Sub
End Class
