using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeChat.App.Service;
using WeChat.App.Socket;
using WeChat.Domain.Models;

namespace WeChat.App.Handle
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2021 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  AutoGreetHandle 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2021/4/6 23:07:50 
     * 描述    :
     * =====================================================================
     * 修改时间：2021/4/6 23:07:50 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class AutoGreetHandle
    {
        //private static WeChatHelper weChatHelper = WeChatHelper.form;

        public static void ReadAutoGreetConfig()
        {
            
            //var user = WxSocket.GetCurUser();
            //if (user == null)
            //{
            //    return;
            //}
            //var config = new AutoGreetConfigService().FindByUserId(user.UserId);
            //if (config == null)
            //{
            //    return;
            //}
            //weChatHelper.AutoGreetStatus.Checked = config.Status ?? false;
            //weChatHelper.EnableCiBa.Checked = config.EnableCiba ?? false;
            //weChatHelper.EnableMotto.Checked = config.EnableMotto ?? false;
            //weChatHelper.EnableWeather.Checked = config.EnableWeather ?? false;
            //weChatHelper.AutoGreetTime.Value = config.GreetTime == null ? DateTime.Now : Convert.ToDateTime(config.GreetTime.ToString());

            //// 加载自动问候数据列表
            //var userList = new AutoGreetService().GetList();

            //userList.ForEach(p =>
            //{
            //    var rowIndex = weChatHelper.AutoGreetView.Rows.Add();
            //    weChatHelper.AutoGreetView.Rows[rowIndex].Cells["WxId"].Value = p.UserId;
            //    weChatHelper.AutoGreetView.Rows[rowIndex].Cells["NickName"].Value = p.NickName;
            //    weChatHelper.AutoGreetView.Rows[rowIndex].Cells["Mobile"].Value = p.Mobile;
            //    weChatHelper.AutoGreetView.Rows[rowIndex].Cells["Remarks"].Value = p.Mobile;
            //});

        }

        
    }
}
