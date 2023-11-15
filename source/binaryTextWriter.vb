Imports System.IO
Public Class binaryTextWriter
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
    Friend WithEvents txtBinFileName As System.Windows.Forms.TextBox
    Friend WithEvents txtFileContents As System.Windows.Forms.TextBox
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtBinFileName = New System.Windows.Forms.TextBox
        Me.txtFileContents = New System.Windows.Forms.TextBox
        Me.btnWrite = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtBinFileName
        '
        Me.txtBinFileName.Location = New System.Drawing.Point(8, 24)
        Me.txtBinFileName.Name = "txtBinFileName"
        Me.txtBinFileName.Size = New System.Drawing.Size(176, 20)
        Me.txtBinFileName.TabIndex = 0
        Me.txtBinFileName.Text = ""
        '
        'txtFileContents
        '
        Me.txtFileContents.Location = New System.Drawing.Point(8, 48)
        Me.txtFileContents.Multiline = True
        Me.txtFileContents.Name = "txtFileContents"
        Me.txtFileContents.Size = New System.Drawing.Size(264, 216)
        Me.txtFileContents.TabIndex = 1
        Me.txtFileContents.Text = ""
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(192, 24)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(56, 23)
        Me.btnWrite.TabIndex = 2
        Me.btnWrite.Text = "Write"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(248, 24)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input Filename and Contents"
        '
        'binaryTextWriter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 273)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.txtFileContents)
        Me.Controls.Add(Me.txtBinFileName)
        Me.Name = "binaryTextWriter"
        Me.Text = "binaryTextWriter"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite.Click
        If (txtBinFileName.Text.Length > 0) Then
            Dim outStream As FileStream = New FileStream(txtBinFileName.Text.Trim, FileMode.Create)
            Dim binWriter As BinaryWriter = New BinaryWriter(outStream)
                        
            Try
				
'				byteStream = txtFileContents.Text.ToCharArray()
				
                binWriter.Write(txtFileContents.Text.ToCharArray())
                MsgBox("Wrote data to " + txtBinFileName.Text, MsgBoxStyle.Information, "Success in writing data")
                binWriter.Close()

            Catch ex As Exception
                MsgBox("No Data to write." + ex.Message, MsgBoxStyle.Critical, "Exception Caught")
            End Try


        End If
    End Sub
End Class
