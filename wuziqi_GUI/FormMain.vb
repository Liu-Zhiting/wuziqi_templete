﻿Public Class FormMain
    'global and const

    Private Property CurrentPlayerColor As PlayerColor = PlayerColor.Black
    Private Property Last_i As Integer = -1
    Private Property MoveCounter As Integer = 1

    Private ReadOnly imgChessBlack As Bitmap = My.Resources.chessboard.black
    Private ReadOnly imgChessWhite As Bitmap = My.Resources.chessboard.white
    Private ReadOnly imgChessEmpty As Bitmap = My.Resources.chessboard.empty

    Private WithEvents MyRobotController As RobotController

#Region "自定义private方法"
    Private Sub InitializeChessboard()
        Const CAPTION_H As Integer = 45
        Dim board_mergin As Integer = 50
        Dim block_size As Integer
        Dim block_mergin As Integer
        Dim tmp As MyButton

        PanelChessBoard.BackColor = Color.LightGray
        PanelChessBoard.Top = board_mergin
        PanelChessBoard.Left = PanelChessBoard.Top
        PanelChessBoard.Height = Me.Height - CAPTION_H - 2 * board_mergin
        PanelChessBoard.Width = PanelChessBoard.Height

        block_mergin = PanelChessBoard.Height * 0.0632
        block_size = (PanelChessBoard.Height - 2 * block_mergin) / 15

        For i = 0 To 224
            tmp = New MyButton With {
                .Text = "",
                .BackColor = Color.LightGray,
                .BackgroundImage = imgChessEmpty,
                .Index = i,
                .Left = block_mergin + (i Mod 15) * block_size,
                .Top = block_mergin + (i \ 15) * block_size,
                .Size = New Point(block_size, block_size),
                .FlatStyle = FlatStyle.Flat,
                .BackgroundImageLayout = ImageLayout.Stretch
            }
            tmp.FlatAppearance.BorderColor = Color.LightGray
            AddHandler tmp.Click, AddressOf BtnChessBoardClickHandler
            BtnChessBoard(i) = tmp
            PanelChessBoard.Controls.Add(tmp)
        Next

    End Sub

    Private Sub BtnChessBoardClickHandler(sender As Object, e As EventArgs)
        Dim i As Integer = sender.Index

        'already has a chess on it
        If BtnChessBoard(i).Text <> "" Then
            Exit Sub
        End If

        'update robot controller
        If CurrentPlayerColor = PlayerColor.Black Then
            MyRobotController.CurrentBoard(i) = ChessColor.Black
        Else
            MyRobotController.CurrentBoard(i) = ChessColor.White
        End If
        MyRobotController.CurrentMove = i
        UpdateBtnBoard(i)
        MoveCounter += 1

        'perform move
        Select Case MyRobotController.Mode
            Case GameMode.PVP

            Case GameMode.PVE
                If 玩家执黑ToolStripMenuItem.Checked Xor CurrentPlayerColor = PlayerColor.Black Then
                    MyRobotController.PerformMove()
                End If
            Case GameMode.EVE
                MyRobotController.PerformMove()
        End Select

        'check judge state
        Dim state As JudgeState = MyRobotController.GetJudgeState()
        If Not state = JudgeState.NotEnd Then
            RaiseEvent GameOver(state)
        End If

    End Sub

    Private Sub UpdateBtnBoard(i As Integer)
        Last_i = i

        If CurrentPlayerColor = PlayerColor.Black Then
            'black chess 
            BtnChessBoard(i).ForeColor = Color.White
            BtnChessBoard(i).BackgroundImage = imgChessBlack
            CurrentPlayerColor = PlayerColor.White
        Else
            'white chess
            BtnChessBoard(i).ForeColor = Color.Black
            BtnChessBoard(i).BackgroundImage = imgChessWhite
            CurrentPlayerColor = PlayerColor.Black
        End If
        BtnChessBoard(i).Text = MoveCounter.ToString()
    End Sub

    Private Sub GameOverHandler(state As JudgeState) Handles Me.GameOver
        Select Case state
            Case JudgeState.NotEnd
                Exit Sub
            Case JudgeState.BlackWin
                MessageBox.Show("黑方胜")
            Case JudgeState.WhiteWin
                MessageBox.Show("白方胜")
            Case JudgeState.Draw
                MessageBox.Show("和棋")
        End Select

        ClearBoard()
        SetUIEnableState(gameStart:=False)

    End Sub

    Private Sub SetUIEnableState(gameStart As Boolean)
        If gameStart Then
            If Not (PVP玩家玩家ToolStripMenuItem.Checked Or PVE玩家机器人ToolStripMenuItem.Checked Or EVE机器人机器人ToolStripMenuItem.Checked) Then
                Throw New Exception("没有选中游戏模式")
                Exit Sub
            End If

            PanelChessBoard.Enabled = True

            'GroupGlobalSetting.Enabled = False
            'GpBoxPVPSet.Enabled = False
            'GpBoxPVESet.Enabled = False
            'GpBoxEVESet.Enabled = False
            设置ToolStripMenuItem.Enabled = False


            BtnStart.Enabled = False
            BtnGiveUp.Enabled = PVP玩家玩家ToolStripMenuItem.Checked Or PVE玩家机器人ToolStripMenuItem.Checked
            BtnTip.Enabled = PVP玩家玩家ToolStripMenuItem.Checked Or PVE玩家机器人ToolStripMenuItem.Checked
            BtnUndo.Enabled = PVP玩家玩家ToolStripMenuItem.Checked Or PVE玩家机器人ToolStripMenuItem.Checked
            BtnPause.Enabled = EVE机器人机器人ToolStripMenuItem.Checked
            BtnStopEVE.Enabled = EVE机器人机器人ToolStripMenuItem.Checked

        Else
            PanelChessBoard.Enabled = False

            'GroupGlobalSetting.Enabled = True
            'GpBoxPVPSet.Enabled = PVP玩家玩家ToolStripMenuItem.Checked
            'GpBoxPVESet.Enabled = PVE玩家机器人ToolStripMenuItem.Checked
            'GpBoxEVESet.Enabled = EVE机器人机器人ToolStripMenuItem.Checked
            设置ToolStripMenuItem.Enabled = True

            BtnStart.Enabled = True
            BtnGiveUp.Enabled = False
            BtnTip.Enabled = False
            BtnUndo.Enabled = False
            BtnPause.Enabled = False
            BtnStopEVE.Enabled = False
        End If

    End Sub

    Private Sub ClearBoard()
        For Each s In BtnChessBoard
            s.BackgroundImage = imgChessEmpty
            s.Text = ""
            s.FlatAppearance.BorderColor = Color.LightGray
        Next
        CurrentPlayerColor = PlayerColor.Black
        Last_i = -1
        MoveCounter = 1
    End Sub

    Private Function UpdateRobotState() As Boolean
        Dim A_Exist As Boolean = IO.File.Exists("RobotA.dll")
        Dim B_Exist As Boolean = IO.File.Exists("RobotB.dll")
        SetRobotRelevantUI(Robot.A, A_Exist)
        SetRobotRelevantUI(Robot.B, B_Exist)

        PVE玩家机器人ToolStripMenuItem.Enabled = A_Exist Or B_Exist
        EVE机器人机器人ToolStripMenuItem.Enabled = A_Exist And B_Exist

        If (Not A_Exist) And B_Exist Then RobotBdll为对手ToolStripMenuItem.Checked = True

        Return Not (PVE玩家机器人ToolStripMenuItem.Checked And ToolLabelIsAExist.Text = "缺失" And ToolLabelIsBExist.Text = "缺失") Or EVE机器人机器人ToolStripMenuItem.Checked And (ToolLabelIsAExist.Text = "缺失" Or ToolLabelIsBExist.Text = "缺失")

    End Function

    Private Sub SetRobotRelevantUI(index As Robot, state As Boolean)
        Select Case index
            Case 0  'Robot A
                TxtRobotNameA.Enabled = state : ToolTxtRobotLevelA.Enabled = state : RobotAdll为对手ToolStripMenuItem.Enabled = state
                If state Then
                    ToolLabelIsAExist.Text = "就绪"
                Else
                    ToolLabelIsAExist.Text = "缺失"
                End If
            Case 1   'Robot B
                TxtRobotNameB.Enabled = state : ToolTxtRobotLevelB.Enabled = state : RobotBdll为对手ToolStripMenuItem.Enabled = state
                If state Then
                    ToolLabelIsBExist.Text = "就绪"
                Else
                    ToolLabelIsBExist.Text = "缺失"
                End If
        End Select
    End Sub

    Private Sub InitializeMyRobotController()
        Dim PVERobotIndex As Robot = GetPVERobotIndex()
        Dim PVERobotColor As PlayerColor = GetPVERobotColor()
        Dim PVERobotLevel As Integer

        If PVE玩家机器人ToolStripMenuItem.Checked Then
            If PVERobotIndex = Robot.A Then
                PVERobotLevel = ToolTxtRobotLevelA.Text
            Else
                PVERobotLevel = ToolTxtRobotLevelB.Text
            End If

            MyRobotController.Mode = GameMode.PVE
            MyRobotController.Reset(PVERobotIndex)
            MyRobotController.SetColor(PVERobotIndex, PVERobotColor)
            MyRobotController.SetLevel(PVERobotIndex, PVERobotLevel)
            If 机器人执黑ToolStripMenuItem.Checked Then
                MyRobotController.PerformMove(PVERobotIndex)
            End If
        ElseIf EVE机器人机器人ToolStripMenuItem.Checked Then
            MyRobotController.Mode = GameMode.EVE
            MyRobotController.Reset(Robot.A)
            MyRobotController.Reset(Robot.B)
            MyRobotController.SetLevel(Robot.A, ToolTxtRobotLevelA.Text)
            MyRobotController.SetLevel(Robot.B, ToolTxtRobotLevelB.Text)

            If RobotAdll执黑ToolStripMenuItem.Checked Then
                MyRobotController.SetColor(Robot.A, PlayerColor.Black)
                MyRobotController.SetColor(Robot.B, PlayerColor.White)
            ElseIf RobotBdll执黑ToolStripMenuItem.Checked Then
                MyRobotController.SetColor(Robot.B, PlayerColor.Black)
                MyRobotController.SetColor(Robot.A, PlayerColor.White)
            End If
        Else
            MyRobotController.Mode = GameMode.PVP
        End If
    End Sub

    Private Sub ShowPlayerName()
        Dim PVERobotIndex As Robot = GetPVERobotIndex()
        Dim PVERobotColor As PlayerColor = GetPVERobotColor()

        If PVP玩家玩家ToolStripMenuItem.Checked Then
            ToolLabelPlayBlack.Text = ToolTxtPVPBlackName.Text
            ToolLabelPlayWhite.Text = ToolTxtPVPWhiteName.Text
        ElseIf PVE玩家机器人ToolStripMenuItem.Checked Then
            If 玩家执黑ToolStripMenuItem.Checked Then
                ToolLabelPlayBlack.Text = ToolTxtPVEPlayerName.Text
                If PVERobotIndex = Robot.A Then
                    ToolLabelPlayWhite.Text = TxtRobotNameA.Text
                Else
                    ToolLabelPlayWhite.Text = TxtRobotNameB.Text
                End If
            Else
                ToolLabelPlayWhite.Text = ToolTxtPVPWhiteName.Text
                If PVERobotIndex = Robot.A Then
                    ToolLabelPlayBlack.Text = TxtRobotNameA.Text
                Else
                    ToolLabelPlayBlack.Text = TxtRobotNameB.Text
                End If
            End If
        ElseIf EVE机器人机器人ToolStripMenuItem.Checked Then
            ToolLabelPlayBlack.Text = TxtRobotNameA.Text
            ToolLabelPlayWhite.Text = TxtRobotNameB.Text
        End If
    End Sub

    Private Function GetPVERobotIndex() As PlayerColor
        Dim robotIndex As Robot

        If RobotAdll为对手ToolStripMenuItem.Checked Then
            robotIndex = Robot.A
        Else
            robotIndex = Robot.B
        End If

        Return robotIndex
    End Function

    Private Function GetPVERobotColor() As PlayerColor
        Dim robotColor As PlayerColor

        If 玩家执黑ToolStripMenuItem.Checked Then
            robotColor = PlayerColor.White
        Else
            robotColor = PlayerColor.Black
        End If

        Return robotColor
    End Function

    Private ReadOnly BtnChessBoard(224) As MyButton
    Private Class MyButton
        Inherits Button
        Property Index As Integer
    End Class
