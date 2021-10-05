// dllmain.cpp : 定义 DLL 应用程序的入口点。
#include "pch.h"
#define ROBOT_NAME_LEN 50


//
int _stdcall GetNextMove(int map[225]);
//
void _stdcall Reset();
//
void _stdcall SetColor(int color);
//
void _stdcall SetLevel(int level);
//
void _stdcall GetName(char name[]);


BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

//function
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
    strcpy_s(name,ROBOT_NAME_LEN, u8"蒸汽机器人（逃");
}
