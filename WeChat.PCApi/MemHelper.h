#pragma once
#include <string>
#include "pch.h"
using namespace std;
class MemHelper
{
public:
	MemHelper();
	~MemHelper();

private:

public:
	static string ReadAsciiString(DWORD address);
	static wstring ReadUnicodeString(DWORD address);
	static DWORD ReadInt(DWORD address);
};
