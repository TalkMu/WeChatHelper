#pragma once
#include <string>
#include <Windows.h>

#define		WX_VERSION		"3.1.0.72"

typedef struct _WXSTRING {
	wchar_t* pstr;
	int len;
	int maxLen;
	int fill1 = 0;
	int fill2 = 0;
} WxString;

class HUtil
{
public:
	HUtil();
	~HUtil();
	/// <summary>
	/// 根据偏移得到地址
	/// </summary>
	/// <param name="offset">偏移值</param>
	/// <returns></returns>
	DWORD Offset(DWORD offset);

	/// <summary>
	/// 获取微信版本
	/// </summary>
	/// <returns></returns>
	static std::string GetWeChatVersion();

	/// <summary>
	/// 验证版本是否匹配
	/// </summary>
	/// <returns></returns>
	static BOOL IsWxVersionValid();

	void OpenConsole();
	void CloseConsole();

private:
	// 微信基址
	DWORD wechatWinAdd = NULL;

	FILE* mConsoleOut;
	std::streambuf* mConsoleOutBackup;
	BOOL mConsoleOpen = FALSE;
};