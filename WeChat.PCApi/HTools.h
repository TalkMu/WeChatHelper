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
	/// 根据偏移得到地址
	/// </summary>
	/// <param name="offset">偏移值</param>
	/// <returns></returns>
	static DWORD Offset(DWORD offset);
	/// <summary>
	/// 获取微信版本
	/// </summary>
	/// <param name="filePath">微信文件路径WeChat.exe</param>
	/// <returns></returns>
	static std::string GetFileVersion(std::string filePath);
	/// <summary>
	/// 获取微信版本
	/// </summary>
	/// <returns></returns>
	static std::string GetWeChatVersion();

	/// <summary>
	/// 判断文件是否存在
	/// </summary>
	/// <param name="file">文件路径</param>
	/// <returns></returns>
	static BOOL FileExist(std::string filePath);

	/// <summary>
	/// 创建目录
	/// </summary>
	static void CreateDir(const char* dir);

	/// <summary>
	/// 获取WeChatWin.dll地址
	/// </summary>
	/// <returns></returns>
	static DWORD GetWeChatWinBase();

	/// <summary>
	/// 检查微信版本是否匹配
	/// </summary>
	/// <returns></returns>
	static BOOL IsWxVersionValid();

	/// <summary>
	/// 编码转换
	/// </summary>
	/// <param name="unicode"></param>
	/// <returns></returns>
	static char* UnicodeToUtf8(const wchar_t* unicode);

	/// <summary>
	/// 编码转换
	/// </summary>
	/// <param name="str"></param>
	/// <returns></returns>
	static wchar_t* UTF8ToUnicode(const char* str);

	/// <summary>
	/// 编码转换
	/// </summary>
	/// <param name="sInfo"></param>
	/// <param name="sourceEncode"></param>
	/// <param name="targetEncode"></param>
	/// <returns></returns>
	static std::string EncodeConvert(std::string sInfo, INT sourceEncode, INT targetEncode);

	/// <summary>
	/// 编码转换
	/// </summary>
	/// <param name="str"></param>
	/// <returns></returns>
	static wchar_t* StrToWchar(std::string str);

	/// <summary>
	/// 读取地址
	/// </summary>
	/// <param name="address"></param>
	/// <returns></returns>
	static DWORD ReadInt(DWORD address);

	/// <summary>
	/// 读取内容
	/// </summary>
	/// <param name="address"></param>
	/// <returns></returns>
	static std::string ReadAsciiString(DWORD address);

	/// <summary>
	/// 读取内容
	/// </summary>
	/// <param name="address"></param>
	/// <returns></returns>
	static std::wstring ReadUnicodeString(DWORD address);
private:

};