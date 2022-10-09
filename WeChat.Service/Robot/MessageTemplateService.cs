using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WeChat.Domain;
using WeChat.Domain.Models;
using WeChat.DTO.Robot;

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

        public List<WxMessageTemplate> GetList(MessageTemplateDTO m)
        {
            using (WeChatHelperContext c = new WeChatHelperContext())
            {
                Expression<Func<WxMessageTemplate, bool>> exp = x => true;
                if (!string.IsNullOrEmpty(m.Name))
                {
                    exp = exp.And(p => p.Name.Contains(m.Name));
                }
                if (m.Enable != null)
                {
                    exp = exp.And(p => p.Enable == m.Enable);
                }
                return c.WxMessageTemplates.Where(exp).ToList();
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
