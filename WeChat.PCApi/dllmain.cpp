// dllmain.cpp : 定义 DLL 应用程序的入口点。
#include "framework.h"
#include <WebSocket.h>
#include <RecMessage.h>
#include <HUtil.h>
#include <ContactList.h>

HUtil* Util = new HUtil();

DWORD WINAPI ThreadProc(_In_ HMODULE hModule);
BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
        CreateThread(NULL, 0, (LPTHREAD_START_ROUTINE)ThreadProc, hModule, 0, NULL);
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

DWORD WINAPI ThreadProc(_In_ HMODULE hModule)
{
    HookChatRecord();
    //Util->OpenConsole();
    InitWebSocket();
    //GetUserInfo();
    //GetContactList();
    return true;
}