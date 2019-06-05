using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CodealotTest
    {
        // TODO: Determine if this test is valueable... it seems at first glance to be testing a completely 
        // fake implementation not utilized in the main game    
        //    [TestMethod]
        //    public void TestMethod1()
        //    {
        //        Codalot codalot = new BasicCodalot();
        //
        //        codalot.setKnight(0, KnightPosition.TAVERN);
        //        codalot.setKnight(1, KnightPosition.TAVERN);
        //        codalot.setKnight(2, KnightPosition.TRAINING_YARD);
        //        codalot.setKnight(3, KnightPosition.TRAINING_YARD);
        //        codalot.setKnight(4, KnightPosition.TRAINING_YARD);
        //        codalot.setKnight(5, KnightPosition.TRAINING_YARD);
        //        codalot.process();
        //
        //        Assert.IsTrue(codalot.calculateEarnedXp() == 4);
        //    }

        /// <summary>
        /// Tests that if a game is created with no amount of knights specified, the default is 12
        /// </summary>
        [TestMethod]
        public void DefaultKnightAmountTest_Expect12()
        {
            // Arrange / Act
            var target = new Codealot.Codalot();

            // Assert
            Assert.IsTrue(target.Knights.Count == 12);
        }

        /// <summary>
        /// Tests that a custom amount of knights can be added to the game
        /// </summary>
        [TestMethod]
        public void CustomKnightAmountTest_ExpectCustomAmount()
        {
            // Arrange / Act
            var customAmount = 20;
            var target = new Codealot.Codalot(customAmount);

            // Assert
            Assert.IsTrue(target.Knights.Count == customAmount);
        }
    }
}
