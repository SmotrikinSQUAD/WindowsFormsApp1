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
        
        public static topic EditTopic(topic _new_value)
        {
            topic old_value = GetTopic(_new_value.topic1);

            using (MyModel db = new MyModel())
            {
                var result = from _topic in db.topics
                             where _topic.topic1 == _new_value.topic1
                             select _topic;

                topic cur_topic = result.First();

                cur_topic.words = _new_value.words;
                db.SaveChanges();
                return old_value;
            }
        }

        public static topic DeleteTopic(string topic_name)
        {
            topic old_value = GetTopic(topic_name);

            using (MyModel db = new MyModel())
            {
                var result = from _topic in db.topics
                             where _topic.topic1 == topic_name
                             select _topic;

                db.topics.Remove(result.First());
                db.SaveChanges();
                return old_value;
            }
        }
    }
}
