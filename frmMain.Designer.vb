<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTileCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAverageUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlbTools = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.mnuStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextEditorTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMenu.SuspendLayout()
        Me.tlbTools.SuspendLayout()
        Me.mnuStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuWindows, Me.mnuHelp})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.MdiWindowListItem = Me.mnuWindows
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(632, 24)
        Me.mnuMenu.TabIndex = 5
        Me.mnuMenu.Text = "Menu Strip"
        Me.TextEditorTips.SetToolTip(Me.mnuMenu, "Usefull commands for you to use.")
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.ToolStripSeparator3, Me.mnuSave, Me.mnuSaveAs, Me.ToolStripSeparator5, Me.mnuClose, Me.mnuExit})
        Me.mnuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "Click to open a list of commands for this program."
        '
        'mnuNew
        '
        Me.mnuNew.Image = CType(resources.GetObject("mnuNew.Image"), System.Drawing.Image)
        Me.mnuNew.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNew.Size = New System.Drawing.Size(146, 22)
        Me.mnuNew.Text = "&New"
        Me.mnuNew.ToolTipText = "Click to create a new document."
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = CType(resources.GetObject("mnuOpen.Image"), System.Drawing.Image)
        Me.mnuOpen.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(146, 22)
        Me.mnuOpen.Text = "&Open"
        Me.mnuOpen.ToolTipText = "Click to open a file."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(146, 22)
        Me.mnuSave.Text = "&Save"
        Me.mnuSave.ToolTipText = "Click to save the current file."
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(146, 22)
        Me.mnuSaveAs.Text = "Save &As"
        Me.mnuSaveAs.ToolTipText = "Click to save the file with more options."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(143, 6)
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(146, 22)
        Me.mnuClose.Text = "&Close"
        Me.mnuClose.ToolTipText = "Click to close the current document."
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuExit.Text = "E&xit"
        Me.mnuExit.ToolTipText = "Click to exit the program."
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuCut, Me.mnuPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.ToolTipText = "Click to open a list of commands to edit the text."
        '
        'mnuCopy
        '
        Me.mnuCopy.Image = CType(resources.GetObject("mnuCopy.Image"), System.Drawing.Image)
        Me.mnuCopy.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(144, 22)
        Me.mnuCopy.Text = "&Copy"
        Me.mnuCopy.ToolTipText = "Click to copy all currently selected text."
        '
        'mnuCut
        '
        Me.mnuCut.Image = CType(resources.GetObject("mnuCut.Image"), System.Drawing.Image)
        Me.mnuCut.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(144, 22)
        Me.mnuCut.Text = "Cu&t"
        Me.mnuCut.ToolTipText = "Click to copy and erase all currently selected text."
        '
        'mnuPaste
        '
        Me.mnuPaste.Image = CType(resources.GetObject("mnuPaste.Image"), System.Drawing.Image)
        Me.mnuPaste.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(144, 22)
        Me.mnuPaste.Text = "&Paste"
        Me.mnuPaste.ToolTipText = "Click to paste any previously copied text into the current position in the text e" &
    "ditor."
        '
        'mnuWindows
        '
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTileCascade, Me.mnuTileVertical, Me.mnuTileHorizontal, Me.mnuAverageUnits})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(68, 20)
        Me.mnuWindows.Text = "&Windows"
        Me.mnuWindows.ToolTipText = "Click to open a menu to manage the windows or open the Average Units Shipped prog" &
    "ram."
        '
        'mnuTileCascade
        '
        Me.mnuTileCascade.Name = "mnuTileCascade"
        Me.mnuTileCascade.Size = New System.Drawing.Size(150, 22)
        Me.mnuTileCascade.Text = "&Cascade"
        Me.mnuTileCascade.ToolTipText = "Click to cascade all the active tiles."
        '
        'mnuTileVertical
        '
        Me.mnuTileVertical.Name = "mnuTileVertical"
        Me.mnuTileVertical.Size = New System.Drawing.Size(150, 22)
        Me.mnuTileVertical.Text = "Tile &Vertical"
        Me.mnuTileVertical.ToolTipText = "Click to align all the active tiles vertically."
        '
        'mnuTileHorizontal
        '
        Me.mnuTileHorizontal.Name = "mnuTileHorizontal"
        Me.mnuTileHorizontal.Size = New System.Drawing.Size(150, 22)
        Me.mnuTileHorizontal.Text = "Tile &Horizontal"
        Me.mnuTileHorizontal.ToolTipText = "Click to align all the active tiles horizontally."
        '
        'mnuAverageUnits
        '
        Me.mnuAverageUnits.Name = "mnuAverageUnits"
        Me.mnuAverageUnits.Size = New System.Drawing.Size(150, 22)
        Me.mnuAverageUnits.Text = "Average &Units"
        Me.mnuAverageUnits.ToolTipText = "Click to open the Average Units Shipped program."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "Click to open a list of helpfull items."
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(119, 22)
        Me.mnuAbout.Text = "&About ..."
        Me.mnuAbout.ToolTipText = "Click to see information about this program."
        '
        'tlbTools
        '
        Me.tlbTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnOpen, Me.btnSave})
        Me.tlbTools.Location = New System.Drawing.Point(0, 24)
        Me.tlbTools.Name = "tlbTools"
        Me.tlbTools.Size = New System.Drawing.Size(632, 25)
        Me.tlbTools.TabIndex = 6
        Me.tlbTools.Text = "ToolStrip"
        Me.TextEditorTips.SetToolTip(Me.tlbTools, "Quick buttons for some common tools for you to use.")
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "&New"
        Me.btnNew.ToolTipText = "Click to create a new document."
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(23, 22)
        Me.btnOpen.Text = "&Open"
        Me.btnOpen.ToolTipText = "Click to open a file."
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "&Save"
        Me.btnSave.ToolTipText = "Click to save the current file."
        '
        'mnuStatus
        '
        Me.mnuStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.mnuStatus.Location = New System.Drawing.Point(0, 431)
        Me.mnuStatus.Name = "mnuStatus"
        Me.mnuStatus.Size = New System.Drawing.Size(632, 22)
        Me.mnuStatus.TabIndex = 7
        Me.mnuStatus.Text = "Status"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.tlbTools)
        Me.Controls.Add(Me.mnuMenu)
        Me.Controls.Add(Me.mnuStatus)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.TextEditorTips.SetToolTip(Me, "This program allows you to open or create text documents or the Average Units Shi" &
        "pped program. ")
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.tlbTools.ResumeLayout(False)
        Me.tlbTools.PerformLayout()
        Me.mnuStatus.ResumeLayout(False)
        Me.mnuStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWindows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTileCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTileVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTileHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextEditorTips As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbTools As System.Windows.Forms.ToolStrip
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuAverageUnits As ToolStripMenuItem
End Class
