using DDDTools.SpecGen.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Spec
{
    static class AssemblyHelper
    {
        public static T GetAssemblyAttribute<T>(this Assembly assembly)
            where T : Attribute
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(T), false);

            T attribute = null;
            if (attributes.Length > 0)
            {
                attribute = attributes[0] as T;
            }
            return attribute;
        }

        public static IEnumerable<SpecificationItem> LoadSpecificationItems(this Assembly assembly)
        {
            var types = assembly.GetTypes().Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(FeatureAttribute) || a.AttributeType == typeof(DomainAttribute))).ToList();

            var featureTypes = types.Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(FeatureAttribute))).ToList();
            var domainTypes = types.Where(t => t.CustomAttributes.Any(a => a.AttributeType == typeof(DomainAttribute))).ToList();

            var features = new Dictionary<string, Feature>();
            foreach (var featureType in featureTypes)
            {
                var featureAttribute = featureType.GetCustomAttribute<FeatureAttribute>();
                var requirements = featureType.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(m => m.GetCustomAttribute<RequirementAttribute>() != null).ToList();

                if (!features.ContainsKey(featureAttribute.Name))
                {
                    Log.LogMessage("Creating feature '{0}'", featureAttribute.Name);
                    features.Add(featureAttribute.Name, new Feature());
                }

                AddRequirmentGroupToFeature(features, featureType, featureAttribute, requirements);
            }

            var domains = new Dictionary<string, Domain>();
            foreach (var domainType in domainTypes)
            {
                var domainAttribute = domainType.GetCustomAttribute<DomainAttribute>();
                var requirements = domainType.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(m => m.GetCustomAttribute<RequirementAttribute>() != null).ToList();

                if (!domains.ContainsKey(domainAttribute.DomainName))
                {
                    Log.LogMessage("Creating domain '{0}'", domainAttribute.DomainName);
                    domains.Add(domainAttribute.DomainName, new Domain { Name = domainAttribute.DomainName });
                }

                if (domainAttribute.ModuleName == null)
                    AddRequirmentGroupToDomain(domains, domainType, domainAttribute, requirements);
                else
                    AddRequirementGroupToModule(domains, domainType, domainAttribute, requirements);
            }

            return (features.Values as IEnumerable<SpecificationItem>).Concat(domains.Values);
        }

        private static void AddRequirmentGroupToFeature(Dictionary<string, Feature> features, Type featureType, FeatureAttribute featureAttribute, List<MethodInfo> requirements)
        {
            features[featureAttribute.Name].RequirementGroups.Add(CreateRequirementGroup(featureType, requirements));
        }

        private static void AddRequirmentGroupToDomain(Dictionary<string, Domain> domains, Type domainType, DomainAttribute domainAttribute, List<MethodInfo> requirements)
        {
            domains[domainAttribute.DomainName].RequirementGroups.Add(CreateRequirementGroup(domainType, requirements));
        }

        private static void AddRequirementGroupToModule(Dictionary<string, Domain> domains, Type domainType, DomainAttribute domainAttribute, List<MethodInfo> requirements)
        {
            var module = domains[domainAttribute.DomainName].Modules.SingleOrDefault(m => m.Name == domainAttribute.ModuleName);
            if (module == null)
            {
                module = new Module { Name = domainAttribute.ModuleName };
                Log.LogMessage("Creating module '{0}'", module.Name);
                domains[domainAttribute.DomainName].Modules.Add(module);
            }

            module.RequirementGroups.Add(CreateRequirementGroup(domainType, requirements));
        }

        private static RequirementGroup CreateRequirementGroup(Type type, IEnumerable<MethodInfo> requirements)
        {
            var name = FormatName(type.Name);
            Log.LogMessage("Creating requirement group '{0}'", name);

            return new RequirementGroup
            {
                Name = name,
                Requiremnets = requirements.Select(r => 
                    {
                        var requirementName = FormatSentence(r.Name);
                        Log.LogMessage("Creating requirement '{0}'", requirementName);

                        return new Requirement
                        {
                            Name = requirementName
                        };
                    }).ToList()
            };
        }

        private static string FormatName(string name)
        {
            if (name.ToLower().EndsWith("tests"))
                name = name.Substring(0, name.Length - 5);
            if (name.ToLower().EndsWith("test"))
                name = name.Substring(0, name.Length - 4);

            name = name.Replace('_', ' ');

            var chars = name.Select((c, i) => char.IsUpper(c) && i > 0 ? " " + c.ToString().ToLower() : c.ToString());
            name = string.Join("", chars);

            return name;
        }

        private static string FormatSentence(string name)
        {
            return FormatName(name) + ".";
        }
    }
}
