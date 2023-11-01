using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public abstract class ATasks : ITask
    {//занятие
        public string Name { get; set; }
        public string DeliveryDates { get; set; }
        public string Formulation { get; set; }
        public abstract string TestLink { get; set; }
        public abstract string ShortDescription { get; set; }
        public abstract List<string> Subtasks { get; set; }

        public  ATasks (string name, string deliveryDates, string formulation)
        {
             Name = name;
             DeliveryDates = deliveryDates;
             Formulation = formulation;
        }
    }
}
