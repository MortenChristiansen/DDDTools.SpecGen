using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.Weapons.StationBatteries
{
    [TestClass]
    [Domain(Domains.Weapons, Modules.StationBatteries)]
    public class PlanetBusterTests
    {
        [TestMethod]
        [Requirement]
        public void Initiating_firing_sequence_calculates_firing_trajectory()
        {

        }

        [TestMethod]
        [Requirement]
        public void Initiating_firing_routes_power_to_the_main_weapon_systems()
        {

        }

        [TestMethod]
        [Requirement]
        public void After_weapon_is_fired_destruction_verification_routine_is_triggered()
        {

        }
    }
}
