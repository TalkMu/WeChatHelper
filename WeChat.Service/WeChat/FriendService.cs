using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.App.ModelView.User;
using WeChat.Domain;
using WeChat.Domain.Models;

namespace WeChat.Service.WeChat
{
    public class FriendService
    {
        public List<WxFriendUserMV> GetList() 
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                return c.WxUserFriends.Where(p => p.UserId == AppData.loginUser.Id).Select(x => new WxFriendUserMV 
                {
                    WxId = x.FriendUser.WxId,
                    WxCode = x.FriendUser.WxCode,
                    NickName = x.FriendUser.NickName,
                    Remark = x.FriendUser.Remark,

                }).ToList();
            }
        }

        public void SaveOrUpdate(WxUserFriend friend)
        {
            using (WeChatHelperContext c = new WeChatHelperContext()) 
            {
                var model = c.WxUserFriends.FirstOrDefault(p => p.UserId == friend.UserId && p.FriendUserId == friend.FriendUserId);
                if (model == null)
                {
                    c.WxUserFriends.Add(friend);
                }
                else 
                {
                    model.Remark = friend.Remark;
                }
                c.SaveChanges();
            }
        }
    }
}
