Imports System.Xml
Imports System.Data.Odbc
Public Class Welcome
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
    Friend WithEvents btnNewProj As System.Windows.Forms.Button
    Friend WithEvents btnOpenExisting As System.Windows.Forms.Button
    Friend WithEvents lstExistProj As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    	Me.lstExistProj = New System.Windows.Forms.ComboBox
    	Me.btnNewProj = New System.Windows.Forms.Button
    	Me.btnOpenExisting = New System.Windows.Forms.Button
    	Me.SuspendLayout
    	'
    	'lstExistProj
    	'
    	Me.lstExistProj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    	Me.lstExistProj.Location = New System.Drawing.Point(8, 128)
    	Me.lstExistProj.Name = "lstExistProj"
    	Me.lstExistProj.Size = New System.Drawing.Size(176, 21)
    	Me.lstExistProj.Sorted = true
    	Me.lstExistProj.TabIndex = 11
    	'
    	'btnNewProj
    	'
    	Me.btnNewProj.Location = New System.Drawing.Point(8, 248)
    	Me.btnNewProj.Name = "btnNewProj"
    	Me.btnNewProj.Size = New System.Drawing.Size(96, 24)
    	Me.btnNewProj.TabIndex = 10
    	Me.btnNewProj.Text = "Start New"
    	'
    	'btnOpenExisting
    	'
    	Me.btnOpenExisting.Location = New System.Drawing.Point(200, 128)
    	Me.btnOpenExisting.Name = "btnOpenExisting"
    	Me.btnOpenExisting.Size = New System.Drawing.Size(96, 24)
    	Me.btnOpenExisting.TabIndex = 9
    	Me.btnOpenExisting.Text = "Open"
    	'
    	'Welcome
    	'
    	Me.BackColor = System.Drawing.Color.LightGray
    	Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
    	Me.ClientSize = New System.Drawing.Size(310, 360)
    	Me.ControlBox = false
    	Me.Controls.Add(Me.lstExistProj)
    	Me.Controls.Add(Me.btnNewProj)
    	Me.Controls.Add(Me.btnOpenExisting)
    	Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    	Me.MaximizeBox = false
    	Me.MinimizeBox = false
    	Me.Name = "Welcome"
    	Me.ShowInTaskbar = false
    	Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    	Me.Text = "Welcome"
    	Me.ResumeLayout(false)
    End Sub

#End Region

    Private Sub btnOpenExisting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenExisting.Click
        Dim openProj As String = lstExistProj.SelectedItem
        Try
            Dim errVar As Integer = openProj.Length ' to throw an exception if openProj is NULL

            'MsgBox("Opening the project " + openProj, MsgBoxStyle.Information, " Opening Project...")
            currProject = openProj
            Me.Close()
            loadForm(New projectMonitor, frmMain)
            ' now close this form and just show the project Monitor form
        Catch ex As Exception
            ' throws nullReference exception if no item is selected and open btn clicked
            MsgBox("Please select an existing project to continue.", MsgBoxStyle.Exclamation, "No Project Selected")
        End Try
    End Sub

    Private Sub btnNewProj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewProj.Click
        Dim frm1 As System.Windows.Forms.Form = New CreateNewProject
        frm1.MdiParent = Me.MdiParent
        frm1.Show()
        Me.Close()
    End Sub

    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = 310
        Me.Height = 360

        setBackgroundImage(Me, iresWelcomeFormBg)

        'try to populate the OpenProjectLists
        Dim i As Integer
        Dim ds As New DataSet
        Dim tmpString As String
        Dim tableCount As Integer

        ds.ReadXml(dataFileXML)
        tableCount = ds.Tables(0).Rows.Count

        If (tableCount = 0) Then
            'no projects in list

        Else
            ' list items in the listbox
            For i = 0 To tableCount - 1
                tmpString = ds.Tables(0).Rows(i).Item(0)
                lstExistProj.Items.Add(tmpString)
            Next
        End If
    End Sub

    Private Sub Welcome_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        bFormActive = False
    End Sub
End Class
