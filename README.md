# wuziqi_templete
本项目为电子科技大学C语言A班的各位大神设计，用于辅助完成五子棋AI实验，并提供AI之间对战的平台。

使用中如果遇到问题，请发送邮件给[我](mailto:ztliu2019cs@alu.uestc.edu.cn)，谢谢！

## 核心目标
- [x] 使用 visual basic 完成一个 winform GUI，令使用者可以专心实现五子棋AI算法，更快的完成实验
- [ ] 提供AI对战平台，令使用者的作品可以与好友的作品一起友好竞技

## 快速开始

这里简单介绍如何使用wuziqi_templete完成实验，有关本项目的文档仍在建设中。

### 获取实验代码

选择一个文件夹，打开powershell或者命令提示符，执行以下指令，以从github获取实验代码

```sh
git clone https://github.com/Liu-Zhiting/wuziqi_templete.git
cd wuziqi_templete
```

运行Visual Studio 2019，打开解决方案。

### 编写机器人代码

这里我们约定，五子棋的棋盘使用长度为15*15=225的int数组来表示，第`i * 15 + j`个元素表示第 i 行第 j 列的棋子。

打开wuziqi_core项目中的`RobotHeader.h`，该文件包含了玩家颜色的枚举`enum PlayerColor`以及棋盘每个格子颜色（状态）的枚举`enum ChessColor`，设置枚举的目的在于规范代码，提高可读性。

```
// 传入一个15*15的棋盘，返回Robot下一步落子的位置
int _stdcall GetNextMove(int map[225]);

// 重置机器人设置
void _stdcall Reset();

// 设置机器人执棋颜色
void _stdcall SetColor(int color);

// 设置机器人能力等级
void _stdcall SetLevel(int level);

// 获取机器人的名字（UTF-8字符串）
void _stdcall GetName(char name[]);
```

打开wuziqi_core项目中的`main.c`，完成main.c中预留的函数。

`GetNextMove`与`SetColor`是机器人必需的，前者是获取机器人下一步落子位置的函数，后者是设置机器人执白棋或者执黑棋的函数。`SetLevel`是设置机器人能力等级的函数，如果你的机器人支持设置难度，可以实现它，否则可以留空。`Reset`函数可以用于重置一些全局变量。`GetName`函数用于获取你为机器人取的名字，只需要修改双引号内的文本即可，**不要去除双引号前的u8前缀**。

**不要对函数名、参数、返回类型作任何更改**，因为它们将作为接口函数在dll中被导出，从而可以被GUI调用。

如果需要添加更多的源代码文件和头文件，**请添加在wuziqi_core项目中**。wuziqi_core是一个共享项目，其他项目会引用它，然后使用其中的代码。在解决方案管理器中，右击“wuziqi_core”，选择添加项-新建项即可。

### 在控制台程序中调试代码

打开wuziqi_UnitTest项目中的`wuziqi_UnitTest.c`文件，根据main函数中的提示，编写代码，调用GetNextMove以及其他函数。

`printMap`是用于在控制台中显示五子棋棋盘的函数。`getTime`是用于获取当前时间的函数，可以测试机器人响应时间。

```
// 在控制台中打印15*15的棋盘
void printMap(int map[225]);

// 获取当前时间
double getTime();
```

wuziqi_core是一个共享项目，wuziqi_UnitTest引用了这个项目，因此可以在wuziqi_core项目中的代码文件里设置断点，VS调试器在运行该项目生成的可执行文件`wuziqi_UnitTest.exe`时，可以正常命中断点。

编译VS解决方案，运行wuziqi_UnitTest.exe，根据运行情况对代码进行调试。

### 在GUI中与你的机器人对弈

确认无误之后，将wuziqi_Robot.dll复制一份，并更名为RobotA.dll或者RobotB.dll。GUI 仅能识别其所在目录中的RobotA.dll或者RobotB.dll。

打开wuziqi_GUI.exe，点击【设置】-【机器人设置】，查看机器人是否就绪。点击【设置】-【全局设置】-【PVE（玩家-机器人）】，然后点击【操作】-【开始】，即可开始游戏。

## 注意事项

- 使用 Visual Studio 编译时请将解决方案平台选择为Any CPU，否则可能会出现bug。如果运行时引发了`System.BadImageFormatException`，请考虑将该选项改为Any CPU然后重新编译。
- 如果你不理解wuziqi_GUI项目中的代码，那么请尽量不要修改它。



