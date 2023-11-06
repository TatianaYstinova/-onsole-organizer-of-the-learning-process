using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public class RegularAssignment : ATasks
    {
        public override string Formulation { get; set; }
        public override List<string> LinksToAddMaterials { get; set; }
        public override string ShortDescription { get { return null; } set { ShortDescription = null; } }
        public override List<string> LinkTestInAThirdPartyResource { get { return null; } set { LinkTestInAThirdPartyResource = null; } }
        public override List<string> Subtasks { get { return null; } set { Subtasks = null; } }

        public RegularAssignment(string name, string deadLine, string formulation, List<string> linksToAddMaterials) : base(name, deadLine)
        {
            this.Formulation = formulation;
            this.LinksToAddMaterials = linksToAddMaterials;
        }

    }
}
