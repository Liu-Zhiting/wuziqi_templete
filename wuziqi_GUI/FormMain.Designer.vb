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
        Me.PanelChessBoard = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolLabelPlayBlack = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolLabelPlayWhite = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolLabelResponseTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.操作ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.开始ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.认输ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.悔棋ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.提示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.暂停ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.停止EVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出游戏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.全局设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PVP玩家玩家ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PVE玩家机器人ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EVE机器人机器人ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.机器人设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobotAdll难度ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTxtRobotLevelA = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RobotBdll难度ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTxtRobotLevelB = New System.Windows.Forms.ToolStripTextBox()
        Me.PVP设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.黑方玩家姓名ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTxtPVPBlackName = New System.Windows.Forms.ToolStripTextBox()
        Me.白方玩家姓名ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTxtPVPWhiteName = New System.Windows.Forms.ToolStripTextBox()
        Me.PVE设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.玩家姓名ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTxtPVEPlayerName = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RobotAdll为对手ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobotBdll为对手ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.玩家执黑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.机器人执黑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EVE设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobotAdll执黑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobotBdll执黑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查看帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolLabelIsAExist = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolLabelIsBExist = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelChessBoard
        '
        Me.PanelChessBoard.BackgroundImage = Global.wuziqi_GUI.My.Resources.chessboard.board
        Me.PanelChessBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelChessBoard.Enabled = False
        Me.PanelChessBoard.Location = New System.Drawing.Point(50, 30)
        Me.PanelChessBoard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelChessBoard.Name = "PanelChessBoard"
        Me.PanelChessBoard.Size = New System.Drawing.Size(450, 450)
        Me.PanelChessBoard.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolLabelPlayBlack, Me.ToolStripStatusLabel3, Me.ToolLabelPlayWhite, Me.ToolStripStatusLabel5, Me.ToolLabelResponseTime})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 509)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(554, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(48, 17)
        Me.ToolStripStatusLabel1.Text = " 黑方："
        '
        'ToolLabelPlayBlack
        '
        Me.ToolLabelPlayBlack.Name = "ToolLabelPlayBlack"
        Me.ToolLabelPlayBlack.Size = New System.Drawing.Size(29, 17)
        Me.ToolLabelPlayBlack.Text = "abc"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(48, 17)
        Me.ToolStripStatusLabel3.Text = " 白方："
        '
        'ToolLabelPlayWhite
        '
        Me.ToolLabelPlayWhite.Name = "ToolLabelPlayWhite"
        Me.ToolLabelPlayWhite.Size = New System.Drawing.Size(33, 17)
        Me.ToolLabelPlayWhite.Text = " abc"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(72, 17)
        Me.ToolStripStatusLabel5.Text = " 响应时间："
        '
        'ToolLabelResponseTime
        '
        Me.ToolLabelResponseTime.Name = "ToolLabelResponseTime"
        Me.ToolLabelResponseTime.Size = New System.Drawing.Size(45, 17)
        Me.ToolLabelResponseTime.Text = "23.33s"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.操作ToolStripMenuItem, Me.设置ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 25)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '操作ToolStripMenuItem
        '
        Me.操作ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.开始ToolStripMenuItem, Me.认输ToolStripMenuItem, Me.悔棋ToolStripMenuItem, Me.提示ToolStripMenuItem, Me.暂停ToolStripMenuItem, Me.停止EVEToolStripMenuItem, Me.ToolStripSeparator4, Me.退出游戏ToolStripMenuItem})
        Me.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem"
        Me.操作ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.操作ToolStripMenuItem.Text = "操作"
        '
        '开始ToolStripMenuItem
        '
        Me.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem"
        Me.开始ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.开始ToolStripMenuItem.Text = "开始"
        '
        '认输ToolStripMenuItem
        '
        Me.认输ToolStripMenuItem.Enabled = False
        Me.认输ToolStripMenuItem.Name = "认输ToolStripMenuItem"
        Me.认输ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.认输ToolStripMenuItem.Text = "认输"
        '
        '悔棋ToolStripMenuItem
        '
        Me.悔棋ToolStripMenuItem.Enabled = False
        Me.悔棋ToolStripMenuItem.Name = "悔棋ToolStripMenuItem"
        Me.悔棋ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.悔棋ToolStripMenuItem.Text = "悔棋"
        '
        '提示ToolStripMenuItem
        '
        Me.提示ToolStripMenuItem.Enabled = False
        Me.提示ToolStripMenuItem.Name = "提示ToolStripMenuItem"
        Me.提示ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.提示ToolStripMenuItem.Text = "提示"
        '
        '暂停ToolStripMenuItem
        '
        Me.暂停ToolStripMenuItem.Enabled = False
        Me.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem"
        Me.暂停ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.暂停ToolStripMenuItem.Text = "暂停"
        '
        '停止EVEToolStripMenuItem
        '
        Me.停止EVEToolStripMenuItem.Enabled = False
        Me.停止EVEToolStripMenuItem.Name = "停止EVEToolStripMenuItem"
        Me.停止EVEToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.停止EVEToolStripMenuItem.Text = "停止EVE"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(121, 6)
        '
        '退出游戏ToolStripMenuItem
        '
        Me.退出游戏ToolStripMenuItem.Name = "退出游戏ToolStripMenuItem"
        Me.退出游戏ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.退出游戏ToolStripMenuItem.Text = "退出游戏"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.全局设置ToolStripMenuItem, Me.机器人设置ToolStripMenuItem, Me.PVP设置ToolStripMenuItem, Me.PVE设置ToolStripMenuItem, Me.EVE设置ToolStripMenuItem})
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        '全局设置ToolStripMenuItem
        '
        Me.全局设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PVP玩家玩家ToolStripMenuItem, Me.PVE玩家机器人ToolStripMenuItem, Me.EVE机器人机器人ToolStripMenuItem})
        Me.全局设置ToolStripMenuItem.Name = "全局设置ToolStripMenuItem"
        Me.全局设置ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.全局设置ToolStripMenuItem.Text = "全局设置"
        '
        'PVP玩家玩家ToolStripMenuItem
        '
        Me.PVP玩家玩家ToolStripMenuItem.Checked = True
        Me.PVP玩家玩家ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PVP玩家玩家ToolStripMenuItem.Name = "PVP玩家玩家ToolStripMenuItem"
        Me.PVP玩家玩家ToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PVP玩家玩家ToolStripMenuItem.Text = "PVP（玩家-玩家）"
        '
        'PVE玩家机器人ToolStripMenuItem
        '
        Me.PVE玩家机器人ToolStripMenuItem.Name = "PVE玩家机器人ToolStripMenuItem"
        Me.PVE玩家机器人ToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.PVE玩家机器人ToolStripMenuItem.Text = "PVE（玩家 -机器人）"
        '
        'EVE机器人机器人ToolStripMenuItem
        '
        Me.EVE机器人机器人ToolStripMenuItem.Name = "EVE机器人机器人ToolStripMenuItem"
        Me.EVE机器人机器人ToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EVE机器人机器人ToolStripMenuItem.Text = "EVE（机器人-机器人）"
        '
        '机器人设置ToolStripMenuItem
        '
        Me.机器人设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolLabelIsAExist, Me.RobotAdll难度ToolStripMenuItem, Me.ToolTxtRobotLevelA, Me.ToolStripSeparator3, Me.ToolStripMenuItem3, Me.ToolLabelIsBExist, Me.RobotBdll难度ToolStripMenuItem, Me.ToolTxtRobotLevelB})
        Me.机器人设置ToolStripMenuItem.Name = "机器人设置ToolStripMenuItem"
        Me.机器人设置ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.机器人设置ToolStripMenuItem.Text = "机器人设置"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "RobotA.dll 状态："
        '
        'RobotAdll难度ToolStripMenuItem
        '
        Me.RobotAdll难度ToolStripMenuItem.Name = "RobotAdll难度ToolStripMenuItem"
        Me.RobotAdll难度ToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RobotAdll难度ToolStripMenuItem.Text = "RobotA.dll 难度："
        '
        'ToolTxtRobotLevelA
        '
        Me.ToolTxtRobotLevelA.Name = "ToolTxtRobotLevelA"
        Me.ToolTxtRobotLevelA.Size = New System.Drawing.Size(100, 23)
        Me.ToolTxtRobotLevelA.Text = "0"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(178, 6)
        '
        'RobotBdll难度ToolStripMenuItem
        '
        Me.RobotBdll难度ToolStripMenuItem.Name = "RobotBdll难度ToolStripMenuItem"
        Me.RobotBdll难度ToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RobotBdll难度ToolStripMenuItem.Text = "RobotB.dll 难度："
        '
        'ToolTxtRobotLevelB
        '
        Me.ToolTxtRobotLevelB.Name = "ToolTxtRobotLevelB"
        Me.ToolTxtRobotLevelB.Size = New System.Drawing.Size(100, 23)
        Me.ToolTxtRobotLevelB.Text = "0"
        '
        'PVP设置ToolStripMenuItem
        '
        Me.PVP设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.黑方玩家姓名ToolStripMenuItem, Me.ToolTxtPVPBlackName, Me.白方玩家姓名ToolStripMenuItem, Me.ToolTxtPVPWhiteName})
        Me.PVP设置ToolStripMenuItem.Name = "PVP设置ToolStripMenuItem"
        Me.PVP设置ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PVP设置ToolStripMenuItem.Text = "PVP设置"
        '
        '黑方玩家姓名ToolStripMenuItem
        '
        Me.黑方玩家姓名ToolStripMenuItem.Name = "黑方玩家姓名ToolStripMenuItem"
        Me.黑方玩家姓名ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.黑方玩家姓名ToolStripMenuItem.Text = "黑方玩家姓名："
        '
        'ToolTxtPVPBlackName
        '
        Me.ToolTxtPVPBlackName.Name = "ToolTxtPVPBlackName"
        Me.ToolTxtPVPBlackName.Size = New System.Drawing.Size(100, 23)
        Me.ToolTxtPVPBlackName.Text = "abc"
        '
        '白方玩家姓名ToolStripMenuItem
        '
        Me.白方玩家姓名ToolStripMenuItem.Name = "白方玩家姓名ToolStripMenuItem"
        Me.白方玩家姓名ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.白方玩家姓名ToolStripMenuItem.Text = "白方玩家姓名："
        '
        'ToolTxtPVPWhiteName
        '
        Me.ToolTxtPVPWhiteName.Name = "ToolTxtPVPWhiteName"
        Me.ToolTxtPVPWhiteName.Size = New System.Drawing.Size(100, 23)
        Me.ToolTxtPVPWhiteName.Text = "abc"
        '
        'PVE设置ToolStripMenuItem
        '
        Me.PVE设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.玩家姓名ToolStripMenuItem, Me.ToolTxtPVEPlayerName, Me.ToolStripSeparator1, Me.RobotAdll为对手ToolStripMenuItem, Me.RobotBdll为对手ToolStripMenuItem, Me.ToolStripSeparator5, Me.玩家执黑ToolStripMenuItem, Me.机器人执黑ToolStripMenuItem})
        Me.PVE设置ToolStripMenuItem.Name = "PVE设置ToolStripMenuItem"
        Me.PVE设置ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PVE设置ToolStripMenuItem.Text = "PVE设置"
        '
        '玩家姓名ToolStripMenuItem
        '
        Me.玩家姓名ToolStripMenuItem.Name = "玩家姓名ToolStripMenuItem"
        Me.玩家姓名ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.玩家姓名ToolStripMenuItem.Text = "玩家姓名："
        '
        'ToolTxtPVEPlayerName
        '
        Me.ToolTxtPVEPlayerName.Name = "ToolTxtPVEPlayerName"
        Me.ToolTxtPVEPlayerName.Size = New System.Drawing.Size(100, 23)
        Me.ToolTxtPVEPlayerName.Text = "abc"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(174, 6)
        '
        'RobotAdll为对手ToolStripMenuItem
        '
        Me.RobotAdll为对手ToolStripMenuItem.Checked = True
        Me.RobotAdll为对手ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RobotAdll为对手ToolStripMenuItem.Name = "RobotAdll为对手ToolStripMenuItem"
        Me.RobotAdll为对手ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RobotAdll为对手ToolStripMenuItem.Text = "RobotA.dll 为对手"
        '
        'RobotBdll为对手ToolStripMenuItem
        '
        Me.RobotBdll为对手ToolStripMenuItem.Name = "RobotBdll为对手ToolStripMenuItem"
        Me.RobotBdll为对手ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RobotBdll为对手ToolStripMenuItem.Text = "RobotB.dll 为对手"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(174, 6)
        '
        '玩家执黑ToolStripMenuItem
        '
        Me.玩家执黑ToolStripMenuItem.Checked = True
        Me.玩家执黑ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.玩家执黑ToolStripMenuItem.Name = "玩家执黑ToolStripMenuItem"
        Me.玩家执黑ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.玩家执黑ToolStripMenuItem.Text = "玩家执黑"
        '
        '机器人执黑ToolStripMenuItem
        '
        Me.机器人执黑ToolStripMenuItem.Name = "机器人执黑ToolStripMenuItem"
        Me.机器人执黑ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.机器人执黑ToolStripMenuItem.Text = "机器人执黑"
        '
        'EVE设置ToolStripMenuItem
        '
        Me.EVE设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RobotAdll执黑ToolStripMenuItem, Me.RobotBdll执黑ToolStripMenuItem})
        Me.EVE设置ToolStripMenuItem.Name = "EVE设置ToolStripMenuItem"
        Me.EVE设置ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EVE设置ToolStripMenuItem.Text = "EVE设置"
        '
        'RobotAdll执黑ToolStripMenuItem
        '
        Me.RobotAdll执黑ToolStripMenuItem.Checked = True
        Me.RobotAdll执黑ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RobotAdll执黑ToolStripMenuItem.Name = "RobotAdll执黑ToolStripMenuItem"
        Me.RobotAdll执黑ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RobotAdll执黑ToolStripMenuItem.Text = "RobotA.dll 执黑"
        '
        'RobotBdll执黑ToolStripMenuItem
        '
        Me.RobotBdll执黑ToolStripMenuItem.Name = "RobotBdll执黑ToolStripMenuItem"
        Me.RobotBdll执黑ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RobotBdll执黑ToolStripMenuItem.Text = "RobotB.dll 执黑"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查看帮助ToolStripMenuItem, Me.ToolStripSeparator2, Me.关于ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '查看帮助ToolStripMenuItem
        '
        Me.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem"
        Me.查看帮助ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.查看帮助ToolStripMenuItem.Text = "查看帮助"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(121, 6)
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'ToolLabelIsAExist
        '
        Me.ToolLabelIsAExist.Name = "ToolLabelIsAExist"
        Me.ToolLabelIsAExist.Size = New System.Drawing.Size(181, 22)
        Me.ToolLabelIsAExist.Text = "???"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem3.Text = "RobotB.dll 状态： "
        '
        'ToolLabelIsBExist
        '
        Me.ToolLabelIsBExist.Name = "ToolLabelIsBExist"
        Me.ToolLabelIsBExist.Size = New System.Drawing.Size(181, 22)
        Me.ToolLabelIsBExist.Text = "???"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(554, 531)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelChessBoard)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "五子棋"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents PanelChessBoard As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 操作ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolLabelPlayBlack As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolLabelPlayWhite As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolLabelResponseTime As ToolStripStatusLabel
    Friend WithEvents 开始ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 认输ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 悔棋ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 提示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 暂停ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 停止EVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 全局设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PVP玩家玩家ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PVE玩家机器人ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EVE机器人机器人ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PVP设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PVE设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EVE设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 黑方玩家姓名ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTxtPVPBlackName As ToolStripTextBox
    Friend WithEvents 白方玩家姓名ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTxtPVPWhiteName As ToolStripTextBox
    Friend WithEvents 机器人设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 玩家姓名ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTxtPVEPlayerName As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RobotAdll执黑ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RobotBdll执黑ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查看帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTxtRobotLevelA As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents RobotBdll难度ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTxtRobotLevelB As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents 退出游戏ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RobotAdll为对手ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RobotBdll为对手ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents 玩家执黑ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 机器人执黑ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RobotAdll难度ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolLabelIsAExist As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolLabelIsBExist As ToolStripMenuItem
End Class
