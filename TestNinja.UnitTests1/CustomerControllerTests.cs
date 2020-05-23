using TestNinja.Fundamentals;
using NUnit.Framework;
using System.Linq;
using System.Collections;

namespace TestNinja.UnitTests1
{
    [TestFixture]
    class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            
            var result = controller.GetCustomer(0);

            //  Not Found
            Assert.That(result, Is.TypeOf<NotFound>());
            //  NotFound or one of its derivatives
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);

            //  Is Found
            Assert.That(result, Is.TypeOf<Ok>());
            //  Is Found
            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
