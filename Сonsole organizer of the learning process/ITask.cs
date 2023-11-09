using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public interface ITask
    {// занятие
        public string Name { get; set; }
        public string Formulation { get; set; }
        public List<string> LinksToAddMaterials { get; set; }
        public string DeadLine { get; set; }
        public List<string> LinkTestInAThirdPartyResource { get; set; }
        public string ShortDescription { get; set; }
        public List<string> Subtasks { get; set; }

    }
}
