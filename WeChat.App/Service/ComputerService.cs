using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WeChat.App.Service
{
    public interface ComputerService
    {
        /// <summary>
        /// 执行脚本
        /// </summary>
        /// <param name="script"></param>
        /// <returns></returns>
        public string Exec(string script);

        /// <summary>
        /// 关机
        /// </summary>
        /// <returns></returns>
        public string Shutdown();

        /// <summary>
        /// 关闭指定计算机
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public string Shutdown(string ip);

        /// <summary>
        /// 唤醒指定电脑
        /// </summary>
        /// <param name="macStr"></param>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public string WakeUp(string macStr,string ip, int port);
    }
}
