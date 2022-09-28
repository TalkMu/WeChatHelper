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
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartConnect = new System.Windows.Forms.Button();
            this.StartWeChatBtn = new System.Windows.Forms.Button();
            this.WeChatPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnableHarvestCode = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ScrollingLog = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FriendView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.GroupView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.OpenAccountView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AutoGreetView = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendView)).BeginInit();
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
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StartConnect);
            this.groupBox1.Controls.Add(this.StartWeChatBtn);
            this.groupBox1.Controls.Add(this.WeChatPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "启动区";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(268, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "2022-09-28 11:01:55";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "断开连接";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Location = new System.Drawing.Point(86, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Helloes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "登录账户：";
            // 
            // StartConnect
            // 
            this.StartConnect.Location = new System.Drawing.Point(6, 248);
            this.StartConnect.Name = "StartConnect";
            this.StartConnect.Size = new System.Drawing.Size(176, 43);
            this.StartConnect.TabIndex = 2;
            this.StartConnect.Text = "开始连接";
            this.StartConnect.UseVisualStyleBackColor = true;
            this.StartConnect.Click += new System.EventHandler(this.StartConnect_Click);
            // 
            // StartWeChatBtn
            // 
            this.StartWeChatBtn.Location = new System.Drawing.Point(306, 219);
            this.StartWeChatBtn.Name = "StartWeChatBtn";
            this.StartWeChatBtn.Size = new System.Drawing.Size(88, 23);
            this.StartWeChatBtn.TabIndex = 1;
            this.StartWeChatBtn.Text = "启动微信";
            this.StartWeChatBtn.UseVisualStyleBackColor = true;
            this.StartWeChatBtn.Click += new System.EventHandler(this.StartWeChatBtn_Click);
            // 
            // WeChatPath
            // 
            this.WeChatPath.Location = new System.Drawing.Point(6, 219);
            this.WeChatPath.Name = "WeChatPath";
            this.WeChatPath.Size = new System.Drawing.Size(294, 23);
            this.WeChatPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EnableHarvestCode);
            this.groupBox2.Location = new System.Drawing.Point(12, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "高级设置";
            // 
            // EnableHarvestCode
            // 
            this.EnableHarvestCode.AutoSize = true;
            this.EnableHarvestCode.Location = new System.Drawing.Point(6, 22);
            this.EnableHarvestCode.Name = "EnableHarvestCode";
            this.EnableHarvestCode.Size = new System.Drawing.Size(87, 21);
            this.EnableHarvestCode.TabIndex = 0;
            this.EnableHarvestCode.Text = "开启收货码";
            this.EnableHarvestCode.UseVisualStyleBackColor = true;
            this.EnableHarvestCode.Click += new System.EventHandler(this.EnableHarvestCode_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ScrollingLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 287);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "消息显示";
            // 
            // ScrollingLog
            // 
            this.ScrollingLog.Location = new System.Drawing.Point(6, 22);
            this.ScrollingLog.Name = "ScrollingLog";
            this.ScrollingLog.Size = new System.Drawing.Size(388, 258);
            this.ScrollingLog.TabIndex = 0;
            this.ScrollingLog.Text = "";
            this.ScrollingLog.TextChanged += new System.EventHandler(this.ScrollingLog_TextChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(418, 21);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(754, 488);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(746, 458);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "好友";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FriendView);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(740, 449);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "好友列表";
            // 
            // FriendView
            // 
            this.FriendView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FriendView.Location = new System.Drawing.Point(6, 22);
            this.FriendView.Name = "FriendView";
            this.FriendView.RowHeadersWidth = 51;
            this.FriendView.RowTemplate.Height = 25;
            this.FriendView.Size = new System.Drawing.Size(728, 421);
            this.FriendView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GroupView);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(746, 458);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "群组";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // GroupView
            // 
            this.GroupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupView.Location = new System.Drawing.Point(6, 6);
            this.GroupView.Name = "GroupView";
            this.GroupView.RowHeadersWidth = 51;
            this.GroupView.RowTemplate.Height = 25;
            this.GroupView.Size = new System.Drawing.Size(734, 446);
            this.GroupView.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.OpenAccountView);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(746, 458);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "公众号";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // OpenAccountView
            // 
            this.OpenAccountView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenAccountView.Location = new System.Drawing.Point(6, 6);
            this.OpenAccountView.Name = "OpenAccountView";
            this.OpenAccountView.RowHeadersWidth = 51;
            this.OpenAccountView.RowTemplate.Height = 25;
            this.OpenAccountView.Size = new System.Drawing.Size(734, 446);
            this.OpenAccountView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(418, 515);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 234);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AutoGreetView);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "自动问候";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AutoGreetView
            // 
            this.AutoGreetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoGreetView.Location = new System.Drawing.Point(3, 3);
            this.AutoGreetView.Name = "AutoGreetView";
            this.AutoGreetView.RowHeadersWidth = 51;
            this.AutoGreetView.RowTemplate.Height = 25;
            this.AutoGreetView.Size = new System.Drawing.Size(506, 198);
            this.AutoGreetView.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.SaveAutoGreetConfigBtn);
            this.groupBox6.Controls.Add(this.EnableMotto);
            this.groupBox6.Controls.Add(this.EnableCiBa);
            this.groupBox6.Controls.Add(this.EnableWeather);
            this.groupBox6.Controls.Add(this.AutoGreetTime);
            this.groupBox6.Controls.Add(this.AutoGreetStatus);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(515, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(224, 198);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "设置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "问候功能：";
            // 
            // SaveAutoGreetConfigBtn
            // 
            this.SaveAutoGreetConfigBtn.Location = new System.Drawing.Point(53, 159);
            this.SaveAutoGreetConfigBtn.Name = "SaveAutoGreetConfigBtn";
            this.SaveAutoGreetConfigBtn.Size = new System.Drawing.Size(129, 33);
            this.SaveAutoGreetConfigBtn.TabIndex = 7;
            this.SaveAutoGreetConfigBtn.Text = "保存配置";
            this.SaveAutoGreetConfigBtn.UseVisualStyleBackColor = true;
            this.SaveAutoGreetConfigBtn.Click += new System.EventHandler(this.SaveAutoGreetConfigBtn_Click);
            // 
            // EnableMotto
            // 
            this.EnableMotto.AutoSize = true;
            this.EnableMotto.Location = new System.Drawing.Point(75, 117);
            this.EnableMotto.Name = "EnableMotto";
            this.EnableMotto.Size = new System.Drawing.Size(51, 21);
            this.EnableMotto.TabIndex = 6;
            this.EnableMotto.Text = "格言";
            this.EnableMotto.UseVisualStyleBackColor = true;
            // 
            // EnableCiBa
            // 
            this.EnableCiBa.AutoSize = true;
            this.EnableCiBa.Location = new System.Drawing.Point(132, 90);
            this.EnableCiBa.Name = "EnableCiBa";
            this.EnableCiBa.Size = new System.Drawing.Size(51, 21);
            this.EnableCiBa.TabIndex = 5;
            this.EnableCiBa.Text = "词霸";
            this.EnableCiBa.UseVisualStyleBackColor = true;
            // 
            // EnableWeather
            // 
            this.EnableWeather.AutoSize = true;
            this.EnableWeather.Location = new System.Drawing.Point(75, 90);
            this.EnableWeather.Name = "EnableWeather";
            this.EnableWeather.Size = new System.Drawing.Size(51, 21);
            this.EnableWeather.TabIndex = 4;
            this.EnableWeather.Text = "天气";
            this.EnableWeather.UseVisualStyleBackColor = true;
            // 
            // AutoGreetTime
            // 
            this.AutoGreetTime.CustomFormat = "HH:mm:ss";
            this.AutoGreetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AutoGreetTime.Location = new System.Drawing.Point(75, 50);
            this.AutoGreetTime.Name = "AutoGreetTime";
            this.AutoGreetTime.Size = new System.Drawing.Size(128, 23);
            this.AutoGreetTime.TabIndex = 3;
            // 
            // AutoGreetStatus
            // 
            this.AutoGreetStatus.AutoSize = true;
            this.AutoGreetStatus.Location = new System.Drawing.Point(75, 22);
            this.AutoGreetStatus.Name = "AutoGreetStatus";
            this.AutoGreetStatus.Size = new System.Drawing.Size(99, 21);
            this.AutoGreetStatus.TabIndex = 2;
            this.AutoGreetStatus.Text = "启用自动问候";
            this.AutoGreetStatus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "执行时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "状态：";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage6.Size = new System.Drawing.Size(742, 204);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeChatHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "微信助手";
            this.Load += new System.EventHandler(this.WeChatHelper_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FriendView)).EndInit();
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
        private System.Windows.Forms.Button StartConnect;
        private System.Windows.Forms.Button StartWeChatBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox WeChatPath;

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView FriendView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveGreetConfigBtn;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.RichTextBox ScrollingLog;
        public System.Windows.Forms.CheckBox EnableHarvestCode;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

