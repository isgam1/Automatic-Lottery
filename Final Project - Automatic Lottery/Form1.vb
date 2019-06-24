Public Class frmAutoLottery

    'FINAL PROJECT - Automatic Lottery Simulator ( NO Winner Numbers)
    'Members: Petter Vazquez, Isaac Anazagasty, Julian Orsini and Rey Hernandez
    'Prof.: Rafael Nieves
    'Class: Visual Computing 2017
    'Last Edited: 12/14/17 - 2:48 p.m.

    Dim rand As New Random

    'Counter variables for stopping timers
    Dim counterLine1 As Integer = 10
    Dim counterLine2 As Integer = 15
    Dim counterLine3 As Integer = 20
    Dim counterLine4 As Integer = 25
    Dim counterLine5 As Integer = 30

    Private Sub frmAutoLottery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Sets the default initial bet to 1$
        lblBet.Text = 1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        'Clears everything inside the cells and prepares it for a new game
        If btnPlay.Text = "PLAY AGAIN" Then
            btnPlay.Text = "PLAY"
            btnBet.Enabled = True
            lblBet.Text = 1

            counterLine1 = 10
            counterLine2 = 15
            counterLine3 = 20
            counterLine4 = 25
            counterLine5 = 30

            lblLine1Num1.Text = 0
            lblLine1Num2.Text = 0
            lblLine1Num3.Text = 0
            lblLine1Num4.Text = 0
            lblLine1Num5.Text = 0
            lblLine1PowerNum.Text = 0

            lblLine2Num1.Text = ""
            lblLine2Num2.Text = ""
            lblLine2Num3.Text = ""
            lblLine2Num4.Text = ""
            lblLine2Num5.Text = ""
            lblLine2PowerNum.Text = ""

            lblLine3Num1.Text = ""
            lblLine3Num2.Text = ""
            lblLine3Num3.Text = ""
            lblLine3Num4.Text = ""
            lblLine3Num5.Text = ""
            lblLine3PowerNum.Text = ""

            lblLine4Num1.Text = ""
            lblLine4Num2.Text = ""
            lblLine4Num3.Text = ""
            lblLine4Num4.Text = ""
            lblLine4Num5.Text = ""
            lblLine4PowerNum.Text = ""

            lblLine5Num1.Text = ""
            lblLine5Num2.Text = ""
            lblLine5Num3.Text = ""
            lblLine5Num4.Text = ""
            lblLine5Num5.Text = ""
            lblLine5PowerNum.Text = ""

            'Starts generating numbers
        ElseIf btnPlay.Text = "PLAY" Then

            btnPlay.Enabled = False

            If lblBet.Text = 1 Then
                tmrGetLine1.Start()
                btnPlay.Text = "PLAY AGAIN"
                btnBet.Enabled = False

            ElseIf lblBet.Text = 2 Then
                tmrGetLine1.Start()
                tmrGetLine2.Start()
                btnPlay.Text = "PLAY AGAIN"
                btnBet.Enabled = False

            ElseIf lblBet.Text = 3 Then
                tmrGetLine1.Start()
                tmrGetLine2.Start()
                tmrGetLine3.Start()
                btnPlay.Text = "PLAY AGAIN"
                btnBet.Enabled = False

            ElseIf lblBet.Text = 4 Then
                tmrGetLine1.Start()
                tmrGetLine2.Start()
                tmrGetLine3.Start()
                tmrGetLine4.Start()
                btnPlay.Text = "PLAY AGAIN"
                btnBet.Enabled = False

            ElseIf lblBet.Text = 5 Then
                tmrGetLine1.Start()
                tmrGetLine2.Start()
                tmrGetLine3.Start()
                tmrGetLine4.Start()
                tmrGetLine5.Start()
                btnPlay.Text = "PLAY AGAIN"
                btnBet.Enabled = False

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBet.Click

        'Opens more lines to play depending on the amount of dollars bet up to a maximun of 5$
        If lblBet.Text = 1 Then
            lblBet.Text = 2

            lblLine2Num1.Text = 0
            lblLine2Num2.Text = 0
            lblLine2Num3.Text = 0
            lblLine2Num4.Text = 0
            lblLine2Num5.Text = 0
            lblLine2PowerNum.Text = 0

        ElseIf lblBet.Text = 2 Then
            lblBet.Text = 3

            lblLine3Num1.Text = 0
            lblLine3Num2.Text = 0
            lblLine3Num3.Text = 0
            lblLine3Num4.Text = 0
            lblLine3Num5.Text = 0
            lblLine3PowerNum.Text = 0

        ElseIf lblBet.Text = 3 Then
            lblBet.Text = 4

            lblLine4Num1.Text = 0
            lblLine4Num2.Text = 0
            lblLine4Num3.Text = 0
            lblLine4Num4.Text = 0
            lblLine4Num5.Text = 0
            lblLine4PowerNum.Text = 0

        ElseIf lblBet.Text = 4 Then
            lblBet.Text = 5

            lblLine5Num1.Text = 0
            lblLine5Num2.Text = 0
            lblLine5Num3.Text = 0
            lblLine5Num4.Text = 0
            lblLine5Num5.Text = 0
            lblLine5PowerNum.Text = 0

        ElseIf lblBet.Text = 5 Then
            MessageBox.Show("You can only bet a maximun of $5 dollars!")

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub tmrGetLine1_Tick(sender As Object, e As EventArgs) Handles tmrGetLine1.Tick

        Dim lineNum As Integer
        Dim lineNums(0 To 4) As Integer
        Dim x, y As Integer

        For x = 0 To 4

