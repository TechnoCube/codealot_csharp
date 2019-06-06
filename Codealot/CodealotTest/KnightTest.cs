using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codealot;

namespace UnitTest
{
    [TestClass]
    public class KnightTest
    {
        /// <summary>
        /// Tests that no XP is earned when stamina is zero and that stamina is not reduced below zero.
        /// The knight should become exhausted for attempting to train with zero stamina, reducing xp to zero
        /// </summary>
        [TestMethod]
        public void ProcessHour_InTrainingYardZeroStamina_ExpectKnightIsExhaustedAndXpReducedToZero()
        {
            // Arrange
            var target = new Knight();
            target.SetXp(5);
            target.SetStamina(0);
            target.MoveToTrainingYard();

            // Act
            target.ProcessHour();

            // Assert
            Assert.IsTrue(target.IsExhausted());
            Assert.AreEqual(0, target.GetXp());
            Assert.AreEqual(0, target.GetStamina());
        }

        /// <summary>
        /// Tests that no XP is earned when the knight is exhausted
        /// </summary>
        [TestMethod]
        public void ProcessHour_InTrainingYardAndExhausted_ExpectKnightEarnsNoXp()
        {
            // Arrange
            var target = new Knight();
            target.MoveToTrainingYard();
            target.SetStamina(0);
            target.ProcessHour();
            target.SetStamina(1);

            // Act
            target.ProcessHour();

            // Assert
            Assert.IsTrue(target.IsExhausted());
            Assert.AreEqual(0, target.GetXp());
        }

        /// <summary>
        /// Tests that XP is earned when stamina is one and that stamina is reduced to zero
        /// </summary>
        [TestMethod]
        public void ProcessHour_InTrainingYardOneStamina_ExpectXpEarned()
        {
            // Arrange
            var target = new Knight();
            target.MoveToTrainingYard();
            target.SetStamina(1);

            // Act
            target.ProcessHour();

            // Assert
            Assert.AreEqual(1, target.GetXp());
            Assert.AreEqual(0, target.GetStamina());
        }

        /// <summary>
        /// Tests that stamina is earned when in the tavern
        /// </summary>
        [TestMethod]
        public void ProcessHour_InTavernNoStamina_ExpectStaminaEarned()
        {
            // Arrange
            var target = new Knight();
            target.MoveToTavern();
            target.SetStamina(0);

            // Act
            target.ProcessHour();

            // Assert
            Assert.AreEqual(1, target.GetStamina());
        }

        /// <summary>
        /// Tests that a knight can be placed in the tavern
        /// </summary>
        [TestMethod]
        public void MoveToTavern_ExpectKnightInTavern()
        {
            // Arrange
            var target = new Knight();            

            // Act
            target.MoveToTavern();

            // Assert
            Assert.IsTrue(target.IsInTavern());
            Assert.IsFalse(target.IsInTrainingYard());
        }

        /// <summary>
        /// Tests that a knight can be placed in the training yard
        /// </summary>
        [TestMethod]
        public void MoveToTrainingYard_ExpectKnightInTrainingYard()
        {
            // Arrange
            var target = new Knight();

            // Act
            target.MoveToTrainingYard();

            // Assert
            Assert.IsTrue(target.IsInTrainingYard());
            Assert.IsFalse(target.IsInTavern());
        }
    }
}
