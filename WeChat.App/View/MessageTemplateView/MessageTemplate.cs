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
using WeChat.App.ModelView;
using WeChat.Domain.Models;
using WeChat.DTO.Robot;
using WeChat.Service.Robot;

namespace WeChat.App.View.MessageTemplateView
{
    public partial class MessageTemplate : UIForm
    {
        private bool selectedRow;

        private MessageTemplateDTO searchParam = new MessageTemplateDTO();

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
        }

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
            }) ;
            comBoBoxMVs.Add(new ComBoBoxMV()
            {
                Label = "否",
                Value = false
            });
            s_enable.DataSource = comBoBoxMVs;
            s_enable.DisplayMember = "Label";
            s_enable.ValueMember = "Value";

        }
        public void LoadData() 
        {
            var list = new MessageTemplateService().GetList(searchParam);
            var listMv = list.Select(x => new MessageTemplateMV
            {
                Enable = x.Enable,
                Name = x.Name,
                Content = x.Content,
                Remark = x.Remark,
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
                dataGridView.CurrentCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SaveOrUpdate saveOrUpdate = new SaveOrUpdate(this);
            saveOrUpdate.WxMessageTemplate = (WxMessageTemplate)dataGridView.CurrentRow.DataBoundItem;
            saveOrUpdate.ShowDialog();
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
