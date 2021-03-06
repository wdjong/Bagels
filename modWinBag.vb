'this is an adaption of a creative computing game
'converted from vb6 to vb.net for educational purposes
'It's like the commercial Mastermind game
Option Strict Off
Option Explicit On
Module modWinBag
	
    Public Const MaxGuess As Integer = 10 '0-9 guesses
    Public Const MaxNum As Integer = 10 '0-9 symbols used in array

    Public curGuess As Integer 'guess number

    Function CGuess() As Integer
        'return the first value that is consistent with evidence
        Dim gd As Integer 'guess
        'Dim cg As Integer 'curGuess
        'Dim possible As Boolean

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        CGuess = 10 ^ My.Settings.Columns 'an impossible value
        For gd = 0 To 10 ^ My.Settings.Columns - 1 'Check each number 2 columns 0 - 99
            If IsPossible(gd) Then
                CGuess = gd
                Exit For
            End If
        Next gd
        If CGuess = 10 ^ My.Settings.Columns Then
            MsgBox("That's impossible!")
        End If
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Function

    Function CGuessRandom() As Integer
        'return a random value that is consistent with evidence
        Dim failSafe As Integer
        Dim aCode As Integer

        aCode = Int(10 ^ My.Settings.Columns * Rnd())
        Do While Not (IsPossible(aCode)) And failSafe < 1000
            aCode = Int(10 ^ My.Settings.Columns * Rnd())
            failSafe += 1
        Loop
        If failSafe >= 10000 Then
            CGuessRandom = CGuess()
        Else
            CGuessRandom = aCode
        End If
    End Function

    Function IsConsistent(ByRef aGuess As Integer, ByRef aGuessNum As Integer) As Boolean
        'If this guess is possibly the right code it will produce the same output (fermi and pico) that the actual code did for THIS guess turn number (i.e. do this for all guesses to this point)
        Dim aPico As Integer
        Dim afermi As Integer

        IsConsistent = True
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            StackCode(0) 'save actual code
            SetCode(aGuess) 'replace it with aGuess (assuming it is correct)
            afermi = CountFermi(aGuessNum) 'if aGuess was the code and aGuessNum was evaluated how many with correct place and number
            If CDbl(.FD(aGuessNum).Text) <> afermi Then 'if that isn't consistent with the result we did get with respect to the real code then this aguess can't be right
                IsConsistent = False
            Else 'fermi consistent
                aPico = CountPico(aGuessNum) - afermi
                If CDbl(.PD(aGuessNum).Text) <> aPico Then
                    IsConsistent = False
                End If
            End If
            StackCode(1) 'pop code
        End With
    End Function

    Function IsPossible(aGuess As Integer) As Boolean
        Dim possible As Boolean
        Dim guessTurnNumber As Integer

        IsPossible = False
        If IsValidCode(aGuess) Then 'check only legal numbers used
            possible = True 'assume guess is ok
            guessTurnNumber = 0 'current guess turn number
            Do While possible And guessTurnNumber < curGuess 'curGuess is where the currentGuessTurnNumber
                If Not IsConsistent(aGuess, guessTurnNumber) Then
                    possible = False 'didn't pass
                Else
                    guessTurnNumber += 1 ' = cg + 1 'check next guess turn
                End If
            Loop
            If possible Then 'passed all tests
                IsPossible = True
            End If
        End If
    End Function

    Function IsValidCode(ByVal aCode As Integer) As Boolean
        'return true if code passed contains no ill eagle characters
        Dim strCode As String
        Dim i As Byte

        IsValidCode = True
        strCode = aCode.ToString("00000")
        For i = My.Settings.Numbers To 9 'Check for digits not in play
            If strCode.Contains(i.ToString) Then
                IsValidCode = False
                Exit Function
            End If
        Next i
    End Function

    Sub SetCode(ByRef aCode As Integer)
        'put a value in the code fields (if temporary call StackCode(0) first)
        Dim strCode As String

        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            strCode = aCode.ToString("00000")
            .Cod1.Text = Mid(strCode, 5, 1)
            .Cod2.Text = Mid(strCode, 4, 1)
            .Cod3.Text = Mid(strCode, 3, 1)
            .Cod4.Text = Mid(strCode, 2, 1)
            .Cod5.Text = Mid(strCode, 1, 1)
        End With
    End Sub

    Sub StackCode(ByRef action As Integer)
        'store the values of the code in c1 ... c5 (so that they don't get changed by some routines)
        Static c1 As String
        Static c2 As String
        Static c3 As String
        Static c4 As String
        Static c5 As String

        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            Select Case action
                Case 0 'push
                    c1 = .Cod1.Text
                    c2 = .Cod2.Text
                    c3 = .Cod3.Text
                    c4 = .Cod4.Text
                    c5 = .Cod5.Text
                Case 1 'pop
                    .Cod1.Text = c1
                    .Cod2.Text = c2
                    .Cod3.Text = c3
                    .Cod4.Text = c4
                    .Cod5.Text = c5
            End Select
        End With
    End Sub

    Sub ChooseRnd()
        Dim aCode As Integer
        Dim strCode As String

        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            aCode = Int(10 ^ My.Settings.Columns * Rnd())
            Do While Not IsValidCode(aCode)
                aCode = Int(10 ^ My.Settings.Columns * Rnd())
            Loop
            strCode = aCode.ToString("00000")
            .Cod1.Text = Mid(strCode, 5, 1)
            .Cod2.Text = Mid(strCode, 4, 1)
            .Cod3.Text = Mid(strCode, 3, 1)
            .Cod4.Text = Mid(strCode, 2, 1)
            .Cod5.Text = Mid(strCode, 1, 1)
        End With
    End Sub

    Sub ClearAll()
        Dim g As Integer

        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            For g = 0 To MaxGuess - 1 'because we're making them all invisibleMy.Settings.Guesses
                .GD1(g).Text = ""
                .GD1(g).Visible = False
                .GD2(g).Text = ""
                .GD2(g).Visible = False
                .GD3(g).Text = ""
                .GD3(g).Visible = False
                .GD4(g).Text = ""
                .GD4(g).Visible = False
                .GD5(g).Text = ""
                .GD5(g).Visible = False
                .FD(g).Text = ""
                .FD(g).Visible = False
                .PD(g).Text = ""
                .PD(g).Visible = False
            Next g
            .LblFermi.Visible = False
            .LblPico.Visible = False
            .Cod1.Text = ""
            .Cod1.Visible = False
            .Cod2.Text = ""
            .Cod2.Visible = False
            .Cod3.Text = ""
            .Cod3.Visible = False
            .Cod4.Text = ""
            .Cod4.Visible = False
            .Cod5.Text = ""
            .Cod5.Visible = False
            .Dig1.Text = ""
            .Dig2.Visible = (My.Settings.Columns >= 1)
            .Dig2.Text = ""
            .Dig2.Visible = (My.Settings.Columns >= 2)
            .Dig3.Text = ""
            .Dig3.Visible = (My.Settings.Columns >= 3)
            .Dig4.Text = ""
            .Dig4.Visible = (My.Settings.Columns >= 4)
            .Dig5.Text = ""
            .Dig5.Visible = (My.Settings.Columns >= 5)
        End With
    End Sub

    Sub SetBGround(ByRef aCont As System.Windows.Forms.Control, ByRef i As Integer)
        aCont.BackColor = System.Drawing.ColorTranslator.FromOle(QBColor(i)) '&HFFFFFF / NoOfNumbers * i
        If i < My.Settings.Numbers / 2 Then
            aCont.ForeColor = System.Drawing.ColorTranslator.FromOle(QBColor(7)) '&HFFFFFF
        Else
            aCont.ForeColor = System.Drawing.ColorTranslator.FromOle(QBColor(0)) '&H0
        End If
    End Sub

    Function CountFermi(ByRef cg As Integer) As Integer
        'a fermi is a number in the right place 
        Dim aCode As String
        Dim bGuess As String
        Dim j As Integer
        Dim d As Integer

        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            aCode = GetCode()
            bGuess = GetGuess(cg)
            d = 0
            For j = 1 To My.Settings.Columns
                If Mid(aCode, j, 1) = Mid(bGuess, j, 1) Then
                    d += 1
                End If
            Next
            CountFermi = d
        End With
    End Function

    Function GetCode() As String
        GetCode = ""
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            Select Case My.Settings.Columns
                Case Is = 5
                    GetCode = .Cod5.Text & .Cod4.Text & .Cod3.Text & .Cod2.Text & .Cod1.Text
                Case Is = 4
                    GetCode = .Cod4.Text & .Cod3.Text & .Cod2.Text & .Cod1.Text
                Case Is = 3
                    GetCode = .Cod3.Text & .Cod2.Text & .Cod1.Text
                Case Is = 2
                    GetCode = .Cod2.Text & .Cod1.Text
                Case Is = 1
                    GetCode = .Cod1.Text
            End Select
        End With
    End Function

    Function CountPico(ByRef cg As Integer) As Integer
        'a pico is a number in the code but not the right place
        Dim aCode As String
        Dim bGuess As String
        Dim cRange(MaxNum) As Integer
        Dim gRange(MaxNum) As Integer
        Dim cIndex As Integer
        Dim gIndex As Integer
        Dim j As Integer
        Dim c As Integer


        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            aCode = GetCode() 'e.g. 337
            bGuess = GetGuess(cg) 'e.g. 333
            c = 0
            For j = 1 To My.Settings.Columns  'e.g. 3
                cIndex = Val(Mid(aCode, j, 1)) '3,3,7
                cRange(cIndex) = cRange(cIndex) + 1 'cRange(3)=2,CRange(7)=1
                gIndex = Val(Mid(bGuess, j, 1)) '3
                gRange(gIndex) = gRange(gIndex) + 1 'gRange(3)=3
            Next j
            For j = 0 To MaxNum - 1 '9
                If cRange(j) > 0 Then 'e.g CRange(3)=2
                    If gRange(j) <= cRange(j) Then
                        c += gRange(j) 'if the guessed number of 3s was less or = that would be used
                    Else
                        c += cRange(j) 'else you've guessed more 3s than are in the code
                    End If
                End If
            Next j
        End With
        CountPico = c
    End Function

    Function GetGuess(ByRef g As Integer) As String
        'get guess index g from table of previous guesses
        GetGuess = ""
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            Select Case My.Settings.Columns
                Case Is = 5
                    GetGuess = .GD5(g).Text & .GD4(g).Text & .GD3(g).Text & .GD2(g).Text & .GD1(g).Text
                Case Is = 4
                    GetGuess = .GD4(g).Text & .GD3(g).Text & .GD2(g).Text & .GD1(g).Text
                Case Is = 3
                    GetGuess = .GD3(g).Text & .GD2(g).Text & .GD1(g).Text
                Case Is = 2
                    GetGuess = .GD2(g).Text & .GD1(g).Text
                Case Is = 1
                    GetGuess = .GD1(g).Text
            End Select
        End With
    End Function

    Function GetCurrentGuess() As String
        'get the current guess
        GetCurrentGuess = ""
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            Select Case My.Settings.Columns
                Case Is = 5
                    GetCurrentGuess = .Dig5.Text & .Dig4.Text & .Dig3.Text & .Dig2.Text & .Dig1.Text
                Case Is = 4
                    GetCurrentGuess = .Dig4.Text & .Dig3.Text & .Dig2.Text & .Dig1.Text
                Case Is = 3
                    GetCurrentGuess = .Dig3.Text & .Dig2.Text & .Dig1.Text
                Case Is = 2
                    GetCurrentGuess = .Dig2.Text & .Dig1.Text
                Case Is = 1
                    GetCurrentGuess = .Dig1.Text
            End Select
        End With
    End Function

    Function GetPermut() As Integer
        'calculate number of possible combinations
        '2 numbers & 2 columns; 01, 10, 00, 11
        '3 numbers & 2 columns; 00, 01, 02, 10, 11, 12, 20, 21, 22
        GetPermut = My.Settings.Numbers ^ My.Settings.Columns
    End Function

    Function IsRight() As Boolean
        'all right when no. of Fermi = no. cols
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            If CDbl(.FD(curGuess).Text) = My.Settings.Columns Then
                IsRight = True
            Else
                IsRight = False
            End If
        End With
    End Function

    Sub Main_Renamed()
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            curGuess = 0
            ClearAll()
            Randomize()
            ChooseRnd()

            While .Dig1.Items.Count > My.Settings.Numbers
                Dim i As Integer = .Dig1.Items.Count - 1
                .Dig1.Items.RemoveAt(i)
                .Dig2.Items.RemoveAt(i)
                .Dig3.Items.RemoveAt(i)
                .Dig4.Items.RemoveAt(i)
                .Dig5.Items.RemoveAt(i)
            End While
            While .Dig1.Items.Count < My.Settings.Numbers
                Dim i As Integer = .Dig1.Items.Count
                .Dig1.Items.Add(i)
                .Dig2.Items.Add(i)
                .Dig3.Items.Add(i)
                .Dig4.Items.Add(i)
                .Dig5.Items.Add(i)
            End While

            '.Show()
            'MsgBox("I'm thinking of a number. Try to guess the number and I'll give you clues.")
        End With
    End Sub

    Sub MarkIt()
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            If ValidGuess() Then
                If .GD1(curGuess).Text = "" Then 'haven't already won
                    MoveGuess()
                    .FD(curGuess).Text = CStr(CountFermi(curGuess))
                    .PD(curGuess).Text = CStr(CountPico(curGuess))
                    .PD(curGuess).Text = CStr(CDbl(.PD(curGuess).Text) - CDbl(.FD(curGuess).Text))
                    If IsRight() Then
                        ShowCode()
                        MsgBox("You got it")
                    Else 'stop incrementing (nb used above)
                        curGuess += 1
                        If curGuess >= My.Settings.Guesses Then
                            ShowCode()
                            MsgBox("You ran out of guesses")
                        End If
                    End If
                End If
            Else
                MsgBox("Invalid guess. You should include " & My.Settings.Columns & " digits from 0 to " & My.Settings.Numbers)
            End If
            SetFocus()
        End With
    End Sub

    Sub ShowCode()
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            .Cod1.Visible = (My.Settings.Columns >= 1)
            .Cod2.Visible = (My.Settings.Columns >= 2)
            .Cod3.Visible = (My.Settings.Columns >= 3)
            .Cod4.Visible = (My.Settings.Columns >= 4)
            .Cod5.Visible = (My.Settings.Columns >= 5)
        End With
    End Sub

    Sub ShowGuess(aGuess As Integer)
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            .Dig1.Text = aGuess.ToString("00000").Substring(4, 1)
            .Dig2.Text = aGuess.ToString("00000").Substring(3, 1)
            .Dig3.Text = aGuess.ToString("00000").Substring(2, 1)
            .Dig4.Text = aGuess.ToString("00000").Substring(1, 1)
            .Dig5.Text = aGuess.ToString("00000").Substring(0, 1)
        End With
    End Sub

    Sub MoveGuess()
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            If curGuess = 0 Then
                .LblFermi.Visible = True
                .LblPico.Visible = True
            End If
            .FD(curGuess).Visible = True
            .PD(curGuess).Visible = True
            If My.Settings.Columns >= 1 Then
                .GD1(curGuess).Text = Left(.Dig1.Text, 1)
                .GD1(curGuess).Visible = True
                SetBGround(.GD1(curGuess), Val(Left(.Dig1.Text, 1)))
                .Dig1.Text = ""
            End If
            If My.Settings.Columns >= 2 Then
                .GD2(curGuess).Text = Left(.Dig2.Text, 1)
                .GD2(curGuess).Visible = (My.Settings.Columns >= 2)
                SetBGround(.GD2(curGuess), Val(Left(.Dig2.Text, 1)))
                .Dig2.Text = ""
            End If
            If My.Settings.Columns >= 3 Then
                .GD3(curGuess).Text = Left(.Dig3.Text, 1)
                .GD3(curGuess).Visible = (My.Settings.Columns >= 3)
                SetBGround(.GD3(curGuess), Val(Left(.Dig3.Text, 1)))
                .Dig3.Text = ""
            End If
            If My.Settings.Columns >= 4 Then
                .GD4(curGuess).Text = Left(.Dig4.Text, 1)
                .GD4(curGuess).Visible = (My.Settings.Columns >= 4)
                SetBGround(.GD4(curGuess), Val(Left(.Dig4.Text, 1)))
                .Dig4.Text = ""
            End If
            If My.Settings.Columns >= 5 Then
                .GD5(curGuess).Text = Left(.Dig5.Text, 1)
                .GD5(curGuess).Visible = (My.Settings.Columns >= 5)
                SetBGround(.GD5(curGuess), Val(Left(.Dig5.Text, 1)))
                .Dig5.Text = ""
            End If
        End With
    End Sub

    Sub SetFocus()
        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            Select Case My.Settings.Columns
                Case 1
                    .Dig1.Focus()
                Case 2
                    .Dig2.Focus()
                Case 3
                    .Dig3.Focus()
                Case 4
                    .Dig4.Focus()
                Case 5
                    .Dig5.Focus()
            End Select

        End With
    End Sub

    Sub SetStatus()
        With FrmWinBag
            .StatusBar1.Panels(1).Text = "P: " & GetPermut() 'permutations
        End With
    End Sub

    Function ValidGuess() As Boolean
        Dim iGuess As Integer

        With My.Forms.FrmWinBag ' frmWinBag.DefInstance
            Try
                iGuess = Int(GetCurrentGuess)
                If IsValidCode(iGuess) Then 'make sure they entered something in every field
                    Select Case My.Settings.Columns 'Depending on how many columns are in play
                        Case 1
                            If .Dig1.Text <> "" Then
                                ValidGuess = True
                            End If
                        Case 2
                            If .Dig1.Text <> "" And .Dig2.Text <> "" Then
                                ValidGuess = True
                            End If
                        Case 3
                            If .Dig1.Text <> "" And .Dig2.Text <> "" And .Dig3.Text <> "" Then
                                ValidGuess = True
                            End If
                        Case 4
                            If .Dig1.Text <> "" And .Dig2.Text <> "" And .Dig3.Text <> "" And .Dig4.Text <> "" Then
                                ValidGuess = True
                            End If
                        Case 5
                            If .Dig1.Text <> "" And .Dig2.Text <> "" And .Dig3.Text <> "" And .Dig4.Text <> "" And .Dig5.Text <> "" Then
                                ValidGuess = True
                            End If
                    End Select
                End If
            Catch ex As Exception
                'MsgBox("Guess invalid. You should include " & My.Settings.Columns & " digits from 0 to " & My.Settings.Numbers)
            End Try
        End With
    End Function
End Module