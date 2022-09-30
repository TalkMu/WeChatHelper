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

        public List<WxUser> SelectByUserIdAndEnableAutoGreet(long userId, bool enableAutoGreet)
        {
            using (WeChatHelperContext c = new WeChatHelperContext()) 
            {
                var wxUsers = c.WxUserFriends.Where(p => p.UserId == userId && p.EnableAutoGreet == enableAutoGreet).Select(x => new WxUser 
                { 
                    Id = x.Id,
                    WxId = x.FriendUser.WxId,
                    WxCode = x.FriendUser.WxCode,
                    NickName = x.FriendUser.NickName,
                    Remark = x.Remark,
                }).ToList();
                return wxUsers;
            }
        }

        public bool CloseAutoGreet(long id)
        {
            using (WeChatHelperContext c = new WeChatHelperContext()) 
            {
                var model = c.WxUserFriends.FirstOrDefault(p => p.Id == id);
                if (model == null)
                {
                    return false;
                }
                model.EnableAutoGreet = false;
                return c.SaveChanges() == 1;
            }

        }
    }
}
