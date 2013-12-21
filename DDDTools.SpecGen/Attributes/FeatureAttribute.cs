using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=false)]
    public class FeatureAttribute : Attribute
    {
        public string Name { get; private set; }

        public FeatureAttribute(string featureName)
        {
            Name = featureName;
        }
    }
}
