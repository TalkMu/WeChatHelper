using Masuit.Tools.Systems;
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
using WeChat.Extend.Helper;

namespace WeChat.App
{
    public partial class Demo : Form
    {
        private BindingList<WxUserMV> list;
        public Demo()
        {
            InitializeComponent();
            list = new BindingList<WxUserMV>();
            for (int i = 0; i < 10; i++) 
            {
                list.Add(new WxUserMV()
                {
                    Id = SnowFlake.GetInstance().GetLongId(),
                    NickName = SnowFlake.GetInstance().GetUniqueId(),
                });
            }
            
            listBox1.DataSource = list;
            listBox1.DisplayMember = "NickName";
            listBox1.ValueMember = "Id";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            list.Add(new WxUserMV()
            {
                Id = SnowFlake.GetInstance().GetLongId(),
                NickName = SnowFlake.GetInstance().GetUniqueId()
            });
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i))
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
