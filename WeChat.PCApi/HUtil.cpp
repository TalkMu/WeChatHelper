#include "pch.h"
#include "HUtil.h"
#include "HTools.h"
#include <iostream>
#include <Windows.h>
#include <Loger.h>

using namespace std;

/// <summary>
/// 构造函数 初始化微信基址
/// </summary>
/// <returns></returns>
HUtil::HUtil(){
	wechatWinAdd = (DWORD)GetModuleHandle(L"WeChatWin.dll");
}

HUtil::~HUtil() {
}
void HUtil::OpenConsole() {
	if (!mConsoleOpen) {
		if (AllocConsole()) {
			mConsoleOutBackup = cout.rdbuf();
			mConsoleOut = freopen("CONOUT$", "w", stdout);
			char nt[100];
			sprintf_s(nt, "地狱微信日志-%lld-%d", GetTickCount64(), GetCurrentProcessId());
			SetConsoleTitleA(nt);
			Sleep(100);
			HWND find = FindWindowA(NULL, nt);
			if (find) {
				HMENU menu = GetSystemMenu(find, FALSE);
				if (menu) {
					if (RemoveMenu(menu, 0xF060, 0)) {
						sprintf_s(nt, "地狱微信日志-%lld-%d-已屏蔽关闭按钮", GetTickCount64(), GetCurrentProcessId());
						SetConsoleTitleA(nt);
					}
				}
			}
		}
		wcout.imbue(locale("", LC_CTYPE));
		mConsoleOpen = TRUE;
	}
}

void HUtil::CloseConsole() {
	if (mConsoleOpen) {
		if (mConsoleOut != NULL && mConsoleOutBackup != NULL) {
			cout.rdbuf(mConsoleOutBackup);
			fclose(mConsoleOut);
		}
		FreeConsole();
		mConsoleOpen = FALSE;
	}
}
/// <summary>
/// 根据偏移得到地址
/// </summary>
/// <param name="offset">偏移值</param>
DWORD HUtil::Offset(DWORD offset) {
	return wechatWinAdd + offset;
}

/// <summary>
/// 获取微信版本
/// </summary>
/// <returns></returns>
string HUtil::GetWeChatVersion() {
	HMODULE module = (HMODULE)GetModuleHandle(L"WeChatWin.dll");
	char filename[MAX_PATH] = { 0 };
	::GetModuleFileNameA(module, filename, sizeof(filename) - 1);
	return HTools::GetFileVersion(filename);
}

/// <summary>
/// 验证微信版本
/// </summary>
/// <returns></returns>
BOOL HUtil::IsWxVersionValid()
{
	string asVer = HUtil::GetWeChatVersion();
	WriteInfo("运行的微信版本：" + asVer);
	//版本匹配
	if (asVer == WX_VERSION)
	{
		return TRUE;
	}

	//版本不匹配
	return FALSE;
}