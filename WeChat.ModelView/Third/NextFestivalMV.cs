using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.ModelView.Third
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.ModelView.Third
	*│　类    名： NextFestivalMV
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/11 11:50:43
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class NextFestivalMV
    {
        /// <summary>
        /// 节日名称
        /// </summary>
        public string Festival { get; set; }
        /// <summary>
        /// 节日日期
        /// </summary>
        public string FestivalDate { get; set; }

        /// <summary>
        /// 倒计时
        /// </summary>
        public string FestivalCountDown
        {
            get 
            {
                var result = DateTime.Parse(FestivalDate).Subtract(DateTime.Now);
                return result.Days.ToString();
            }
        }
    }
}