StartPosition:

            lineNum = rand.Next(1, 40)

            For y = 0 To 4
                If lineNum = lineNums(y) Then
                    GoTo StartPosition
                End If
            Next

            lineNums(x) = lineNum

        Next

        lblLine1Num1.Text = lineNums(0)
        lblLine1Num2.Text = lineNums(1)
        lblLine1Num3.Text = lineNums(2)
        lblLine1Num4.Text = lineNums(3)
        lblLine1Num5.Text = lineNums(4)
        lblLine1PowerNum.Text = rand.Next(1, 15)

        counterLine1 = counterLine1 - 1

        If (counterLine1 = 0) Then
            tmrGetLine1.Enabled = False

            If (lblBet.Text = 1) Then
                btnPlay.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmrGetLine2_Tick(sender As Object, e As EventArgs) Handles tmrGetLine2.Tick

        Dim lineNum As Integer
        Dim lineNums(0 To 4) As Integer
        Dim x, y As Integer

        For x = 0 To 4

StartPosition:

            lineNum = rand.Next(1, 40)

            For y = 0 To 4
                If lineNum = lineNums(y) Then
                    GoTo StartPosition
                End If
            Next

            lineNums(x) = lineNum

        Next

        lblLine2Num1.Text = lineNums(0)
        lblLine2Num2.Text = lineNums(1)
        lblLine2Num3.Text = lineNums(2)
        lblLine2Num4.Text = lineNums(3)
        lblLine2Num5.Text = lineNums(4)
        lblLine2PowerNum.Text = rand.Next(1, 15)

        counterLine2 = counterLine2 - 1

        If (counterLine2 = 0) Then
            tmrGetLine2.Enabled = False

            If (lblBet.Text = 2) Then
                btnPlay.Enabled = True
            End If

        End If

    End Sub

    Private Sub tmrGetLine3_Tick(sender As Object, e As EventArgs) Handles tmrGetLine3.Tick

        Dim lineNum As Integer
        Dim lineNums(0 To 4) As Integer
        Dim x, y As Integer

        For x = 0 To 4

StartPosition:

            lineNum = rand.Next(1, 40)

            For y = 0 To 4
                If lineNum = lineNums(y) Then
                    GoTo StartPosition
                End If
            Next

            lineNums(x) = lineNum

        Next

        lblLine3Num1.Text = lineNums(0)
        lblLine3Num2.Text = lineNums(1)
        lblLine3Num3.Text = lineNums(2)
        lblLine3Num4.Text = lineNums(3)
        lblLine3Num5.Text = lineNums(4)
        lblLine3PowerNum.Text = rand.Next(1, 15)

        counterLine3 = counterLine3 - 1

        If (counterLine3 = 0) Then
            tmrGetLine3.Enabled = False

            If (lblBet.Text = 3) Then
                btnPlay.Enabled = True
            End If

        End If

    End Sub

    Private Sub tmrGetLine4_Tick(sender As Object, e As EventArgs) Handles tmrGetLine4.Tick

        Dim lineNum As Integer
        Dim lineNums(0 To 4) As Integer
        Dim x, y As Integer

        For x = 0 To 4

StartPosition:

            lineNum = rand.Next(1, 40)

            For y = 0 To 4
                If lineNum = lineNums(y) Then
                    GoTo StartPosition
                End If
            Next

            lineNums(x) = lineNum

        Next

        lblLine4Num1.Text = lineNums(0)
        lblLine4Num2.Text = lineNums(1)
        lblLine4Num3.Text = lineNums(2)
        lblLine4Num4.Text = lineNums(3)
        lblLine4Num5.Text = lineNums(4)
        lblLine4PowerNum.Text = rand.Next(1, 15)

        counterLine4 = counterLine4 - 1

        If (counterLine4 = 0) Then
            tmrGetLine4.Enabled = False

            If (lblBet.Text = 4) Then
                btnPlay.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmrGetLine5_Tick(sender As Object, e As EventArgs) Handles tmrGetLine5.Tick

        Dim lineNum As Integer
        Dim lineNums(0 To 4) As Integer
        Dim x, y As Integer

        For x = 0 To 4

StartPosition:

            lineNum = rand.Next(1, 40)

            For y = 0 To 4
                If lineNum = lineNums(y) Then
                    GoTo StartPosition
                End If
            Next

            lineNums(x) = lineNum

        Next

        lblLine5Num1.Text = lineNums(0)
        lblLine5Num2.Text = lineNums(1)
        lblLine5Num3.Text = lineNums(2)
        lblLine5Num4.Text = lineNums(3)
        lblLine5Num5.Text = lineNums(4)
        lblLine5PowerNum.Text = rand.Next(1, 15)

        counterLine5 = counterLine5 - 1

        If (counterLine5 = 0) Then
            tmrGetLine5.Enabled = False

            If (lblBet.Text = 5) Then
                btnPlay.Enabled = True
            End If

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        aboxAbout.ShowDialog()
    End Sub
End Class
