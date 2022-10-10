using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Extend.Helper.Date;

namespace WeChat.Extend.Helper
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.Extend.Helper
	*│　类    名： StrHelper
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/10 10:46:16
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class StrHelper
    {
		public static string GetMsgId()
		{
			return DateHelper.Format(DateTime.Now, "yyyyMMddHHmmss");
		}
	}
}
