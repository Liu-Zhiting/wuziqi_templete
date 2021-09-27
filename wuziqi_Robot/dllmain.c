// dllmain.cpp : 定义 DLL 应用程序的入口点。
#include "pch.h"



//
int _stdcall GetNextMove(int map[225], int move);
//
void _stdcall Reset();
//
void _stdcall SetColor(int color);
//
void _stdcall SetLevel(int level);


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
int _stdcall GetNextMove(int map[225], int move)
{
    
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
