#pragma once
//用户消息
struct RecieveMsgStruct
{
	wchar_t* fromWxid;
	wchar_t* senderWxid;
	wchar_t* unkonwStr;
	wchar_t* content;
};

//好友列表
struct FriendStruct
{
	wchar_t wxid[0x100] = L"NULL";
	wchar_t account[0x200] = L"NULL";
	wchar_t nickname[0x200] = L"NULL";
	wchar_t head[0x1000] = L"NULL";
	wchar_t v1[0x200] = L"NULL";
	wchar_t reMark[0x200] = L"NULL";
	wchar_t bigHeadImgUrl[0x1000] = L"NULL";
};