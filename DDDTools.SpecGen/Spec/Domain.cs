using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Spec
{
    class Domain : SpecificationItem
    {
        public List<Module> Modules { get; private set; }
        public List<RequirementGroup> RequirementGroups { get; set; }

        public Domain()
        {
            Modules = new List<Module>();
            RequirementGroups = new List<RequirementGroup>();
        }
    }
}
