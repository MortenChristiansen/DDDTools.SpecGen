using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Spec
{
    class Module : SpecificationItem
    {
        public List<RequirementGroup> RequirementGroups { get; set; }

        public Module()
        {
            RequirementGroups = new List<RequirementGroup>();
        }
    }
}
