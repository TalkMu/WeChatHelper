
using DBHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeChat.Service.Lrw
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2021 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  OrderService 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2021/4/6 16:10:50 
     * 描述    :
     * =====================================================================
     * 修改时间：2021/4/6 16:10:50 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class OrderService
    {
        /// <summary>
        /// 懒人窝DB
        /// </summary>
        private static readonly DBHelper LrwDb = new DBHelper("LrwDB");

        /// <summary>
        /// 获取订单收货码
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <returns></returns>
        public string GetHarvestCode(string orderNumber)
        {
            var harvestCode = LrwDb.ExecuteScalar<string>(LrwDb.CreateCommand("select ReceivingCode from [Order] where OrderNumber = {0}", orderNumber));
            return harvestCode;
        }

        public void SendHarvestCode() 
        {
        
        }
    }
}
