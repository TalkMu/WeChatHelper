using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain.Models;

namespace WeChat.Service.Robot
{
    public class MessageTemplateService
    {
        public bool Save(WxMessageTemplate wxMessageTemplate) 
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                c.WxMessageTemplates.Add(wxMessageTemplate);
                return c.SaveChanges()>0;
            }
        }

        public List<WxMessageTemplate> GetList()
        {
            using (WeChatHelperContext c = new WeChatHelperContext()) 
            {
                return c.WxMessageTemplates.ToList();
            }
        }

        public bool SaveOrUpdate(WxMessageTemplate wxMessageTemplate)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                if (wxMessageTemplate == null && wxMessageTemplate.Id == 0)
                {
                    c.WxMessageTemplates.Add(wxMessageTemplate);
                }
                else 
                {
                    c.WxMessageTemplates.Update(wxMessageTemplate);
                }
                return c.SaveChanges()>0;
            }
        }

        public WxMessageTemplate FindById(long id)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                return c.WxMessageTemplates.FirstOrDefault(p => p.Id == id);
            }
        }

        public bool RemoveById(long id)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                var model = FindById(id);
                c.WxMessageTemplates.Remove(model);
                return c.SaveChanges() > 0;
            }
        }
    }
}
