using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain.Models;

namespace WeChat.Service.System
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.Service.System
	*│　类    名： DictService
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/13 16:31:20
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class DictService
    {
		public WxDict FindByDictCode(string dictCode) 
		{
			using (WeChatHelperContext c = new WeChatHelperContext()) 
			{
				return c.WxDicts.FirstOrDefault(p => p.DictCode.Equals(dictCode));
			}
		}
    }
}
