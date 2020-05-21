using System;
using TestNinja.Fundamentals;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace TestNinja.UnitTests1
{
    //  [TestClass] MSTest attribute
    [TestFixture]   // NUnit framework
    public class ReservationTests
    {
        //  Scenarios when trying to Cancel
        //  1.  Is an admin
        //  2.  Is the creator
        //  3.  3rd party, non-admin or creator

        //[TestMethod]  MSTest attribute
        [Test]  // NUnit
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //  1.  Is an admin

            //  Arrange
            //  where you initialize objects
            var reservation = new Reservation();

            //  Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //  Assert  //  Many options for Assert, personal preference
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //Assert.That(result == true);
        }

        //[TestMethod]  MSTest attribute
        [Test]  // NUnit
        public void CanBeCancelledBy_UserIsCreator_ReturnsTrue()
        {
            //  2.  Is the creator
            
            //  Arrange
            //  where you initialize objects
            var creator = new User { IsAdmin = false };
            var reservation = new Reservation() { MadeBy = creator };            

            //  Act
            var result = reservation.CanBeCancelledBy(creator);

            //  Assert
            Assert.IsTrue(result);
        }

        //[TestMethod]  MSTest attribute
        [Test]  // NUnit
        public void CanBeCancelledBy_UserIs3rdParty_ReturnsFalse()
        {
            //  3.  3rd party, non-admin or creator

            //  Arrange
            //  where you initialize objects
            var reservation = new Reservation() { MadeBy = new User() };  
            var otherUser = new User { IsAdmin = false };
            
            //  Act
            var result = reservation.CanBeCancelledBy(otherUser);

            //  Assert
            Assert.IsFalse(result);
        }
    }
}
