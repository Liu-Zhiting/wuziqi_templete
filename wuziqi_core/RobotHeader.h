#pragma once

enum PlayerColor
{
    PLAYER_BLACK = 0,
    PLAYER_WHITE = 1
};
enum ChessColor
{
    CHESS_EMPTY = 0,
    CHESS_BLACK = 1,
    CHESS_WHITE = 2
};

#define ROBOT_NAME_LEN 50

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