#End Region

#Region "控件方法"
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolLabelResponseTime.Text = ""

        'set window size
        Me.Height = My.Computer.Screen.WorkingArea.Height * 0.75
        Me.Width = My.Computer.Screen.WorkingArea.Width * 0.75

        'lock window size
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size

        'initialize chessboard
        InitializeChessboard()

        'init robot
        UpdateRobotState()
        MyRobotController = New RobotController

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        'TODO 修复机器人对战功能
        If EVE机器人机器人ToolStripMenuItem.Checked Then
            MessageBox.Show("十分抱歉，功能异常，正在修复中，敬请期待")
            Exit Sub
        End If

        'check robot
        Dim IsRobotAvaliable As Boolean = UpdateRobotState()
        If Not IsRobotAvaliable Then
            MessageBox.Show("没有可用的robot")
            Exit Sub
        End If

        'init UI
        ClearBoard()
        MyRobotController.ClearBoard()
        SetUIEnableState(gameStart:=True)
        ShowPlayerName()

        'set robot
        InitializeMyRobotController()
        If PVE玩家机器人ToolStripMenuItem.Checked Then
            If 机器人执黑ToolStripMenuItem.Checked Then MyRobotController.PerformMove(GetPVERobotIndex())
        ElseIf EVE机器人机器人ToolStripMenuItem.Checked Then
            MyRobotController.PerformMove(Robot.A)
        End If

    End Sub

    Private Sub BtnPVPExchangeColor_Click(sender As Object, e As EventArgs) Handles BtnPVPExchangeColor.Click
        Dim s As String = ToolTxtPVPBlackName.Text
        ToolTxtPVPBlackName.Text = ToolTxtPVPWhiteName.Text
        ToolTxtPVPWhiteName.Text = s
    End Sub

    Private Sub BtnGiveUp_Click(sender As Object, e As EventArgs) Handles BtnGiveUp.Click
        Dim state As JudgeState
        If PVP玩家玩家ToolStripMenuItem.Checked Then
            If MoveCounter Mod 2 = 1 Then
                state = JudgeState.WhiteWin
            Else
                state = JudgeState.BlackWin
            End If
        ElseIf PVE玩家机器人ToolStripMenuItem.Checked Then
            If 玩家执黑ToolStripMenuItem.Checked Then
                state = JudgeState.WhiteWin
            Else
                state = JudgeState.BlackWin
            End If
        Else
            Exit Sub
        End If
        RaiseEvent GameOver(state)
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        MessageBox.Show("功能暂未开放，敬请期待！")
        Exit Sub
        If BtnPause.Text = "暂停" Then


            BtnPause.Text = "继续"
        Else



            BtnPause.Text = "暂停"
        End If
    End Sub

    Private Sub BtnStopEVE_Click(sender As Object, e As EventArgs) Handles BtnStopEVE.Click
        ClearBoard()
        PanelChessBoard.Enabled = False
        GroupGlobalSetting.Enabled = True

        BtnStart.Enabled = True
        BtnPause.Enabled = False
        BtnStopEVE.Enabled = False


    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        MessageBox.Show("功能暂未开放，敬请期待！")
        Exit Sub
    End Sub

    Private Sub BtnTip_Click(sender As Object, e As EventArgs) Handles BtnTip.Click
        MessageBox.Show("功能暂未开放，敬请期待！")
        Exit Sub
    End Sub
