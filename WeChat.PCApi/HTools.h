#pragma once
#include <string>
#include "pch.h"

#define		WX_VERSION		"3.1.0.72"

class HTools
{
public:
	HTools();
	~HTools();
	/// <summary>
	/// ����ƫ�Ƶõ���ַ
	/// </summary>
	/// <param name="offset">ƫ��ֵ</param>
	/// <returns></returns>
	static DWORD Offset(DWORD offset);
	/// <summary>
	/// ��ȡ΢�Ű汾
	/// </summary>
	/// <param name="filePath">΢���ļ�·��WeChat.exe</param>
	/// <returns></returns>
	static std::string GetFileVersion(std::string filePath);
	/// <summary>
	/// ��ȡ΢�Ű汾
	/// </summary>
	/// <returns></returns>
	static std::string GetWeChatVersion();

	/// <summary>
	/// �ж��ļ��Ƿ����
	/// </summary>
	/// <param name="file">�ļ�·��</param>
	/// <returns></returns>
	static BOOL FileExist(std::string filePath);

	/// <summary>
	/// ����Ŀ¼
	/// </summary>
	static void CreateDir(const char* dir);

	/// <summary>
	/// ��ȡWeChatWin.dll��ַ
	/// </summary>
	/// <returns></returns>
	static DWORD GetWeChatWinBase();

	/// <summary>
	/// ���΢�Ű汾�Ƿ�ƥ��
	/// </summary>
	/// <returns></returns>
	static BOOL IsWxVersionValid();

	/// <summary>
	/// ����ת��
	/// </summary>
	/// <param name="unicode"></param>
	/// <returns></returns>
	static char* UnicodeToUtf8(const wchar_t* unicode);

	/// <summary>
	/// ����ת��
	/// </summary>
	/// <param name="str"></param>
	/// <returns></returns>
	static wchar_t* UTF8ToUnicode(const char* str);

	/// <summary>
	/// ����ת��
	/// </summary>
	/// <param name="sInfo"></param>
	/// <param name="sourceEncode"></param>
	/// <param name="targetEncode"></param>
	/// <returns></returns>
	static std::string EncodeConvert(std::string sInfo, INT sourceEncode, INT targetEncode);

	/// <summary>
	/// ����ת��
	/// </summary>
	/// <param name="str"></param>
	/// <returns></returns>
	static wchar_t* StrToWchar(std::string str);

	/// <summary>
	/// ��ȡ��ַ
	/// </summary>
	/// <param name="address"></param>
	/// <returns></returns>
	static DWORD ReadInt(DWORD address);

	/// <summary>
	/// ��ȡ����
	/// </summary>
	/// <param name="address"></param>
	/// <returns></returns>
	static std::string ReadAsciiString(DWORD address);

	/// <summary>
	/// ��ȡ����
	/// </summary>
	/// <param name="address"></param>
	/// <returns></returns>
	static std::wstring ReadUnicodeString(DWORD address);
private:

};