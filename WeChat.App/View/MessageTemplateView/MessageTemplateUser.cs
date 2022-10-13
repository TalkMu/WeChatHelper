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
using WeChat.App.ModelView.User;
using WeChat.Domain;
using WeChat.Domain.Models;
using WeChat.Service.Robot;

namespace WeChat.App.View.MessageTemplateView
{
    public partial class MessageTemplateUser : UIForm
    {
        private UserMessageTemplateService userMessageTemplateService = new UserMessageTemplateService();

        public long MsgTempId { get; set; }
        private List<WxUserMV> LeftList;
        private List<WxUserMV> RightList;
        private BindingList<WxUserMV> RightListDS;
        private BindingList<WxUserMV> LeftListDS;


        public MessageTemplateUser()
        {
            InitializeComponent();

            
        }
        private void LoadData()
        {

            // 查询未关联的用户
            LeftList = userMessageTemplateService.NotRelationUserList(MsgTempId);
            LeftListDS = new BindingList<WxUserMV>(LeftList);
            ListBoxLeft.DataSource = LeftListDS;
            ListBoxLeft.DisplayMember = "NickName";
            ListBoxLeft.ValueMember = "Id";

            // 查询已经关联的用户
            RightList = userMessageTemplateService.RelationUserList(MsgTempId);
            RightListDS = new BindingList<WxUserMV>(RightList);
            ListBoxRight.DataSource = RightListDS;
            ListBoxRight.DisplayMember = "NickName";
            ListBoxRight.ValueMember = "Id";
        }

        private void ToRightBtn_Click(object sender, EventArgs e)
        {
            var indexs = ListBoxLeft.SelectedIndices;
            List<WxUserMV> list = new List<WxUserMV>();
            for (int i = 0; i < indexs.Count; i++)
            {
                var item = ListBoxLeft.Items[indexs[i]] as WxUserMV;
                list.Add(item);
            }
            list.ForEach(item =>
            {
                RightListDS.Add(item);
                LeftListDS.Remove(item);
                LeftList.Remove(item);
            });
        }

        private void ToLeftBtn_Click(object sender, EventArgs e)
        {
            var indexs = ListBoxRight.SelectedIndices;
            List<WxUserMV> list = new List<WxUserMV>();
            for (int i = 0; i < indexs.Count; i++)
            {
                var item = ListBoxRight.Items[indexs[i]] as WxUserMV;
                list.Add(item);
            }
            list.ForEach(item =>
            {
                LeftListDS.Add(item);
                RightListDS.Remove(item);
                RightList.Remove(item);
            });
        }

        private void LeftSearch_TextChanged(object sender, EventArgs e)
        {
            var content = LeftSearch.Text;
            if (string.IsNullOrEmpty(content))
            {
                LeftListDS = new BindingList<WxUserMV>(LeftList);
                ListBoxLeft.DataSource = LeftListDS;
            }
            else
            {
                LeftListDS = new BindingList<WxUserMV>(LeftList.Where(p => p.NickName.Contains(content) || (p.Remark != null && p.Remark.Contains(content)) || p.WxId.Contains(content)).ToList());
                ListBoxLeft.DataSource = LeftListDS;
            }

        }
        #region 刷新UI
        public void RunUi(Action action)
        {
            BeginInvoke(action);
        }
        #endregion

        private void RigthSearch_TextChanged(object sender, EventArgs e)
        {
            var content = RigthSearch.Text;
            if (string.IsNullOrEmpty(content))
            {
                RightListDS = new BindingList<WxUserMV>(RightList);
                ListBoxRight.DataSource = RightListDS;
            }
            else
            {
                RightListDS = new BindingList<WxUserMV>(RightList.Where(p => p.NickName.Contains(content) || (p.Remark != null && p.Remark.Contains(content))|| p.WxId.Contains(content)).ToList());
                ListBoxRight.DataSource = RightListDS;
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            userMessageTemplateService.RemoveByMsgTempId(MsgTempId);

            var list = RightList.Select(x => new WxUserMessageTemplate()
            {
                MsgTempId = MsgTempId,
                UserId = x.Id
            }).ToList();
            userMessageTemplateService.BatchSave(list);

            this.Hide();
        }

        private void MessageTemplateUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
