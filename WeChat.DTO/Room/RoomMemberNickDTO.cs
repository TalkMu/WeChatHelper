using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.DTO.Room
{
    /**
	*┌──────────────────────────────────────────────────────────────┐
	*│　命名空间： WeChat.DTO.Room
	*│　类    名： RoomMemberNickDTO
	*└──────────────────────────────────────────────────────────────┘
	*┌──────────────────────────────────────────────────────────────┐
	*│　描    述：
	*│　作    者：admin
	*│　版    本：1.0.0
	*│　邮    箱：koolss@koolss.com
	*│　创建时间：2022/10/17 15:57:54
	*│　机器名称：DESKTOP-GNAF83O
	*└──────────────────────────────────────────────────────────────┘
	*/
    public class RoomMemberNickDTO
    {

		/// <summary>
		/// 用户昵称
		/// </summary>
		[JsonProperty(PropertyName = "nick")]
		public string NickName { get; set; }
		/// <summary>
		/// 群ID
		/// </summary>
		[JsonProperty(PropertyName = "roomid")]
		public string RoomId { get; set; }
		/// <summary>
		/// 用户ID
		/// </summary>
		[JsonProperty(PropertyName = "wxid")]
		public string WxId { get; set; }
    }
}
