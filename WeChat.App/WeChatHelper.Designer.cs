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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeChatHelper));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectStateLabel = new System.Windows.Forms.Label();
            this.ShowWeChatBtn = new System.Windows.Forms.Button();
            this.CleanRecordBtn = new System.Windows.Forms.Button();
            this.CloseWeChatBtn = new System.Windows.Forms.Button();
            this.OpenWeChatBtn = new System.Windows.Forms.Button();
            this.DisConnectBtn = new System.Windows.Forms.Button();
            this.StartConnectBtn = new System.Windows.Forms.Button();
            this.WsUrlTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ScrollingLog = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FriendView = new System.Windows.Forms.DataGridView();
            this.FriendViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FriendToAutoChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FriendToAutoGreetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.GroupView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.OpenAccountView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AutoGreetView = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ExecuteAutoGreetBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveAutoGreetConfigBtn = new System.Windows.Forms.Button();
            this.EnableMotto = new System.Windows.Forms.CheckBox();
            this.EnableCiBa = new System.Windows.Forms.CheckBox();
            this.EnableWeather = new System.Windows.Forms.CheckBox();
            this.AutoGreetTime = new System.Windows.Forms.DateTimePicker();
            this.AutoGreetStatus = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.AutoGreetTask = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendView)).BeginInit();
            this.FriendViewMenu.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenAccountView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGreetView)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectStateLabel);
            this.groupBox1.Controls.Add(this.ShowWeChatBtn);
            this.groupBox1.Controls.Add(this.CleanRecordBtn);
            this.groupBox1.Controls.Add(this.CloseWeChatBtn);
            this.groupBox1.Controls.Add(this.OpenWeChatBtn);
            this.groupBox1.Controls.Add(this.DisConnectBtn);
            this.groupBox1.Controls.Add(this.StartConnectBtn);
            this.groupBox1.Controls.Add(this.WsUrlTxt);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(514, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "启动区";
            // 
            // connectStateLabel
            // 
            this.connectStateLabel.AutoSize = true;
            this.connectStateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectStateLabel.ForeColor = System.Drawing.Color.Red;
            this.connectStateLabel.Location = new System.Drawing.Point(342, 261);
            this.connectStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectStateLabel.Name = "connectStateLabel";
            this.connectStateLabel.Size = new System.Drawing.Size(54, 19);
            this.connectStateLabel.TabIndex = 11;
            this.connectStateLabel.Text = "未连接";
            // 
            // ShowWeChatBtn
            // 
            this.ShowWeChatBtn.Location = new System.Drawing.Point(264, 26);
            this.ShowWeChatBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowWeChatBtn.Name = "ShowWeChatBtn";
            this.ShowWeChatBtn.Size = new System.Drawing.Size(116, 45);
            this.ShowWeChatBtn.TabIndex = 10;
            this.ShowWeChatBtn.Text = "显示微信";
            this.ShowWeChatBtn.UseVisualStyleBackColor = true;
            this.ShowWeChatBtn.Click += new System.EventHandler(this.ShowWeChatBtn_Click);
            // 
            // CleanRecordBtn
            // 
            this.CleanRecordBtn.Location = new System.Drawing.Point(391, 26);
            this.CleanRecordBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CleanRecordBtn.Name = "CleanRecordBtn";
            this.CleanRecordBtn.Size = new System.Drawing.Size(116, 45);
            this.CleanRecordBtn.TabIndex = 9;
            this.CleanRecordBtn.Text = "清空记录";
            this.CleanRecordBtn.UseVisualStyleBackColor = true;
            this.CleanRecordBtn.Click += new System.EventHandler(this.CleanRecordBtn_Click);
            // 
            // CloseWeChatBtn
            // 
            this.CloseWeChatBtn.Location = new System.Drawing.Point(136, 26);
            this.CloseWeChatBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseWeChatBtn.Name = "CloseWeChatBtn";
            this.CloseWeChatBtn.Size = new System.Drawing.Size(116, 45);
            this.CloseWeChatBtn.TabIndex = 8;
            this.CloseWeChatBtn.Text = "关闭微信";
            this.CloseWeChatBtn.UseVisualStyleBackColor = true;
            this.CloseWeChatBtn.Click += new System.EventHandler(this.CloseWeChatBtn_Click);
            // 
            // OpenWeChatBtn
            // 
            this.OpenWeChatBtn.Location = new System.Drawing.Point(8, 26);
            this.OpenWeChatBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenWeChatBtn.Name = "OpenWeChatBtn";
            this.OpenWeChatBtn.Size = new System.Drawing.Size(116, 45);
            this.OpenWeChatBtn.TabIndex = 7;
            this.OpenWeChatBtn.Text = "启动微信";
            this.OpenWeChatBtn.UseVisualStyleBackColor = true;
            this.OpenWeChatBtn.Click += new System.EventHandler(this.OpenWeChatBtn_Click);
            // 
            // DisConnectBtn
            // 
            this.DisConnectBtn.Location = new System.Drawing.Point(280, 292);
            this.DisConnectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisConnectBtn.Name = "DisConnectBtn";
            this.DisConnectBtn.Size = new System.Drawing.Size(226, 51);
            this.DisConnectBtn.TabIndex = 5;
            this.DisConnectBtn.Text = "断开连接";
            this.DisConnectBtn.UseVisualStyleBackColor = true;
            this.DisConnectBtn.Click += new System.EventHandler(this.DisConnectBtn_Click);
            // 
            // StartConnectBtn
            // 
            this.StartConnectBtn.Location = new System.Drawing.Point(8, 292);
            this.StartConnectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartConnectBtn.Name = "StartConnectBtn";
            this.StartConnectBtn.Size = new System.Drawing.Size(226, 51);
            this.StartConnectBtn.TabIndex = 2;
            this.StartConnectBtn.Text = "开始连接";
            this.StartConnectBtn.UseVisualStyleBackColor = true;
            this.StartConnectBtn.Click += new System.EventHandler(this.StartConnect_Click);
            // 
            // WsUrlTxt
            // 
            this.WsUrlTxt.Location = new System.Drawing.Point(8, 258);
            this.WsUrlTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WsUrlTxt.Name = "WsUrlTxt";
            this.WsUrlTxt.Size = new System.Drawing.Size(325, 27);
            this.WsUrlTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(15, 371);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(514, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "高级设置";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ScrollingLog);
            this.groupBox3.Location = new System.Drawing.Point(15, 544);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(514, 338);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "消息显示";
            // 
            // ScrollingLog
            // 
            this.ScrollingLog.Location = new System.Drawing.Point(8, 26);
            this.ScrollingLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScrollingLog.Name = "ScrollingLog";
            this.ScrollingLog.Size = new System.Drawing.Size(498, 303);
            this.ScrollingLog.TabIndex = 0;
            this.ScrollingLog.Text = "";
            this.ScrollingLog.TextChanged += new System.EventHandler(this.ScrollingLog_TextChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(537, 25);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(969, 574);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(961, 541);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "好友";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FriendView);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(951, 528);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "好友列表";
            // 
            // FriendView
            // 
            this.FriendView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FriendView.ContextMenuStrip = this.FriendViewMenu;
            this.FriendView.Location = new System.Drawing.Point(8, 26);
            this.FriendView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FriendView.Name = "FriendView";
            this.FriendView.RowHeadersWidth = 51;
            this.FriendView.RowTemplate.Height = 25;
            this.FriendView.Size = new System.Drawing.Size(936, 495);
            this.FriendView.TabIndex = 0;
            this.FriendView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FriendView_CellMouseDown);
            // 
            // FriendViewMenu
            // 
            this.FriendViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FriendViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FriendToAutoChatToolStripMenuItem,
            this.FriendToAutoGreetToolStripMenuItem});
            this.FriendViewMenu.Name = "FirendViewMenu";
            this.FriendViewMenu.Size = new System.Drawing.Size(184, 52);
            // 
            // FriendToAutoChatToolStripMenuItem
            // 
            this.FriendToAutoChatToolStripMenuItem.Name = "FriendToAutoChatToolStripMenuItem";
            this.FriendToAutoChatToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.FriendToAutoChatToolStripMenuItem.Text = "添加到自动聊天";
            // 
            // FriendToAutoGreetToolStripMenuItem
            // 
            this.FriendToAutoGreetToolStripMenuItem.Name = "FriendToAutoGreetToolStripMenuItem";
            this.FriendToAutoGreetToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.FriendToAutoGreetToolStripMenuItem.Text = "添加到自动问候";
            this.FriendToAutoGreetToolStripMenuItem.Click += new System.EventHandler(this.FriendToAutoGreetToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GroupView);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(961, 541);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "群组";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // GroupView
            // 
            this.GroupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupView.Location = new System.Drawing.Point(8, 7);
            this.GroupView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupView.Name = "GroupView";
            this.GroupView.RowHeadersWidth = 51;
            this.GroupView.RowTemplate.Height = 25;
            this.GroupView.Size = new System.Drawing.Size(944, 525);
            this.GroupView.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.OpenAccountView);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Size = new System.Drawing.Size(961, 541);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "公众号";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // OpenAccountView
            // 
            this.OpenAccountView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenAccountView.Location = new System.Drawing.Point(8, 7);
            this.OpenAccountView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenAccountView.Name = "OpenAccountView";
            this.OpenAccountView.RowHeadersWidth = 51;
            this.OpenAccountView.RowTemplate.Height = 25;
            this.OpenAccountView.Size = new System.Drawing.Size(944, 525);
            this.OpenAccountView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(537, 606);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 275);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AutoGreetView);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(956, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "自动问候";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AutoGreetView
            // 
            this.AutoGreetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoGreetView.Location = new System.Drawing.Point(4, 4);
            this.AutoGreetView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoGreetView.Name = "AutoGreetView";
            this.AutoGreetView.RowHeadersWidth = 51;
            this.AutoGreetView.RowTemplate.Height = 25;
            this.AutoGreetView.Size = new System.Drawing.Size(651, 233);
            this.AutoGreetView.TabIndex = 2;
            this.AutoGreetView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AutoGreetView_CellMouseClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ExecuteAutoGreetBtn);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.SaveAutoGreetConfigBtn);
            this.groupBox6.Controls.Add(this.EnableMotto);
            this.groupBox6.Controls.Add(this.EnableCiBa);
            this.groupBox6.Controls.Add(this.EnableWeather);
            this.groupBox6.Controls.Add(this.AutoGreetTime);
            this.groupBox6.Controls.Add(this.AutoGreetStatus);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(662, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(288, 233);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "设置";
            // 
            // ExecuteAutoGreetBtn
            // 
            this.ExecuteAutoGreetBtn.Location = new System.Drawing.Point(149, 187);
            this.ExecuteAutoGreetBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExecuteAutoGreetBtn.Name = "ExecuteAutoGreetBtn";
            this.ExecuteAutoGreetBtn.Size = new System.Drawing.Size(131, 39);
            this.ExecuteAutoGreetBtn.TabIndex = 9;
            this.ExecuteAutoGreetBtn.Text = "立即执行";
            this.ExecuteAutoGreetBtn.UseVisualStyleBackColor = true;
            this.ExecuteAutoGreetBtn.Click += new System.EventHandler(this.ExecuteAutoGreetBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "问候功能：";
            // 
            // SaveAutoGreetConfigBtn
            // 
            this.SaveAutoGreetConfigBtn.Location = new System.Drawing.Point(8, 187);
            this.SaveAutoGreetConfigBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveAutoGreetConfigBtn.Name = "SaveAutoGreetConfigBtn";
            this.SaveAutoGreetConfigBtn.Size = new System.Drawing.Size(131, 39);
            this.SaveAutoGreetConfigBtn.TabIndex = 7;
            this.SaveAutoGreetConfigBtn.Text = "保存配置";
            this.SaveAutoGreetConfigBtn.UseVisualStyleBackColor = true;
            this.SaveAutoGreetConfigBtn.Click += new System.EventHandler(this.SaveAutoGreetConfigBtn_Click);
            // 
            // EnableMotto
            // 
            this.EnableMotto.AutoSize = true;
            this.EnableMotto.Location = new System.Drawing.Point(96, 138);
            this.EnableMotto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnableMotto.Name = "EnableMotto";
            this.EnableMotto.Size = new System.Drawing.Size(61, 24);
            this.EnableMotto.TabIndex = 6;
            this.EnableMotto.Text = "格言";
            this.EnableMotto.UseVisualStyleBackColor = true;
            // 
            // EnableCiBa
            // 
            this.EnableCiBa.AutoSize = true;
            this.EnableCiBa.Location = new System.Drawing.Point(170, 106);
            this.EnableCiBa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnableCiBa.Name = "EnableCiBa";
            this.EnableCiBa.Size = new System.Drawing.Size(61, 24);
            this.EnableCiBa.TabIndex = 5;
            this.EnableCiBa.Text = "词霸";
            this.EnableCiBa.UseVisualStyleBackColor = true;
            // 
            // EnableWeather
            // 
            this.EnableWeather.AutoSize = true;
            this.EnableWeather.Location = new System.Drawing.Point(96, 106);
            this.EnableWeather.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnableWeather.Name = "EnableWeather";
            this.EnableWeather.Size = new System.Drawing.Size(61, 24);
            this.EnableWeather.TabIndex = 4;
            this.EnableWeather.Text = "天气";
            this.EnableWeather.UseVisualStyleBackColor = true;
            // 
            // AutoGreetTime
            // 
            this.AutoGreetTime.CustomFormat = "HH:mm:ss";
            this.AutoGreetTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AutoGreetTime.Location = new System.Drawing.Point(96, 59);
            this.AutoGreetTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoGreetTime.Name = "AutoGreetTime";
            this.AutoGreetTime.Size = new System.Drawing.Size(163, 27);
            this.AutoGreetTime.TabIndex = 3;
            this.AutoGreetTime.Value = new System.DateTime(2022, 9, 30, 11, 49, 0, 0);
            // 
            // AutoGreetStatus
            // 
            this.AutoGreetStatus.AutoSize = true;
            this.AutoGreetStatus.Location = new System.Drawing.Point(96, 26);
            this.AutoGreetStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoGreetStatus.Name = "AutoGreetStatus";
            this.AutoGreetStatus.Size = new System.Drawing.Size(121, 24);
            this.AutoGreetStatus.TabIndex = 2;
            this.AutoGreetStatus.Text = "启用自动问候";
            this.AutoGreetStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "执行时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "状态：";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Size = new System.Drawing.Size(956, 242);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "自动聊天";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // AutoGreetTask
            // 
            this.AutoGreetTask.Tick += new System.EventHandler(this.AutoGreetTask_Tick);
            // 
            // WeChatHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 895);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WeChatHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "微信助手";
            this.Load += new System.EventHandler(this.WeChatHelper_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FriendView)).EndInit();
            this.FriendViewMenu.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpenAccountView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoGreetView)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Timer AutoGreetTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartConnectBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox WsUrlTxt;

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView FriendView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveGreetConfigBtn;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.RichTextBox ScrollingLog;
        public System.Windows.Forms.CheckBox AutoGreetStatus;
        public System.Windows.Forms.DateTimePicker AutoGreetTime;
        public System.Windows.Forms.CheckBox EnableWeather;
        public System.Windows.Forms.CheckBox EnableMotto;
        public System.Windows.Forms.CheckBox EnableCiBa;
        public System.Windows.Forms.Button SaveAutoGreetConfigBtn;
        public System.Windows.Forms.DataGridView AutoGreetView;
        private System.Windows.Forms.DataGridView GroupView;
        private System.Windows.Forms.DataGridView OpenAccountView;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button DisConnectBtn;
        private System.Windows.Forms.Button ShowWeChatBtn;
        private System.Windows.Forms.Button CleanRecordBtn;
        private System.Windows.Forms.Button CloseWeChatBtn;
        private System.Windows.Forms.Button OpenWeChatBtn;
        private System.Windows.Forms.Label connectStateLabel;
        private System.Windows.Forms.ContextMenuStrip FriendViewMenu;
        private System.Windows.Forms.ToolStripMenuItem FriendToAutoChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FriendToAutoGreetToolStripMenuItem;
        public System.Windows.Forms.Button ExecuteAutoGreetBtn;
    }
}

