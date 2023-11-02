using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public class TestAssignment:ATasks
    {
        public override List<string> LinkTestInAThirdPartyResource { get; set; }
        public override string Formulation { get { return null; } set { Formulation = null; } }
        public override List<string> LinksToAddMaterials { get { return null; } set { LinksToAddMaterials = null; } }
        public override string ShortDescription { get { return null; } set { ShortDescription = null; } }
        public override List<string> Subtasks { get { return null; } set { Subtasks = null; } }

    }
    public TestAssignment(string name, string deliveryDates, List<string> linkTestInAThirdPartyResource) : base(name,deliveryDates)
    {
         this.LinkTestInAThirdPartyResource = linkTestInAThirdPartyResource;
    }
}
