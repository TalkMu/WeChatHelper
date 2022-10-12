using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeChat.Domain;
using WeChat.Domain.Models;
using WeChat.Service.Robot;

namespace WeChat.App.View.MessageTemplateView
{
    public partial class MessageTemplateUser : UIForm
    {
        private UserMessageTemplateService messageTemplateService = new UserMessageTemplateService();
        public MessageTemplateUser()
        {
            InitializeComponent();

            LoadData();
        }
        private void LoadData() 
        {
            // 查询已经关联的用户
            WxUserMessageTemplate wxUserMessageTemplate = new WxUserMessageTemplate();
            var list = messageTemplateService.List(wxUserMessageTemplate);
            list.ForEach(x => 
            {
                ListBox listBox = new ListBox();
                listBox.Text = x.WxId +"|" + x.NickName;
                UserTransfer.ItemsLeft.Add(x.WxId + "|" + x.NickName);
            });
            
        }


    }
}
