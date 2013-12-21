using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Spec
{
    class Feature : SpecificationItem
    {
        public List<RequirementGroup> RequirementGroups { get; set; }

        public Feature()
        {
            RequirementGroups = new List<RequirementGroup>();
        }
    }
}
