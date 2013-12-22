using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Spec
{
    public class HtmlFormatter
    {
        private ProductSpecification _specification;
        private int nestingLevel;
        private string _htmlFormat =
@"<html>
    <head>
        <meta charset=""utf-8"">
        <title>Specification</title>
        <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300' rel='stylesheet' type='text/css'>
        <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""style.css"" />
    </head>
<body>
{0}
</body>
</html>";
        

        public HtmlFormatter(ProductSpecification specification)
        {
            _specification = specification;
        }

        public string FormatDomains()
        {
            nestingLevel = 1;


            return string.Format(_htmlFormat, Div("product", "<h1>" + _specification.ProductName+ "</h1>\r\n" +
                GetNesting() + "\t<h3>" + _specification.CompanyName + "</h3>\r\n" +
                GetNesting() + "\t<h3>" + _specification.ProductDescription + "</h3>\r\n" +
                string.Join("\r\n", _specification.AssemblySpecifications.Select(s => FormatDomainsInAssemblySpecification(s)))));
        }

        private string FormatDomainsInAssemblySpecification(AssemblySpecification specification)
        {
            if (specification.Domains.Count == 0)
                return string.Empty;

            nestingLevel++;
            return Div("assembly", "<h2>" + specification.AssemblyName + "</h2>\r\n" +
                GetNesting() + "\t<h4>" + specification.AssemblyDescription + "</h4>\r\n" +
                GetNesting() + "\t<h4>" + specification.AssemblyVersion + "</h4>\r\n" + 
                string.Join("\r\n", specification.Domains.Select(d => FormatDomain(d))));
        }

        private string FormatDomain(Domain domain)
        {
            nestingLevel++;
            return Div("domain", "<h3>" + domain.Name + "</h3>\r\n" + 
                string.Join("\r\n", domain.RequirementGroups.Select(g => FormatGroup(g))) + "\r\n" +
                string.Join("\r\n", domain.Modules.Select(m => FormatModule(m))));
        }

        private string FormatModule(Module module)
        {
            nestingLevel++;
            return Div("module", "<h4>" + module.Name + "</h4>\r\n" + 
                string.Join("\r\n", module.RequirementGroups.Select(g => FormatGroup(g))));
        }

        private string FormatGroup(RequirementGroup group)
        {
            nestingLevel++;
            return GetNesting() +"<h5>" + group.Name + "</h5>\r\n" + 
                Ul(string.Join("\r\n", group.Requiremnets.Select(r => FormatRequirement(r))));
        }

        private string FormatRequirement(Requirement requirement)
        {
            return GetNesting() + "\t<li>" + requirement.Name + "</li>";
        }

        private string Div(string @class, string content)
        {
            return string.Format(
@"{2}<div class=""{0}"">
    {2}{1}
{2}</div>", @class, content, new string(Enumerable.Repeat('\t', nestingLevel--).ToArray()));
        }

        private string Ul(string content)
        {
            return string.Format(
@"{1}<ul>
{0}
{1}</ul>", content, new string(Enumerable.Repeat('\t', nestingLevel--).ToArray()));
        }

        private string GetNesting()
        {
            return new string(Enumerable.Repeat('\t', nestingLevel).ToArray());
        }
    }
}
