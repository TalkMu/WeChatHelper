using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using WeChat.App.Service;
using WeChat.Service.Lrw;

namespace WeChat.App.Handle
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2021 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  HarvestCodeControl 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2021/4/6 22:59:14 
     * 描述    :
     * =====================================================================
     * 修改时间：2021/4/6 22:59:14 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class HarvestCodeHandle
    {
        //private static WeChatHelper weChatHelper = WeChatHelper.form;
        /// <summary>
        /// 发送收货码
        /// </summary>
        /// <param name="wxId"></param>
        /// <param name="message"></param>
        public void SendHarvestCode(string wxId, string message) 
        {
            string pattern = @"CD\d{16}";
            var hasMatch = Regex.IsMatch(message, pattern);
            if (hasMatch)
            {
                Match match = Regex.Match(message, pattern);
                string orderNumber = match.Value;
                var harvestCode = new OrderService().GetHarvestCode(orderNumber);
                string sendContent = string.Format("订单号：{0}\n收货码：{1}", orderNumber, harvestCode);
                new SocketService().Send(wxId, sendContent);
            }
        }
    }
}
