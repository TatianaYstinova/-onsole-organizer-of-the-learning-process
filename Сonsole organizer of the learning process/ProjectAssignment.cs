using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Сonsole_organizer_of_the_learning_process
{
    public class ProjectAssignment:ATasks
    {
        public List<string> LinksToAdditionalMaterials { get; set; }
        public override string ShortDescription { get; set; }
        public override List<string> Subtasks { get; set; }
        public override string TestLink { get => null; set => throw new NotImplementedException(); }

        public ProjectAssignment(string name, string shortDescription, List<string> subtasks, List<string> linksToAdditionalMaterials)
        {
            this.Name = name;
            this.ShortDescription = shortDescription;
            this.Subtasks = subtasks;
            this.LinksToAdditionalMaterials = linksToAdditionalMaterials;
        }
    }
}
