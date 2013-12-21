using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.SpaceStations
{
    [TestClass]
    [Domain(Domains.SpaceStations)]
    public class HangarTests
    {
        [TestMethod]
        [Requirement]
        public void When_cargo_is_loaded_onto_ship_the_storage_inventory_is_updated()
        {

        }

        [TestMethod]
        [Requirement]
        public void Repairing_a_ship_assigns_repair_crew()
        {

        }
    }
}
