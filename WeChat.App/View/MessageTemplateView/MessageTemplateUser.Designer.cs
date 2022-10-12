namespace WeChat.App.View.MessageTemplateView
{
    partial class MessageTemplateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.UserTransfer = new Sunny.UI.UITransfer();
            this.SubmitBtn = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // UserTransfer
            // 
            this.UserTransfer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserTransfer.Location = new System.Drawing.Point(7, 44);
            this.UserTransfer.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.UserTransfer.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserTransfer.Name = "UserTransfer";
            this.UserTransfer.Padding = new System.Windows.Forms.Padding(1);
            this.UserTransfer.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.UserTransfer.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.UserTransfer.ShowText = false;
            this.UserTransfer.Size = new System.Drawing.Size(675, 350);
            this.UserTransfer.TabIndex = 0;
            this.UserTransfer.Text = "uiTransfer1";
            this.UserTransfer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserTransfer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitBtn.Location = new System.Drawing.Point(294, 441);
            this.SubmitBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(100, 35);
            this.SubmitBtn.TabIndex = 1;
            this.SubmitBtn.Text = "提交";
            this.SubmitBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // MessageTemplateUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(689, 509);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.UserTransfer);
            this.Name = "MessageTemplateUser";
            this.Text = "关联用户";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITransfer UserTransfer;
        private Sunny.UI.UIButton SubmitBtn;
    }
}