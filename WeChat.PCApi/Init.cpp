#include "Init.h"
#include "HUtil.h"
#include "Command.h"
#include "Sql.h"
#include "WebSocket.h"
#include "CJsonObject.hpp"

bool isHook = false;
/**
 * ��ʼ�� Hook
 * @param
 * @return void
*/
void InitWeChat() {
	neb::CJsonObject result;

	if (isHook) {
		Send(Cmd_Init, result, "", L"�ѳ�ʼ����");
		return;
	}
	//��鵱ǰ΢�Ű汾
	try
	{
		if (HUtil::IsWxVersionValid()) {

			//HookDB();

			//HookChatRecord();

			isHook = true;

			Send(Cmd_Init, result, "",  L"��ʼ���ɹ���");
		}
		else
		{
			isHook = false;
			Send(Cmd_Init, result, "",  L"��ǰ΢�Ű汾��ƥ�䣬������WeChat2.8.0.112��");
		}
	}
	catch (...)
	{
		isHook = false;
		Send(Cmd_Init, result, "", L"��ʼ���쳣��");

	}
}
