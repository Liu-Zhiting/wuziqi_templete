<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnUndo = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnGiveUp = New System.Windows.Forms.Button()
        Me.BtnTip = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnStopEVE = New System.Windows.Forms.Button()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.GroupGlobalSetting = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RdiModeEVE = New System.Windows.Forms.RadioButton()
        Me.RdiModePVE = New System.Windows.Forms.RadioButton()
        Me.RdiModePVP = New System.Windows.Forms.RadioButton()
        Me.GpBoxEVESet = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RdiEVEBlackB = New System.Windows.Forms.RadioButton()
        Me.RdiEVEBlackA = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRobotNameB = New System.Windows.Forms.TextBox()
        Me.TxtRobotNameA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRobotLevelA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRobotLevelB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelChessBoard = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblIsBExist = New System.Windows.Forms.Label()
        Me.LblIsAExist = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GpBoxPVESet = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RdiPVEBlackRobot = New System.Windows.Forms.RadioButton()
        Me.RdiPVEBlackPlayer = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RdiPVERobotB = New System.Windows.Forms.RadioButton()
        Me.RdiPVERobotA = New System.Windows.Forms.RadioButton()
        Me.GpBoxPVPSet = New System.Windows.Forms.GroupBox()
        Me.BtnPVPExchangeColor = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPVPWhiteName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPVPBlackName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblResponseTime = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblPlayWhite = New System.Windows.Forms.Label()
        Me.LblPlayBlack = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupGlobalSetting.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GpBoxEVESet.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GpBoxPVESet.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GpBoxPVPSet.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUndo
        '
        Me.BtnUndo.Enabled = False
        Me.BtnUndo.Location = New System.Drawing.Point(17, 91)
        Me.BtnUndo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(91, 40)
        Me.BtnUndo.TabIndex = 1
        Me.BtnUndo.Text = "悔棋"
        Me.BtnUndo.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(115, 91)
        Me.BtnStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(89, 40)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "开始"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnGiveUp
        '
        Me.BtnGiveUp.Enabled = False
        Me.BtnGiveUp.Location = New System.Drawing.Point(17, 42)
        Me.BtnGiveUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGiveUp.Name = "BtnGiveUp"
        Me.BtnGiveUp.Size = New System.Drawing.Size(91, 40)
        Me.BtnGiveUp.TabIndex = 1
        Me.BtnGiveUp.Text = "认输"
        Me.BtnGiveUp.UseVisualStyleBackColor = True
        '
        'BtnTip
        '
        Me.BtnTip.Enabled = False
        Me.BtnTip.Location = New System.Drawing.Point(115, 42)
        Me.BtnTip.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnTip.Name = "BtnTip"
        Me.BtnTip.Size = New System.Drawing.Size(89, 40)
        Me.BtnTip.TabIndex = 1
        Me.BtnTip.Text = "提示"
        Me.BtnTip.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnStart)
        Me.GroupBox1.Controls.Add(Me.BtnStopEVE)
        Me.GroupBox1.Controls.Add(Me.BtnPause)
        Me.GroupBox1.Controls.Add(Me.BtnTip)
        Me.GroupBox1.Controls.Add(Me.BtnGiveUp)
        Me.GroupBox1.Controls.Add(Me.BtnUndo)
        Me.GroupBox1.Location = New System.Drawing.Point(755, 573)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(314, 157)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "玩家操作区"
        '
        'BtnStopEVE
        '
        Me.BtnStopEVE.Enabled = False
        Me.BtnStopEVE.Location = New System.Drawing.Point(211, 91)
        Me.BtnStopEVE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnStopEVE.Name = "BtnStopEVE"
        Me.BtnStopEVE.Size = New System.Drawing.Size(89, 40)
        Me.BtnStopEVE.TabIndex = 1
        Me.BtnStopEVE.Text = "停止EVE"
        Me.BtnStopEVE.UseVisualStyleBackColor = True
        '
        'BtnPause
        '
        Me.BtnPause.Enabled = False
        Me.BtnPause.Location = New System.Drawing.Point(211, 42)
        Me.BtnPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(89, 40)
        Me.BtnPause.TabIndex = 1
        Me.BtnPause.Text = "暂停"
        Me.BtnPause.UseVisualStyleBackColor = True
        '
        'GroupGlobalSetting
        '
        Me.GroupGlobalSetting.Controls.Add(Me.Panel3)
        Me.GroupGlobalSetting.Location = New System.Drawing.Point(755, 195)
        Me.GroupGlobalSetting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupGlobalSetting.Name = "GroupGlobalSetting"
        Me.GroupGlobalSetting.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupGlobalSetting.Size = New System.Drawing.Size(262, 134)
        Me.GroupGlobalSetting.TabIndex = 3
        Me.GroupGlobalSetting.TabStop = False
        Me.GroupGlobalSetting.Text = "全局设置"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RdiModeEVE)
        Me.Panel3.Controls.Add(Me.RdiModePVE)
        Me.Panel3.Controls.Add(Me.RdiModePVP)
        Me.Panel3.Location = New System.Drawing.Point(30, 18)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 108)
        Me.Panel3.TabIndex = 1
        '
        'RdiModeEVE
        '
        Me.RdiModeEVE.AutoSize = True
        Me.RdiModeEVE.Location = New System.Drawing.Point(12, 82)
        Me.RdiModeEVE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdiModeEVE.Name = "RdiModeEVE"
        Me.RdiModeEVE.Size = New System.Drawing.Size(252, 32)
        Me.RdiModeEVE.TabIndex = 0
        Me.RdiModeEVE.TabStop = True
        Me.RdiModeEVE.Text = "EVE（机器人-机器人）"
        Me.RdiModeEVE.UseVisualStyleBackColor = True
        '
        'RdiModePVE
        '
        Me.RdiModePVE.AutoSize = True
        Me.RdiModePVE.Location = New System.Drawing.Point(12, 45)
        Me.RdiModePVE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdiModePVE.Name = "RdiModePVE"
        Me.RdiModePVE.Size = New System.Drawing.Size(232, 32)
        Me.RdiModePVE.TabIndex = 0
        Me.RdiModePVE.TabStop = True
        Me.RdiModePVE.Text = "PVE（玩家-机器人）"
        Me.RdiModePVE.UseVisualStyleBackColor = True
        '
        'RdiModePVP
        '
        Me.RdiModePVP.AutoSize = True
        Me.RdiModePVP.Checked = True
        Me.RdiModePVP.Location = New System.Drawing.Point(12, 8)
        Me.RdiModePVP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdiModePVP.Name = "RdiModePVP"
        Me.RdiModePVP.Size = New System.Drawing.Size(212, 32)
        Me.RdiModePVP.TabIndex = 0
        Me.RdiModePVP.TabStop = True
        Me.RdiModePVP.Text = "PVP（玩家-玩家）"
        Me.RdiModePVP.UseVisualStyleBackColor = True
        '
        'GpBoxEVESet
        '
        Me.GpBoxEVESet.Controls.Add(Me.Label8)
        Me.GpBoxEVESet.Controls.Add(Me.RdiEVEBlackB)
        Me.GpBoxEVESet.Controls.Add(Me.RdiEVEBlackA)
        Me.GpBoxEVESet.Enabled = False
        Me.GpBoxEVESet.Location = New System.Drawing.Point(1101, 537)
        Me.GpBoxEVESet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpBoxEVESet.Name = "GpBoxEVESet"
        Me.GpBoxEVESet.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpBoxEVESet.Size = New System.Drawing.Size(262, 51)
        Me.GpBoxEVESet.TabIndex = 4
        Me.GpBoxEVESet.TabStop = False
        Me.GpBoxEVESet.Text = "EVE设置"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 28)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "执棋："
        '
        'RdiEVEBlackB
        '
        Me.RdiEVEBlackB.AutoSize = True
        Me.RdiEVEBlackB.Location = New System.Drawing.Point(156, 18)
        Me.RdiEVEBlackB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdiEVEBlackB.Name = "RdiEVEBlackB"
        Me.RdiEVEBlackB.Size = New System.Drawing.Size(92, 32)
        Me.RdiEVEBlackB.TabIndex = 2
        Me.RdiEVEBlackB.Text = "B执黑"
        Me.RdiEVEBlackB.UseVisualStyleBackColor = True
        '
        'RdiEVEBlackA
        '
        Me.RdiEVEBlackA.AutoSize = True
        Me.RdiEVEBlackA.Checked = True
        Me.RdiEVEBlackA.Location = New System.Drawing.Point(71, 18)
        Me.RdiEVEBlackA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdiEVEBlackA.Name = "RdiEVEBlackA"
        Me.RdiEVEBlackA.Size = New System.Drawing.Size(94, 32)
        Me.RdiEVEBlackA.TabIndex = 2
        Me.RdiEVEBlackA.TabStop = True
        Me.RdiEVEBlackA.Text = "A执黑"
        Me.RdiEVEBlackA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "机器人A名称"
        '
        'TxtRobotNameB
        '
        Me.TxtRobotNameB.Location = New System.Drawing.Point(103, 58)
        Me.TxtRobotNameB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRobotNameB.Name = "TxtRobotNameB"
        Me.TxtRobotNameB.Size = New System.Drawing.Size(147, 35)
        Me.TxtRobotNameB.TabIndex = 0
        Me.TxtRobotNameB.Text = "RobotB"
        '
        'TxtRobotNameA
        '
        Me.TxtRobotNameA.Location = New System.Drawing.Point(103, 27)
        Me.TxtRobotNameA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRobotNameA.Name = "TxtRobotNameA"
        Me.TxtRobotNameA.Size = New System.Drawing.Size(147, 35)
        Me.TxtRobotNameA.TabIndex = 0
        Me.TxtRobotNameA.Text = "RobotA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "机器人B名称"
        '
        'TxtRobotLevelA
        '
        Me.TxtRobotLevelA.Location = New System.Drawing.Point(86, 87)
        Me.TxtRobotLevelA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRobotLevelA.Name = "TxtRobotLevelA"
        Me.TxtRobotLevelA.Size = New System.Drawing.Size(59, 35)
        Me.TxtRobotLevelA.TabIndex = 0
        Me.TxtRobotLevelA.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "难度"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "A："
        '
        'TxtRobotLevelB
        '
        Me.TxtRobotLevelB.Location = New System.Drawing.Point(191, 88)
        Me.TxtRobotLevelB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRobotLevelB.Name = "TxtRobotLevelB"
        Me.TxtRobotLevelB.Size = New System.Drawing.Size(59, 35)
        Me.TxtRobotLevelB.TabIndex = 0
        Me.TxtRobotLevelB.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 28)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "B："
        '
        'PanelChessBoard
        '
        Me.PanelChessBoard.BackgroundImage = Global.wuziqi_GUI.My.Resources.chessboard.board
        Me.PanelChessBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelChessBoard.Enabled = False
        Me.PanelChessBoard.Location = New System.Drawing.Point(50, 50)
        Me.PanelChessBoard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelChessBoard.Name = "PanelChessBoard"
        Me.PanelChessBoard.Size = New System.Drawing.Size(680, 680)
        Me.PanelChessBoard.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblIsBExist)
        Me.GroupBox4.Controls.Add(Me.LblIsAExist)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TxtRobotNameA)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TxtRobotNameB)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TxtRobotLevelA)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TxtRobotLevelB)
        Me.GroupBox4.Location = New System.Drawing.Point(1101, 50)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(262, 183)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "机器人设置"
        '
        'LblIsBExist
        '
        Me.LblIsBExist.AutoSize = True
        Me.LblIsBExist.Location = New System.Drawing.Point(128, 151)
        Me.LblIsBExist.Name = "LblIsBExist"
        Me.LblIsBExist.Size = New System.Drawing.Size(0, 28)
        Me.LblIsBExist.TabIndex = 10
        '
        'LblIsAExist
        '
        Me.LblIsAExist.AutoSize = True
        Me.LblIsAExist.Location = New System.Drawing.Point(128, 121)
        Me.LblIsAExist.Name = "LblIsAExist"
        Me.LblIsAExist.Size = New System.Drawing.Size(0, 28)
        Me.LblIsAExist.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(185, 28)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "RobotB.dll 状态："
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(187, 28)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "RobotA.dll 状态："
        '
        'GpBoxPVESet
        '
        Me.GpBoxPVESet.Controls.Add(Me.Label11)
        Me.GpBoxPVESet.Controls.Add(Me.TextBox1)
        Me.GpBoxPVESet.Controls.Add(Me.Label7)
        Me.GpBoxPVESet.Controls.Add(Me.Label4)
        Me.GpBoxPVESet.Controls.Add(Me.Panel2)
        Me.GpBoxPVESet.Controls.Add(Me.Panel1)
        Me.GpBoxPVESet.Enabled = False
        Me.GpBoxPVESet.Location = New System.Drawing.Point(1101, 392)
        Me.GpBoxPVESet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpBoxPVESet.Name = "GpBoxPVESet"
        Me.GpBoxPVESet.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpBoxPVESet.Size = New System.Drawing.Size(262, 137)
        Me.GpBoxPVESet.TabIndex = 6
        Me.GpBoxPVESet.TabStop = False
        Me.GpBoxPVESet.Text = "PVE设置"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 28)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "玩家姓名"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 33)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 35)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "张三"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 28)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "执棋："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "对手："
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RdiPVEBlackRobot)
        Me.Panel2.Controls.Add(Me.RdiPVEBlackPlayer)
        Me.Panel2.Location = New System.Drawing.Point(54, 97)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(202, 28)
        Me.Panel2.TabIndex = 4
        '
        'RdiPVEBlackRobot
        '
        Me.RdiPVEBlackRobot.AutoSize = True
        Me.RdiPVEBlackRobot.Location = New System.Drawing.Point(104, 4)
        Me.RdiPVEBlackRobot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdiPVEBlackRobot.Name = "RdiPVEBlackRobot"
        Me.RdiPVEBlackRobot.Size = New System.Drawing.Size(142, 32)
        Me.RdiPVEBlackRobot.TabIndex = 2
        Me.RdiPVEBlackRobot.Text = "机器人执黑"
        Me.RdiPVEBlackRobot.UseVisualStyleBackColor = True
        '
        'RdiPVEBlackPlayer
        '
        Me.RdiPVEBlackPlayer.AutoSize = True
        Me.RdiPVEBlackPlayer.Checked = True
        Me.RdiPVEBlackPlayer.Location = New System.Drawing.Point(17, 4)
        Me.RdiPVEBlackPlayer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdiPVEBlackPlayer.Name = "RdiPVEBlackPlayer"
        Me.RdiPVEBlackPlayer.Size = New System.Drawing.Size(121, 32)
        Me.RdiPVEBlackPlayer.TabIndex = 2
        Me.RdiPVEBlackPlayer.TabStop = True
        Me.RdiPVEBlackPlayer.Text = "玩家执黑"
        Me.RdiPVEBlackPlayer.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RdiPVERobotB)
        Me.Panel1.Controls.Add(Me.RdiPVERobotA)
        Me.Panel1.Location = New System.Drawing.Point(54, 62)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 33)
        Me.Panel1.TabIndex = 3
        '
        'RdiPVERobotB
        '
        Me.RdiPVERobotB.AutoSize = True
        Me.RdiPVERobotB.Location = New System.Drawing.Point(104, 4)
        Me.RdiPVERobotB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdiPVERobotB.Name = "RdiPVERobotB"
        Me.RdiPVERobotB.Size = New System.Drawing.Size(113, 32)
        Me.RdiPVERobotB.TabIndex = 2
        Me.RdiPVERobotB.Text = "机器人B"
        Me.RdiPVERobotB.UseVisualStyleBackColor = True
        '
        'RdiPVERobotA
        '
        Me.RdiPVERobotA.AutoSize = True
        Me.RdiPVERobotA.Checked = True
        Me.RdiPVERobotA.Location = New System.Drawing.Point(17, 4)
        Me.RdiPVERobotA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdiPVERobotA.Name = "RdiPVERobotA"
        Me.RdiPVERobotA.Size = New System.Drawing.Size(115, 32)
        Me.RdiPVERobotA.TabIndex = 2
        Me.RdiPVERobotA.TabStop = True
        Me.RdiPVERobotA.Text = "机器人A"
        Me.RdiPVERobotA.UseVisualStyleBackColor = True
        '
        'GpBoxPVPSet
        '
        Me.GpBoxPVPSet.Controls.Add(Me.BtnPVPExchangeColor)
        Me.GpBoxPVPSet.Controls.Add(Me.Label10)
        Me.GpBoxPVPSet.Controls.Add(Me.TxtPVPWhiteName)
        Me.GpBoxPVPSet.Controls.Add(Me.Label9)
        Me.GpBoxPVPSet.Controls.Add(Me.TxtPVPBlackName)
        Me.GpBoxPVPSet.Location = New System.Drawing.Point(1101, 252)
        Me.GpBoxPVPSet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpBoxPVPSet.Name = "GpBoxPVPSet"
        Me.GpBoxPVPSet.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpBoxPVPSet.Size = New System.Drawing.Size(262, 132)
        Me.GpBoxPVPSet.TabIndex = 7
        Me.GpBoxPVPSet.TabStop = False
        Me.GpBoxPVPSet.Text = "PVP设置"
        '
        'BtnPVPExchangeColor
        '
        Me.BtnPVPExchangeColor.Location = New System.Drawing.Point(77, 97)
        Me.BtnPVPExchangeColor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnPVPExchangeColor.Name = "BtnPVPExchangeColor"
        Me.BtnPVPExchangeColor.Size = New System.Drawing.Size(90, 24)
        Me.BtnPVPExchangeColor.TabIndex = 2
        Me.BtnPVPExchangeColor.Text = "交换颜色"
        Me.BtnPVPExchangeColor.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 28)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "白棋玩家姓名："
        '
        'TxtPVPWhiteName
        '
        Me.TxtPVPWhiteName.Location = New System.Drawing.Point(110, 66)
        Me.TxtPVPWhiteName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPVPWhiteName.Name = "TxtPVPWhiteName"
        Me.TxtPVPWhiteName.Size = New System.Drawing.Size(140, 35)
        Me.TxtPVPWhiteName.TabIndex = 0
        Me.TxtPVPWhiteName.Text = "罗老师"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 28)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "黑棋玩家姓名："
        '
        'TxtPVPBlackName
        '
        Me.TxtPVPBlackName.Location = New System.Drawing.Point(110, 31)
        Me.TxtPVPBlackName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPVPBlackName.Name = "TxtPVPBlackName"
        Me.TxtPVPBlackName.Size = New System.Drawing.Size(140, 35)
        Me.TxtPVPBlackName.TabIndex = 0
        Me.TxtPVPBlackName.Text = "张三"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblResponseTime)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.LblPlayWhite)
        Me.GroupBox2.Controls.Add(Me.LblPlayBlack)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(755, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 138)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "状态栏："
        '
        'LblResponseTime
        '
        Me.LblResponseTime.AutoSize = True
        Me.LblResponseTime.Location = New System.Drawing.Point(28, 93)
        Me.LblResponseTime.Name = "LblResponseTime"
        Me.LblResponseTime.Size = New System.Drawing.Size(117, 28)
        Me.LblResponseTime.TabIndex = 15
        Me.LblResponseTime.Text = "响应时间："
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 28)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "白棋："
        '
        'LblPlayWhite
        '
        Me.LblPlayWhite.AutoSize = True
        Me.LblPlayWhite.Location = New System.Drawing.Point(93, 59)
        Me.LblPlayWhite.Name = "LblPlayWhite"
        Me.LblPlayWhite.Size = New System.Drawing.Size(0, 28)
        Me.LblPlayWhite.TabIndex = 12
        '
        'LblPlayBlack
        '
        Me.LblPlayBlack.AutoSize = True
        Me.LblPlayBlack.Location = New System.Drawing.Point(93, 26)
        Me.LblPlayBlack.Name = "LblPlayBlack"
        Me.LblPlayBlack.Size = New System.Drawing.Size(0, 28)
        Me.LblPlayBlack.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 28)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "黑棋："
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1424, 781)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GpBoxPVPSet)
        Me.Controls.Add(Me.GpBoxPVESet)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GpBoxEVESet)
        Me.Controls.Add(Me.GroupGlobalSetting)
        Me.Controls.Add(Me.PanelChessBoard)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "五子棋"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupGlobalSetting.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GpBoxEVESet.ResumeLayout(False)
        Me.GpBoxEVESet.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GpBoxPVESet.ResumeLayout(False)
        Me.GpBoxPVESet.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GpBoxPVPSet.ResumeLayout(False)
        Me.GpBoxPVPSet.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents PanelChessBoard As Panel
    Private WithEvents BtnUndo As Button
    Private WithEvents BtnStart As Button
    Private WithEvents BtnGiveUp As Button
    Private WithEvents BtnTip As Button
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents GroupGlobalSetting As GroupBox
    Private WithEvents RdiModeEVE As RadioButton
    Private WithEvents RdiModePVE As RadioButton
    Private WithEvents RdiModePVP As RadioButton
    Private WithEvents GpBoxEVESet As GroupBox
    Private WithEvents Label1 As Label
    Private WithEvents TxtRobotNameB As TextBox
    Private WithEvents TxtRobotNameA As TextBox
    Private WithEvents RdiEVEBlackB As RadioButton
    Private WithEvents RdiEVEBlackA As RadioButton
    Private WithEvents Label2 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label3 As Label
    Private WithEvents TxtRobotLevelB As TextBox
    Private WithEvents TxtRobotLevelA As TextBox
    Private WithEvents GroupBox4 As GroupBox
    Private WithEvents GpBoxPVESet As GroupBox
    Private WithEvents BtnStopEVE As Button
    Private WithEvents BtnPause As Button
    Private WithEvents RdiPVEBlackRobot As RadioButton
    Private WithEvents RdiPVEBlackPlayer As RadioButton
    Private WithEvents RdiPVERobotB As RadioButton
    Private WithEvents RdiPVERobotA As RadioButton
    Private WithEvents Panel1 As Panel
    Private WithEvents Panel3 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label4 As Label
    Private WithEvents GpBoxPVPSet As GroupBox
    Private WithEvents BtnPVPExchangeColor As Button
    Private WithEvents Label10 As Label
    Private WithEvents TxtPVPWhiteName As TextBox
    Private WithEvents Label9 As Label
    Private WithEvents TxtPVPBlackName As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents LblIsBExist As Label
    Private WithEvents LblIsAExist As Label
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents Label15 As Label
    Private WithEvents LblPlayWhite As Label
    Private WithEvents LblPlayBlack As Label
    Private WithEvents Label14 As Label
    Private WithEvents LblResponseTime As Label
End Class
