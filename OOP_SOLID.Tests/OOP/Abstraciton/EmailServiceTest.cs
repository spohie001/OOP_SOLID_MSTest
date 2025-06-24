using OOP_SOLID.OOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.Tests.OOP.Abstraciton
{
    [TestClass]
    public class EmailServiceTest
    {
        [TestMethod]
        public void SendEmail_SendEmailTriggered_ReturnedAllMessages()
        {
            var email = new EmailService();
            var result = email.SendEmail();
            Assert.AreEqual("Connected", result.First());
            Assert.AreEqual("Authenticated", result[1]);
            Assert.AreEqual("Email sent", result.Last());
        }
    }
}
