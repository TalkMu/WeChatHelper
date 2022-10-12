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
using WeChat.App.Handle;
using WeChat.App.ModelView;
using WeChat.App.Quartz;
using WeChat.Domain.Constant;
using WeChat.Domain.Models;
using WeChat.DTO.Robot;
using WeChat.Service.Robot;

namespace WeChat.App.View.MessageTemplateView
{
    public partial class MessageTemplate : UIForm
    {
        private bool selectedRow;

        private MessageTemplateDTO searchParam = new MessageTemplateDTO();

        private MessageTemplateHandle handle = new MessageTemplateHandle();

        public bool SelectedRow 
        {
            get => selectedRow;
            set
                {
                selectedRow = value;
                updateBtn.Enabled = value;
                delBtn.Enabled = value;
            }

        }
        public MessageTemplate()
        {
            InitializeComponent();
            InitWindow();
            LoadData();
            handle.LoadQuart();
        }

        #region 初始化UI
        public void InitWindow()
        {
            var TextBoxColumnX = new DataGridViewTextBoxColumn();
            //TextBoxColumnX.DataPropertyName = "Id";
            //TextBoxColumnX.HeaderText = "Id";
            //TextBoxColumnX.Name = "Id";
            //dataGridView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "Name";
            TextBoxColumnX.HeaderText = "名称";
            TextBoxColumnX.Name = "Name";
            dataGridView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "Content";
            TextBoxColumnX.HeaderText = "内容";
            TextBoxColumnX.Name = "Content";
            dataGridView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "EnableStr";
            TextBoxColumnX.HeaderText = "是否启用";
            TextBoxColumnX.Name = "EnableStr";
            dataGridView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "Cron";
            TextBoxColumnX.HeaderText = "表达式";
            TextBoxColumnX.Name = "Cron";
            dataGridView.Columns.Add(TextBoxColumnX);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;

            List<ComBoBoxMV> comBoBoxMVs = new List<ComBoBoxMV>();
            comBoBoxMVs.Add(new ComBoBoxMV()
            {
                Label = "全部",
                Value = null
            });
            comBoBoxMVs.Add(new ComBoBoxMV()
            {
                Label = "是",
                Value = true
            });
            comBoBoxMVs.Add(new ComBoBoxMV()
            {
                Label = "否",
                Value = false
            });
            s_enable.DataSource = comBoBoxMVs;
            s_enable.DisplayMember = "Label";
            s_enable.ValueMember = "Value";

        }
        #endregion

        #region 刷新列表数据
        public void LoadData()
        {
            var list = new MessageTemplateService().GetList(searchParam);
            var listMv = list.Select(x => new MessageTemplateMV
            {
                Enable = x.Enable,
                Name = x.Name,
                Content = x.Content,
                Remark = x.Remark,
                Cron = x.Cron,
                TaskCode = x.TaskCode,
                Id = x.Id,
            }).ToList();
            dataGridView.DataSource = listMv;
            if (listMv.Count == 0)
            {
                SelectedRow = false;
            }
            else
            {
                SelectedRow = true;
            }
        }
        #endregion

        #region 刷新UI
        public void RunUi(Action action)
        {
            BeginInvoke(action);
        }
        #endregion

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveOrUpdate saveOrUpdate = new SaveOrUpdate(this);
            saveOrUpdate.ShowDialog();
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[e.RowIndex].Selected = true;

                UIContextMenuStrip strip = new UIContextMenuStrip();
                strip.Items.Add("执行一次");
                strip.Items.Add("关联用户");
                strip.Items[0].Click += ExecOnceToolStripMenuItem_Click;
                strip.Items[1].Click += ShowUserView;
                strip.Show(MousePosition.X, MousePosition.Y);
            }
        }
        private void ShowUserView(object sender, EventArgs e) 
        {
            MessageTemplateUser messageTemplateUser = new MessageTemplateUser();
            messageTemplateUser.ShowDialog();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            SaveOrUpdate saveOrUpdate = new SaveOrUpdate(this);
            saveOrUpdate.WxMessageTemplate = (WxMessageTemplate)dataGridView.CurrentRow.DataBoundItem;
            saveOrUpdate.ShowDialog();
        }

        private void ExecOnceToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageTemplateMV row = (MessageTemplateMV)dataGridView.CurrentRow.DataBoundItem;
            handle.ExecQuart(row.TaskCode);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            var row = (WxMessageTemplate)dataGridView.CurrentRow.DataBoundItem;
            var result = new MessageTemplateService().RemoveById(row.Id);
            if (result)
            {
                this.LoadData();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchParam.Name = s_name.Text;
            searchParam.Enable = s_enable.SelectedValue == null ? null : bool.Parse(s_enable.SelectedValue.ToString());
            this.LoadData();
        }
    }
}
