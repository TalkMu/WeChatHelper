#pragma once
#include <string>
#include "pch.h"
using namespace std;

class StrHelper
{
public:
	StrHelper();
	~StrHelper();

private:

public:
	static wstring StringToWString(const string str,UINT codePage = CP_ACP);
	static string WStringToString(const wstring wStr, UINT CodePage = CP_ACP);

	static char* WCharToChar(const wchar_t* lpszSrc, UINT CodePage = CP_ACP);
	static wchar_t* CharToWChar(const char* lpszSrc, UINT   CodePage = CP_ACP);

	
};

