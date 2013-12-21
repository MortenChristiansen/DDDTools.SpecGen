using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.Spaceships.Fighters
{
    [TestClass]
    [Domain(Domains.Spaceships, Modules.Fighters)]
    public class DFighterTests
    {
        [TestMethod]
        [Requirement]
        public void You_cannot_assign_a_pilot_to_a_fighter_that_already_has_a_pilot()
        {

        }

        [TestMethod]
        [Requirement]
        public void Increasing_thrust_adjusts_fuel_consumption_accordingly()
        {

        }

        [TestMethod]
        [Requirement]
        public void When_fuel_levels_goes_under_ten_percent_the__low_fuel_indicator_blinks()
        {

        }
    }
}
