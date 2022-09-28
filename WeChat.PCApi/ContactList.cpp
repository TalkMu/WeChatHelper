#include <Loger.h>
#include <OffSet.h>
#include <CJsonObject.hpp>
#include <EVString.h>
#include <string>
#include <Command.h>
#include <WebSocket.h>
#include <MemHelper.h>
using namespace std;

#define HOOK_LEN 5

DWORD jumBackAddress;
DWORD retCallAdd;

extern DWORD GetWechatWin1()
{
	return (DWORD)LoadLibrary(L"WeChatWin.dll");
}

/*
微信ID（ascii）：eax + 0x10
微信ID（unicode）：eax + 0x30
微信号（unicode）：eax + 0x44
V（unicode）：eax + 0x58
备注（unicode）：eax + 0x78
名称（unicode）：eax + 0x8C
拼音缩写（unicode）：eax + 0xCC
头像（unicode）：eax + 0x11C
个性签名（unicode）：eax + 0x1BC
国籍（unicode）：eax + 0x1D0
省（unicode）：eax + 0x1E4
市（unicode）：eax + 0x1F8
好友来源（unicode）：eax + 0x20C
朋友圈图片（unicode）：eax + 0x29C
*/
void GetContactJump(DWORD eax) 
{
	if (eax == NULL)
	{
		return;
	}
	cout << "eax:"<< eax << endl;
	DWORD wxIdAdd = eax + 0x30;
	DWORD accountAdd = eax + 0x44;
	DWORD vAdd = eax + 0x58;
	DWORD remarksAdd = eax + 0x78;
	DWORD nickNameAdd = eax + 0x8C;
	DWORD headImgAdd = eax + 0x11C;
	DWORD signAdd = eax + 0x1BC;
	WriteInfo("1");
	wchar_t wxId[0x100] = { 0 };
	swprintf_s(wxId, L"%s", *((LPVOID*)wxIdAdd));
	//wstring wxId = HTools::ReadUnicodeString(wxIdAdd);
	WriteInfo("wxid");
	wstring account = MemHelper::ReadUnicodeString(accountAdd);
	WriteInfo("account");
	wstring v = MemHelper::ReadUnicodeString(vAdd);
	WriteInfo("v");
	wstring remarks = MemHelper::ReadUnicodeString(remarksAdd);
	WriteInfo("remarks");
	wstring nickName = MemHelper::ReadUnicodeString(nickNameAdd);
	WriteInfo("nickName");
	wstring headImg = MemHelper::ReadUnicodeString(headImgAdd);
	WriteInfo("headImg");
	wstring sign = MemHelper::ReadUnicodeString(signAdd);
	WriteInfo("sign");
	cout << EVString::w2a(wxId) << ":" << EVString::w2a_string(account).c_str()<<":"<< EVString::w2a_string(nickName, CP_ACP).c_str() << endl;
}

DWORD hEax;
DWORD hEcx;
DWORD hEdx;
DWORD hEbx;
DWORD hEsp;
DWORD hEbp;
DWORD hEsi;
DWORD hEdi;
VOID __declspec(naked) HookContactHandle()
{
	__asm {
		call retCallAdd
		mov hEax, eax
		mov hEcx, ecx
		mov hEdx, edx
		mov hEbx, ebx
		mov hEsp, esp
		mov hEbp, ebp
		mov hEsi, esi
		mov hEdi, edi
	}
	GetContactJump(hEax);
	__asm {
		mov eax, hEax
		mov ecx, hEcx
		mov edx, hEdx
		mov ebx, hEbx
		mov esp, hEsp
		mov ebp, hEbp
		mov esi, hEsi
		mov edi, hEdi
		jmp jumBackAddress
	}
}

void GetContactList() 
{
	// HOOK的地址
	DWORD hookAdd = GetWechatWin1() + FRIEND_LIST;
	retCallAdd = GetWechatWin1() + 0xF8A90;
	//跳回的地址
	jumBackAddress = hookAdd + HOOK_LEN;
	WriteInfo("开始GetContactList");
	// 组装数据
	BYTE jmpCode[HOOK_LEN] = { 0xE9 };
	*(DWORD*)&jmpCode[1] = (DWORD)&HookContactHandle - hookAdd - HOOK_LEN;
	if (WriteProcessMemory(GetCurrentProcess(), (LPVOID)hookAdd, jmpCode, HOOK_LEN, NULL) == 0)
	{
		WriteInfo("GetContactList 内存写入失败.");
	}
}