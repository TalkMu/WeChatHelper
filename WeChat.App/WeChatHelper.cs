
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WeChat.App.DataSource;
using WeChat.App.Handle;
using WeChat.App.ModelView;
using WeChat.App.ModelView.User;
using WeChat.App.Service;
using WeChat.App.Service.Impl;
using WeChat.App.View;
using WeChat.App.View.MessageTemplateView;
using WeChat.Domain;
using WeChat.Domain.Enum;
using WeChat.Domain.Models;
using WeChat.DTO.Message;
using WeChat.DTO.Socket;
using WeChat.Extend.Helper;
using WeChat.Extend.Helper.Date;
using WeChat.Service.Lrw;
using WeChat.Service.WeChat;

namespace WeChat.App
{
    public partial class WeChatHelper : UIForm
    {
        private WeChatService weChatService = new WeChatService();
        public static WeChatHelper form;

        private UserService userService = new UserService();
        private FriendService friendService = new FriendService();



        #region 属性

        #region Socket是否连接中
        private bool wsConnectRunning;
        public bool WsConnectRunning
        {
            get => wsConnectRunning;
            set
            {
                if (value)
                {
                    RunUi(() =>
                    {
                        connectStateLabel.Text = "已连接";
                        connectStateLabel.ForeColor = Color.Green;
                    });
                    StartConnectBtn.Enabled = false;
                    DisConnectBtn.Enabled = true;
                }
                else
                {
                    RunUi(() =>
                    {
                        connectStateLabel.Text = "未连接";
                        connectStateLabel.ForeColor = Color.Red;
                    });
                    StartConnectBtn.Enabled = true;
                    DisConnectBtn.Enabled = false;

                }
                wsConnectRunning = value;
            }
        }
        #endregion

        #region 最后心跳时间
        private DateTime lastHeartTime;
        public DateTime LastHeartTime
        {
            get => lastHeartTime;
            set
            {
                RunUi(() =>
                {
                    connectStateLabel.Text = DateHelper.FormatDateTime(value);
                    connectStateLabel.ForeColor = Color.Green;
                });
                lastHeartTime = value;
            }
        }
        #endregion

        #endregion

        public WeChatHelper()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            form = this;
        }



        #region 初始化组件

        public void InitWindow() 
        {

        }

        public void InitFriendView()
        {
            DataGridViewTextBoxColumn TextBoxColumnX = new DataGridViewTextBoxColumn();
            // 获取或设置数据源属性的名称或与 DataGridViewColumn 绑定的数据库列的名称。
            TextBoxColumnX.DataPropertyName = "WxId";
            TextBoxColumnX.HeaderText = "微信ID";
            // 获取或设置列名
            TextBoxColumnX.Name = "WxId";
            FriendView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "WxCode";
            TextBoxColumnX.HeaderText = "微信号";
            TextBoxColumnX.Name = "WxCode";
            FriendView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "NickName";
            TextBoxColumnX.HeaderText = "昵称";
            TextBoxColumnX.Name = "NickName";
            FriendView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "HeadImg";
            TextBoxColumnX.HeaderText = "头像";
            TextBoxColumnX.Name = "HeadImg";
            FriendView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "Remark";
            TextBoxColumnX.HeaderText = "备注";
            TextBoxColumnX.Name = "Remark";
            FriendView.Columns.Add(TextBoxColumnX);


            FriendView.AutoGenerateColumns = false;
            FriendView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FriendView.BackgroundColor = Color.White;
            FriendView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FriendView.BorderStyle = BorderStyle.Fixed3D;
        }

        public void InitGroupView()
        {
            DataGridViewTextBoxColumn TextBoxColumnX = new DataGridViewTextBoxColumn();
            // 获取或设置数据源属性的名称或与 DataGridViewColumn 绑定的数据库列的名称。
            TextBoxColumnX.DataPropertyName = "WxId";
            TextBoxColumnX.HeaderText = "微信ID";
            // 获取或设置列名
            TextBoxColumnX.Name = "WxId";
            GroupView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "WxCode";
            TextBoxColumnX.HeaderText = "微信号";
            TextBoxColumnX.Name = "WxCode";
            GroupView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "NickName";
            TextBoxColumnX.HeaderText = "昵称";
            TextBoxColumnX.Name = "NickName";
            GroupView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "HeadImg";
            TextBoxColumnX.HeaderText = "头像";
            TextBoxColumnX.Name = "HeadImg";
            GroupView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "Remark";
            TextBoxColumnX.HeaderText = "备注";
            TextBoxColumnX.Name = "Remark";
            GroupView.Columns.Add(TextBoxColumnX);


            GroupView.AutoGenerateColumns = false;
            GroupView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GroupView.BackgroundColor = Color.White;
            GroupView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GroupView.BorderStyle = BorderStyle.Fixed3D;
        }

