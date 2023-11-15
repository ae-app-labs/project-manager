Imports System.Text.RegularExpressions

Module Operations

    '------------------------------------------------
    ' Global Stuff
    '------------------------------------------------
    Public frmCurr As Form
    Public frmMain As Form
    Public pmVersion As Double = 1.8
    Public bFormActive As Boolean ' global variable used all across the project to know that a form is active
    Public dataFileXML As String = "data\projects1.xml"
    Public currProject As String  ' curr proj title
    Public currProjIdx As Integer ' projects index no in XML db
    Public gbManualVersioned As Boolean = False
    Public gManualVersion As Integer

    Public MSG_NO_PROJ_OPEN As String = "Please open a project first"

    Private g_executablePath As String = Application.ExecutablePath
    Public g_projectPath As String = g_executablePath.Substring(0, g_executablePath.LastIndexOf("\"))    ' Path to project directory
    Public g_resourceDir As String = g_projectPath + "\resources"                   ' Path to the resources directory

    Public versionInfo As String = "Project Manager Version :" + pmVersion.ToString + Chr(13) + "(Internal Software Project Management Tool)"

    ' Image Resources names
    Public iresWelcomeFormBg As String = "pm_welcome_bg.png"
    Public iresProjManFormBg As String = "pm_project_monitor.png"
    Public iresNewProjFormBg As String = "pm_create_new_proj.png"


    '------------------------------------------------
    ' Functions
    '------------------------------------------------

    Public Sub logWriter()
        ' TODO : Writes the log information
    End Sub

    ' Function loadImage()
    ' Loads and image into the placeholder
    ' Inputs : Image placeholder and image name
    ' June 2008
    '-------------------------------------
    sub loadImage(ByVal imagePlaceHolder As PictureBox, ByVal imageResourceName As String)
        Try
            imagePlaceHolder.Image = New System.Drawing.Bitmap(g_resourceDir + "\" + imageResourceName)
        Catch ex As Exception
            ' Exception if resource is not found
            MsgBox("Resource '" + imageResourceName + "' not found!", MsgBoxStyle.Exclamation, "Resource Missing")
        End Try
    End sub

    ' Function setBackgroundImage()
    ' Loads and image as background image for a Form
    ' Inputs : Form name and image to load
    ' August 2008
    '-------------------------------------
    Sub setBackgroundImage(ByVal frmThis As Windows.Forms.Form, ByVal imageResourceName As String)
        Try
            frmThis.BackgroundImage = New System.Drawing.Bitmap(g_resourceDir + "\" + imageResourceName)
        Catch ex As Exception
            ' Exception if resource is not found
            MsgBox("Resource '" + imageResourceName + "' not found!", MsgBoxStyle.Exclamation, "Resource Missing")
        End Try
    End Sub

    ' Function isStrEmpty(str) as boolean
    ' accepts a string
    ' returns true if it is mt 
    '--------------------------------------------------
    Function isStrEmpty(ByVal str As String) As Boolean
        If (str.Length = 0) Then
            Return True
        End If
        Return False
    End Function

    ' Function loadForm()
    ' Inputs : FormToBeLoaded as child to an MDI Parent form
    ' Returns: True if success, if any exception occurs, false
    '-----------------------------------------------------------------------
    Function loadForm(ByVal frmToLoad As Form, ByVal frmParent As Form) As Boolean
        Try
            If (bFormActive = True) Then
                frmCurr.Close()
            End If
            frmCurr = frmToLoad
            frmCurr.MdiParent = frmParent
            frmCurr.StartPosition = FormStartPosition.WindowsDefaultLocation
            frmCurr.Show()
            bFormActive = True
            Return True
        Catch ex As Exception
            MsgBox("Runtime exception caught when loading a form." + Chr(13) + ex.Message, MsgBoxStyle.Critical, "Exception Caught")
            Return False
        End Try
    End Function

    ' Function getAddedTime
    ' Created: 20-Jul-2007
    ' Author : Midhun Harikumar
    ' Desc   : returns the total sum time from two date objects
    ' input  : two objects of type date
    ' returns: a string having the time combined in dt1 and dt2 (dt1+dt2)

    '-----------------------------------------------------------------------
    Function getAddedTime(ByVal dt1 As Date, ByVal dt2 As Date) As String
        ' Variables
        Dim minuteOffset, hourOffset, newHours, newMinutes, newSeconds As Integer
        Dim offsetTimeString As String

        ' Initialisations
        minuteOffset = 0
        hourOffset = 0

        ' add and apply corrections to seconds
        newSeconds = dt1.Second + dt2.Second
        If (newSeconds >= 60) Then
            minuteOffset = newSeconds / 60
            newSeconds = newSeconds Mod 60
        End If

        ' add and apply corrections to minutes
        newMinutes = minuteOffset + (dt1.Minute + dt2.Minute)
        If (newMinutes >= 60) Then
            hourOffset = newMinutes / 60
            newMinutes = newMinutes Mod 60
        End If

        ' add and apply corrections to hours
        newHours = hourOffset + (dt1.Hour + dt2.Hour)

        ' apply correctional formatting to the string, a conditional operator would have been useful
        ' update to this 
        ' offsetTimeString = newHours.ToString + ":" + newMinutes.ToString + ":" + newSeconds.ToString
        If (newHours < 10) Then
            offsetTimeString = "0" + newHours.ToString
        Else
            offsetTimeString = newHours.ToString
        End If
        If (newMinutes < 10) Then
            offsetTimeString = offsetTimeString + ":0" + newMinutes.ToString
        Else
            offsetTimeString = offsetTimeString + ":" + newMinutes.ToString
        End If
        If (newSeconds < 10) Then
            offsetTimeString = offsetTimeString + ":0" + newSeconds.ToString
        Else
            offsetTimeString = offsetTimeString + ":" + newSeconds.ToString
        End If

        Return (offsetTimeString)
    End Function


    ' Function readFileData()
    ' created: 23-July-2007
    ' Author : Midhn Harikumar
    ' Desc   : Opens and reads the contents of a file
    ' Input  : string containing Filename of file to read
    ' returns: string containing the content of the file
    ' -------------------------------------------------------------
    Public Function readFileData(ByVal fileName As String) As String
        Dim rd As System.IO.StreamReader
        Dim buffer As String
        Try
            rd = New System.IO.StreamReader(fileName)
            buffer = rd.ReadToEnd
            rd.Close()
            Return buffer
        Catch ex As Exception
            MsgBox("An exception occured while reading the file " + fileName + Chr(13) + ex.Message, MsgBoxStyle.Critical, "Exception caught")
            Return ""
        End Try
    End Function


    ' Function textToHTML
    ' created: 23-July-2007
    ' Version: 2.0
    ' Author : midhun Harikumar
    ' Desc   : formats the text in a file to HTML by adding <br> after each line
    ' input  : string representing the filename
    ' returns: string containing the HTML code
    ' Update : 7:35 PM 1/19/2009 - Using Regular Expression to format the 
    '          input string instead of looping through each line
    ' -------------------------------------------------------
    Public Function textToHTML(ByVal str As String) As String
        Dim bLoopVar As Boolean = True
        Dim readBuffer As String = ""
        dim formattedString as String = ""
        Try
            Dim rd As System.IO.StreamReader = New System.IO.StreamReader(str)
            readBuffer = rd.ReadToEnd()
            
			Dim Pattern As String = "\n"			
			Dim Rgx As New Regex(Pattern)
			formattedString=Rgx.Replace(readBuffer, "<br/>")
	        rd.Close()
        Catch ex As Exception
            MsgBox("This project's Work history file '" + str + "' not found!" + (Chr(13)) + "Work History will not be added to report file.", MsgBoxStyle.Information, "File not found")
        End Try
        Return (formattedString)
    End Function

    ' function getHashedTime()
    ' Returns a hashed double equivalent of the date object
    '
    '--------------------------------------------------------
    Public Function getHashedTime(ByVal dt1 As Date) As Double
        Dim result As Double
        result = dt1.Second + (60 * dt1.Minute) + (3600 * dt1.Hour)
        Return result

    End Function

    'function getReleaseVersionString()
    'created : 31-Dec-2007
    '
    '--------------------------------------------------
    Public Function getReleaseVersionString(ByVal internalFormat As Double) As String
        Dim strInternalVersion As String = internalFormat.ToString
        Dim strReleaseVersion As String = ""
        Dim nCharCount As Integer = strInternalVersion.Length
        While (nCharCount > 0)
            nCharCount = nCharCount - 1
            strReleaseVersion = strInternalVersion.Chars(nCharCount) + "." + strReleaseVersion
        End While
        strReleaseVersion = strReleaseVersion.Substring(0, strReleaseVersion.Length - 1) ' removes the final .
        'MsgBox(strReleaseVersion) ' debug
        Return strReleaseVersion.ToString()
    End Function

    'function getMonthName()
    'created : 31-Dec-2007
    '
    '-------------------------------------------------------
    Public Function getMonthName(ByVal monthNumber As String) As String
        Select Case monthNumber
            Case 1 : Return ("January")
            Case 2 : Return ("February")
            Case 3 : Return ("March")
            Case 4 : Return ("April")
            Case 5 : Return ("May")
            Case 6 : Return ("June")
            Case 7 : Return ("July")
            Case 8 : Return ("August")
            Case 9 : Return ("September")
            Case 10 : Return ("October")
            Case 11 : Return ("November")
            Case 12 : Return ("December")
        End Select
        Return ""
    End Function
End Module
