using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain.Models;

namespace WeChat.Service.WeChat
{
    public class UserFriendService
    {
        public bool AddFriend(WxUserFriend wxUserFriend) 
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                var temp = c.WxUserFriends.FirstOrDefault(p => p.UserId == wxUserFriend.UserId && p.FriendUserId == wxUserFriend.FriendUserId);

                if (temp == null)
                {
                    c.WxUserFriends.Add(wxUserFriend);
                }
                else 
                {
                    temp.UserId = wxUserFriend.UserId;
                    temp.FriendUserId = wxUserFriend.FriendUserId;
                    temp.Remark = wxUserFriend.Remark;
                    temp.EnableAutoGreet = wxUserFriend.EnableAutoGreet;
                    temp.EnableAutoChat = wxUserFriend.EnableAutoChat;
                    temp.CreateTime = wxUserFriend.CreateTime;
                }
                return c.SaveChanges()==1;
            }
        }
    }
}
