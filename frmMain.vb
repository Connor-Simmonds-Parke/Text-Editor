'Name: Connor Simmonds-Parke
'Student ID: 100344939
'Course: NETD - 2202
'Project: MDITextEditor
'Date: April 18, 2018
'Description: This program is a modified text editor that allows multiple documents to be open
'             at once. The Average Units Shipped program can also be opened within the program.
'             This program also contains a few tools to arrange the windows, edit the document(s)
'             or save/close the documents. Uses the child form frmTextEditor to open .txt documents.


Option Strict On

Imports System.Windows.Forms

Public Class frmMain

    ''' <summary>
    ''' Opens a new blank document using the frmTextEditor child class when the new button is clicked.
    ''' </summary>
    Private Sub NewForm(ByVal sender As Object, ByVal e As EventArgs) Handles mnuNew.Click, btnNew.Click

        'DECLARATIONS
        Dim frmTextEditor As New frmTextEditor 'Creates a new class object of the child text editor.

        frmTextEditor.MdiParent = Me 'Sets the object's parent to the main form.
        frmTextEditor.Show() 'Shows the object.

    End Sub

    ''' <summary>
    ''' Opens a file when the open button is clicked, only allows .txt files. 
    ''' </summary>
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles mnuOpen.Click, btnOpen.Click

        'DECLARATIONS
        Dim openFileDialog As New OpenFileDialog 'Creates a new Open File Dialog.
        Dim frmTextEditor As frmTextEditor 'Creates an object of the text editor class.

        openFileDialog.Filter = "Text Files (*.txt)|*.txt" 'Only allows .txt files to be opened.

        If (openFileDialog.ShowDialog(Me) = DialogResult.OK) Then 'If the user clicks okay to open a file.

            frmTextEditor = New frmTextEditor 'Creates a new instance of the text editor child form.
            frmTextEditor.OpenFileChild(openFileDialog.FileName) 'Calls to the open file function from the text editor child form.
            frmTextEditor.MdiParent = Me
            frmTextEditor.Show()

        End If

    End Sub

    ''' <summary>
    ''' Opens the Average Units Shipped program when clicked.
    ''' </summary>
    Private Sub mnuAverageUnits_Click(sender As Object, e As EventArgs) Handles mnuAverageUnits.Click

        'DECLARATIONS
        Dim frmAverageUnitsShipped As New frmAverageUnitsShipped 'Creates a new object of the child class.

        frmAverageUnitsShipped.MdiParent = Me
        frmAverageUnitsShipped.Show()

    End Sub

    ''' <summary>
    ''' Checks to see if the file is a text document. If it is, allows the user to save the file
    ''' automatically, if it exists, or select a name and destination to save if not.
    ''' </summary>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click, mnuSave.Click

        If (Not ActiveMdiChild Is Nothing) Then 'As long as there is a document open.

            If (ActiveMdiChild.GetType Is GetType(FinalTextEditor.frmTextEditor)) Then 'If the active form is a text editor class.

                Dim frmTextEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor) 'Sets a variable to hold the current active form as the text editor class.

                If (frmTextEditor.FileExists = True) Then 'Calls to the function in frmTextEditor that checks to see if the file currently exists on the hard drive.

                    frmTextEditor.SaveFile(frmTextEditor.FullFilePathChild) 'Calls to the function in frmTextEditor that saves the document.

                Else 'If the file does not exist yet.

                    SaveAs(frmTextEditor) 'Calls to the SaveAs function that opens a save dialog so the user can choose the name and location to save the file as.

                End If

            End If

        End If

    End Sub

    ''' <summary>
    ''' Nearly identical to the btnSave_click except it always opens the save dialog to allow
    ''' the user to set the name and location they want for the file.
    ''' </summary>
    Private Sub SaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuSaveAs.Click

        If (Not ActiveMdiChild Is Nothing) Then 'As long as there is an active child form.

            If (ActiveMdiChild.GetType Is GetType(FinalTextEditor.frmTextEditor)) Then 'If the form is a text editor type.

                Dim frmTextEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)
                SaveAs(frmTextEditor) 'Saves the form through a save dialog.

            End If

        End If

    End Sub

    ''' <summary>
    ''' Closes the program when pressed.
    ''' </summary>
    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Me.Close() 'Closes the program (There is code that handles the form closing).


    End Sub

    ''' <summary>
    ''' Copies the current selected text when clicked.
    ''' </summary>
    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click

        Dim frmTextEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

        frmTextEditor.Copy() 'Calls to the text editor child function that copies the currently selected text.

    End Sub

    ''' <summary>
    ''' Copies then deletes the current selected text when clicked.
    ''' </summary>
    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click

        Dim frmTextEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

        frmTextEditor.Cut() 'Calls to the text editor child function that copies and then deletes the currently selected text.

    End Sub

    ''' <summary>
    ''' Pastes any saved text to the currently selected location when clicked.
    ''' </summary>
    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click

        Dim frmTextEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

        frmTextEditor.Paste() 'Calls to the text editor child function that pastes any saved text into the current selected location.

    End Sub

    ''' <summary>
    ''' When clicked, sets the layout of all the current child forms in a cascade style.
    ''' </summary>
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTileCascade.Click

        Me.LayoutMdi(MdiLayout.Cascade) 'Layers all current child forms in a cascade style.

    End Sub

    ''' <summary>
    ''' When clicked, sets the layout of all the current child forms in a vertical style.
    ''' </summary>
    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTileVertical.Click

        Me.LayoutMdi(MdiLayout.TileVertical) 'Layers all current child forms in a veritcal style.

    End Sub

    ''' <summary>
    ''' When clicked, sets the layout of all the current child forms in a horizontal style.
    ''' </summary>
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTileHorizontal.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal) 'Layers all current child forms in a horizontal style.

    End Sub

    ''' <summary>
    ''' Closes the current active child form when clicked. If the form is a text editor and has any
    ''' unsaved changes, it will prompt the user of this fact and give them a choice to close without
    ''' saving or not.
    ''' </summary>
    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click

        If (Not ActiveMdiChild Is Nothing) Then 'If there is an active child form.

            If (ActiveMdiChild.GetType Is GetType(FinalTextEditor.frmAverageUnitsShipped)) Then 'If the active form is a the Average Units Shipped program.

                ActiveMdiChild.Close() 'Closes the form.

            Else 'If the form is a text editor.

                Dim frmTextEditor As frmTextEditor = CType(Me.ActiveMdiChild, frmTextEditor)

                If (frmTextEditor.AskToSave = False) Then 'Uses the text editor child function to check if the file has been changed, if it hasn't.

                    ActiveMdiChild.Close() 'Closes the form.

                Else 'If the file does have unsaved changes.

                    If (UnsavedChanges() = True) Then 'Calls to the function that brings up a messagebox choice to close the program or not, if they do choose to close.

                        ActiveMdiChild.Close() 'Closes the form.

                    End If

                End If

            End If

        End If

    End Sub

    ''' <summary>
    ''' A sub routine that creates a save dialog and calls upon the text editor child function
    ''' that saves the current document.
    ''' </summary>
    Private Sub SaveAs(frmTextEditor As frmTextEditor)

        'DECLARATIONS
        Dim saveDialog As New SaveFileDialog

        saveDialog.Filter = "Text Files (*.txt)|*.txt" 'Only allows .txt files.

        If (saveDialog.ShowDialog(Me) = DialogResult.OK) Then 'If the user clicks okay to save the file.

            frmTextEditor.SaveFile(saveDialog.FileName) 'Saves the file.

        End If

    End Sub

    ''' <summary>
    ''' Creates a dialog check to see if the user wants to close the main program or not, when there are any
    ''' unsaved changes. Returns a true or false boolean value depending on the user's choice.
    ''' </summary>
    Private Function UnsavedChanges() As Boolean

        'DECLARATIONS
        Dim dialogResult As DialogResult
        Dim result As Boolean = False 'Boolean variable to hold the user's choice to close the program or not.

        dialogResult = MessageBox.Show("You have unsaved changes to your document(s). Exit without saving?", "Unsaved Changes", MessageBoxButtons.OKCancel)

        If (dialogResult = DialogResult.OK) Then 'If the user clicks okay to close the program without saving.

            result = True

        End If

        Return result 'Returns the result of the user's chhoice.

    End Function

    ''' <summary>
    ''' This routine happens when the main form is closing through any method. If there are any unsaved
    ''' changes to a text editor document, then it will prompt the user with a question to close without
    ''' saving or not to close.
    ''' </summary>
    Private Sub frmMain_formClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'DECLARATIONS
        Dim unsavedChangeStatus As Integer = 0 'Variable to hold whether there are any forms with unsaved changes, 0 for no.

        For Each form As Form In MdiChildren 'Loops through each open child form.

            If (form.GetType Is GetType(FinalTextEditor.frmTextEditor)) Then 'If the form is a text editor.

                Dim currentForm As frmTextEditor = CType(form, frmTextEditor)

                If (currentForm.AskToSave = True) Then 'Checks to see if the form has any unsaved changes, if they do.

                    unsavedChangeStatus = 1 'The user has at least one unsaved change, sets the variable that holds the status to 1.

                End If

            End If

        Next form

        If (unsavedChangeStatus = 1) Then 'If there is at least one unsaved change to a text editor form.

            If (UnsavedChanges() = True) Then 'Calls to the function that asks the user if they want to close with unsaved changes.

                Me.Dispose() 'Closes the program.

            Else 'If they don't want to close the program with unsaved changes.

                e.Cancel = True 'Stops the program from closing.

            End If

        Else 'If there are no unsaved changes.

            Me.Dispose() 'Closes the program.

        End If

    End Sub

    ''' <summary>
    ''' Shows a messagebox that displays some info about the program when clicked.
    ''' </summary>
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click

        MessageBox.Show("NETD-2202" & vbCrLf & vbCrLf & "Final Project" & vbCrLf & vbCrLf & "C. Simmonds-Parke")

    End Sub

End Class
