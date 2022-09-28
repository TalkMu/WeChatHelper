#include "Init.h"
#include "HUtil.h"
#include "Command.h"
#include "Sql.h"
#include "WebSocket.h"
#include "CJsonObject.hpp"

bool isHook = false;
/**
 * 初始化 Hook
 * @param
 * @return void
*/
void InitWeChat() {
	neb::CJsonObject result;

	if (isHook) {
		Send(Cmd_Init, result, "", L"已初始化。");
		return;
	}
	//检查当前微信版本
	try
	{
		if (HUtil::IsWxVersionValid()) {

			//HookDB();

			//HookChatRecord();

			isHook = true;

			Send(Cmd_Init, result, "",  L"初始化成功。");
		}
		else
		{
			isHook = false;
			Send(Cmd_Init, result, "",  L"当前微信版本不匹配，请下载WeChat2.8.0.112。");
		}
	}
	catch (...)
	{
		isHook = false;
		Send(Cmd_Init, result, "", L"初始化异常。");

	}
}
