using DBHelpers;
using Masuit.Tools.DateTimeExt;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeChat.App.View.MessageTemplateView;

namespace WeChat.App
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ChineseCalendar calendar = new ChineseCalendar(DateTime.Parse("2022-09-28"));

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MessageTemplate());
            Application.Run(new WeChatHelper());
            //Application.Run(new Demo());
        }
    }
}
