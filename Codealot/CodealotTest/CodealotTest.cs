using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CodealotTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Codalot codalot = new BasicCodalot();

            codalot.setKnight(0, KnightPosition.TAVERN);
            codalot.setKnight(1, KnightPosition.TAVERN);
            codalot.setKnight(2, KnightPosition.TRAINING_YARD);
            codalot.setKnight(3, KnightPosition.TRAINING_YARD);
            codalot.setKnight(4, KnightPosition.TRAINING_YARD);
            codalot.setKnight(5, KnightPosition.TRAINING_YARD);
            codalot.process();

            Assert.IsTrue(codalot.calculateEarnedXp() == 4);
        }
    }
}