#End Region

    Public Sub RobotClick(index As Integer)
        BtnChessBoard(index).PerformClick()
    End Sub

    Public Sub ShowResponseTime(seconds As Double)
        LblResponseTime.Text = String.Format("响应时间：{0:n2}s", seconds)
        ToolLabelResponseTime.Text = String.Format("响应时间：{0:n2}s", seconds)
    End Sub

    Private Event GameOver(state As JudgeState)

    Private Sub PVP玩家玩家ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PVP玩家玩家ToolStripMenuItem.Click
        If Not PVP玩家玩家ToolStripMenuItem.Checked Then
            PVP玩家玩家ToolStripMenuItem.Checked = True
            PVE玩家机器人ToolStripMenuItem.Checked = False
            EVE机器人机器人ToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub PVE玩家机器人ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PVE玩家机器人ToolStripMenuItem.Click
        If Not PVE玩家机器人ToolStripMenuItem.Checked Then
            PVP玩家玩家ToolStripMenuItem.Checked = False
            PVE玩家机器人ToolStripMenuItem.Checked = True
            EVE机器人机器人ToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub EVE机器人机器人ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EVE机器人机器人ToolStripMenuItem.Click
        If Not EVE机器人机器人ToolStripMenuItem.Checked Then
            PVP玩家玩家ToolStripMenuItem.Checked = False
            PVE玩家机器人ToolStripMenuItem.Checked = False
            EVE机器人机器人ToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub RobotAdll执黑ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RobotAdll执黑ToolStripMenuItem.Click
        If Not RobotAdll执黑ToolStripMenuItem.Checked Then
            RobotAdll执黑ToolStripMenuItem.Checked = True
            RobotBdll执黑ToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub RobotBdll执黑ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RobotBdll执黑ToolStripMenuItem.Click
        If Not RobotBdll执黑ToolStripMenuItem.Checked Then
            RobotAdll执黑ToolStripMenuItem.Checked = False
            RobotBdll执黑ToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub RobotAdll为对手ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RobotAdll为对手ToolStripMenuItem.Click
        If Not RobotAdll为对手ToolStripMenuItem.Checked Then
            RobotAdll为对手ToolStripMenuItem.Checked = True
            RobotBdll为对手ToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub RobotBdll为对手ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RobotBdll为对手ToolStripMenuItem.Click
        If Not RobotBdll为对手ToolStripMenuItem.Checked Then
            RobotAdll为对手ToolStripMenuItem.Checked = False
            RobotBdll为对手ToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub 玩家执黑ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 玩家执黑ToolStripMenuItem.Click
        If Not 玩家执黑ToolStripMenuItem.Checked Then
            玩家执黑ToolStripMenuItem.Checked = True
            机器人执黑ToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub 机器人执黑ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 机器人执黑ToolStripMenuItem.Click
        If Not 机器人执黑ToolStripMenuItem.Checked Then
            玩家执黑ToolStripMenuItem.Checked = False
            机器人执黑ToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub 退出游戏ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出游戏ToolStripMenuItem.Click
        If MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub 开始ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 开始ToolStripMenuItem.Click
        'TODO 修复机器人对战功能
        If EVE机器人机器人ToolStripMenuItem.Checked Then
            MessageBox.Show("十分抱歉，功能异常，正在修复中，敬请期待")
            Exit Sub
        End If

        'check robot
        Dim IsRobotAvaliable As Boolean = UpdateRobotState()
        If Not IsRobotAvaliable Then
            MessageBox.Show("没有可用的robot")
            Exit Sub
        End If

        'init UI
        ClearBoard()
        MyRobotController.ClearBoard()
        SetUIEnableState(gameStart:=True)
        ShowPlayerName()

        'set robot
        InitializeMyRobotController()
        If PVE玩家机器人ToolStripMenuItem.Checked Then
            If 机器人执黑ToolStripMenuItem.Checked Then MyRobotController.PerformMove(GetPVERobotIndex())
        ElseIf EVE机器人机器人ToolStripMenuItem.Checked Then
            MyRobotController.PerformMove(Robot.A)
        End If
    End Sub

    Private Sub 认输ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 认输ToolStripMenuItem.Click
        Dim state As JudgeState
        If PVP玩家玩家ToolStripMenuItem.Checked Then
            If MoveCounter Mod 2 = 1 Then
                state = JudgeState.WhiteWin
            Else
                state = JudgeState.BlackWin
            End If
        ElseIf PVE玩家机器人ToolStripMenuItem.Checked Then
            If 玩家执黑ToolStripMenuItem.Checked Then
                state = JudgeState.WhiteWin
            Else
                state = JudgeState.BlackWin
            End If
        Else
            Exit Sub
        End If
        RaiseEvent GameOver(state)
    End Sub

    Private Sub 悔棋ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 悔棋ToolStripMenuItem.Click
        MessageBox.Show("功能暂未开放，敬请期待！")
        Exit Sub
    End Sub

    Private Sub 提示ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 提示ToolStripMenuItem.Click
        MessageBox.Show("功能暂未开放，敬请期待！")
        Exit Sub
    End Sub

    Private Sub 暂停ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 暂停ToolStripMenuItem.Click
        MessageBox.Show("功能暂未开放，敬请期待！")
        Exit Sub
        If 暂停ToolStripMenuItem.Text = "暂停" Then


            暂停ToolStripMenuItem.Text = "继续"
        Else



            暂停ToolStripMenuItem.Text = "暂停"
        End If
    End Sub

    Private Sub 停止EVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 停止EVEToolStripMenuItem.Click
        ClearBoard()
        PanelChessBoard.Enabled = False
        GroupGlobalSetting.Enabled = True

        BtnStart.Enabled = True
        BtnPause.Enabled = False
        BtnStopEVE.Enabled = False
    End Sub
End Class
Enum GameMode
    PVP
    PVE
    EVE
End Enum

Enum PlayerColor
    Black = 1
    White = 2
End Enum

Enum ChessColor
    Empty = 0
    Black = 1
    White = 2
End Enum

Enum Robot
    A = 0
    B = 1
End Enum

Enum JudgeState
    NotEnd = 0
    BlackWin = 1
    WhiteWin = 2
    Draw = 3
End Enum

