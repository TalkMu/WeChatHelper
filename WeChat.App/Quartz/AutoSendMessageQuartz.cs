﻿using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.App.Quartz
{
    public class AutoSendMessageQuartz : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() => 
            {
                
            });
        }
    }
}
