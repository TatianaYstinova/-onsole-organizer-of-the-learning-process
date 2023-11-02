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
        public override string ShortDescription { get; set; }
        public override List<string> Subtasks { get; set; }
        public override List<string> LinksToAddMaterials { get; set; }
        public override string Formulation { get { return null; } set { LinkTestInAThirdPartyResource = null; } }
        public override List<string> LinkTestInAThirdPartyResource { get { return null; } set { LinkTestInAThirdPartyResource = null; } }
       
        public ProjectAssignment(string name, string shortDescription, List<string> subtasks, List<string> linksToAddMaterials, string deliveryDates):base(name, deliveryDates)
        {
            
            this.ShortDescription = shortDescription;
            this.LinksToAddMaterials = linksToAddMaterials;
            this.Subtasks = subtasks;
        }
    }
}
