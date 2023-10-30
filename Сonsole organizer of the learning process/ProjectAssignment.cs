using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public class ProjectAssignment : ALessons
    {
        public string ShortDescription { get; set; }
        public List<string> Subtasks { get; set; }
    }
}
