using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain.Models;

namespace WeChat.Service.WeChat
{
    public class UserService
    {
        public bool SaveOrUpdate(WxUser wxUser)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                var temp = c.WxUsers.FirstOrDefault(p => p.WxId.Equals(wxUser.WxId));
                if (temp == null)
                {
                    c.WxUsers.Add(wxUser);
                }
                else
                {
                    wxUser.Id = temp.Id;
                    temp.NickName = wxUser.NickName;
                    temp.WxCode = wxUser.WxCode;
                    temp.WxId = wxUser.WxId;
                }
                return c.SaveChanges() == 1;
            }
        }

        public WxUser SelectByWxId(string wxId)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                return c.WxUsers.FirstOrDefault(p => p.WxId.Equals(wxId));
            }
        }
    }
}
