using System;
using System.Collections.Generic;
using System.Text;

namespace WeChat.DTO.Controls
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2021 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  MsgRecordViewDTO 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2021/4/6 22:51:18 
     * 描述    :
     * =====================================================================
     * 修改时间：2021/4/6 22:51:18 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class MsgRecordViewDTO
    {
        public string WxId { get; set; }
        public string Content { get; set; }
        public string SenderWxId { get; set; }
    }
}
