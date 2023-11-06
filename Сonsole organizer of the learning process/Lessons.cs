using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public enum LessonType //перечисление типов занятий
    {
        Lecture,
        Consultation,
        Other
    }

    public class Lessons : ILesson
    {//занятие
        public string Date { get; set; }
        public List<string> topics { get; set; }
        public string Comment { get; set; }
        public LessonType type { get; set; }

        public Lessons(string date, List<string> topics, string comment, LessonType type)
        {
            this.Date = date;
            this.topics = topics;
            this.Comment = comment;
            this.type = type;
        }
        public override string ToString()
        {
            string topicTopics = null;
            foreach( string topic in topics ) 
            {
                topicTopics += topic;
            }
            
            string ops = Date + " " + topicTopics + " " + Comment + " " + type.ToString();

            return ops;
        }
    }
}

