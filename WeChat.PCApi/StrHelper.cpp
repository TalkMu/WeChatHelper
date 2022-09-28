#include "pch.h"
#include "StrHelper.h"

StrHelper::StrHelper()
{
}
StrHelper::~StrHelper() 
{

}
#pragma region StringToWString
wstring StrHelper::StringToWString(const string str, UINT codePage)
{
	wstring wstrRet = L"";

	if (str.size() > 0)
	{
		int nUnicodeLen = MultiByteToWideChar(codePage, 0, str.c_str(), -1, NULL, 0);
		LPWSTR pUnicode = new WCHAR[nUnicodeLen + 1];
		if (pUnicode != NULL)
		{
			ZeroMemory((void*)pUnicode, (nUnicodeLen + 1) * sizeof(WCHAR));
			MultiByteToWideChar(codePage, 0, str.c_str(), -1, pUnicode, nUnicodeLen);

			wstrRet = pUnicode;
			delete[] pUnicode;
		}
	}
	return wstrRet;
}
#pragma endregion

#pragma region WStringToString
string StrHelper::WStringToString(const wstring wStr, UINT codePage)
{
	string strRet = "";

	if (wStr.size() > 0)
	{
		int  nANSILen = WideCharToMultiByte(codePage, 0, wStr.c_str(), -1, NULL, 0, NULL, NULL);
		char* pANSI = new char[nANSILen + 1];
		if (pANSI != NULL)
		{
			ZeroMemory(pANSI, nANSILen + 1);
			WideCharToMultiByte(codePage, 0, wStr.c_str(), -1, pANSI, nANSILen, NULL, NULL);
			strRet = pANSI;
			delete[] pANSI;
		}
	}
	return strRet;
}
#pragma endregion

#pragma region WCharToChar
char* StrHelper::WCharToChar(const wchar_t* lpszSrc,UINT codePage)
{
	if (lpszSrc != NULL)
	{
		int  nANSILen = WideCharToMultiByte(codePage, 0, lpszSrc, -1, NULL, 0, NULL, NULL);
		char* pANSI = new char[nANSILen + 1];
		if (pANSI != NULL)
		{
			ZeroMemory(pANSI, nANSILen + 1);
			WideCharToMultiByte(codePage, 0, lpszSrc, -1, pANSI, nANSILen, NULL, NULL);
			return pANSI;
		}
	}
	return NULL;
}
#pragma endregion

#pragma region CharToWChar
wchar_t* StrHelper::CharToWChar(const char* lpszSrc, UINT codePage) 
{
	if (lpszSrc != NULL)
	{
		int nUnicodeLen = MultiByteToWideChar(codePage, 0, lpszSrc, -1, NULL, 0);
		LPWSTR pUnicode = new WCHAR[nUnicodeLen + 1];
		if (pUnicode != NULL)
		{
			ZeroMemory((void*)pUnicode, (nUnicodeLen + 1) * sizeof(WCHAR));
			MultiByteToWideChar(codePage, 0, lpszSrc, -1, pUnicode, nUnicodeLen);
			return pUnicode;
		}
	}
	return NULL;
}
#pragma endregion
