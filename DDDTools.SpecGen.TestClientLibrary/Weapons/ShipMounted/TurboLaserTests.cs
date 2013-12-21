using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.Weapons.ShipMounted
{
    [TestClass]
    [Domain(Domains.Weapons, Modules.ShipMounted)]
    public class TurboLaserTests
    {
        [TestMethod]
        [Requirement]
        public void Holding_down_the_trigger_enables_autofire()
        {

        }

        [TestMethod]
        [Requirement]
        public void Pressing_trigger_releases_single_shot()
        {

        }
    }
}
