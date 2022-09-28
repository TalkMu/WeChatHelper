#include <Loger.h>
#include <OffSet.h>
#include <CJsonObject.hpp>
#include <EVString.h>
#include "WxStruct.h"
#include <string>
#include <Command.h>
#include <WebSocket.h>
#include <MemHelper.h>
using namespace std;

#define HOOK_LEN 5

DWORD retAdd;

DWORD GetWechatWin()
{
	return (DWORD)LoadLibrary(L"WeChatWin.dll");
}
void ReceiveMsgProc(LPVOID Context)
{
	//RecieveMsgStruct * msg = (RecieveMsgStruct*)Context;
	////WriteInfo("收到消息1");
	////todo:处理自动功能(自动收款、自动加名片等)
	//neb::CJsonObject data;
	////todo:fromWxid、senderWxid某些特殊消息有异常

	////WriteInfo("收到消息2");
	//data.Add("Type", msg->type);
	//data.Add("IsSelf", msg->isSelf);
	//if (msg->fromWxid != NULL) { data.Add("FromWxid", EVString::w2a(msg->fromWxid)); }
	//if (msg->senderWxid != NULL) { data.Add("SendWxid", EVString::w2a(msg->senderWxid)); }
	//if (msg->content != NULL) { data.Add("Content", EVString::w2a(msg->content)); }
	//if (msg->unkonwStr != NULL) { data.Add("Other", EVString::w2a(msg->unkonwStr)); }
	//delete msg;
	////WriteInfo("收到消息3");
	//Send(Cmd_ReceiveMessage, data);
}

/**
 * 处理拦截到的消息内容
 * @param DWORD data
 * @return VOID
 */
VOID RecieveMessageJump(DWORD edi)
{
	DWORD dataAdd = MemHelper::ReadInt(edi);
	DWORD wxIdAdd = dataAdd + 0x40;
	DWORD contentAdd = dataAdd + 0x68;
	DWORD senderWxIdAdd = dataAdd + 0x164;
	wstring wxId = MemHelper::ReadUnicodeString(wxIdAdd);
	wstring content = MemHelper::ReadUnicodeString(contentAdd);
	wstring senderWxId = MemHelper::ReadUnicodeString(senderWxIdAdd);
	//cout << EVString::w2a_string(wxId).c_str() << "   " << EVString::w2a_string(content).c_str() << endl;
	neb::CJsonObject data;
	data.Add("WxId", EVString::w2a_string(wxId).c_str());
	data.Add("Content", EVString::w2a_string(content).c_str());
	data.Add("SenderWxId", EVString::w2a_string(senderWxId).c_str());
	Send(Cmd_ReceiveMessage, data);
}

DWORD cEax = 0;
DWORD cEcx = 0;
DWORD cEdx = 0;
DWORD cEbx = 0;
DWORD cEsp = 0;
DWORD cEbp = 0;
DWORD cEsi = 0;
DWORD cEdi = 0;
VOID __declspec(naked) HookHandle()
{
	__asm {
		mov cEax, eax
		mov cEcx, ecx
		mov cEdx, edx
		mov cEbx, ebx
		mov cEsp, esp
		mov cEbp, ebp
		mov cEsi, esi
		mov cEdi, edi
	}
	RecieveMessageJump(cEdi);
	__asm {
		mov eax, cEax
		mov ecx, cEcx
		mov edx, cEdx
		mov ebx, cEbx
		mov esp, cEsp
		mov ebp, cEbp
		mov esi, cEsi
		mov edi, cEdi
		jmp retAdd
	}
}
/*
573CD5AE    57              push edi
573CD5AF    51              push ecx
573CD5B0    E8 EB6ECDFF     call WeChatWi.570A44A0
573CD5B5    83C4 04         add esp,0x4


[[edi]] + 0x40	微信ID或群ID
[[edi]] + 0x68	文本内容
[[edi]] + 0x164	群聊的发送人ID
[[edi]] + 0x178	消息ID

HOOK地址：WeChatWin.dll + 3CD5B0
返回地址：WeChatWin.dll + 3CD5B5
*/
void HookChatRecord() 
{
	// HOOK的地址
	DWORD hookAdd = GetWechatWin() + RECIEVE_MESSAGE_CALL;
	// 返回的地址
	retAdd = hookAdd + HOOK_LEN;
	WriteInfo("开始HookChatRecord");
	// 组装数据
	BYTE jmpCode[HOOK_LEN] = { 0xE9 };
	*(DWORD*)&jmpCode[1] = (DWORD)&HookHandle - hookAdd - HOOK_LEN;
	if (WriteProcessMemory(GetCurrentProcess(), (LPVOID)hookAdd, jmpCode, HOOK_LEN, NULL) == 0)
	{
		WriteInfo("HookChat 内存写入失败.");
	}
}