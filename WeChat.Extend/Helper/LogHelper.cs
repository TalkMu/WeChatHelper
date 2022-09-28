using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;


/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Lrw.Core.Helper
*│　类    名： LogHelper
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：日志控件
*│　作    者：Koolss
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2020/3/31 星期二 15:13:45
*│　机器名称：HL
*└──────────────────────────────────────────────────────────────┘
*/
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace WeChat.Extend.Helper
{

    public class LogHelper
    {
        private static ILog logger;
        private static ILoggerRepository LoggerRepository;

        static LogHelper()
        {
            LoggerRepository = LogManager.CreateRepository("Log4netConsolePractice");
            //logger = LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2));
        }

        /// <summary>
        /// 输出Debug日志
        /// </summary>
        /// <param name="message">消息</param>
        public static void Debug(object message)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Debug(message);
        }

        /// <summary>
        /// 输出Debug日志
        /// </summary>
        /// <param name="message">消息</param>
        public static void Debug(object message, Exception ex)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Debug(message, ex);
        }

        /// <summary>
        /// 输出Debug日志
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="args">变量</param>
        public static void DebugFormat(string message, params object[] args)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).DebugFormat(message, args);
        }

        public static void Error(object message)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Error(message);
        }

        public static void Error(object message, Exception exception)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Error(message, exception);
        }

        public static void ErrorFormat(string message, params object[] args)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).ErrorFormat(message, args);
        }

        public static void Info(object message)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Info(message);
        }

        public static void Info(object message, Exception ex)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Info(message, ex);
        }

        public static void InfoFormat(string message, params object[] args)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).InfoFormat(message, args);
        }

        public static void Warn(object message)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Warn(message);
        }

        public static void Warn(object message, Exception ex)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Warn(message, ex);
        }

        public static void WarnFormat(string message, params object[] args)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).WarnFormat(message, args);
        }

        /// <summary>
        /// 获得调用者的调用者的声明类型
        /// </summary>
        /// <param name="super">上级级别:1代表上级，2代表上上级，以此类推</param>
        /// <returns></returns>
        private static Type GetCallerType(int super)
        {
            StackTrace trace = new StackTrace();
            return trace.GetFrame(super).GetMethod().DeclaringType;
        }

        private static string GetCurrentMethodFullName()
        {
            StackFrame frame;
            string str;
            string str1;
            bool flag;
            try
            {
                int num = 2;
                StackTrace stackTrace = new StackTrace();
                int length = stackTrace.GetFrames().Length;
                do
                {
                    int num1 = num;
                    num = num1 + 1;
                    frame = stackTrace.GetFrame(num1);
                    str = frame.GetMethod().DeclaringType.ToString();
                    flag = (!str.EndsWith("Exception") ? false : num < length);
                }
                while (flag);
                string name = frame.GetMethod().Name;
                str1 = string.Concat(str, ".", name);
            }
            catch
            {
                str1 = null;
            }
            return str1;
        }
    }
}
