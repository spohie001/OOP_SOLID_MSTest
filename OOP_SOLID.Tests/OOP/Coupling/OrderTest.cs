using OOP_SOLID.OOP.Coupling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.Tests.OOP.Coupling
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void Order_PlaceOrderTriggered_OrderPlacedByChosenMethod()
        {
            var orderEmail = new Order(new EmailSender());
            var orderSms = new Order(new SmsSender());
            Assert.AreEqual("Email sent.", orderEmail.PlaceOrder());
            Assert.AreEqual("Sms sent.", orderSms.PlaceOrder());
        }
    }
}
