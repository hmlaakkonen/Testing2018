using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;

namespace ArmourTester
{
    [TestClass]
    public class ArmourTester
    {
        [TestMethod]
        public void testLevel()
        {
            Armour ar = new Armour("Kalle", "Kustaa", 30, 2, 1);
            int lvl = ar.getLevel();

            if (lvl < 0)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void testSlot()
        {
            Armour ar = new Armour("Kalle", "Kustaa", 30, 2, 1);
            int slot = ar.getSlot();
                
            if (slot < 0 || slot > 3) {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void testHeadSlot()
        {
            Armour ar = new Armour("Kalle", "Kypäri", 30, 2, 1);
            int slot = ar.getSlot();

            Assert.AreEqual(0, slot);
        }
    }
}
