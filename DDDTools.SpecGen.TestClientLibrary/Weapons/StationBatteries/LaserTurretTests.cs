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
    public class LaserTurretTests
    {
        [TestMethod]
        [Requirement]
        public void Firing_lasers_consume_power()
        {

        }

        [TestMethod]
        [Requirement]
        public void Selecting_target_initiates_tracking_procedure()
        {

        }

        [TestMethod]
        [Requirement]
        public void Tracking_target_moving_faster_than_tracking_speed_shows_warning()
        {

        }

        [TestMethod]
        [Requirement]
        public void Selecting_friendly_target_prompts_for_verification()
        {

        }
    }
}
