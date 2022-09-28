#pragma once
#include "pch.h"
#include <string>
using namespace std;


/// <summary>
/// 发送文本消息
/// </summary>
/// <param name="wxId">微信ID</param>
/// <param name="msg">消息内容</param>
void SendTextMsg(wstring wxId, wstring msg);
