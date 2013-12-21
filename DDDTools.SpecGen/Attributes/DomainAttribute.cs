using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DomainAttribute : Attribute
    {
        public DomainAttribute(string domainName)
        {

        }

        public DomainAttribute(string domainName, string moduleName)
        {

        }
    }
}
