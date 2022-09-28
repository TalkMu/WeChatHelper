using System;
using System.Collections.Generic;
using System.Text;
using WeChat.Extend.Helper.Date;

namespace WeChat.App.Handle
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2021 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  ScrollingLog 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2021/4/6 22:43:45 
     * 描述    :
     * =====================================================================
     * 修改时间：2021/4/6 22:43:45 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class ScrollingLogHandle
    {
        private static WeChatHelper weChatHelper = WeChatHelper.form;
        /// <summary>
        /// 追加消息到日志控制台
        /// </summary>
        /// <param name="content"></param>
        public static void AppendTextToLog(string content)
        {
            weChatHelper.ScrollingLog.AppendText(DateHelper.Now() + " " + content + "\n");
        }
    }
}
