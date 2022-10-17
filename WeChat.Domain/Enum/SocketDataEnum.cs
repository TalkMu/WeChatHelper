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
        GET_USER_LIST = 5000,
        /// <summary>
        /// 获取通讯录成功
        /// </summary>
        GET_USER_LIST_SUCCSESS = 5001,
        /// <summary>
        /// 获取通讯录失败
        /// </summary>
        GET_USER_LIST_FAIL = 5002,
        /// <summary>
        /// 获取我的信息
        /// </summary>
        GET_USER_INFO = 6500,
        /// <summary>
        /// 获取我的信息成功
        /// </summary>
        GET_USER_INFO_SUCCESS = 6500,
        /// <summary>
        /// 发送文本信息
        /// </summary>
        SEND_TXT_MSG = 555,
        /// <summary>
        /// 获取好友详细资料
        /// </summary>
        GET_FRIEND_DETAIL = 6550,
        /// <summary>
        /// 获取好友详细资料成功
        /// </summary>
        GET_FRIEND_DETAIL_SUCCESS = 6550,
        /// <summary>
        /// 接收图片消息
        /// </summary>
        RECV_IMG_MSG = 3,
        /// <summary>
        /// 获取群列表及成员wxId
        /// </summary>
        GET_ROOM_MEMBER_LIST = 5010,
        /// <summary>
        /// 获取群列表及成员wxId成功
        /// </summary>
        GET_ROOM_MEMBER_LIST_SUCCESS = 5010,
        /// <summary>
        /// 获取群成员昵称
        /// </summary>
        GET_ROOM_MEMBER_NICK = 5020,
        /// <summary>
        /// 获取群成员昵称成功
        /// </summary>
        GET_ROOM_MEMBER_NICK_SUCCESS = 5020,
    }
}
