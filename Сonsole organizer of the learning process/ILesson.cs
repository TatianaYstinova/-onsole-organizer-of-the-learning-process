using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public interface ILesson
    {// задание
        public string Name { get; set; }
        public string DeliveryDates { get; set; }
        public string Formulation { get; set; }
    }
}
