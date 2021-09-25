Public Class frmTextfileProject
    '       August Rosenberger
    '       CPT 341
    '       Fall 2020 NJIT
    '       Oct / 9 / 2020

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsmOpenFile.Click
        '---------------file picking and writing to rich text box-------------------------------------------------------------

        Dim fileContent As String

        ofdPickFile.ShowDialog()

        Dim file As IO.StreamReader = IO.File.OpenText(ofdPickFile.FileName)

        Do While file.Peek <> -1
            fileContent = file.ReadLine
        Loop

        rtbTextWindow.Text = fileContent

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCountChar_Click(sender As Object, e As EventArgs) Handles btnCountChar.Click
        '--------------------Counting Charecters in text box-----------------------------------------------------------------------------------------------------------------------
        Dim charCount As Integer
        charCount = rtbTextWindow.TextLength
        tbCharCount.Text = charCount


    End Sub

    Private Sub btnCountWord_Click(sender As Object, e As EventArgs) Handles btnCountWord.Click
        '----------------------Counting number of words in text box---------------------------------------------------------------------------------
        Dim charcount As Integer
        Dim spaceCount As Integer
        Dim textBox As String
        textBox = rtbTextWindow.Text

        charcount = rtbTextWindow.TextLength
        For Each word As String In Split(textBox, " ")
            spaceCount += 1
        Next

        spaceCount += 2

        tbWordCount.Text = spaceCount

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        '------------Search for word in search box-------------------------------
        rtbTextWindow.SelectionBackColor = Color.White
        tbAnsiEquiv.Text = ""


        rtbTextWindow.Find(tbSearchTerm.Text, RichTextBoxFinds.WholeWord)
        rtbTextWindow.SelectionBackColor = Color.Aquamarine
        tbStringIndex.Text = rtbTextWindow.Text.IndexOf(tbSearchTerm.Text)

        Dim term(tbSearchTerm.TextLength) As String

        Dim ansi As String


        For i = 0 To tbSearchTerm.Text.Length - 1
            term(i) = tbSearchTerm.Text.Substring(i, 1)


            ansi = Asc(term(i))
            tbAnsiEquiv.Text = tbAnsiEquiv.Text + ansi + " "
        Next

    End Sub

    Private Sub btnFindNext_Click(sender As Object, e As EventArgs) Handles btnFindNext.Click
        'Dim nextChunk As String
        'nextChunk = rtbTextWindow.Text.Substring(CInt(tbStringIndex.Text))
        Dim currentIndex As Integer
        currentIndex = CInt(tbStringIndex.Text)
        Dim termLen As Integer
        termLen = tbSearchTerm.Text.Length
        Dim startFrom As Integer
        startFrom = termLen + currentIndex


        rtbTextWindow.Find(tbSearchTerm.Text, startFrom, RichTextBoxFinds.WholeWord)
        rtbTextWindow.SelectionBackColor = Color.Aquamarine
        tbStringIndex.Text = rtbTextWindow.Text.IndexOf(tbSearchTerm.Text, startFrom)

        If CInt(tbStringIndex.Text) = -1 Then
            MsgBox("You have found all instances of this term in the text file.")
        End If


    End Sub

    Private Sub ShiftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShiftToolStripMenuItem.Click
        If tbKey.Text.Length >= 1 Then
            Dim keyAry(rtbTextWindow.Text.Length) As Integer

            Dim iteration As Integer
            Dim charecter As String
            Dim ansiChar As Integer
            Dim newChar As Integer

            '----populate key array--------------------------------------------------------------------------------------
            For i = 0 To rtbTextWindow.Text.Length - 1
                iteration = i Mod tbKey.Text.Length

                keyAry(i) = CInt(tbKey.Text.Substring(iteration, 1))
            Next

            tbCharShift.Text = ""


            '------perform char shiftig---------------------------------------------------------------------
            For i = 0 To rtbTextWindow.Text.Length - 1
                ansiChar = Asc(rtbTextWindow.Text.Substring(i, 1))
                newChar = ansiChar + keyAry(i)
                charecter = Chr(newChar)
                tbCharShift.Text = tbCharShift.Text + charecter
            Next




        else
            MsgBox("KEY REQUIRED")
        End If

    End Sub

    Private Sub ShiftBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShiftBackToolStripMenuItem.Click

        If tbKey.Text.Length >= 1 Then
            Dim keyAry(rtbTextWindow.Text.Length) As Integer
            Dim tempAry(rtbTextWindow.Text.Length) As String

            Dim iteration As Integer
            Dim charecter As String
            Dim ansiChar As Integer
            Dim newChar As Integer

            '----populate key array--------------------------------------------------------------------------------------
            For i = 0 To rtbTextWindow.Text.Length - 1
                iteration = i Mod tbKey.Text.Length

                keyAry(i) = CInt(tbKey.Text.Substring(iteration, 1))
            Next

            '------perform char shiftig---------------------------------------------------------------------
            For i = 0 To rtbTextWindow.Text.Length - 1
                ansiChar = Asc(tbCharShift.Text.Substring(i, 1))
                newChar = ansiChar - keyAry(i)
                charecter = Chr(newChar)
                tempAry(i) = charecter
            Next
            '----reset shifted textbox---------------------------------------------------------------------
            tbCharShift.Text = ""
            '-----fill with un-shifted values--------------------------------------------------------------------
            For i = 0 To rtbTextWindow.Text.Length - 1
                tbCharShift.Text = tbCharShift.Text + tempAry(i)
            Next



        Else
            MsgBox("KEY REQUIRED")
        End If


    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Close()
    End Sub
End Class
