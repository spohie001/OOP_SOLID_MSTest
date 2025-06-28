using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.SingleResponsibility
{
    internal class UserService
    {
        public string Register(User user) //buissness logic is now in a different class
        {
            //business logic..

            //Send email
            var emailSender = new EmailSender();
            return emailSender.SendEmail(user.Email, "Welcome to our platform");
        }
    }
}
