using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain;
using WeChat.DTO.Socket;
using WeChat.Service.WeChat;

namespace WeChat.App.Handle
{
	/**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.App.Handle
	*│　类    名： ChatRecordHandle
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/17 10:43:10
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
	public class ChatRecordHandle
    {
		private UserChatRecordService userChatRecordService = new UserChatRecordService();
		public void SaveTxt(WxServerReceiveDTO<object> data) 
		{
			var toWxId = "";
			var fromWxId = "";
			if (data.WxId.Contains("@chatroom"))
			{
				// 群消息
				toWxId = data.WxId;
				fromWxId = data.Sender;
			}
			else 
			{
				// 个人消息
				toWxId = AppData.loginUser.WxId;
				fromWxId = data.WxId;
			}
			userChatRecordService.SaveTxt(fromWxId, toWxId, data.Data.ToString());
		}
    }
}
