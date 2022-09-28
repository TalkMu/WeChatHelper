#include "SendMsg.h"
#include "HUtil.h"
#include "OffSet.h"
#include <string>
#include <Loger.h>
using namespace std;


/// <summary>
/// �����ı���Ϣ
/// </summary>
/// <param name="wxId">΢��ID</param>
/// <param name="msg">��Ϣ����</param>
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
	56D6A1BB    6A 01           push 0x1                                 ; ѹ��0x1
	56D6A1BD    57              push edi                                 ; ѹ�뻺����0x0
	56D6A1BE    53              push ebx                                 ; ��Ϣ����(WxString)
	56D6A1BF    8D95 78FFFFFF   lea edx,dword ptr ss:[ebp-0x88]          ; ������wxid(WxString)
	56D6A1C5    8D8D 58FAFFFF   lea ecx,dword ptr ss:[ebp-0x5A8]         ; 0x5A8��С�Ļ�����
	56D6A1CB    E8 D06A2900     call WeChatWi.57000CA0                   ; ��Ϣ����call
	56D6A1D0    83C4 0C         add esp,0xC                              ; ��ƽջ
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