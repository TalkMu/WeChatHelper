using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.App.Handle;

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

        /// <summary>
        /// 启动定时任务
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="taskCode"></param>
        /// <param name="jobGroup"></param>
        /// <param name="cron"></param>
        public static void StartJob<T>(string taskCode, string jobGroup, string cron) 
        {
            var jobKey = new JobKey(taskCode, jobGroup);
            var jobDetail = scheduler.GetJobDetail(jobKey);
            if (jobDetail.Result != null)
            {
                return;
            }

            // 创建一个任务
            IJobDetail job = JobBuilder.Create().OfType<T>()
                .WithIdentity(taskCode, jobGroup)
                .Build();


            // 创建一个触发器
            ITrigger cronTrigger = TriggerBuilder.Create().StartNow().WithIdentity(taskCode, jobGroup)
                                    .WithCronSchedule(cron, w => w.WithMisfireHandlingInstructionDoNothing())
                                    .Build() as ICronTrigger;
            // 将job和trigger添加到调度器中
            scheduler.ScheduleJob(job, cronTrigger);
            // 开始调度
            scheduler.Start();
            //ScrollingLogHandle.AppendTextToLog($"[Task]:{taskCode} 启用成功");
        }

        /// <summary>
        /// 修改定时任务执行时间
        /// </summary>
        /// <param name="taskCode"></param>
        /// <param name="jobGroup"></param>
        /// <param name="cron"></param>
        public static void ModifyJob(string taskCode, string jobGroup, string cron) 
        {
            var triggerKey = new TriggerKey(taskCode,jobGroup);
            ICronTrigger cronTrigger = (ICronTrigger)scheduler.GetTrigger(triggerKey).Result;
            var oldCron = cronTrigger.CronExpressionString;
            if (!oldCron.Equals(cron))
            {
                cronTrigger.CronExpressionString = cron;
            }
            scheduler.RescheduleJob(triggerKey, cronTrigger);
        }
        /// <summary>
        /// 暂停某个定时任务
        /// </summary>
        /// <param name="taskCode"></param>
        /// <param name="jobGroup"></param>
        public static void PauseJob(string taskCode, string jobGroup) 
        {
            var jobKey = new JobKey(taskCode, jobGroup);
            var jobDetail = scheduler.GetJobDetail(jobKey);
            if (jobDetail.Result == null)
            {
                return;
            }
            scheduler.PauseJob(jobKey);
        }
        /// <summary>
        /// 恢复某个定时任务
        /// </summary>
        /// <param name="taskCode"></param>
        /// <param name="jobGroup"></param>
        public static void ResumeJob(string taskCode, string jobGroup)
        {
            var jobKey = new JobKey(taskCode, jobGroup);
            var jobDetail = scheduler.GetJobDetail(jobKey);
            if (jobDetail.Result == null)
            {
                return;
            }
            scheduler.ResumeJob(jobKey);
        }

        /// <summary>
        /// 删除某个定时任务
        /// </summary>
        /// <param name="taskCode"></param>
        /// <param name="jobGroup"></param>
        public static void DeleteJob(string taskCode, string jobGroup)
        {
            var jobKey = new JobKey(taskCode, jobGroup);
            var jobDetail = scheduler.GetJobDetail(jobKey);
            if (jobDetail.Result == null)
            {
                return;
            }
            scheduler.DeleteJob(jobKey);
        }

        /// <summary>
        /// 添加或修改任务
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="taskCode"></param>
        /// <param name="jobGroup"></param>
        /// <param name="cron"></param>
        public static void StartOrModifyJob<T>(string taskCode, string jobGroup, string cron) 
        {
            var jobKey = new JobKey(taskCode, jobGroup);
            var jobDetail = scheduler.GetJobDetail(jobKey);
            if (jobDetail.Result == null)
            {
                StartJob<T>(taskCode, jobGroup, cron);
            }
            else 
            {
                ModifyJob(taskCode, jobGroup, cron);
            }
        }
    }
}
