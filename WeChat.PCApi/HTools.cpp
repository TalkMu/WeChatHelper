#include "pch.h"
#include "HTools.h"
#include <corecrt_io.h>
#include <direct.h>

using namespace std;

#pragma comment(lib, "version.lib")

/// <summary>
/// 根据偏移得到地址
/// </summary>
/// <param name="offset">偏移值</param>
DWORD HTools::Offset(DWORD offset) {
	return GetWeChatWinBase() + offset;
}

/// <summary>
/// 获取应用版本号
/// </summary>
/// <param name="filePath">文件路径</param>
/// <returns></returns>
string HTools::GetFileVersion(std::string filePath)
{
	
	string version = "0.0.0.0";
	if (FileExist(filePath))
	{
		VS_FIXEDFILEINFO* fInfo;
		unsigned int fSize = sizeof(VS_FIXEDFILEINFO);
		// 获取版本信息大小
		int size = GetFileVersionInfoSizeA(filePath.c_str(), NULL);
		if (size != 0)
		{
			size = size * 2;
			char* buff = new char[size];
			// 检索指定文件的版本信息
			if (GetFileVersionInfoA(filePath.c_str(), NULL, size, buff))
			{
				if (VerQueryValueA(buff, "\\", (void**)&fInfo, &fSize)) {
					sprintf(buff, "%d.%d.%d.%d",
						HIWORD(fInfo->dwFileVersionMS),
						LOWORD(fInfo->dwFileVersionMS),
						HIWORD(fInfo->dwFileVersionLS),
						LOWORD(fInfo->dwFileVersionLS));
					version = buff;
				}
				delete[] buff;
			}
		}
	}
	return version;
}

/// <summary>
/// 判断文件是否存在
/// </summary>
/// <param name="filePath">文件路径</param>
/// <returns></returns>
BOOL HTools::FileExist(std::string filePath)
{
	struct stat buffer;
	// 通过文件名filename获取文件信息，并保存在buf所指的结构体stat中
	// 返回值: 执行成功则返回0，失败返回-1
	// 因此如果文件存在，该函数将返回0，否则返回1
	int exist = stat(filePath.c_str(), &buffer);
	if (exist == 0)
	{
		return true;
	}
	else
	{
		return false;
	}
}



/// <summary>
/// 创建目录
/// </summary>
/// <param name="dir"></param>
void HTools::CreateDir(const char* dir)
{
	int m = 0, n;
	string str1, str2;

	str1 = dir;
	str2 = str1.substr(0, 2);
	str1 = str1.substr(3, str1.size());

	while (m >= 0)
	{
		m = str1.find('\\');
		str2 += '\\' + str1.substr(0, m);
		n = _access(str2.c_str(), 0); //判断该目录是否存在
		if (n == -1)
		{
			_mkdir(str2.c_str());     //创建目录
		}
		str1 = str1.substr(m + 1, str1.size());
	}
}

DWORD HTools::ReadInt(DWORD address) {
	DWORD intValue = 0;
	intValue = *(DWORD*)address;
	return intValue;
}

string HTools::ReadAsciiString(DWORD address) {
	string sValue = "";
	char cValue[0x1000] = { 0 };
	memcpy(cValue, (const void*)address, 0x1000);
	sValue = string(cValue);
	return sValue;
}

wstring HTools::ReadUnicodeString(DWORD address) {
	wstring value;
	int slen = (int)ReadInt(address + 0x4);
	DWORD str = ReadInt(address);
	if (str == NULL || slen == 0) {
		return value;
	}
	wchar_t* buffer = NULL;
	do {
		buffer = new wchar_t[slen + 1];
	} while (buffer == NULL);
	wmemset(buffer, 0, slen + 1);
	wmemcpy(buffer, (const wchar_t*)str, slen);
	buffer[slen] = '\0';
	value.append(buffer);
	delete[] buffer;
	return value;
}

DWORD HTools::GetWeChatWinBase()
{
	return (DWORD)LoadLibrary(L"WeChatWin.dll");
}

/// <summary>
/// 获取微信版本
/// </summary>
/// <returns></returns>
string HTools::GetWeChatVersion() {
	HMODULE module = (HMODULE)GetModuleHandle(L"WeChatWin.dll");
	char filename[MAX_PATH] = { 0 };
	::GetModuleFileNameA(module, filename, sizeof(filename) - 1);
	return HTools::GetFileVersion(filename);
}

/// <summary>
/// 验证微信版本
/// </summary>
/// <returns></returns>
BOOL HTools::IsWxVersionValid()
{
	string asVer = HTools::GetWeChatVersion();
	//版本匹配
	if (asVer == WX_VERSION)
	{
		return TRUE;
	}

	//版本不匹配
	return FALSE;
}