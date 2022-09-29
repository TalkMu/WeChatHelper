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
                var model = c.WxUserFriends.FirstOrDefault(p => p.UserId == wxUserFriend.UserId && p.FriendUserId == wxUserFriend.FriendUserId);

                if (model == null)
                {
                    c.WxUserFriends.Add(wxUserFriend);
                }
                else 
                {
                    wxUserFriend.Id = model.Id;
                    c.WxUserFriends.Update(wxUserFriend);
                }
                return c.SaveChanges()==1;
            }
        }
    }
}
