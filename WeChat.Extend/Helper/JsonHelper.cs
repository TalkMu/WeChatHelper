using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/**
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Lrw.Core.Helper
*│　类    名： JsonHelper
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：
*│　作    者：Koolss
*│　版    本：1.0.0
*│　邮    箱：koolss@koolss.com
*│　创建时间：2020/4/1 15:55:26
*│　机器名称：DESKTOP-PST79O6
*└──────────────────────────────────────────────────────────────┘
*/

namespace WeChat.Extend.Helper
{
    public class JsonHelper
    {
        public static string ToJson(Object obj)
        {
            return obj == null ? "" : JsonConvert.SerializeObject(obj);
        }

        public static string ToJson(Object obj,bool hasIgnore)
        {
            if (obj == null)
            {
                return "";
            }
            if (hasIgnore)
            {
                return JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            }
            else 
            {
                return JsonConvert.SerializeObject(obj);
            }
        }
        public static T FromJson<T>(string json) where T : class
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string ToJsonSort(Object obj)
        {
            if (obj == null)
            {
                return "";
            }
            var dic = JsonConvert.DeserializeObject<SortedDictionary<string, object>>(JsonConvert.SerializeObject(obj));
            SortedDictionary<string, object> keyValues = new SortedDictionary<string, object>(dic);
            keyValues.OrderBy(m => m.Value);//升序
            //keyValues.OrderByDescending(m => m.Key);//降序
            return JsonConvert.SerializeObject(keyValues);
        }
    }
}
