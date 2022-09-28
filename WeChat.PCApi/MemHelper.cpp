#include "pch.h"
#include "MemHelper.h"

MemHelper::MemHelper() 
{}
MemHelper::~MemHelper() 
{}
#pragma region ReadUnicodeString
wstring MemHelper::ReadUnicodeString(DWORD address)
{
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
#pragma endregion

#pragma region ReadAsciiString
string MemHelper::ReadAsciiString(DWORD address) {
	string sValue = "";
	char cValue[0x1000] = { 0 };
	memcpy(cValue, (const void*)address, 0x1000);
	sValue = string(cValue);
	return sValue;
}
#pragma endregion

#pragma region ReadInt
DWORD MemHelper::ReadInt(DWORD address) {
	DWORD intValue = 0;
	intValue = *(DWORD*)address;
	return intValue;
}
#pragma endregion
