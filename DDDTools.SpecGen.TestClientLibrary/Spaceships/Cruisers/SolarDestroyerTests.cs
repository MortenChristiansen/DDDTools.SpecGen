using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.Spaceships.Cruisers
{
    [TestClass]
    [Domain(Domains.Spaceships, Modules.Cruisers)]
    public class SolarDestroyerTests
    {
        [TestMethod]
        [Requirement]
        public void Assigning_personnel_to_cruiser_updates_personnel_roster()
        {

        }
    }
}
