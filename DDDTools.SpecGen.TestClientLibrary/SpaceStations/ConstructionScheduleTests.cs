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
    public class ConstructionScheduleTests
    {
        [TestMethod]
        [Requirement]
        public void When_deadline_is_six_months_away_imperial_envoy_is_sent_to_verify_progress()
        {

        }

        [TestMethod]
        [Requirement]
        public void When_creating_an_estimate_the_result_reflects_the_amount_of_resources_supplied()
        {

        }
    }
}