        public void InitOpenAccountView()
        {
            DataGridViewTextBoxColumn TextBoxColumnX = new DataGridViewTextBoxColumn();
            // 获取或设置数据源属性的名称或与 DataGridViewColumn 绑定的数据库列的名称。
            TextBoxColumnX.DataPropertyName = "WxId";
            TextBoxColumnX.HeaderText = "微信ID";
            // 获取或设置列名
            TextBoxColumnX.Name = "WxId";
            OpenAccountView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "WxCode";
            TextBoxColumnX.HeaderText = "微信号";
            TextBoxColumnX.Name = "WxCode";
            OpenAccountView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "NickName";
            TextBoxColumnX.HeaderText = "昵称";
            TextBoxColumnX.Name = "NickName";
            OpenAccountView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "HeadImg";
            TextBoxColumnX.HeaderText = "头像";
            TextBoxColumnX.Name = "HeadImg";
            OpenAccountView.Columns.Add(TextBoxColumnX);

            TextBoxColumnX = new DataGridViewTextBoxColumn();
            TextBoxColumnX.DataPropertyName = "Remark";
            TextBoxColumnX.HeaderText = "备注";
            TextBoxColumnX.Name = "Remark";
            OpenAccountView.Columns.Add(TextBoxColumnX);


            OpenAccountView.AutoGenerateColumns = false;
            OpenAccountView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OpenAccountView.BackgroundColor = Color.White;
            OpenAccountView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OpenAccountView.BorderStyle = BorderStyle.Fixed3D;
        }
        #endregion

        #region Socket服务
        /// <summary>
        /// 开启服务
        /// </summary>
        public void ConnectSocket()
        {
            DisconnectSocket();
            ScrollingLogHandle.AppendTextToLog($"[连接服务] 将连接到{Appsetting.SOCKET_URL}");
            AppData.webSocket = new WebSocket(Appsetting.SOCKET_URL);
            AppData.webSocket.Connect();

            AppData.webSocket.OnOpen += WsOnOpen;
            AppData.webSocket.OnClose += WsOnClose;
            AppData.webSocket.OnMessage += WsOnMessage;
            AppData.webSocket.OnError += WsOnError;
            ScrollingLogHandle.AppendTextToLog($"[连接服务] 连接操作成功");
            WsConnectRunning = true;
        }
        /// <summary>
        /// 关闭服务
        /// </summary>
        public void DisconnectSocket()
        {
            if (AppData.webSocket == null)
            {
                return;
            }
            ScrollingLogHandle.AppendTextToLog($"[断开服务] 尝试断开服务");
            AppData.webSocket.Close();
            AppData.webSocket.OnOpen -= WsOnOpen;
            AppData.webSocket.OnClose -= WsOnClose;
            AppData.webSocket.OnMessage -= WsOnMessage;
            AppData.webSocket.OnError -= WsOnError;
            ScrollingLogHandle.AppendTextToLog($"[断开服务] 服务已断开");
            WsConnectRunning = false;
        }
        #endregion

        #region Socket 事件
        private void WsOnOpen(object sender, EventArgs e)
        {
            ScrollingLogHandle.AppendTextToLog($"已连接到:{Appsetting.SOCKET_URL}");
        }
        private void WsOnClose(object sender, CloseEventArgs e)
        {
            ScrollingLogHandle.AppendTextToLog($"与{Appsetting.SOCKET_URL}的连接已关闭");
        }
        private void WsOnMessage(object sender, MessageEventArgs e)
        {
            if (e == null)
            {
                ScrollingLogHandle.AppendTextToLog($"[WS信息事件] 获取到空信息");
                return;
            }

            if (e.IsText)
            {
                HandleReceiveMessage(e.Data);
                return;
            }
        }
        private void WsOnError(object sender, ErrorEventArgs e)
        {
            ScrollingLogHandle.AppendTextToLog($"已连接到:{Appsetting.SOCKET_URL}");
        }
        #endregion

