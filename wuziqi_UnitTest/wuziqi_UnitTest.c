#include "RobotHeader.h"
#include <stdio.h>


// 在控制台中打印15*15的棋盘
void printMap(int map[225]);

// 获取当前时间
double getTime();

int main()
{
    /*
    提示：
    从命令行输入行、列来获取玩家落子位置，调用GetNextMove函数获取机器人落子位置
    使用system("cls")清屏，调用printMap打印走完这两步后的棋盘
    在调用GetNextMove函数之前与之后，分别获取当前时间，两者相减即为机器人响应时间
    */

    // 这是一个对printMap函数的测试，我随便写的（逃   
    int map[225] = { 0 };
    map[0] = 1;
    map[1] = 2;
    map[15] = 1;
    printMap(map);
    return 0;
}

void printMap(int map[225])
{
    const char* symbol[3] = { "  ","●","○" };
    int i, j;
    for (i = 0; i < 15; i++)
    {
        printf("%2d ", (i + 1));
        for (j = 0; j < 15; j++)
        {
            printf("%2s", symbol[map[i * 15 + j]]);
        }
        printf("\n");
    }
    printf("   ");
    for (i = 0; i < 15; i++)
    {
        printf("%2d", (i + 1));
    }
}

double getTime()
{
    // 我比较懒，这个留给大神自己实现哈（逃
    return 0.0;
}
