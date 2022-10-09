using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.App.Quartz
{
    public class QuartzManage
    {
        static Task<IScheduler> taskScheduler = StdSchedulerFactory.GetDefaultScheduler();

        static IScheduler scheduler;

        private static readonly object objLock = new object();

        static QuartzManage()
        {
            if (scheduler == null)
            {
                lock (objLock)
                {
                    if (scheduler == null)
                        scheduler = taskScheduler.Result;
                }
            }
        }

        public static void StartJobWithCron<T>(long id ,string name,string group, string cronExpression) 
        {
            // 创建一个任务
            IJobDetail job = JobBuilder.Create().OfType<T>()
                .WithIdentity(name, group + "_job_group")
                .UsingJobData("id", id)
                .Build();


            // 创建一个触发器
            ITrigger cronTrigger = TriggerBuilder.Create().StartNow().WithIdentity(name, group + "_trigger_group")
                                    .WithCronSchedule(cronExpression, w => w.WithMisfireHandlingInstructionDoNothing())
                                    .Build() as ICronTrigger;
            // 将job和trigger添加到调度器中
            scheduler.ScheduleJob(job, cronTrigger);
            // 开始调度
            scheduler.Start();
        }

        public static void ModifyJob(IJobDetail job, ICronTrigger trigger, string cronExpression) 
        {
            var cronTrigger = trigger;
            cronTrigger.CronExpressionString = cronExpression;

            scheduler.RescheduleJob(cronTrigger.Key, cronTrigger);
        }
    }
}
