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
	/// ����ƫ�Ƶõ���ַ
	/// </summary>
	/// <param name="offset">ƫ��ֵ</param>
	/// <returns></returns>
	DWORD Offset(DWORD offset);

	/// <summary>
	/// ��ȡ΢�Ű汾
	/// </summary>
	/// <returns></returns>
	static std::string GetWeChatVersion();

	/// <summary>
	/// ��֤�汾�Ƿ�ƥ��
	/// </summary>
	/// <returns></returns>
	static BOOL IsWxVersionValid();

	void OpenConsole();
	void CloseConsole();

private:
	// ΢�Ż�ַ
	DWORD wechatWinAdd = NULL;

	FILE* mConsoleOut;
	std::streambuf* mConsoleOutBackup;
	BOOL mConsoleOpen = FALSE;
};