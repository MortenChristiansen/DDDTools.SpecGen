using DDDTools.SpecGen.Spec;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.LogAction = m => System.Console.WriteLine(m);

            var path = @"C:\Users\Morten\Documents\GitHub\DDDTools.SpecGen\DDDTools.SpecGen.TestClientLibrary\bin\Debug";
            var specification = ProductSpecification.Create("The Galactic Empire", "The Star of Death", "A space station capable of destroying planets", path);
            var formatter = new HtmlFormatter(specification);
            var html = formatter.FormatDomains();

            var htmlFile = new FileInfo("specification.html");
            using (var fw = new StreamWriter(htmlFile.OpenWrite()))
            {
                fw.Write(html);
            }

            FileHelper.SaveCssFile();

            Log.LogMessage("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
