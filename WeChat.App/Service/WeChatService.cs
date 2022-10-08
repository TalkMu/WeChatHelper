using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using WeChat.App.Handle;
using WeChat.Domain.Enum;
using WeChat.DTO.Socket;
using WeChat.Extend.Helper;
using WeChat.Extend.WinApi;

/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： WeChat.Service.WeChat
*│　类    名： WeChatService
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：kools
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2021/3/30 14:28:25
*│　机器名称：DESKTOP-KBNKUO5
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.App.Service
{
    public class WeChatService
    {

        private static string dllPath = Path.Combine(Directory.GetCurrentDirectory(), Appsetting.WECHAT_API_DLL);

        /// <summary>
        /// 使用WindowsAPI函数SwitchToThisWindow，可以将指定窗口移动到屏幕最前
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="fAltTab"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        #region 获取微信exe路径
        public string GetWeChatPath()
        {
            RegistryKey registryKey = Registry.CurrentUser;
            RegistryKey software = registryKey.OpenSubKey("Software\\Tencent\\WeChat", true);
            object InstallPath = software.GetValue("InstallPath");
            return InstallPath.ToString() + "\\WeChat.exe";
        }
        #endregion

        #region 打开微信
        /// <summary>
        /// 打开微信
        /// </summary>
        /// <returns></returns>
        public bool OpenWechat()
        {
            var list = Process.GetProcessesByName("WeChat");
            if (list.Length != 0)
            {
                return true;
            }
            string WxPath = "";
            try
            {
                RegistryKey registryKey = Registry.CurrentUser;
                RegistryKey software = registryKey.OpenSubKey("Software\\Tencent\\WeChat", true);
                object InstallPath = software.GetValue("InstallPath");
                WxPath = InstallPath.ToString() + "\\WeChat.exe";

                //NeedUpdateType 设置低于100，禁止自动升级
                software.SetValue("NeedUpdateType", 80);

                registryKey.Close();
            }
            catch (Exception ex)
            {
                LogHelper.ErrorFormat("启动微信异常：{0}", ex.StackTrace);
            }
            if (!string.IsNullOrEmpty(WxPath))
            {
                Process.Start(WxPath);
                Thread.Sleep(500);
                return true;
            }
            return false;
        }
        #endregion

        #region 关闭微信
        public void CloseWeChat() 
        {
            var list = Process.GetProcessesByName("WeChat");
            foreach (var item in list) 
            {
                item.Kill();
                item.WaitForExit();
                ScrollingLogHandle.AppendTextToLog("已关闭微信");
            }

        }
        #endregion

        #region 注入微信
        public bool InjectDllToWeChat()
        {
            var list = Process.GetProcessesByName("WeChat");
            if (list == null || list.Length <= 0)
            {
                return false;
            }
            bool hasSuccess = false;
            foreach (var item in list)
            {
                if (!HasInjected(item.Id))
                {
                    hasSuccess = InjectDll(item.Id);
                }
            }
            return hasSuccess;
        }
        #endregion

        #region 置顶微信窗口
        public void TopWindow() 
        {
            var list = Process.GetProcessesByName("WeChat");
            var item = list.FirstOrDefault();
            SwitchToThisWindow(item.MainWindowHandle, true);
        }
        #endregion

        #region DLL注入
        /// <summary>
        /// dll注入
        /// </summary>
        /// <param name="processId"></param>
        public bool InjectDll(int processId)
        {
            if (!File.Exists(dllPath))
            {
                LogHelper.InfoFormat("DLL文件不存在:{0}", dllPath);
                return false;
            }
            LogHelper.InfoFormat("DLL文件路径:{0}", dllPath);
            var WxProcess = Process.GetProcessById(processId);

            if (WxProcess == null)
            {
                LogHelper.ErrorFormat("请先启动微信");
                return false;
            }

            int DllPathSize = dllPath.Length * 2 + 1;
            int MEM_COMMIT = 0x00001000;
            int PAGE_READWRITE = 0x04;
            int DllAddress = PInvoke.VirtualAllocEx((int)WxProcess.Handle, 0, DllPathSize, MEM_COMMIT, PAGE_READWRITE);
            if (DllAddress == 0)
            {
                LogHelper.ErrorFormat("申请dll内存失败");
                return false;
            }
            if (PInvoke.WriteProcessMemory((int)WxProcess.Handle, DllAddress, dllPath, DllPathSize, 0) == false)
            {
                LogHelper.ErrorFormat("内存写入失败");
                return false;
            }
            int module = PInvoke.GetModuleHandleA("Kernel32.dll");
            int LoadLibraryAddress = PInvoke.GetProcAddress(module, "LoadLibraryA");
            if (LoadLibraryAddress == 0)
            {
                LogHelper.Error("查找LoadLibraryA地址失败");
                return false;
            }
            if (PInvoke.CreateRemoteThread((int)WxProcess.Handle, 0, 0, LoadLibraryAddress, DllAddress, 0, 0) == 0)
            {
                LogHelper.Error("执行远程线程失败");
                return false;
            }
            return true;
        }
        #endregion

        #region 是否已注入
        /// <summary>
        /// 是否被注入
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        public bool HasInjected(int processId)
        {
            var process = Process.GetProcessById(processId);
            if (process.Modules.OfType<ProcessModule>().Any(o => o.FileName.Contains(Appsetting.WECHAT_API_DLL)))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
