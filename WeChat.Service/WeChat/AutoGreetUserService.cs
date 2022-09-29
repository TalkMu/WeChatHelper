using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain.Models;

namespace WeChat.Service.WeChat
{
    public class AutoGreetUserService
    {
        public bool Save(WxAutoGreetUser wxAutoGreetUser) 
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                if (!c.WxAutoGreetUsers.Any(p => p.UserId == wxAutoGreetUser.UserId && p.FriendUserId == wxAutoGreetUser.FriendUserId))
                {
                    c.WxAutoGreetUsers.Add(wxAutoGreetUser);
                }
                return c.SaveChanges() == 1;
            }
        }
    }
}
