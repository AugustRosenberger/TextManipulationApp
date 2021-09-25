<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextfileProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTextfileProject))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menstrTextManip = New System.Windows.Forms.MenuStrip()
        Me.tsmOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShiftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShiftBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtbTextWindow = New System.Windows.Forms.RichTextBox()
        Me.gbCounters = New System.Windows.Forms.GroupBox()
        Me.btnCountChar = New System.Windows.Forms.Button()
        Me.btnCountWord = New System.Windows.Forms.Button()
        Me.lblCoundChars = New System.Windows.Forms.Label()
        Me.lblCountWords = New System.Windows.Forms.Label()
        Me.tbCharCount = New System.Windows.Forms.TextBox()
        Me.tbWordCount = New System.Windows.Forms.TextBox()
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.lblANSI = New System.Windows.Forms.Label()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbAnsiEquiv = New System.Windows.Forms.TextBox()
        Me.tbStringIndex = New System.Windows.Forms.TextBox()
        Me.tbSearchTerm = New System.Windows.Forms.TextBox()
        Me.gbCharShift = New System.Windows.Forms.GroupBox()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.tbKey = New System.Windows.Forms.TextBox()
        Me.tbCharShift = New System.Windows.Forms.TextBox()
        Me.lblTextBox = New System.Windows.Forms.Label()
        Me.ofdPickFile = New System.Windows.Forms.OpenFileDialog()
        Me.tltpWordCount = New System.Windows.Forms.ToolTip(Me.components)
        Me.tltpCharCount = New System.Windows.Forms.ToolTip(Me.components)
        Me.tltpSearch = New System.Windows.Forms.ToolTip(Me.components)
        Me.tltpFindNext = New System.Windows.Forms.ToolTip(Me.components)
        Me.tltpKey = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menstrTextManip.SuspendLayout()
        Me.gbCounters.SuspendLayout()
        Me.gbSearch.SuspendLayout()
        Me.gbCharShift.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(502, 299)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'menstrTextManip
        '
        Me.menstrTextManip.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.menstrTextManip.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.menstrTextManip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOpenFile, Me.ShiftToolStripMenuItem, Me.ShiftBackToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.menstrTextManip.Location = New System.Drawing.Point(0, 0)
        Me.menstrTextManip.Name = "menstrTextManip"
        Me.menstrTextManip.Size = New System.Drawing.Size(1759, 49)
        Me.menstrTextManip.TabIndex = 1
        Me.menstrTextManip.Text = "Text Manipulation Tools:"
        '
        'tsmOpenFile
        '
        Me.tsmOpenFile.Name = "tsmOpenFile"
        Me.tsmOpenFile.Size = New System.Drawing.Size(218, 45)
        Me.tsmOpenFile.Text = "Open Text File"
        Me.tsmOpenFile.ToolTipText = "Click Here to Open a File"
        '
        'ShiftToolStripMenuItem
        '
        Me.ShiftToolStripMenuItem.Name = "ShiftToolStripMenuItem"
        Me.ShiftToolStripMenuItem.Size = New System.Drawing.Size(89, 45)
        Me.ShiftToolStripMenuItem.Text = "Shift"
        Me.ShiftToolStripMenuItem.ToolTipText = "Shift Your Text Based on Your Key"
        '
        'ShiftBackToolStripMenuItem
        '
        Me.ShiftBackToolStripMenuItem.Name = "ShiftBackToolStripMenuItem"
        Me.ShiftBackToolStripMenuItem.Size = New System.Drawing.Size(158, 45)
        Me.ShiftBackToolStripMenuItem.Text = "Shift Back"
        Me.ShiftBackToolStripMenuItem.ToolTipText = "Shift Back to Your Original Text Based on Your Key"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(87, 45)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        Me.EXITToolStripMenuItem.ToolTipText = "Exit The Application"
        '
        'rtbTextWindow
        '
        Me.rtbTextWindow.Location = New System.Drawing.Point(597, 110)
        Me.rtbTextWindow.Name = "rtbTextWindow"
        Me.rtbTextWindow.Size = New System.Drawing.Size(1105, 299)
        Me.rtbTextWindow.TabIndex = 2
        Me.rtbTextWindow.Text = ""
        '
        'gbCounters
        '
        Me.gbCounters.Controls.Add(Me.btnCountChar)
        Me.gbCounters.Controls.Add(Me.btnCountWord)
        Me.gbCounters.Controls.Add(Me.lblCoundChars)
        Me.gbCounters.Controls.Add(Me.lblCountWords)
        Me.gbCounters.Controls.Add(Me.tbCharCount)
        Me.gbCounters.Controls.Add(Me.tbWordCount)
        Me.gbCounters.Location = New System.Drawing.Point(54, 472)
        Me.gbCounters.Name = "gbCounters"
        Me.gbCounters.Size = New System.Drawing.Size(731, 292)
        Me.gbCounters.TabIndex = 3
        Me.gbCounters.TabStop = False
        Me.gbCounters.Text = "Count"
        '
        'btnCountChar
        '
        Me.btnCountChar.Location = New System.Drawing.Point(521, 220)
        Me.btnCountChar.Name = "btnCountChar"
        Me.btnCountChar.Size = New System.Drawing.Size(190, 51)
        Me.btnCountChar.TabIndex = 5
        Me.btnCountChar.Text = "Count Char"
        Me.tltpCharCount.SetToolTip(Me.btnCountChar, "Click Here to Count the Charecters in the Text")
        Me.btnCountChar.UseVisualStyleBackColor = True
        '
        'btnCountWord
        '
        Me.btnCountWord.Location = New System.Drawing.Point(521, 112)
        Me.btnCountWord.Name = "btnCountWord"
        Me.btnCountWord.Size = New System.Drawing.Size(190, 51)
        Me.btnCountWord.TabIndex = 4
        Me.btnCountWord.Text = "Count Words"
        Me.tltpWordCount.SetToolTip(Me.btnCountWord, "Click Here to Count the Words in the Document")
        Me.btnCountWord.UseVisualStyleBackColor = True
        '
        'lblCoundChars
        '
        Me.lblCoundChars.AutoSize = True
        Me.lblCoundChars.Location = New System.Drawing.Point(30, 169)
        Me.lblCoundChars.Name = "lblCoundChars"
        Me.lblCoundChars.Size = New System.Drawing.Size(299, 32)
        Me.lblCoundChars.TabIndex = 3
        Me.lblCoundChars.Text = "Number of Charecters:"
        '
        'lblCountWords
        '
        Me.lblCountWords.AutoSize = True
        Me.lblCountWords.Location = New System.Drawing.Point(30, 57)
        Me.lblCountWords.Name = "lblCountWords"
        Me.lblCountWords.Size = New System.Drawing.Size(242, 32)
        Me.lblCountWords.TabIndex = 2
        Me.lblCountWords.Text = "Number of Words:"
        '
        'tbCharCount
        '
        Me.tbCharCount.Location = New System.Drawing.Point(36, 220)
        Me.tbCharCount.Name = "tbCharCount"
        Me.tbCharCount.ReadOnly = True
        Me.tbCharCount.Size = New System.Drawing.Size(466, 38)
        Me.tbCharCount.TabIndex = 1
        '
        'tbWordCount
        '
        Me.tbWordCount.Location = New System.Drawing.Point(36, 112)
        Me.tbWordCount.Name = "tbWordCount"
        Me.tbWordCount.ReadOnly = True
        Me.tbWordCount.Size = New System.Drawing.Size(466, 38)
        Me.tbWordCount.TabIndex = 0
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.lblANSI)
        Me.gbSearch.Controls.Add(Me.lblIndex)
        Me.gbSearch.Controls.Add(Me.lblSearch)
        Me.gbSearch.Controls.Add(Me.btnFindNext)
        Me.gbSearch.Controls.Add(Me.btnSearch)
        Me.gbSearch.Controls.Add(Me.tbAnsiEquiv)
        Me.gbSearch.Controls.Add(Me.tbStringIndex)
        Me.gbSearch.Controls.Add(Me.tbSearchTerm)
        Me.gbSearch.Location = New System.Drawing.Point(838, 472)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(864, 292)
        Me.gbSearch.TabIndex = 4
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Search"
        '
        'lblANSI
        '
        Me.lblANSI.AutoSize = True
        Me.lblANSI.Location = New System.Drawing.Point(542, 169)
        Me.lblANSI.Name = "lblANSI"
        Me.lblANSI.Size = New System.Drawing.Size(230, 32)
        Me.lblANSI.TabIndex = 7
        Me.lblANSI.Text = "ANSI Equivalent:"
        '
        'lblIndex
        '
        Me.lblIndex.AutoSize = True
        Me.lblIndex.Location = New System.Drawing.Point(50, 169)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(279, 32)
        Me.lblIndex.TabIndex = 6
        Me.lblIndex.Text = "String Index of Word:"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(50, 57)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(234, 32)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "Search For Term:"
        '
        'btnFindNext
        '
        Me.btnFindNext.Location = New System.Drawing.Point(678, 99)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(168, 51)
        Me.btnFindNext.TabIndex = 4
        Me.btnFindNext.Text = "Find Next"
        Me.tltpFindNext.SetToolTip(Me.btnFindNext, "Click Here to Find the Next Instance of Your Term")
        Me.btnFindNext.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(468, 99)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(168, 51)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.tltpSearch.SetToolTip(Me.btnSearch, "Click Here to Search for a Spesific Term")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tbAnsiEquiv
        '
        Me.tbAnsiEquiv.Location = New System.Drawing.Point(458, 220)
        Me.tbAnsiEquiv.Name = "tbAnsiEquiv"
        Me.tbAnsiEquiv.ReadOnly = True
        Me.tbAnsiEquiv.Size = New System.Drawing.Size(388, 38)
        Me.tbAnsiEquiv.TabIndex = 2
        '
        'tbStringIndex
        '
        Me.tbStringIndex.Location = New System.Drawing.Point(22, 220)
        Me.tbStringIndex.Name = "tbStringIndex"
        Me.tbStringIndex.ReadOnly = True
        Me.tbStringIndex.Size = New System.Drawing.Size(388, 38)
        Me.tbStringIndex.TabIndex = 1
        '
        'tbSearchTerm
        '
        Me.tbSearchTerm.Location = New System.Drawing.Point(22, 112)
        Me.tbSearchTerm.Name = "tbSearchTerm"
        Me.tbSearchTerm.Size = New System.Drawing.Size(388, 38)
        Me.tbSearchTerm.TabIndex = 0
        '
        'gbCharShift
        '
        Me.gbCharShift.Controls.Add(Me.lblKey)
        Me.gbCharShift.Controls.Add(Me.tbKey)
        Me.gbCharShift.Controls.Add(Me.tbCharShift)
        Me.gbCharShift.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbCharShift.Location = New System.Drawing.Point(54, 812)
        Me.gbCharShift.Name = "gbCharShift"
        Me.gbCharShift.Size = New System.Drawing.Size(1648, 292)
        Me.gbCharShift.TabIndex = 4
        Me.gbCharShift.TabStop = False
        Me.gbCharShift.Text = "Charecter Shifting"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(1503, 77)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(72, 32)
        Me.lblKey.TabIndex = 2
        Me.lblKey.Text = "Key:"
        '
        'tbKey
        '
        Me.tbKey.Location = New System.Drawing.Point(1450, 136)
        Me.tbKey.Name = "tbKey"
        Me.tbKey.Size = New System.Drawing.Size(180, 38)
        Me.tbKey.TabIndex = 1
        Me.tltpKey.SetToolTip(Me.tbKey, "Enter Your Key Here")
        '
        'tbCharShift
        '
        Me.tbCharShift.Location = New System.Drawing.Point(36, 51)
        Me.tbCharShift.Multiline = True
        Me.tbCharShift.Name = "tbCharShift"
        Me.tbCharShift.ReadOnly = True
        Me.tbCharShift.Size = New System.Drawing.Size(1384, 218)
        Me.tbCharShift.TabIndex = 0
        '
        'lblTextBox
        '
        Me.lblTextBox.AutoSize = True
        Me.lblTextBox.Location = New System.Drawing.Point(1028, 75)
        Me.lblTextBox.Name = "lblTextBox"
        Me.lblTextBox.Size = New System.Drawing.Size(241, 32)
        Me.lblTextBox.TabIndex = 6
        Me.lblTextBox.Text = "Text From .txt FIle"
        '
        'ofdPickFile
        '
        Me.ofdPickFile.InitialDirectory = "C:\Users\ar070\OneDrive\Desktop"
        '
        'tltpWordCount
        '
        Me.tltpWordCount.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'tltpCharCount
        '
        Me.tltpCharCount.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'tltpSearch
        '
        Me.tltpSearch.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'tltpFindNext
        '
        Me.tltpFindNext.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'tltpKey
        '
        Me.tltpKey.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmTextfileProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1759, 1171)
        Me.Controls.Add(Me.lblTextBox)
        Me.Controls.Add(Me.gbCharShift)
        Me.Controls.Add(Me.gbSearch)
        Me.Controls.Add(Me.gbCounters)
        Me.Controls.Add(Me.rtbTextWindow)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.menstrTextManip)
        Me.MainMenuStrip = Me.menstrTextManip
        Me.Name = "frmTextfileProject"
        Me.Text = "Text Manipulation"
        Me.tltpKey.SetToolTip(Me, "Enter Your Key Here")
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menstrTextManip.ResumeLayout(False)
        Me.menstrTextManip.PerformLayout()
        Me.gbCounters.ResumeLayout(False)
        Me.gbCounters.PerformLayout()
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.gbCharShift.ResumeLayout(False)
        Me.gbCharShift.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents menstrTextManip As System.Windows.Forms.MenuStrip
    Friend WithEvents ShiftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShiftBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtbTextWindow As System.Windows.Forms.RichTextBox
    Friend WithEvents gbCounters As System.Windows.Forms.GroupBox
    Friend WithEvents btnCountChar As System.Windows.Forms.Button
    Friend WithEvents btnCountWord As System.Windows.Forms.Button
    Friend WithEvents lblCoundChars As System.Windows.Forms.Label
    Friend WithEvents lblCountWords As System.Windows.Forms.Label
    Friend WithEvents tbCharCount As System.Windows.Forms.TextBox
    Friend WithEvents tbWordCount As System.Windows.Forms.TextBox
    Friend WithEvents gbSearch As System.Windows.Forms.GroupBox
    Friend WithEvents gbCharShift As System.Windows.Forms.GroupBox
    Friend WithEvents lblTextBox As System.Windows.Forms.Label
    Friend WithEvents tsmOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdPickFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblANSI As System.Windows.Forms.Label
    Friend WithEvents lblIndex As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnFindNext As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tbAnsiEquiv As System.Windows.Forms.TextBox
    Friend WithEvents tbStringIndex As System.Windows.Forms.TextBox
    Friend WithEvents tbSearchTerm As System.Windows.Forms.TextBox
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents tbKey As System.Windows.Forms.TextBox
    Friend WithEvents tbCharShift As System.Windows.Forms.TextBox
    Friend WithEvents tltpCharCount As System.Windows.Forms.ToolTip
    Friend WithEvents tltpWordCount As System.Windows.Forms.ToolTip
    Friend WithEvents tltpFindNext As System.Windows.Forms.ToolTip
    Friend WithEvents tltpSearch As System.Windows.Forms.ToolTip
    Friend WithEvents tltpKey As System.Windows.Forms.ToolTip

End Class
