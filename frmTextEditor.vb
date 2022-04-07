'Name: Connor Simmonds-Parke
'Student ID: 100344939
'Course: NETD - 2202
'Project: TextEditor
'Date: April 3, 2018
'Description: A text editor that allows the user to create a new text document, save it or open a different
'             text document. Within the program, the user can cut, copy or paste text into or out of the program.
'Modified On: April 17, 2018
'Modified:  Added as a child form for MDITextEditor.
'           Removed buttons And menu items that were no longer needed along with their event handlers.
'           Changed cut, paste and copy click events into friend sub routines.
'           Changed SaveFile and OpenFile sub routines slightly.
'           Added three new friend functions/sub routines (bottom three).

Option Strict On

Imports System.IO 'For file saving/opening.

Public Class frmTextEditor

    'GLOBAL DECLARATIONS
    Dim fullFilePath As String 'String to hold the file path of the text document (if it exists).
    Dim originalFile As String = String.Empty

    ''' <summary>
    ''' Sub that creates a FileStream using the file path and sets the mode and access to create and write.
    ''' Once the FileStream is created, creates a StreamWriter using the parameters from the FileStream and then
    ''' writes the output (text/value in the textbox) to the new file.
    ''' </summary>
    Friend Sub SaveFile(fullFilePathInput As String)

        ''DECLARATIONS
        Const userAction As String = "Save"

        Dim fileStream As New FileStream(fullFilePathInput, FileMode.Create, FileAccess.Write)
        Dim writeStream As New StreamWriter(fileStream)
        Dim output As String = txtInput.Text

        fullFilePath = fullFilePathInput
        writeStream.Write(output)
        writeStream.Close()
        originalFile = output
        DynamicTitle(userAction)

    End Sub

    ''' <summary>
    ''' Function similar to SaveFile but instead reads the values of the file, saves them to a variable
    ''' and then returns that variable back to the calling code.
    ''' </summary>
    Private Function OpenFile(filePath As String) As String

        'DECLARATIONS
        Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim fileContent As String = String.Empty 'String to hold the text/values of the file to be opened.
        Dim readStream As New StreamReader(fileStream)

        fileContent = readStream.ReadToEnd() 'Reads the whole file and saves the text/values to the variable.
        readStream.Close()
        originalFile = fileContent

        Return fileContent 'Returns the variable that holds the values/text from the opened file.

    End Function

    Friend Sub Copy()

        'DECLARATIONS
        Const userAction As String = "Copy"

        My.Computer.Clipboard.SetText(txtInput.SelectedText) 'Saves the selected text to the user's clipboard.
        DynamicTitle(userAction)

    End Sub

    Friend Sub Cut()

        'DECLARATIONS
        Const userAction As String = "Cut"

        My.Computer.Clipboard.SetText(txtInput.SelectedText) 'Saves the selected text to the user's clipboard.
        txtInput.SelectedText = String.Empty 'Deletes the selected text.
        DynamicTitle(userAction)

    End Sub

    Friend Sub Paste()

        ''DECLARATIONS
        Const userAction As String = "Paste"

        txtInput.SelectedText = My.Computer.Clipboard.GetText() 'Inserts any text in the user's clipboard at the selected location.
        DynamicTitle(userAction)

    End Sub

    ''' <summary>
    ''' A function to change the title of the form to the file location and the action the user is doing.
    ''' </summary>
    Private Sub DynamicTitle(userAction As String)

        Me.Text = "Text Editor " & fullFilePath & " " & userAction

    End Sub

    Friend Function AskToSave() As Boolean

        'DECLARATIONS
        Dim needSave As Boolean = False

        If (txtInput.Text <> originalFile) Then

            AskToSave = True

        End If

        Return AskToSave

    End Function

    Friend Sub OpenFileChild(filePath As String)

        ''DECLARATIONS
        Const userAction As String = "Open"

        Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim fileContent As String = String.Empty 'String to hold the text/values of the file to be opened.
        Dim readStream As New StreamReader(fileStream)


        fileContent = readStream.ReadToEnd() 'Reads the whole file and saves the text/values to the variable.
        readStream.Close()
        originalFile = fileContent
        txtInput.Text = fileContent
        fullFilePath = filePath

        DynamicTitle(userAction)

    End Sub

    Friend ReadOnly Property FullFilePathChild() As String

        Get

            Return fullFilePath

        End Get

    End Property

    Friend Function FileExists() As Boolean

        Dim result As Boolean = True

        If (File.Exists(fullFilePath) = False) Then

            result = False

        End If

        Return result

    End Function

End Class
