using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Spec
{
    public class ProductSpecification
    {
        internal string CompanyName { get; set; }
        internal string ProductName { get; set; }
        internal string ProductDescription { get; set; }
        internal List<AssemblySpecification> AssemblySpecifications { get; set; }

        private ProductSpecification()
	    {
            AssemblySpecifications = new List<AssemblySpecification>();
	    }

        public static ProductSpecification Create(string companyName, string productName, string productDescription, string directoryPath)
        {
            var specification = new ProductSpecification
            {
                CompanyName = companyName,
                ProductName = productName,
                ProductDescription = productDescription
            };
            specification.Load(directoryPath);
            return specification;
        }

        private void Load(string directoryPath)
        {
            AssemblySpecifications.Clear();

            // TODO: Add error handling
            var directory = new DirectoryInfo(directoryPath);

            var assemblies = directory.GetFiles("*.dll");
            foreach (var assembly in assemblies)
            {
                LoadAssembly(assembly);
            }
        }

        private void LoadAssembly(FileInfo assemblyFile)
        {
            Log.LogMessage("Loading assembly '{0}'", assemblyFile.Name);

            // TODO: Add error handling
            var assembly = Assembly.LoadFile(assemblyFile.FullName);

            var assemblySpecification = CreateAssemblySpecification(assembly);
            AssemblySpecifications.Add(assemblySpecification);
        }

        private AssemblySpecification CreateAssemblySpecification(Assembly assembly)
        {
            var titleAttribute = assembly.GetAssemblyAttribute<AssemblyTitleAttribute>();
            var descriptionAttribute = assembly.GetAssemblyAttribute<AssemblyDescriptionAttribute>();
            var versionAttribute = assembly.GetAssemblyAttribute<AssemblyFileVersionAttribute>();
            // TODO: Add null checks

            var assemblySpecification = new AssemblySpecification(assembly, titleAttribute.Title, descriptionAttribute.Description, versionAttribute.Version);
            assemblySpecification.LoadSpecificationItems();
            return assemblySpecification;
        }
    }
}
