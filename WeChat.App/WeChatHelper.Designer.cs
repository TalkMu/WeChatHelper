namespace WeChat.App
{
    partial class WeChatHelper
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeChatHelper));
            this.AutoGreetTask = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.机器人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定时消息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.智能回复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchBtn = new Sunny.UI.UISymbolButton();
            this.s_name = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.FriendView = new Sunny.UI.UIDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GroupView = new Sunny.UI.UIDataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.OpenAccountView = new Sunny.UI.UIDataGridView();
            this.OpenWeChatBtn = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.connectStateLabel = new Sunny.UI.UILabel();
            this.DisConnectBtn = new Sunny.UI.UISymbolButton();
            this.WsUrlTxt = new Sunny.UI.UITextBox();
            this.CleanRecordBtn = new Sunny.UI.UIButton();
            this.StartConnectBtn = new Sunny.UI.UISymbolButton();
            this.CloseWeChatBtn = new Sunny.UI.UIButton();
            this.ShowWeChatBtn = new Sunny.UI.UIButton();
            this.ScrollingLog = new Sunny.UI.UIRichTextBox();
            this.menuStrip.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenAccountView)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.机器人ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 35);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 29);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            // 
            // 机器人ToolStripMenuItem
            // 
            this.机器人ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.定时消息ToolStripMenuItem,
            this.智能回复ToolStripMenuItem});
            this.机器人ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.机器人ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.机器人ToolStripMenuItem.Name = "机器人ToolStripMenuItem";
            this.机器人ToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.机器人ToolStripMenuItem.Text = "机器人";
            // 
            // 定时消息ToolStripMenuItem
            // 
            this.定时消息ToolStripMenuItem.Name = "定时消息ToolStripMenuItem";
            this.定时消息ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.定时消息ToolStripMenuItem.Text = "定时消息";
            this.定时消息ToolStripMenuItem.Click += new System.EventHandler(this.定时消息ToolStripMenuItem_Click);
            // 
            // 智能回复ToolStripMenuItem
            // 
            this.智能回复ToolStripMenuItem.Name = "智能回复ToolStripMenuItem";
            this.智能回复ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.智能回复ToolStripMenuItem.Text = "智能回复";
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTabControl1.Frame = null;
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(418, 63);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(763, 692);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControl1.StyleCustomMode = true;
            this.uiTabControl1.TabIndex = 6;
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.Transparent;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiTabControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.searchBtn);
            this.tabPage1.Controls.Add(this.s_name);
            this.tabPage1.Controls.Add(this.uiLabel1);
            this.tabPage1.Controls.Add(this.FriendView);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(763, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "好友";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.Location = new System.Drawing.Point(227, 4);
            this.searchBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(82, 31);
            this.searchBtn.Symbol = 61442;
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "搜索";
            this.searchBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // s_name
            // 
            this.s_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.s_name.Location = new System.Drawing.Point(69, 5);
            this.s_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.s_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.s_name.Name = "s_name";
            this.s_name.ShowText = false;
            this.s_name.Size = new System.Drawing.Size(150, 29);
            this.s_name.TabIndex = 10;
            this.s_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.s_name.Watermark = "";
            this.s_name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(10, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(58, 21);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "关键字";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FriendView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.FriendView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FriendView.BackgroundColor = System.Drawing.Color.White;
            this.FriendView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FriendView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FriendView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FriendView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FriendView.EnableHeadersVisualStyles = false;
            this.FriendView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FriendView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.FriendView.Location = new System.Drawing.Point(0, 38);
            this.FriendView.Name = "FriendView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FriendView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FriendView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FriendView.RowTemplate.Height = 25;
            this.FriendView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.FriendView.SelectedIndex = -1;
            this.FriendView.Size = new System.Drawing.Size(763, 614);
            this.FriendView.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.FriendView.Style = Sunny.UI.UIStyle.Custom;
            this.FriendView.TabIndex = 0;
            this.FriendView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.FriendView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FriendView_CellMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPage2.Controls.Add(this.GroupView);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "群聊";
            // 
            // GroupView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.GroupView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GroupView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.GroupView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GroupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GroupView.DefaultCellStyle = dataGridViewCellStyle8;
            this.GroupView.EnableHeadersVisualStyles = false;
            this.GroupView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.GroupView.Location = new System.Drawing.Point(0, 0);
            this.GroupView.Name = "GroupView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.GroupView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GroupView.RowTemplate.Height = 25;
            this.GroupView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.GroupView.SelectedIndex = -1;
            this.GroupView.Size = new System.Drawing.Size(763, 652);
            this.GroupView.Style = Sunny.UI.UIStyle.Custom;
            this.GroupView.TabIndex = 0;
            this.GroupView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPage3.Controls.Add(this.OpenAccountView);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 60);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "公众号";
            // 
            // OpenAccountView
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.OpenAccountView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.OpenAccountView.BackgroundColor = System.Drawing.Color.White;
            this.OpenAccountView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OpenAccountView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.OpenAccountView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OpenAccountView.DefaultCellStyle = dataGridViewCellStyle13;
            this.OpenAccountView.EnableHeadersVisualStyles = false;
            this.OpenAccountView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenAccountView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.OpenAccountView.Location = new System.Drawing.Point(0, 0);
            this.OpenAccountView.Name = "OpenAccountView";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OpenAccountView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenAccountView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.OpenAccountView.RowTemplate.Height = 25;
            this.OpenAccountView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.OpenAccountView.SelectedIndex = -1;
            this.OpenAccountView.Size = new System.Drawing.Size(763, 652);
            this.OpenAccountView.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.OpenAccountView.Style = Sunny.UI.UIStyle.Custom;
            this.OpenAccountView.TabIndex = 0;
            this.OpenAccountView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // OpenWeChatBtn
            // 
            this.OpenWeChatBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenWeChatBtn.Location = new System.Drawing.Point(13, 35);
            this.OpenWeChatBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.OpenWeChatBtn.Name = "OpenWeChatBtn";
            this.OpenWeChatBtn.Size = new System.Drawing.Size(85, 35);
            this.OpenWeChatBtn.TabIndex = 12;
            this.OpenWeChatBtn.Text = "启动微信";
            this.OpenWeChatBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.OpenWeChatBtn.Click += new System.EventHandler(this.OpenWeChatBtn_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.connectStateLabel);
            this.uiGroupBox1.Controls.Add(this.DisConnectBtn);
            this.uiGroupBox1.Controls.Add(this.WsUrlTxt);
            this.uiGroupBox1.Controls.Add(this.CleanRecordBtn);
            this.uiGroupBox1.Controls.Add(this.StartConnectBtn);
            this.uiGroupBox1.Controls.Add(this.CloseWeChatBtn);
            this.uiGroupBox1.Controls.Add(this.ShowWeChatBtn);
            this.uiGroupBox1.Controls.Add(this.OpenWeChatBtn);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox1.Location = new System.Drawing.Point(4, 63);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(402, 279);
            this.uiGroupBox1.TabIndex = 7;
            this.uiGroupBox1.Text = "启动区";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // connectStateLabel
            // 
            this.connectStateLabel.AutoSize = true;
            this.connectStateLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectStateLabel.Location = new System.Drawing.Point(170, 112);
            this.connectStateLabel.Name = "connectStateLabel";
            this.connectStateLabel.Size = new System.Drawing.Size(58, 21);
            this.connectStateLabel.TabIndex = 17;
            this.connectStateLabel.Text = "未连接";
            this.connectStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectStateLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // DisConnectBtn
            // 
            this.DisConnectBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisConnectBtn.Location = new System.Drawing.Point(208, 223);
            this.DisConnectBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.DisConnectBtn.Name = "DisConnectBtn";
            this.DisConnectBtn.Size = new System.Drawing.Size(181, 44);
            this.DisConnectBtn.TabIndex = 19;
            this.DisConnectBtn.Text = "断开连接";
            this.DisConnectBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.DisConnectBtn.Click += new System.EventHandler(this.DisConnectBtn_Click);
            // 
            // WsUrlTxt
            // 
            this.WsUrlTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WsUrlTxt.Location = new System.Drawing.Point(95, 78);
            this.WsUrlTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WsUrlTxt.MinimumSize = new System.Drawing.Size(1, 16);
            this.WsUrlTxt.Name = "WsUrlTxt";
            this.WsUrlTxt.ShowText = false;
            this.WsUrlTxt.Size = new System.Drawing.Size(212, 29);
            this.WsUrlTxt.TabIndex = 16;
            this.WsUrlTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.WsUrlTxt.Watermark = "";
            this.WsUrlTxt.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // CleanRecordBtn
            // 
            this.CleanRecordBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CleanRecordBtn.Location = new System.Drawing.Point(304, 35);
            this.CleanRecordBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.CleanRecordBtn.Name = "CleanRecordBtn";
            this.CleanRecordBtn.Size = new System.Drawing.Size(85, 35);
            this.CleanRecordBtn.TabIndex = 15;
            this.CleanRecordBtn.Text = "清空记录";
            this.CleanRecordBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.CleanRecordBtn.Click += new System.EventHandler(this.CleanRecordBtn_Click);
            // 
            // StartConnectBtn
            // 
            this.StartConnectBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartConnectBtn.Location = new System.Drawing.Point(13, 223);
            this.StartConnectBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.StartConnectBtn.Name = "StartConnectBtn";
            this.StartConnectBtn.Size = new System.Drawing.Size(181, 44);
            this.StartConnectBtn.TabIndex = 18;
            this.StartConnectBtn.Text = "开始连接";
            this.StartConnectBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.StartConnectBtn.Click += new System.EventHandler(this.StartConnectBtn_Click);
            // 
            // CloseWeChatBtn
            // 
            this.CloseWeChatBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseWeChatBtn.Location = new System.Drawing.Point(110, 35);
            this.CloseWeChatBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.CloseWeChatBtn.Name = "CloseWeChatBtn";
            this.CloseWeChatBtn.Size = new System.Drawing.Size(85, 35);
            this.CloseWeChatBtn.TabIndex = 14;
            this.CloseWeChatBtn.Text = "关闭微信";
            this.CloseWeChatBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.CloseWeChatBtn.Click += new System.EventHandler(this.CloseWeChatBtn_Click);
            // 
            // ShowWeChatBtn
            // 
            this.ShowWeChatBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowWeChatBtn.Location = new System.Drawing.Point(207, 35);
            this.ShowWeChatBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ShowWeChatBtn.Name = "ShowWeChatBtn";
            this.ShowWeChatBtn.Size = new System.Drawing.Size(85, 35);
            this.ShowWeChatBtn.TabIndex = 13;
            this.ShowWeChatBtn.Text = "显示微信";
            this.ShowWeChatBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ShowWeChatBtn.Click += new System.EventHandler(this.ShowWeChatBtn_Click);
            // 
            // ScrollingLog
            // 
            this.ScrollingLog.FillColor = System.Drawing.Color.White;
            this.ScrollingLog.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScrollingLog.Location = new System.Drawing.Point(4, 352);
            this.ScrollingLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScrollingLog.MinimumSize = new System.Drawing.Size(1, 1);
            this.ScrollingLog.Name = "ScrollingLog";
            this.ScrollingLog.Padding = new System.Windows.Forms.Padding(2);
            this.ScrollingLog.ShowText = false;
            this.ScrollingLog.Size = new System.Drawing.Size(402, 403);
            this.ScrollingLog.TabIndex = 0;
            this.ScrollingLog.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScrollingLog.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // WeChatHelper
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.ScrollingLog);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiTabControl1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeChatHelper";
            this.Text = "微信助手";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1184, 761);
            this.Load += new System.EventHandler(this.WeChatHelper_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpenAccountView)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Timer AutoGreetTask;

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SaveGreetConfigBtn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 机器人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 定时消息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 智能回复ToolStripMenuItem;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UIDataGridView FriendView;
        private Sunny.UI.UIButton OpenWeChatBtn;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton ShowWeChatBtn;
        private Sunny.UI.UIButton CloseWeChatBtn;
        private Sunny.UI.UIButton CleanRecordBtn;
        private Sunny.UI.UILabel connectStateLabel;
        private Sunny.UI.UITextBox WsUrlTxt;
        private Sunny.UI.UISymbolButton StartConnectBtn;
        private Sunny.UI.UISymbolButton DisConnectBtn;
        public Sunny.UI.UIRichTextBox ScrollingLog;
        private Sunny.UI.UIDataGridView GroupView;
        private Sunny.UI.UIDataGridView OpenAccountView;
        private Sunny.UI.UISymbolButton searchBtn;
        private Sunny.UI.UITextBox s_name;
        private Sunny.UI.UILabel uiLabel1;
    }
}

