using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		public List<WxUser> FindWxUserByMsgTemplateId(long msgTempId) 
		{
			using (WeChatHelperContext c = new WeChatHelperContext())
			{
				return c.WxUserMessageTemplates.Where(p=>p.MsgTempId == msgTempId).Select(x=>x.User).ToList();
			}
		}
    }
}
