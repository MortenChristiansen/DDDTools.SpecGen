using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DomainAttribute : Attribute
    {
        public string DomainName { get; private set; }
        public string ModuleName { get; private set; }

        public DomainAttribute(string domainName)
        {
            DomainName = domainName;
        }

        public DomainAttribute(string domainName, string moduleName)
        {
            DomainName = domainName;
            ModuleName = moduleName;
        }
    }
}
