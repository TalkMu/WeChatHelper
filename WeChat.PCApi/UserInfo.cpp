#include "UserInfo.h"
#include <string>
#include <WebSocket.h>
#include "OffSet.h"
#include "HTools.h"
#include "CJsonObject.hpp"
#include "WebSocket.h"
#include "Command.h"
#include "Loger.h"


using namespace std;


void GetUserInfo() 
{
	string wxid = HTools::ReadAsciiString(HTools::ReadInt(HTools::Offset(MY_WX_ID)));
	WriteInfo("wxid:"+ wxid);
	string account = HTools::ReadAsciiString(HTools::Offset(MY_ACCOUNT));
	WriteInfo("account:" + account);
	string mobile = HTools::ReadAsciiString(HTools::Offset(MY_MOBILE));
	WriteInfo("mobile:" + mobile);
	string nickName = HTools::ReadAsciiString(HTools::Offset(MY_NICK_NAME));
	WriteInfo("nickName:" + nickName);
	string headImg = HTools::ReadAsciiString(HTools::ReadInt(HTools::Offset(MY_HEAD_IMG)));
	WriteInfo("headImg:" + headImg);
	string province = HTools::ReadAsciiString(HTools::Offset(MY_PROVINCE));
	WriteInfo("province:" + province);
	string city = HTools::ReadAsciiString(HTools::Offset(MY_CITY));
	WriteInfo("city:" + city);
	string loginDevice = HTools::ReadAsciiString(HTools::Offset(MY_LOGIN_DEVICE));
	WriteInfo("loginDevice:" + loginDevice);

	neb::CJsonObject ret;
	ret.Add("UserId", wxid);
	ret.Add("Account", account);
	ret.Add("NickName", nickName);
	ret.Add("Device", loginDevice);
	ret.Add("Moble", mobile);
	ret.Add("Province", province);
	ret.Add("City", city);
	ret.Add("HeadImg", headImg);
	WriteInfo("拼装完成");
	Send(Cmd_GetUser, ret, "",L"操作成功");
}