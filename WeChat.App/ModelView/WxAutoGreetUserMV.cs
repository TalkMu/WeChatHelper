using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.App.ModelView
{
    public class WxAutoGreetUserMV
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 微信ID
        /// </summary>
        public string WxId { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        public string WxCode { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
