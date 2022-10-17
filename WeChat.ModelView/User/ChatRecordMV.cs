using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.ModelView.User
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.ModelView.User
	*│　类    名： ChatRecordMV
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/17 16:11:15
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class ChatRecordMV
    {
		public string FromUserNick { get; set; }
		public string ToUserNick { get; set; }
		public string MsgContent { get; set; }
		public string CreateTime { get; set; }
    }
}
