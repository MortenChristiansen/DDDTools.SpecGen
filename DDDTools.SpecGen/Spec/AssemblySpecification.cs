using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Spec
{
    class AssemblySpecification
    {
        private Assembly _assembly;

        public string AssemblyName { get; private set; }
        public string AssemblyDescription { get; private set; }
        public string AssemblyVersion { get; private set; }
        public List<Feature> Features { get; private set; }
        public List<Domain> Domains { get; private set; }

        public AssemblySpecification(Assembly assembly, string name, string description, string version)
        {
            _assembly = assembly;

            AssemblyName = name;
            AssemblyDescription = description;
            AssemblyVersion = version;

            Features = new List<Feature>();
            Domains = new List<Domain>();
        }

        public void LoadSpecificationItems()
        {
            var items = _assembly.LoadSpecificationItems().ToList();

            Features = items.OfType<Feature>().ToList();
            Domains = items.OfType<Domain>().ToList();
        }
    }
}
