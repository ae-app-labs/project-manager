Imports System.Xml
Imports System.IO.Stream
Public Class projectMonitor
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
    Friend WithEvents lblProjTitle As System.Windows.Forms.Label
    Friend WithEvents txtCurrVer As System.Windows.Forms.TextBox
    Friend WithEvents btnIncrVer As System.Windows.Forms.Button
    Friend WithEvents btnDecrVer As System.Windows.Forms.Button
    Friend WithEvents btnUpdHist As System.Windows.Forms.Button
    Friend WithEvents txtWorkHist As System.Windows.Forms.TextBox
    Friend WithEvents btnClearHist As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesignTime As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodingTime As System.Windows.Forms.TextBox
    Friend WithEvents txtTestingTime As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumTime As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtTimer As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents rbDesign As System.Windows.Forms.RadioButton
    Friend WithEvents rbCoding As System.Windows.Forms.RadioButton
    Friend WithEvents rbTesting As System.Windows.Forms.RadioButton
    Friend WithEvents rbDocum As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblProjTitle = New System.Windows.Forms.Label
        Me.txtCurrVer = New System.Windows.Forms.TextBox
        Me.txtWorkHist = New System.Windows.Forms.TextBox
        Me.btnIncrVer = New System.Windows.Forms.Button
        Me.btnDecrVer = New System.Windows.Forms.Button
        Me.btnUpdHist = New System.Windows.Forms.Button
        Me.btnClearHist = New System.Windows.Forms.Button
        Me.txtDesignTime = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodingTime = New System.Windows.Forms.TextBox
        Me.txtTestingTime = New System.Windows.Forms.TextBox
        Me.rbDesign = New System.Windows.Forms.RadioButton
        Me.rbCoding = New System.Windows.Forms.RadioButton
        Me.rbTesting = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.rbDocum = New System.Windows.Forms.RadioButton
        Me.txtDocumTime = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.txtTimer = New System.Windows.Forms.TextBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblProjTitle
        '
        Me.lblProjTitle.BackColor = System.Drawing.Color.White
        Me.lblProjTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblProjTitle.Name = "lblProjTitle"
        Me.lblProjTitle.Size = New System.Drawing.Size(288, 16)
        Me.lblProjTitle.TabIndex = 0
        Me.lblProjTitle.Text = "Current Project"
        '
        'txtCurrVer
        '
        Me.txtCurrVer.Location = New System.Drawing.Point(248, 88)
        Me.txtCurrVer.Name = "txtCurrVer"
        Me.txtCurrVer.ReadOnly = True
        Me.txtCurrVer.Size = New System.Drawing.Size(56, 20)
        Me.txtCurrVer.TabIndex = 4
        Me.txtCurrVer.Text = "0"
        Me.txtCurrVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWorkHist
        '
        Me.txtWorkHist.AcceptsReturn = True
        Me.txtWorkHist.Location = New System.Drawing.Point(8, 64)
        Me.txtWorkHist.Multiline = True
        Me.txtWorkHist.Name = "txtWorkHist"
        Me.txtWorkHist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtWorkHist.Size = New System.Drawing.Size(224, 168)
        Me.txtWorkHist.TabIndex = 3
        Me.txtWorkHist.Text = ""
        '
        'btnIncrVer
        '
        Me.btnIncrVer.Location = New System.Drawing.Point(248, 64)
        Me.btnIncrVer.Name = "btnIncrVer"
        Me.btnIncrVer.Size = New System.Drawing.Size(56, 20)
        Me.btnIncrVer.TabIndex = 4
        Me.btnIncrVer.Text = "Incr.Ver"
        '
        'btnDecrVer
        '
        Me.btnDecrVer.Location = New System.Drawing.Point(248, 112)
        Me.btnDecrVer.Name = "btnDecrVer"
        Me.btnDecrVer.Size = New System.Drawing.Size(56, 20)
        Me.btnDecrVer.TabIndex = 5
        Me.btnDecrVer.Text = "Decr.Ver"
        '
        'btnUpdHist
        '
        Me.btnUpdHist.Location = New System.Drawing.Point(240, 200)
        Me.btnUpdHist.Name = "btnUpdHist"
        Me.btnUpdHist.Size = New System.Drawing.Size(64, 32)
        Me.btnUpdHist.TabIndex = 6
        Me.btnUpdHist.Text = "Update History"
        '
        'btnClearHist
        '
        Me.btnClearHist.Location = New System.Drawing.Point(240, 176)
        Me.btnClearHist.Name = "btnClearHist"
        Me.btnClearHist.Size = New System.Drawing.Size(64, 20)
        Me.btnClearHist.TabIndex = 7
        Me.btnClearHist.Text = "Clear Hist"
        '
        'txtDesignTime
        '
        Me.txtDesignTime.BackColor = System.Drawing.Color.LightGray
        Me.txtDesignTime.Location = New System.Drawing.Point(104, 256)
        Me.txtDesignTime.Name = "txtDesignTime"
        Me.txtDesignTime.ReadOnly = True
        Me.txtDesignTime.Size = New System.Drawing.Size(80, 20)
        Me.txtDesignTime.TabIndex = 8
        Me.txtDesignTime.Text = ""
        Me.txtDesignTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Design"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Coding"
        '
        'txtCodingTime
        '
        Me.txtCodingTime.BackColor = System.Drawing.Color.LightGray
        Me.txtCodingTime.Location = New System.Drawing.Point(104, 280)
        Me.txtCodingTime.Name = "txtCodingTime"
        Me.txtCodingTime.ReadOnly = True
        Me.txtCodingTime.Size = New System.Drawing.Size(80, 20)
        Me.txtCodingTime.TabIndex = 11
        Me.txtCodingTime.Text = ""
        Me.txtCodingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTestingTime
        '
        Me.txtTestingTime.BackColor = System.Drawing.Color.LightGray
        Me.txtTestingTime.Location = New System.Drawing.Point(104, 304)
        Me.txtTestingTime.Name = "txtTestingTime"
        Me.txtTestingTime.ReadOnly = True
        Me.txtTestingTime.Size = New System.Drawing.Size(80, 20)
        Me.txtTestingTime.TabIndex = 12
        Me.txtTestingTime.Text = ""
        Me.txtTestingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbDesign
        '
        Me.rbDesign.BackColor = System.Drawing.Color.Transparent
        Me.rbDesign.Location = New System.Drawing.Point(88, 256)
        Me.rbDesign.Name = "rbDesign"
        Me.rbDesign.Size = New System.Drawing.Size(16, 20)
        Me.rbDesign.TabIndex = 13
        '
        'rbCoding
        '
        Me.rbCoding.BackColor = System.Drawing.Color.Transparent
        Me.rbCoding.Location = New System.Drawing.Point(88, 280)
        Me.rbCoding.Name = "rbCoding"
        Me.rbCoding.Size = New System.Drawing.Size(16, 20)
        Me.rbCoding.TabIndex = 14
        Me.rbCoding.Text = "RadioButton2"
        '
        'rbTesting
        '
        Me.rbTesting.BackColor = System.Drawing.Color.Transparent
        Me.rbTesting.Location = New System.Drawing.Point(88, 304)
        Me.rbTesting.Name = "rbTesting"
        Me.rbTesting.Size = New System.Drawing.Size(16, 20)
        Me.rbTesting.TabIndex = 15
        Me.rbTesting.Text = "RadioButton3"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Testing"
        '
        'rbDocum
        '
        Me.rbDocum.BackColor = System.Drawing.Color.Transparent
        Me.rbDocum.Location = New System.Drawing.Point(88, 328)
        Me.rbDocum.Name = "rbDocum"
        Me.rbDocum.Size = New System.Drawing.Size(16, 20)
        Me.rbDocum.TabIndex = 18
        Me.rbDocum.Text = "RadioButton4"
        '
        'txtDocumTime
        '
        Me.txtDocumTime.BackColor = System.Drawing.Color.LightGray
        Me.txtDocumTime.Location = New System.Drawing.Point(104, 328)
        Me.txtDocumTime.Name = "txtDocumTime"
        Me.txtDocumTime.ReadOnly = True
        Me.txtDocumTime.Size = New System.Drawing.Size(80, 20)
        Me.txtDocumTime.TabIndex = 17
        Me.txtDocumTime.Text = ""
        Me.txtDocumTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Documentation"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(200, 256)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(47, 20)
        Me.btnStart.TabIndex = 21
        Me.btnStart.Text = "Start"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(249, 256)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(47, 20)
        Me.btnStop.TabIndex = 22
        Me.btnStop.Text = "Stop"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(200, 304)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 20)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update Time"
        '
        'txtTimer
        '
        Me.txtTimer.Location = New System.Drawing.Point(200, 280)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(96, 20)
        Me.txtTimer.TabIndex = 25
        Me.txtTimer.Text = ""
        Me.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(200, 328)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(96, 20)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "Reset"
        '
        'Timer1
        '
        '
        'projectMonitor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(310, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtTimer)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbDocum)
        Me.Controls.Add(Me.txtDocumTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbTesting)
        Me.Controls.Add(Me.rbCoding)
        Me.Controls.Add(Me.rbDesign)
        Me.Controls.Add(Me.txtTestingTime)
        Me.Controls.Add(Me.txtCodingTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDesignTime)
        Me.Controls.Add(Me.btnClearHist)
        Me.Controls.Add(Me.btnUpdHist)
        Me.Controls.Add(Me.btnDecrVer)
        Me.Controls.Add(Me.btnIncrVer)
        Me.Controls.Add(Me.txtWorkHist)
        Me.Controls.Add(Me.txtCurrVer)
        Me.Controls.Add(Me.lblProjTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "projectMonitor"
        Me.Text = "projectMonitor"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim fileVersion As IO.StreamWriter
    Dim fileWorkHis As IO.StreamWriter
    Dim fileReport As IO.StreamWriter

    Dim sFileRep As String
    Dim sFileVer As String
    Dim sFilehis As String

    Dim ds As New DataSet
    Dim d1, d2 As Date
    Dim timerIsRunning As Boolean
    Public Sub acceptInput()
        '
    End Sub
    Private Sub projectMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = 310
        Me.Height = 360
        bFormActive = True
        timerIsRunning = False

        'enableProjectSettingsMenu()

        setBackgroundImage(Me, iresProjManFormBg)

        Dim i As Integer
        Dim sTitle As String

        ds.ReadXml(dataFileXML) ' load XML db

        For i = 0 To ds.Tables(0).Rows.Count - 1
            sTitle = ds.Tables(0).Rows(i).Item(0)
            If (sTitle = currProject) Then
                ' found the project
                sFileRep = ds.Tables(0).Rows(i).Item(9)
                sFileVer = ds.Tables(0).Rows(i).Item(10)
                sFilehis = ds.Tables(0).Rows(i).Item(11)
                currProjIdx = i                 ' set global variable with currProjectindexValue
                lblProjTitle.Text = " Curent Project - " + sTitle
                txtCurrVer.Text = (ds.Tables(0).Rows(i).Item(1) + 1)

                txtDesignTime.Text = ds.Tables(0).Rows(i).Item(5)
                txtCodingTime.Text = ds.Tables(0).Rows(i).Item(6)
                txtTestingTime.Text = ds.Tables(0).Rows(i).Item(7)
                txtDocumTime.Text = ds.Tables(0).Rows(i).Item(8)

                'fileReport = New IO.StreamWriter(fileRep, False)
                'fileVersion = New IO.StreamWriter(fileVer, False)


                'fileReport.WriteLine(HTMLHeader)
                'fileReport.WriteLine(HTMLFooter)

                'fileReport.Close()
            End If
        Next
        txtWorkHist.Clear()
        txtWorkHist.Focus()
    End Sub

    Private Sub btnIncrVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncrVer.Click
        txtCurrVer.Text = (txtCurrVer.Text + 1)
        If (gbManualVersioned) Then
            txtCurrVer.Text = gManualVersion
            gbManualVersioned = False
        End If
        
    End Sub

    Private Sub btnDecrVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrVer.Click
        If (txtCurrVer.Text > 1) Then
            txtCurrVer.Text = (txtCurrVer.Text - 1)
        End If
    End Sub

    Private Sub btnUpdHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdHist.Click
        If (txtWorkHist.Text.Length) Then
            fileWorkHis = New IO.StreamWriter(sFilehis, True)
            Dim currTime As String = " [" + Date.Now.ToShortTimeString + " " + Date.Now.ToShortDateString + "]"
            fileWorkHis.WriteLine("- " + txtWorkHist.Text + ", " + txtCurrVer.Text.ToString + currTime)
            fileWorkHis.WriteLine("")
            fileWorkHis.Close()

            ' update the version value in xml db
            ' first update the local dataset
            ds.Tables(0).Rows(currProjIdx).Item(1) = txtCurrVer.Text
            ds.WriteXml(dataFileXML)

            txtCurrVer.Text = (txtCurrVer.Text + 1)
        Else
            MsgBox("You have not entered any data.", MsgBoxStyle.Exclamation, "No Message Entered")
        End If

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim fieldToUpdate As Integer = 0
        Dim retString As String = ""
        Dim dt1, dt2 As Date

        If (timerIsRunning) Then
            Timer1.Stop() ' explicitly stop the timer if user forgot
            timerIsRunning = False
        End If
        '----------------------------------------------------------------
        '|   START TRY CATCH                                            |
        '----------------------------------------------------------------
        Try
            dt1 = Date.Parse(txtTimer.Text)
            ' Start if else ladder to determine what type of time it is
            If (rbDesign.Checked) Then
                fieldToUpdate = 5
                dt2 = Date.Parse(txtDesignTime.Text)
                retString = getAddedTime(dt1, dt2)
                txtDesignTime.Text = retString
            Else
                If (rbCoding.Checked) Then
                    fieldToUpdate = 6
                    dt2 = Date.Parse(txtCodingTime.Text)
                    retString = getAddedTime(dt1, dt2)
                    txtCodingTime.Text = retString
                Else
                    If (rbTesting.Checked) Then
                        fieldToUpdate = 7
                        dt2 = Date.Parse(txtTestingTime.Text)
                        retString = getAddedTime(dt1, dt2)
                        txtTestingTime.Text = retString
                    Else
                        If (rbDocum.Checked) Then
                            fieldToUpdate = 8
                            dt2 = Date.Parse(txtDocumTime.Text)
                            retString = getAddedTime(dt1, dt2)
                            txtDocumTime.Text = retString
                        End If
                    End If
                End If
            End If
            ' end if else ladder
            If (fieldToUpdate) Then
                'ds.ReadXml(dataFileXML)
                ds.Tables(0).Rows(currProjIdx).Item(fieldToUpdate) = retString
                ds.WriteXml(dataFileXML)
            Else
                MsgBox("Please select a field to update the time", MsgBoxStyle.Exclamation, "No field selected")
            End If

        Catch ex As Exception
            ' exception may be thrown if the txtTimer variable is in incorrtect format to be handled by date.parse
            MsgBox("The timer is not yet started!" + Chr(13) + ex.Message, MsgBoxStyle.Critical, "Runtime Exception Caught")
        End Try
        '<-- END TRY CATCH -->
    End Sub

    Private Sub projectMonitor_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        bFormActive = False
    End Sub

    Private Sub btnClearHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearHist.Click
        txtWorkHist.Clear()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtTimer.Clear()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        d1 = Date.Now.ToLongTimeString
        txtTimer.Clear()
        Timer1.Start()
        timerIsRunning = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Timer1.Stop()
        timerIsRunning = False
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        d2 = Date.Now.ToLongTimeString
        txtTimer.Text = d2.Subtract(d1).ToString
    End Sub

    Private Sub rbDesign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDesign.CheckedChanged
        If (rbDesign.Checked) Then
            txtDesignTime.BackColor = Color.Azure
        Else
            txtDesignTime.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub rbCoding_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCoding.CheckedChanged
        If (rbCoding.Checked) Then
            txtCodingTime.BackColor = Color.Azure
        Else
            txtCodingTime.BackColor = Color.LightGray
        End If

    End Sub

    Private Sub rbTesting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTesting.CheckedChanged
        If (rbTesting.Checked) Then
            txtTestingTime.BackColor = Color.Azure
        Else
            txtTestingTime.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub rbDocum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDocum.CheckedChanged
        If (rbDocum.Checked) Then
            txtDocumTime.BackColor = Color.Azure
        Else
            txtDocumTime.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub txtWorkHist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWorkHist.KeyDown
        If (e.KeyData = Keys.A) Then
            'MsgBox(e.Modifiers.ToString)
            'txtWorkHist.SelectAll()
        End If
    End Sub
End Class
