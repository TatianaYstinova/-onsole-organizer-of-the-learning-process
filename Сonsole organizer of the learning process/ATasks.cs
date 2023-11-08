using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public abstract class ATasks : ITask
    {//занятие
        public  string Name { get; set; }
        public  string DeadLine { get; set; }
        public abstract string Formulation { get; set; }
        public abstract List<string> LinksToAddMaterials { get; set; }
        public abstract List<string> LinkTestInAThirdPartyResource { get; set; }
        public abstract string ShortDescription { get; set; }
        public abstract List<string> Subtasks { get; set; }

        public ATasks(string name, string deadLine)
        {
            Name = name;
            DeadLine = deadLine;
        }
        
    }
}
