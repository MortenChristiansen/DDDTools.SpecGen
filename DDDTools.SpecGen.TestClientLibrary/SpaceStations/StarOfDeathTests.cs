using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.SpaceStatiuons
{
    [TestClass]
    [Domain(Domains.SpaceStations)]
    public class StarOfDeathTests
    {
        [TestMethod]
        [Requirement]
        public void Starting_construction_requires_schedule()
        {

        }

        [TestMethod]
        [Requirement]
        public void Completing_construction_triggers_imperial_visit()
        {

        }
    }
}
