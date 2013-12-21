using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.Personnel.Soldiers
{
    [TestClass]
    [Domain(Domains.Personnel, Modules.Soldiers)]
    public class PilotTests
    {
        [TestMethod]
        [Requirement]
        public void A_pilot_must_have_pilot_certificate()
        {

        }

        [TestMethod]
        [Requirement]
        public void Creating_a_pilot_without_a_spaceship_sets_his_status_as_reserve()
        {

        }
    }
}
