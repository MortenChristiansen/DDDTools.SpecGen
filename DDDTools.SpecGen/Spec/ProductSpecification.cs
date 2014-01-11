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

            try
            {
                var directory = new DirectoryInfo(directoryPath);

                var assemblies = directory.GetFiles("*.dll");
                foreach (var assembly in assemblies)
                {
                    LoadAssembly(assembly);
                }
            }
            catch (Exception e)
            {
                Log.LogMessage("Failed Failed processing directory");
                Log.LogMessage("Error: " + e.Message);
                Log.LogMessage("Stacktrace: " + e.StackTrace);
            }
        }

        private void LoadAssembly(FileInfo assemblyFile)
        {
            Log.LogMessage("Loading assembly '{0}'", assemblyFile.Name);

            try
            {
                var assembly = Assembly.LoadFile(assemblyFile.FullName);

                var assemblySpecification = CreateAssemblySpecification(assembly);
                AssemblySpecifications.Add(assemblySpecification);
            }
            catch (Exception e)
            {
                Log.LogMessage("Failed to load assembly '{0}'", assemblyFile.Name);
                Log.LogMessage("Error: " + e.Message);
                Log.LogMessage("Stacktrace: " + e.StackTrace);

                throw;
            }
        }

        private AssemblySpecification CreateAssemblySpecification(Assembly assembly)
        {
            var titleAttribute = assembly.GetAssemblyAttribute<AssemblyTitleAttribute>() ?? new AssemblyTitleAttribute("NO TITLE ATTRIBUTE");
            var descriptionAttribute = assembly.GetAssemblyAttribute<AssemblyDescriptionAttribute>() ?? new AssemblyDescriptionAttribute("NO DESCRIPTION ATTRIBUTE");
            var versionAttribute = assembly.GetAssemblyAttribute<AssemblyFileVersionAttribute>() ?? new AssemblyFileVersionAttribute("0.0.0.0");

            var assemblySpecification = new AssemblySpecification(assembly, titleAttribute.Title, descriptionAttribute.Description, versionAttribute.Version);
            assemblySpecification.LoadSpecificationItems();
            return assemblySpecification;
        }
    }
}
