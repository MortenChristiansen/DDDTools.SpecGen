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
    public class TrooperTests
    {
        [TestMethod]
        [Requirement]
        public void Promoting_a_trooper_updates_his_rank()
        {

        }
    }
}
