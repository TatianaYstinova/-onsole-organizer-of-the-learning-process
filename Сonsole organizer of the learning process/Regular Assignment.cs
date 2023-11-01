using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сonsole_organizer_of_the_learning_process
{
    public class RegularAssignment : ATasks
    {
        public List<string> LinksToAdditionalMaterials { get; set; }
        public override string TestLink { get => null; set => throw new NotImplementedException();}
        public override string ShortDescription { get => null; set => throw new NotImplementedException(); }
        public override List<string> Subtasks { get => null; set => throw new NotImplementedException(); }
        public RegularAssignment( string name, string formulation, List<string> linksToAdditionalMaterials, string deliveryDates):base(name, deliveryDates,  formulation)
        {
            this.Name = name;
            this.Formulation = formulation;
            this.LinksToAdditionalMaterials = linksToAdditionalMaterials;
            this.DeliveryDates = DeliveryDates;
        }

    }
}
