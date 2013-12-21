using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.Power
{
    [TestClass]
    [Domain(Domains.Power)]
    public class GeneratorTests
    {
        [TestMethod]
        [Requirement]
        public void Overloading_a_generator_increases_power_output()
        {

        }

        [TestMethod]
        [Requirement]
        public void When_generator_explodes_chain_reaction_occurs()
        {

        }
    }
}