        #region 接收处理Socket消息
        /// <summary>
        /// 处理Socket消息
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="base64Str"></param>
        public void HandleReceiveMessage(string data)
        {
            var model = JsonHelper.FromJson<WxServerReceiveDTO<object>>(data);

            switch (model.Code)
            {
                case SocketDataEnum.HEART_BEAT:
                    HandleHeartBeat(JsonHelper.FromJson<WxServerReceiveDTO<string>>(data));
                    break;
                case SocketDataEnum.USER_LIST:
                    this.HandleUserList(JsonHelper.FromJson<WxServerReceiveDTO<BindingList<WxFriendUserMV>>>(data));
                    break;
                case SocketDataEnum.GET_USER_LIST_SUCCSESS:
                    this.HandleUserList(JsonHelper.FromJson<WxServerReceiveDTO<BindingList<WxFriendUserMV>>>(data));
                    break;
                case SocketDataEnum.GET_USER_INFO:
                    this.HandleUserInfo(JsonHelper.FromJson<WxServerReceiveDTO<string>>(data));
                    break;
                case SocketDataEnum.GET_FRIEND_DETAIL:
                    this.HandleFriendDetail(JsonHelper.FromJson<WxServerReceiveDTO<object>>(data));
                    break;
                default:
                    //ScrollingLogHandle.AppendTextToLog($"已获取信息：{data}");
                    HandleRecTxtMsg(JsonHelper.FromJson<WxServerReceiveDTO<object>>(data));
                    break;
            }

        }
        #endregion

        #region 处理消息
        public void HandleHeartBeat(WxServerReceiveDTO<string> data)
        {
            LastHeartTime = Convert.ToDateTime(data.Time);
            var contentJson = JsonHelper.ToJson(data);
            //ScrollingLogHandle.AppendTextToLog($"[处理服务器心跳] 已获取信息：{contentJson}");
        }
        public void HandleRecTxtMsg(WxServerReceiveDTO<object> data)
        {
            var contentJson = data.Data;
            var contentStr = contentJson.ToString();
            if (data.WxId == null) 
            {
                return;
            }
            if (data.WxId.Contains("@chatroom"))
            {
                // 群聊
                
            }
            else
            {
                // 个人
                ScrollingLogHandle.AppendTextToLog($"[处理接收文字消息] 已获取信息:{contentJson}");
            }
            // 懒人窝验证码
            new HarvestCodeHandle().SendHarvestCode(data.WxId, contentStr);
            // 电脑操作
            new WindowsComputerServiceImpl().Handle(contentStr);


            //ScrollingLogHandle.AppendTextToLog($"[处理接收文字消息] 已获取信息:{contentJson}");
        }

        public void HandleUserInfo(WxServerReceiveDTO<string> data)
        {
            var contentJson = data.Data;

            var wxUserInfo = JsonHelper.FromJson<WxUserMV>(contentJson);
            WxUser wxUser = new WxUser()
            {
                WxId = wxUserInfo.WxId,
                WxCode = wxUserInfo.WxCode,
                NickName = wxUserInfo.NickName,
            };
            userService.SaveOrUpdate(wxUser);

            // 查询登录用户信息
            AppData.loginUser = wxUser;

            // 加载页面数据
            this.LoadPageData();
        }

        public void HandleFriendDetail(WxServerReceiveDTO<object> data) 
        {
        
        }

        public void HandleUserList(WxServerReceiveDTO<BindingList<WxFriendUserMV>> data)
        {
            var users = data.Data;
            var userService = new UserService();
            var weChatService = new WeChatService();
            users.ToList().ForEach(user => 
            {
                var item = new WxUser()
                {
                    WxId = user.WxId,
                    NickName = user.NickName,
                    WxCode = user.WxCode,
                };
                userService.SaveOrUpdate(item);

                var friend = new WxUserFriend()
                {
                    UserId = AppData.loginUser.Id,
                    FriendUserId = item.Id,
                    Remark = user.Remark,
                    CreateTime = DateTime.Now,
                };
                friendService.SaveOrUpdate(friend);
                // weChatService.GetFriendDetail(user.WxId);
            });
        }
        #endregion

        #region 窗体事件

        #region 刷新UI
        public void RunUi(Action action)
        {
            BeginInvoke(action);
        }
        #endregion

