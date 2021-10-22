#include "RobotHeader.h"
#include <string.h>
#include <stdlib.h>

int _stdcall GetNextMove(int map[225])
{
    return 0;
}

void _stdcall Reset()
{

}

void _stdcall SetColor(int color)
{

}

void _stdcall SetLevel(int level)
{

}

void _stdcall GetName(char name[])
{
    // u8前缀用于表明使用UTF-8字符集，必须加上，否则可能乱码
    memset(name, 0, ROBOT_NAME_LEN);
    strcpy_s(name, ROBOT_NAME_LEN, u8"蒸汽机器人（逃");
}