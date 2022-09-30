using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain;
using WeChat.Domain.Models;

namespace WeChat.Service.WeChat
{
    public class FriendService
    {
        public List<WxUser> GetAutoGreetUserList() 
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                return c.WxUserFriends.Where(p => p.UserId == AppData.loginUser.Id).Select(x => new WxUser
                {
                    WxId = x.FriendUser.WxId
                }).ToList();
            }
        }
    }
}
