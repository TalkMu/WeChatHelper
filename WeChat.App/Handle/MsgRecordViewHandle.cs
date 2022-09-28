using System;
using System.Collections.Generic;
using System.Text;
using WeChat.DTO.Controls;

namespace WeChat.App.Handle
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2021 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  MsgRecordViewControl 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2021/4/6 22:46:50 
     * 描述    :
     * =====================================================================
     * 修改时间：2021/4/6 22:46:50 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class MsgRecordViewHandle
    {
        /// <summary>
        /// 添加行
        /// </summary>
        /// <param name="model"></param>
        public static void AddRow(MsgRecordViewDTO model) 
        {
            //int rowIndex = WeChatHelper.form.MsgRecordView.Rows.Add();
            //WeChatHelper.form.MsgRecordView.Rows[rowIndex].Cells["WxId"].Value = model.WxId;
            //WeChatHelper.form.MsgRecordView.Rows[rowIndex].Cells["SenderWxId"].Value = model.SenderWxId;
            //WeChatHelper.form.MsgRecordView.Rows[rowIndex].Cells["Content"].Value = model.Content;
        }
    }
}
