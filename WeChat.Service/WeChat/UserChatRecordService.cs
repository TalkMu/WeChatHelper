using System;
using System.Collections.Generic;
using System.Linq;
using WeChat.Domain.Models;
using WeChat.Extend.Helper.Date;
using WeChat.ModelView;
using WeChat.ModelView.User;

namespace WeChat.Service.WeChat
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.Service.WeChat
	*│　类    名： UserChatRecordService
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/17 10:36:37
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class UserChatRecordService
    {
        private WeChatService weChatService = new WeChatService();
        public void Save(WxUserChatRecord wxUserChatRecord)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                c.WxUserChatRecords.Add(wxUserChatRecord);
                c.SaveChanges();
            }
        }
        public void SaveTxt(string fromWxId, string toWxId, string content)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                var fromUser = c.WxUsers.FirstOrDefault(p => fromWxId.Equals(p.WxId));
                if (fromUser == null)
                {
                    fromUser = new WxUser()
                    {
                        WxId = fromWxId,
                    };
                    c.WxUsers.Add(fromUser);
                    c.SaveChanges();
                    weChatService.GetRoomMemberNick(toWxId, fromWxId);
                }
                var toUser = c.WxUsers.FirstOrDefault(p => p.WxId.Equals(toWxId));
                if (fromUser != null && toUser != null)
                {
                    Save(new WxUserChatRecord()
                    {
                        FromId = fromUser.Id,
                        ToId = toUser.Id,
                        CreateTime = DateTime.Now,
                        MsgType = "TXT",
                        MsgContent = content
                    });
                }
                WxDataSource.CHAT_RECORD_DATA.Add(new ChatRecordMV()
                {
                    FromUserNick = fromUser.NickName,
                    ToUserNick = toUser.NickName,
                    MsgContent = content,
                    CreateTime = DateHelper.FormatTime(DateTime.Now)
                });
            }
        }
    }
}
