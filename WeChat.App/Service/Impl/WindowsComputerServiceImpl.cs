using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WeChat.Extend.Helper;

namespace WeChat.App.Service.Impl
{
    internal class WindowsComputerServiceImpl : ComputerService
    {
        //通过正则表达式设定MAC地址筛选标准，关于正则表达式请自行百度
        const string macCheckRegexString = @"^([0-9a-fA-F]{2})(([/\s:-][0-9a-fA-F]{2}){5})$";

        // IP地址检验
        const string ipCheckRegex = @"((25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))";

        #region 执行脚本
        public string Exec(string script)
        {
            using (Process p = new Process())
            {
                //设置要启动的应用程序
                p.StartInfo.FileName = "cmd.exe";
                //是否使用操作系统shell启动
                p.StartInfo.UseShellExecute = false;
                // 接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardInput = true;
                // 设置输出信息
                p.StartInfo.RedirectStandardOutput = true;
                // 输出错误
                p.StartInfo.RedirectStandardError = true;
                //不显示程序窗口
                p.StartInfo.CreateNoWindow = true;

                //启动程序
                p.Start();

                //向cmd窗口发送输入信息
                p.StandardInput.WriteLine(script);
                //自动处理缓存数据　　　　　　　　　　　　　　 
                p.StandardInput.AutoFlush = true;
                //退出命令窗口
                p.StandardInput.WriteLine("exit");
                //等待程序执行完退出进程
                p.WaitForExit();

                var errorMsg = p.StandardError.ReadToEnd();
                var outPutMsg = p.StandardOutput.ReadToEnd();
                return string.IsNullOrEmpty(errorMsg) ? outPutMsg : errorMsg;
            }
        }
        #endregion

        #region 关机
        public string Shutdown()
        {
            return Shutdown(null);
        }
        #endregion

        #region 关闭指定计算机
        public string Shutdown(string ip)
        {
            if (!Regex.IsMatch(ip, ipCheckRegex)) 
            {
                return "请输入正确的IP地址";
            }
            string script = String.Format("shutdown -s -t 0");
            if (!string.IsNullOrEmpty(ip))
            {
                script += String.Format(" -m \\\\{0}", ip);
            }
            return this.Exec(script);
        }
        #endregion

        #region 唤醒计算机
        public string WakeUp(string macStr, string ip, int port)
        {
            if (!Regex.IsMatch(ip, ipCheckRegex))
            {
                return "请输入正确的IP地址";
            }
            //查看该MAC地址是否匹配正则表达式定义，（mac，0）前一个参数是指mac地址，后一个是从指定位置开始查询，0即从头开始
            if (Regex.IsMatch(macStr, macCheckRegexString))
            {
                return "请输入正确的MAC地址";
            }
            byte[] macByte = FormatMac(macStr);
            return WakeUpCore(ip, macByte, port);
            
        } 
        #endregion

        #region 开始唤醒
        private static string WakeUpCore(string ip, byte[] magicBytes, int port)
        {
            //发送方法是通过UDP
            UdpClient client = new UdpClient();
            // IPAddress.Broadcast：内容为：255,255,255,255.广播形式，所以不需要IP
            // client.Connect(IPAddress.Broadcast, port);
            client.Connect(IPAddress.Parse(ip), port);
            try
            {
                //下方为发送内容的编制，6遍“FF”+17遍mac的byte类型字节。
                byte[] packet = new byte[17 * 6];
                for (int i = 0; i < 6; i++)
                    packet[i] = 0xFF;
                for (int i = 1; i <= 16; i++)
                    for (int j = 0; j < 6; j++)
                        packet[i * 6 + j] = magicBytes[j];

                int result = client.Send(packet, packet.Length);
                return result>0?"唤醒成功":"唤醒失败";
            }
            catch (SocketException e)
            {
                string msg = String.Format("IP:{0} 网络唤醒失败: 原因{1}", ip, e.Message);
                LogHelper.ErrorFormat(msg);
                return msg;
            }
        }
        #endregion

        #region Mac地址转换为二进制
        private static byte[] FormatMac(string macInput)
        {
            byte[] mac = new byte[6];

            string str = macInput;
            //消除MAC地址中的“-”符号
            string[] sArray = str.Split('-');


            //mac地址从string转换成byte
            for (var i = 0; i < 6; i++)
            {
                var byteValue = Convert.ToByte(sArray[i], 16);
                mac[i] = byteValue;
            }

            return mac;
        }
        #endregion
    }
}
