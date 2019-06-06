using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codealot;

namespace UnitTest
{
    [TestClass]
    public class CodealotGameTest
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
            var target = new CodealotGame();

            // Assert
            Assert.AreEqual(12, target.Knights.Count);
        }

        /// <summary>
        /// Tests that a custom amount of knights can be added to the game
        /// </summary>
        [TestMethod]
        public void CustomKnightAmountTest_ExpectCustomAmount()
        {
            // Arrange / Act
            var customAmount = 20;
            var target = new CodealotGame(customAmount);

            // Assert
            Assert.AreEqual(customAmount, target.Knights.Count);
        }

        /// <summary>
        /// Tests that if three knights are above the bonus threshold, those three knights gain three bonus xp
        /// </summary>
        [TestMethod]
        public void GrantBonusXp_ThreeKnightsAchieveBonus_ExpectThreeBonusXpAwarded()
        {
            // Arrange
            var target = new CodealotGame();
            for (int i = 0; i < 12; i++)
            {
                if (i < 3)
                {
                    target.Knights[i].SetXp(5);
                }
            }

            // Act
            target.GrantBonusXp();

            // Assert
            for (int i = 0; i < 12; i++)
            {
                if (i < 3)
                {
                    Assert.AreEqual(8, target.Knights[i].GetXp());
                }
                else
                {
                    Assert.AreEqual(0, target.Knights[i].GetXp());
                }
            }
        }

        /// <summary>
        /// Tests that if five knights are above the bonus threshold, those five knights gain five bonus xp
        /// </summary>
        [TestMethod]
        public void GrantBonusXp_FiveKnightsAchieveBonus_ExpectFiveBonusXpAwarded()
        {
            // Arrange
            var target = new CodealotGame();
            for (int i = 0; i < 12; i++)
            {
                if (i < 5)
                {
                    target.Knights[i].SetXp(5);
                }
            }

            // Act
            target.GrantBonusXp();

            // Assert
            for (int i = 0; i < 12; i++)
            {
                if (i < 5)
                {
                    Assert.AreEqual(10, target.Knights[i].GetXp());
                }
                else
                {
                    Assert.AreEqual(0, target.Knights[i].GetXp());
                }
            }
        }

        /// <summary>
        /// Tests that if eight knights are above the bonus threshold, those eight knights gain eight bonus xp
        /// </summary>
        [TestMethod]
        public void GrantBonusXp_EightKnightsAchieveBonus_ExpectEightBonusXpAwarded()
        {
            // Arrange
            var target = new CodealotGame();
            for (int i = 0; i < 12; i++)
            {
                if (i < 8)
                {
                    target.Knights[i].SetXp(5);
                }
            }

            // Act
            target.GrantBonusXp();

            // Assert
            for (int i = 0; i < 12; i++)
            {
                if (i < 8)
                {
                    Assert.AreEqual(13, target.Knights[i].GetXp());
                }
                else
                {
                    Assert.AreEqual(0, target.Knights[i].GetXp());
                }
            }
        }
    }
}
