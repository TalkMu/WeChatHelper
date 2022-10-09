using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain.Models;

namespace WeChat.App.ModelView
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.App.ModelView
	*│　类    名： MessageTemplateMV
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：kools
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/9 19:05:35
	*│　机器名称：DESKTOP-KBNKUO5
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class MessageTemplateMV:WxMessageTemplate
    {
		/// <summary>
		/// 是否启用
		/// </summary>
		public string enableStr;
		public string EnableStr 
		{
			get 
			{
				return Enable ? "是" : "否";

            }
			set 
			{ 
				enableStr = value; 
			}
		}

    }
}
