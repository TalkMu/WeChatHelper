using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.App.Handle;
using WeChat.Domain;
using WeChat.Domain.Enum;
using WeChat.DTO.Socket;
using WeChat.Extend.Helper;
using WeChat.Extend.Helper.Date;

namespace WeChat.App.Service
{
    public class SocketService
    {
        #region 发送处理Socket消息
        public void Send(SocketDTO model)
        {
            if (model == null)
            {
                LogHelper.Error("发送数据不能为空");
                return;
            }
            var data = JsonHelper.ToJson(model);
            ScrollingLogHandle.AppendTextToLog($"[发送消息] 发送数据：{data}");
            AppData.webSocket.Send(data);
        }
        #endregion

        #region 发送Socket消息
        public void Send(string wxId, string content)
        {
            SocketDTO model = new SocketDTO()
            {
                Id = StrHelper.GetMsgId(),
                WxId = wxId,
                Content = content,
                Type = SocketDataEnum.SEND_TXT_MSG
            };
            var data = JsonHelper.ToJson(model);
            //ScrollingLogHandle.AppendTextToLog($"[发送消息] 发送数据：{data}");
            AppData.webSocket.Send(data);
        } 
        #endregion
    }
}
