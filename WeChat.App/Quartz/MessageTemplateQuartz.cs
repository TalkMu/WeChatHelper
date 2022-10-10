using Masuit.Tools.DateTimeExt;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.App.Handle;
using WeChat.App.Service;
using WeChat.Domain;
using WeChat.Extend.Helper.Date;
using WeChat.Service.Robot;

namespace WeChat.App.Quartz
{
    public class MessageTemplateQuartz : IJob
    {
        MessageTemplateHandle handle = new MessageTemplateHandle();
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() => 
            {
                var taskCode = context.JobDetail.Key.Name;

                handle.ExecQuart(taskCode);
            });
        }
    }
}
