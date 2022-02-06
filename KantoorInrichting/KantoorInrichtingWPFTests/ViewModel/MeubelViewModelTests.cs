using Microsoft.VisualStudio.TestTools.UnitTesting;
using KantoorInrichtingWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace KantoorInrichtingWPF.ViewModel.Tests
{
    [TestClass()]
    public class MeubelViewModelTests
    {
        [TestMethod()]
        public void MeubelViewModelTest()
        {         
            // Test het geval waarin tekst word doorgegeven in plaats van een getal voor een prijs
            string _prijs = "Voetbal";
            Assert.IsInstanceOfType(_prijs, typeof(int));
        }

        [TestMethod()]
        public void StaticUpdateCatalogusTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateCatalogusExecuteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void XmlInvoegenTest()
        {
            Assert.Fail();
        }
    }
}