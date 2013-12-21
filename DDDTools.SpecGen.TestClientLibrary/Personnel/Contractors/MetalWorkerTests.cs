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
    public class MetalWorkerTests
    {
        [TestMethod]
        [Requirement]
        public void A_metal_worker_must_have_one_or_more_metal_related_proficiencies()
        {

        }
    }
}
