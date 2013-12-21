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
    public class FighterBayTests
    {
        [TestMethod]
        [Requirement]
        public void When_a_fighter_launches_the_bay_capacity_is_increased()
        {

        }

        [TestMethod]
        [Requirement]
        public void When_a_fighter_lands_the_bay_capacity_is_reduced()
        {

        }

        [TestMethod]
        [Requirement]
        public void A_fighter_requesting_landing_permission_is_denied_if_there_is_not_sufficient_capacity()
        {

        }
    }
}
