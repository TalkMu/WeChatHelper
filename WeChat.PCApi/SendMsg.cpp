#include "SendMsg.h"
#include "HUtil.h"
#include "OffSet.h"
#include <string>
#include <Loger.h>
using namespace std;


/// <summary>
/// 发送文本消息
/// </summary>
/// <param name="wxId">微信ID</param>
/// <param name="msg">消息内容</param>
void SendTextMsg(wstring wxId,wstring msg) 
{
	WriteInfo("SendTextMsg");
	HUtil* Util = new HUtil();
	WxString to = { 0 };
	WxString text = { 0 };

	to.pstr = (wchar_t*)wxId.c_str();
	to.len = wxId.size();
	to.maxLen = wxId.size() * 2;

	text.pstr = (wchar_t*)msg.c_str();
	text.len = msg.size();
	text.maxLen = msg.size() * 2;

	/*
	56D6A1BB    6A 01           push 0x1                                 ; 压入0x1
	56D6A1BD    57              push edi                                 ; 压入缓存区0x0
	56D6A1BE    53              push ebx                                 ; 消息内容(WxString)
	56D6A1BF    8D95 78FFFFFF   lea edx,dword ptr ss:[ebp-0x88]          ; 接收人wxid(WxString)
	56D6A1C5    8D8D 58FAFFFF   lea ecx,dword ptr ss:[ebp-0x5A8]         ; 0x5A8大小的缓存区
	56D6A1CB    E8 D06A2900     call WeChatWi.57000CA0                   ; 消息发送call
	56D6A1D0    83C4 0C         add esp,0xC                              ; 外平栈
	*/

	char ediBuff[0x20] = { 0 };
	char ecxBuff[0x5A8] = { 0 };

	DWORD sendCall = Util->Offset(SEND_MESSAGE_CALL);
	__asm
	{
		push 0x1;
		lea edi, ediBuff;
		push edi;
		lea ebx, text;
		push ebx;
		lea edx, to;
		lea ecx, ecxBuff;
		call sendCall;
		add esp, 0xC;

	}
}