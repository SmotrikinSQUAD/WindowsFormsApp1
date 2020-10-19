using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dbhandler
{
    public static class dbManager
    {
        public static List<topic> GetAllTopics()
        {
            using (MyModel db = new MyModel())
            {
                var result = from _topics in db.topics
                             select _topics;

                return result.ToList();
            }
        }
         
        public static topic GetTopic(string topic_name)
        {
            using (MyModel db = new MyModel())
            {
                var result = from _topic in db.topics
                             where _topic.topic1 == topic_name
                             select _topic;

                return result.FirstOrDefault();
            }
        }
    }
}
