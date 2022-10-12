using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WeChat.App.ModelView.User;
using WeChat.Domain;
using WeChat.Domain.Models;

namespace WeChat.Service.Robot
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.Service.Robot
	*│　类    名： UserMessageTemplateService
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/10 10:26:56
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class UserMessageTemplateService
    {

        public List<WxUserMV> FindWxUserByMsgTemplateId(long msgTempId) 
		{
			using (WeChatHelperContext c = new WeChatHelperContext())
			{
				return c.WxUserMessageTemplates.Where(p=>p.MsgTempId == msgTempId).Select(x=>new WxUserMV
				{
					WxId = x.User.WxId,
					CityCode = x.User.City.CityCode,
					CityName = x.User.City.CityName,
				}).ToList();
			}
		}

        public List<WxUserMV> List(WxUserMessageTemplate wxUserMessageTemplate)
        {
			using (WeChatHelperContext c = new WeChatHelperContext())
			{
				Expression<Func<WxUserMessageTemplate, bool>> exp = x => true;
                if (wxUserMessageTemplate.UserId>0)
                {
					exp = exp.And(p => p.UserId == wxUserMessageTemplate.UserId);
                }
				if (wxUserMessageTemplate.MsgTempId > 0)
				{
					exp = exp.And(p => p.MsgTempId == wxUserMessageTemplate.MsgTempId);
				}
				var loginUserId = AppData.GetUserId();
				return c.WxUserMessageTemplates.Where(exp).Select(x => new WxUserMV
				{
					Id = x.User.Id,
					WxId = x.User.WxId,
					NickName = x.User.NickName,
					Remark = c.WxUserFriends.Any(p=>p.UserId == loginUserId && p.FriendUserId == wxUserMessageTemplate.UserId)? c.WxUserFriends.FirstOrDefault(p => p.UserId == loginUserId && p.FriendUserId == wxUserMessageTemplate.UserId).Remark:"",
				}).ToList();
			}
		}
    }
}
