using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.Personnel.Contractors
{
    [TestClass]
    [Domain(Domains.Personnel, Modules.Contractors)]
    public class ForemanTests
    {
        [TestMethod]
        [Requirement]
        public void Assigning_a_team_to_a_foreman_updates_his_list_of_employees()
        {

        }
    }
}
