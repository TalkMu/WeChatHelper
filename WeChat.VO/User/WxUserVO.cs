using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain.Models;

namespace WeChat.VO.User
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.VO
	*│　类    名： WxUserVO
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/11 14:27:19
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class WxUserVO:WxUser
    {
		public string CityName { get; set; }
		public string CityCode { get; set; }
    }
}
