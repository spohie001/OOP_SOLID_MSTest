using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.SingleResponsibility
{
    //"A class should have only one reason to change. meaning that it hould have only one responsibility or purpose
    
    internal class User //class violates SRP!
    {
        //it manages user data
        public string Username {  get; set; } //* 1. 
        public string Email { get; set; }

        //and also containes logic for registration
        public void Register()
        {
            //business logic..

            //Send email
            var emailSender = new EmailSender();
            emailSender.SendEmail(this.Email, "Welcome to our platform");
        }

        //* reazons to be changed:
        //* 1. we need more fields
        //* 2. wen want to change logic of the registration process
    }
}
