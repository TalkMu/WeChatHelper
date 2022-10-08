using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WeChat.Extend.Helper;

namespace WeChat.App.Service
{
    public class BootComputerService
    {
        //通过正则表达式设定MAC地址筛选标准，关于正则表达式请自行百度
        const string macCheckRegexString = @"^([0-9a-fA-F]{2})(([/\s:-][0-9a-fA-F]{2}){5})$";

        // IP地址检验
        const string ipCheckRegex = @"((25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))";

        private static readonly Regex MacCheckRegex = new Regex(macCheckRegexString);

        public void Run(string content) 
        {
            if (content.Contains("开机"))
            {
                // 唤醒电脑
                this.WakeUp("171.223.39.114", "00-FF-CC-14-E2-AD", 9);
            }
            if (content.Contains("关机"))
            {
                if (Regex.IsMatch(content, ipCheckRegex)) 
                {
                    // 获取内容中的IP地址
                    Match match = Regex.Match(content, ipCheckRegex);
                    var ip = match.Value;
                    // 唤醒电脑
                    this.Shudown(ip);
                }
                
            }
        }

        #region 唤醒电脑
        public bool WakeUp(string ip, string macStr, int port)
        {
            //查看该MAC地址是否匹配正则表达式定义，（mac，0）前一个参数是指mac地址，后一个是从指定位置开始查询，0即从头开始
            if (MacCheckRegex.IsMatch(macStr, 0))
            {
                byte[] macByte = FormatMac(macStr);
                return WakeUpCore(ip, macByte, port) > 0;
            }

            return false;
        } 
        #endregion

        

        #region 开始唤醒
        private static int WakeUpCore(string ip, byte[] magicBytes, int port)
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
                return result;
            }
            catch (SocketException e)
            {
                LogHelper.ErrorFormat("IP:{0} 网络唤醒失败: 原因{1}",ip,e.Message);
            }
            return -1;
        }
        #endregion

        #region 局域网关机
        public bool Shudown(string ip, string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            ConnectionOptions connectionOptions = new ConnectionOptions();
            connectionOptions.Username = userName;
            connectionOptions.Password = password;

            ManagementScope managementScope = new ManagementScope(ip + "//root//cimv2", connectionOptions);
            managementScope.Options.EnablePrivileges = true;

            try
            {
                managementScope.Connect();
            }
            catch (Exception e)
            {
                LogHelper.ErrorFormat("远程连接电脑失败 :{0}", e.Message);
            }

            if (managementScope.IsConnected)
            {
                try
                {
                    ObjectQuery oq = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                    ManagementObjectSearcher mos = new ManagementObjectSearcher(managementScope, oq);
                    ManagementObjectCollection moc = mos.Get();

                    foreach (ManagementObject m in moc)
                    {
                        string[] ss = { "" };
                        m.InvokeMethod("Shudown", ss);
                    }
                }
                catch (Exception e)
                {

                    throw;
                }
            }
            return true;
        }
        #endregion

        #region CMD局域网关机
        /// <summary>
        /// 1.关闭远程机防火墙
        /// 2.设置远程强制关机系统权限 gpedit.msc
        /// 3.计算机属性远程设置
        /// 展开“Windows 设置”>“安全设置”>“本地策略”>“用户权利指派”。在右侧中找到并选择“从远端系统强制关机”
        /// </summary>
        /// <param name="ip"></param>
        public void Shudown(string ip)
        {
            string args = String.Format("shutdown -s -t 0");
            if (!string.IsNullOrEmpty(ip))
            {
                args += String.Format(" -m \\\\{0}", ip);
            }
            Process commandProcess = new Process();
            try
            {
                commandProcess.StartInfo.FileName = "cmd.exe";
                commandProcess.StartInfo.UseShellExecute = false;
                commandProcess.StartInfo.CreateNoWindow = true;
                commandProcess.StartInfo.RedirectStandardError = true;
                commandProcess.StartInfo.RedirectStandardInput = true;
                commandProcess.StartInfo.RedirectStandardOutput = true;
                commandProcess.Start();
                commandProcess.StandardInput.WriteLine(args);
                commandProcess.StandardInput.WriteLine("exit");
                for (; !commandProcess.HasExited;)//等待cmd命令运行完毕
                {
                    System.Threading.Thread.Sleep(1);
                }
                //错误输出
                string errorMsg = commandProcess.StandardError.ReadToEnd();

                string outPutMsg = commandProcess.StandardOutput.ReadToEnd();
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (commandProcess != null)
                {
                    commandProcess.Dispose();
                    commandProcess = null;
                }
            }
        }
        #endregion

        #region 执行CMD命令
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
                return string.IsNullOrEmpty(errorMsg)?outPutMsg:errorMsg;
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
            string script = String.Format("shutdown -s -t 0");
            if (!string.IsNullOrEmpty(ip))
            {
                script += String.Format(" -m \\\\{0}", ip);
            }
            return this.Exec(script);
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
