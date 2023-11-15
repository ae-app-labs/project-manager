Public Class manualVersionInfo
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
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents txtMinor As System.Windows.Forms.TextBox
    Friend WithEvents txtSub As System.Windows.Forms.TextBox
    Friend WithEvents txtRevision As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMajor = New System.Windows.Forms.TextBox
        Me.txtMinor = New System.Windows.Forms.TextBox
        Me.txtSub = New System.Windows.Forms.TextBox
        Me.txtRevision = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(8, 112)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(56, 23)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(96, 112)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Major Version"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Minor Version"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Build"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Revision"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(96, 8)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(56, 20)
        Me.txtMajor.TabIndex = 1
        Me.txtMajor.Text = ""
        '
        'txtMinor
        '
        Me.txtMinor.Location = New System.Drawing.Point(96, 32)
        Me.txtMinor.Name = "txtMinor"
        Me.txtMinor.Size = New System.Drawing.Size(56, 20)
        Me.txtMinor.TabIndex = 2
        Me.txtMinor.Text = ""
        '
        'txtSub
        '
        Me.txtSub.Location = New System.Drawing.Point(96, 56)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(56, 20)
        Me.txtSub.TabIndex = 3
        Me.txtSub.Text = ""
        '
        'txtRevision
        '
        Me.txtRevision.Location = New System.Drawing.Point(96, 80)
        Me.txtRevision.Name = "txtRevision"
        Me.txtRevision.Size = New System.Drawing.Size(56, 20)
        Me.txtRevision.TabIndex = 4
        Me.txtRevision.Text = ""
        '
        'manualVersionInfo
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleMode = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(170, 141)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtRevision)
        Me.Controls.Add(Me.txtSub)
        Me.Controls.Add(Me.txtMinor)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "manualVersionInfo"
        Me.ShowInTaskbar = False
        Me.Text = "Manually Enter Version Info"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'process data
        If (isStrEmpty(txtMajor.Text) Or isStrEmpty(txtMinor.Text) Or isStrEmpty(txtSub.Text) Or isStrEmpty(txtRevision.Text)) Then
            MsgBox("All the fields must be filled." + Chr(13) + " Versioning standards may depend on the company.", MsgBoxStyle.Information, "Required Fields not entered")
        Else
            Dim version As Integer = Integer.Parse(txtRevision.Text) + 10 * Integer.Parse(txtSub.Text) + 100 * Integer.Parse(txtMinor.Text) + 1000 * Integer.Parse(txtMajor.Text)
            If (frmCurr.Name = "projectMonitor") Then
                gbManualVersioned = True
                gManualVersion = version
            Else
                MsgBox("Please open an existing Project First", MsgBoxStyle.Information, "No projects Open")
            End If
            Me.Close()
        End If
    End Sub
End Class
