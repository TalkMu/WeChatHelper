#include "pch.h"
#include "HUtil.h"
#include "HTools.h"
#include <iostream>
#include <Windows.h>
#include <Loger.h>

using namespace std;

/// <summary>
/// ���캯�� ��ʼ��΢�Ż�ַ
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
			sprintf_s(nt, "����΢����־-%lld-%d", GetTickCount64(), GetCurrentProcessId());
			SetConsoleTitleA(nt);
			Sleep(100);
			HWND find = FindWindowA(NULL, nt);
			if (find) {
				HMENU menu = GetSystemMenu(find, FALSE);
				if (menu) {
					if (RemoveMenu(menu, 0xF060, 0)) {
						sprintf_s(nt, "����΢����־-%lld-%d-�����ιرհ�ť", GetTickCount64(), GetCurrentProcessId());
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
/// ����ƫ�Ƶõ���ַ
/// </summary>
/// <param name="offset">ƫ��ֵ</param>
DWORD HUtil::Offset(DWORD offset) {
	return wechatWinAdd + offset;
}

/// <summary>
/// ��ȡ΢�Ű汾
/// </summary>
/// <returns></returns>
string HUtil::GetWeChatVersion() {
	HMODULE module = (HMODULE)GetModuleHandle(L"WeChatWin.dll");
	char filename[MAX_PATH] = { 0 };
	::GetModuleFileNameA(module, filename, sizeof(filename) - 1);
	return HTools::GetFileVersion(filename);
}

/// <summary>
/// ��֤΢�Ű汾
/// </summary>
/// <returns></returns>
BOOL HUtil::IsWxVersionValid()
{
	string asVer = HUtil::GetWeChatVersion();
	WriteInfo("���е�΢�Ű汾��" + asVer);
	//�汾ƥ��
	if (asVer == WX_VERSION)
	{
		return TRUE;
	}

	//�汾��ƥ��
	return FALSE;
}