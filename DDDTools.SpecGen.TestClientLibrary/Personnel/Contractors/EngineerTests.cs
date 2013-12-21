using DDDTools.SpecGen.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary.Personnel.Contractors
{
    [TestClass]
    [Domain(Domains.Personnel, Modules.Contractors)]
    public class EngineerTests
    {
        [TestMethod]
        [Requirement]
        public void Assigning_an_engineer_to_a_job_updates_his_schedule()
        {

        }
    }
}
