using System;
using System.Collections.Generic;
using System.Text;

namespace WeChat.Domain.Enum
{
    public enum SocketDataEnum
    {
        /// <summary>
        /// 心跳包
        /// </summary>
        HEART_BEAT = 5005,
        /// <summary>
        /// 接受文本消息
        /// </summary>
        RECV_TXT_MSG = 1,
        /// <summary>
        /// 获取通讯录
        /// </summary>
        USER_LIST = 5000,
        /// <summary>
        /// 获取通讯录成功
        /// </summary>
        GET_USER_LIST_SUCCSESS = 5001,
        /// <summary>
        /// 获取通讯录失败
        /// </summary>
        GET_USER_LIST_FAIL = 5002,
        /// <summary>
        /// 获取个人信息
        /// </summary>
        GET_USER_INFO = 6500,
        /// <summary>
        /// 发送文本信息
        /// </summary>
        SEND_TXT_MSG = 555,
        /// <summary>
        /// 发送文件信息
        /// </summary>
        Cmd_SendFileMessage = 5,
        /// <summary>
        /// 发送图片信息
        /// </summary>
        Cmd_SendImageMessage = 6,
        /// <summary>
        /// 发送@信息
        /// </summary>
        Cmd_SendAtMsg = 7,
        /// <summary>
        /// 发送名片消息
        /// </summary>
        Cmd_SendXmlCard = 8,
        /// <summary>
        /// 发送文章链接消息
        /// </summary>
        Cmd_SendXmlArticle = 9,
        /// <summary>
        /// 接收消息
        /// </summary>
        Cmd_ReceiveMessage = 10,
        /// <summary>
        /// 修改群名
        /// </summary>
        Cmd_SetRoomName = 11,
        /// <summary>
        /// 设置群公告
        /// </summary>
        Cmd_SetChatRoomAnnouncement = 12,
        /// <summary>
        /// 添加群成员
        /// </summary>
        Cmd_AddChatRoomMember = 13,
        /// <summary>
        /// 删除群成员
        /// </summary>
        Cmd_DeleteChatRoomMember = 14,
        /// <summary>
        /// 获取群成员
        /// </summary>
        Cmd_GetChatRoomMember = 15,
        /// <summary>
        /// 退出群
        /// </summary>
        Cmd_QuitChatRoom = 16,
    }
}
