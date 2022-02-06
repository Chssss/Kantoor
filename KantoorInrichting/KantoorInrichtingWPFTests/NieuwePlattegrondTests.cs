using Microsoft.VisualStudio.TestTools.UnitTesting;
using KantoorInrichtingWPF;
using System;
using System.Collections.Generic;
using System.Text;

namespace KantoorInrichtingWPF.Tests
{
    [TestClass()]
    public class NieuwePlattegrondTests
    {
        [TestMethod()]
        public void NieuwePlattegrondTest()
        {
            // Test het geval waarin tekst word doorgegeven in plaats van een decimaal voor de hoogte
            string TBHoogte = "Testcode";
            Assert.IsInstanceOfType(TBHoogte, typeof(decimal));
        }
    }
}