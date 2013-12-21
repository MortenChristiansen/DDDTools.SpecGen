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
    public class BluePrintTests
    {
        [TestMethod]
        [Requirement]
        public void When_analyzing_blue_prints_structural_weaknesses_are_identifies()
        {

        }

        [TestMethod]
        [Requirement]
        public void The_analyzing_person_must_have_an_engineering_degree()
        {
            
        }

        [TestMethod]
        [Requirement]
        public void Stealing_a_blueprint_removes_it_from_inventory()
        {

        }
    }
}
