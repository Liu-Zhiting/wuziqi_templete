Class RobotController
    Private Const ROBOT_NAME_LEN As Integer = 50

    Public Declare Function NextMoveA Lib "RobotA.dll" Alias "GetNextMove" (ByRef map As Integer) As Integer
    Public Declare Sub ResetA Lib "RobotA.dll" Alias "Reset" ()
    Public Declare Sub SetColorA Lib "RobotA.dll" Alias "SetColor" (ByVal playerColor As Integer)
    Public Declare Sub SetLevelA Lib "RobotA.dll" Alias "SetLevel" (ByVal level As Integer)
    Public Declare Sub GetNameA Lib "RobotA.dll" Alias "GetName" (ByRef name As Byte)

    Public Declare Function NextMoveB Lib "RobotB.dll" Alias "GetNextMove" (ByRef map As Integer) As Integer
    Public Declare Sub ResetB Lib "RobotB.dll" Alias "Reset" ()
    Public Declare Sub SetColorB Lib "RobotB.dll" Alias "SetColor" (ByVal playerColor As Integer)
    Public Declare Sub SetLevelB Lib "RobotB.dll" Alias "SetLevel" (ByVal level As Integer)
    Public Declare Sub GetNameB Lib "RobotB.dll" Alias "GetName" (ByRef name As Byte)

    Public Property Mode As GameMode = GameMode.PVE
    Public Property CurrentBoard As Integer()
    Public Property CurrentMove As Integer

    Public Property CurrentRobot As Robot

    Sub New()
        ReDim CurrentBoard(224)
        If IO.File.Exists("RobotA.dll") Then
            CurrentRobot = Robot.A
        Else
            CurrentRobot = Robot.B
        End If
    End Sub

    Sub New(robotIndex As Robot)
        ReDim CurrentBoard(224)
        CurrentRobot = robotIndex
    End Sub

    Overloads Sub Reset()
        ResetA()
        ResetB()
    End Sub

    Overloads Sub Reset(robotIndex As Robot)
        Select Case robotIndex
            Case Robot.A
                ResetA()
            Case Robot.B
                ResetB()
        End Select
    End Sub

    Overloads Sub SetLevel(robotIndex As Robot, level As Integer)
        Select Case robotIndex
            Case Robot.A
                SetLevelA(level)
            Case Robot.B
                SetLevelB(level)
        End Select
    End Sub

    Overloads Sub SetLevel(level As Integer)
        Select Case CurrentRobot
            Case Robot.A
                SetLevelA(level)
            Case Robot.B
                SetLevelB(level)
        End Select
    End Sub

    Overloads Sub SetColor(robotIndex As Robot, color As PlayerColor)
        Select Case robotIndex
            Case Robot.A
                SetColorA(color)
            Case Robot.B
                SetColorB(color)
        End Select
    End Sub

    Overloads Sub SetColor(color As PlayerColor)
        Select Case CurrentRobot
            Case Robot.A
                SetColorA(color)
            Case Robot.B
                SetColorB(color)
        End Select
    End Sub

    Public Function GetRobotName(robotIndex As Robot) As String
        Dim result As String
        Dim buf(ROBOT_NAME_LEN) As Byte

        If robotIndex = Robot.A Then
            GetNameA(buf(0))
        Else
            GetNameB(buf(0))
        End If

        'buf 后面有一串0，需要截断
        For i = 0 To buf.Length - 1
            If buf(i) = 0 Then
                ReDim Preserve buf(i)
                Exit For
            End If
        Next

        result = Text.Encoding.UTF8.GetString(buf)
        Return result
    End Function


    Private Sub RobotControler_OnMove(robotIndex As Robot) Handles Me.OnMove
        Dim index As Integer
        Dim t1, t2 As Date
        Dim dt As TimeSpan

        t1 = Now
        Select Case robotIndex
            Case Robot.A
                index = NextMoveA(CurrentBoard(0))
            Case Robot.B
                index = NextMoveB(CurrentBoard(0))
        End Select
        t2 = Now
        dt = t2 - t1

        FormMain.ShowResponseTime(dt.TotalSeconds)
        If Mode = GameMode.EVE Then ExchangeRobot()
        FormMain.RobotClick(index)

    End Sub

    Sub ExchangeRobot()
        If CurrentRobot = Robot.A Then
            CurrentRobot = Robot.B
        Else
            CurrentRobot = Robot.A
        End If
    End Sub

    Sub ClearBoard()
        ReDim CurrentBoard(224)
    End Sub

    Function GetJudgeState() As JudgeState
        ' check horizonal
        For i = 0 To 14
            For j = 0 To 10
                Dim s As Boolean = True
                For k = 0 To 3
                    s = s And (CurrentBoard(i * 15 + j + k) = CurrentBoard(i * 15 + j + k + 1))
                Next k
                If s Then
                    If CurrentBoard(i * 15 + j) = ChessColor.White Then
                        Return JudgeState.WhiteWin
                    ElseIf CurrentBoard(i * 15 + j) = ChessColor.Black Then
                        Return JudgeState.BlackWin
                    End If
                End If
            Next j
        Next i

        ' check vertical
        For j = 0 To 14
            For i = 0 To 10
                Dim s As Boolean = True
                For k = 0 To 3
                    s = s And (CurrentBoard((i + k) * 15 + j) = CurrentBoard((i + k + 1) * 15 + j))
                Next
                If s Then
                    If CurrentBoard(i * 15 + j) = ChessColor.White Then
                        Return JudgeState.WhiteWin
                    ElseIf CurrentBoard(i * 15 + j) = ChessColor.Black Then
                        Return JudgeState.BlackWin
                    End If
                End If
            Next
        Next

        ' check oblique left-up to right-down
        For x = 0 To 20
            Dim start = Math.Abs(10 - x)
            If x > 10 Then start *= 15
            Dim len = -Math.Abs(x - 10) + 15
            For l = 0 To len - 5
                Dim s As Boolean = True
                For k = 0 To 3
                    s = s And (CurrentBoard(start + 16 * (l + k)) = CurrentBoard(start + 16 * (l + k + 1)))
                Next
                If s Then
                    If CurrentBoard(start + 16 * l) = ChessColor.White Then
                        Return JudgeState.WhiteWin
                    ElseIf CurrentBoard(start + 16 * l) = ChessColor.Black Then
                        Return JudgeState.BlackWin
                    End If
                End If
            Next
        Next

        ' check oblique left-down to right-up
        For x = 0 To 20
            Dim start As Integer = x - 10
            If x > 10 Then start *= 15
            start += 14
            Dim len As Integer = -Math.Abs(x - 10) + 15
            For l = 0 To len - 5
                Dim s As Boolean = True
                For k = 0 To 3
                    s = s And (CurrentBoard(start + 14 * (l + k)) = CurrentBoard(start + 14 * (l + k + 1)))
                Next
                If s Then
                    If CurrentBoard(start + 14 * l) = ChessColor.White Then
                        Return JudgeState.WhiteWin
                    ElseIf CurrentBoard(start + 14 * l) = ChessColor.Black Then
                        Return JudgeState.BlackWin
                    End If
                End If
            Next
        Next

        ' check draw
        Dim draw_flag As Boolean = True
        For i = 0 To 224
            If CurrentBoard(i) = ChessColor.Empty Then
                draw_flag = False
                Exit For
            End If
        Next
        If draw_flag Then
            Return JudgeState.Draw
        Else
            Return JudgeState.NotEnd
        End If

    End Function

    Overloads Sub PerformMove(robotIndex As Robot)
        RaiseEvent OnMove(robotIndex)
    End Sub

    Overloads Sub PerformMove()
        RaiseEvent OnMove(CurrentRobot)
    End Sub

    Overloads Function GetHint() As Integer
        Select Case CurrentRobot
            Case Robot.A
                Return NextMoveA(CurrentBoard(0))
            Case Robot.B
                Return NextMoveB(CurrentBoard(0))
            Case Else
                Throw New Exception
        End Select
    End Function

    Overloads Function GetHint(robotIndex As Robot) As Integer
        Select Case robotIndex
            Case Robot.A
                Return NextMoveA(CurrentBoard(0))
            Case Robot.B
                Return NextMoveB(CurrentBoard(0))
            Case Else
                Throw New Exception
        End Select
    End Function

    Event OnMove(robotIndex As Robot)

End Class