        #region 加载窗体
        private void WeChatHelper_Load(object sender, EventArgs e)
        {
            this.InitWindow();
            // 初始化好友视图
            this.InitFriendView();
            this.InitGroupView();
            this.InitOpenAccountView();
            // 加载WsUrl
            WsUrlTxt.Text = Appsetting.SOCKET_URL;

            DisConnectBtn.Enabled = false;
        }
        #endregion

        #region 消息日志变更
        private void ScrollingLog_TextChanged(object sender, EventArgs e)
        {
            ScrollingLog.SelectionStart = ScrollingLog.Text.Length;
            ScrollingLog.ScrollToCaret();
        }
        #endregion

        #region 开始连接
        private void StartConnectBtn_Click(object sender, EventArgs e)
        {
            // 启用Socket服务
            this.ConnectSocket();

            // 查询登录信息
            weChatService.GetUserInfo();

            // 获取好友列表、群组、公众号
            weChatService.GetUserList();

            
        }
        #endregion

        #region 断开连接
        private void DisConnectBtn_Click(object sender, EventArgs e)
        {
            this.DisconnectSocket();
        }
        #endregion

        #region 启动微信
        private void OpenWeChatBtn_Click(object sender, EventArgs e)
        {
            // 启动微信
            var openWechat = weChatService.OpenWechat();
            if (openWechat)
            {
                ScrollingLogHandle.AppendTextToLog("启动微信成功");
            }

            // 注入DLL
            //var injectDll = weChatService.InjectDllToWeChat();
            //if (injectDll)
            //{
            //    ScrollingLogHandle.AppendTextToLog("成功注入DLL到微信");
            //}
        }
        #endregion

        #region 关闭微信
        private void CloseWeChatBtn_Click(object sender, EventArgs e)
        {
            weChatService.CloseWeChat();
        }
        #endregion

        #region 显示微信
        private void ShowWeChatBtn_Click(object sender, EventArgs e)
        {
            weChatService.TopWindow();
        }
        #endregion

        #region 右键好友列表
        private void FriendView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                FriendView.ClearSelection();
                FriendView.Rows[e.RowIndex].Selected = true;

                UIContextMenuStrip strip = new UIContextMenuStrip();
                strip.Items.Add("更新个人资料");
                strip.Items[0].Click += UpdateDetailToolStripMenuItem_Click;
                strip.Show(MousePosition.X, MousePosition.Y);
            }
        }
        #endregion

        #region 更新好友资料
        private void UpdateDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 获取当前选中行
            //var curRow = FriendView.CurrentRow;
            //var wxFriendUserMV = (WxFriendUserMV)curRow.DataBoundItem;

            //weChatService.GetFriendDetail(wxFriendUserMV.WxId);
        }
        #endregion

        #region 清空日志
        private void CleanRecordBtn_Click(object sender, EventArgs e)
        {
            ScrollingLog.Text = "";
        } 
        #endregion

        #endregion

        #region 基础方法

        #region 加载页面
        public void LoadPageData()
        {
            // 加载定时任务
            new MessageTemplateHandle().LoadQuart();

            LoadFriendList();
        }

        #region 加载通讯录列表
        private void LoadFriendList()
        {
            // 获取好友列表
            var userList = friendService.GetList();
            FriendView.DataSource = null;
            GroupView.DataSource = null;
            OpenAccountView.DataSource = null;
            // 群聊
            var groupList = userList.Where(p => p.WxId.EndsWith("@chatroom")).ToList();
            // 公众号
            var openAccountList = userList.Where(p => p.WxId.StartsWith("gh_")).ToList();
            // 好友
            var friendList = userList.Where(p => !p.WxId.EndsWith("@chatroom") && !p.WxId.StartsWith("gh_")).ToList();

            RunUi(() =>
            {
                FriendView.DataSource = friendList;
                GroupView.DataSource = groupList;
                OpenAccountView.DataSource = openAccountList;
            });
            FriendView.AllowUserToAddRows = false;
            GroupView.AllowUserToAddRows = false;
            OpenAccountView.AllowUserToAddRows = false;
        }
        #endregion


        #endregion

        #region 显示弹框
        public void Show(string content)
        {
            MessageBox.Show(content, "提示");
        } 
        #endregion

        #endregion

        private void 定时消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageTemplate messageTemplate = new MessageTemplate();
            messageTemplate.ShowDialog();
        }

        
    }
}
