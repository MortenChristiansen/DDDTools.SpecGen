using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.Personnel.Staff
{
    [TestClass]
    [Domain(Domains.Personnel, Modules.Staff)]
    public class AdministratorTests
    {
        [TestMethod]
        [Requirement]
        public void A_new_administrator_has_complete_space_station_construction_responsibility()
        {

        }
    }
}
