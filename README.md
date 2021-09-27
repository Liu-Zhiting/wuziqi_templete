# wuziqi2020
五子棋AI

本项目专门用于UESTC2020-C语言A班各位大神提交作业！

## 核心目标
利用所学C语言技能，实现五子棋AI算法，并用自学的Visual Basic .NET 制作交互式图形界面调用C语言编译的dll，实现VB与C的通信

## 项目说明

### wuziqi_Robot

五子棋机器人，C语言编写的dll项目，作业的主要成分

采用极大极小值搜索 + alpha-beta剪枝，运行时可自由设置搜索层数为4、6、8层

4层搜索平均用时 0.2 sec，6层平均用时 1 sec，8层搜索平均用时 10 sec

为提高性能，采用了贪心评估算法缩减结点，并将评估函数返回值打表编译在dll里

### wuziqi_GUI

Visual Basic .NET 编写的winform GUI，调用外置dll中的机器人

可进行人人对战、人机对战、机器人对战（暂时不可用）的五子棋游戏平台

### wuziqi_Judge

C语言编写的dll项目，用于判断棋局状态为【没有结束】、【黑方胜】、【白方胜】或者【和棋】

### wuziqi_GE_data_generator

Visual Basic .NET 编写的控制台程序，用于对评估函数返回值打表

### wuziqi_C_Debug

用于从项目中复制C代码并调试的项目

## 下一步的工作

### wuziqi_Robot

- 利用启发式算法优化 alpha-beta剪枝
- 尝试用多线程技术加快估值过程
- 尝试用策略模式 + 工厂模式 重构 GlobalEvaluation 模块

### wuziqi_GUI

- 在GUI里添加悔棋、暂停、提示功能
- 使用多线程技术避免界面假死

## 暂不添加的高级功能

以下功能在教程中提到过或曾计划实现，但由于某些原因暂不添加至项目中。如果之后有意实现某功能，我将从本列表中移除它。

- Zobrist 散列实现缓存
- 训练 BP 神经网络以替代贪心算法做评估函数
- 添加黑棋的“禁手”规则
- 基于活三与冲四的“算杀” 
- 用WPF重写GUI
- 使用GacUI 、Ant Design、Sunny UI 等第三方UI项目重写UI
- 另外实现基于 遗传算法 的五子棋AI

## 参考

- [本项目的wiki，包括我转载的俸爷转载的五子棋教程（逃](https://github.com/SMagic-L/wuziqi2020/wiki)

