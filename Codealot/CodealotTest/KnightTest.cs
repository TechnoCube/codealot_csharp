using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codealot;

namespace UnitTest
{
    [TestClass]
    public class KnightTest
    {
        /// <summary>
        /// Tests that no XP is earned when stamina is zero and that stamina is not reduced below zero
        /// </summary>
        [TestMethod]
        public void ProcessHour_InTrainingYardZeroStamina_ExpectNoXpEarned()
        {
            // Arrange
            var target = new Knight();
            target.MoveToTrainingYard();

            // Act
            target.ProcessHour();

            // Assert
            Assert.AreEqual(0, target.GetXp());
            Assert.AreEqual(0, target.GetStamina());
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
            target.IncrementStamina(1);

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
