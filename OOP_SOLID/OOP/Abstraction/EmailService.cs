using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.OOP.Abstraction
{
    public class EmailService
    {
        //Reduce complexity by hiding unnecessary details
        public List<string> SendEmail()
        {
            List<string> result = new List<string>();
            result.Add(Connect());
            result.Add(Authenticate());
            result.Add("Email sent");
            return result;
        }
        private string Connect()
        {
            return "Connected";
        }
        private string Authenticate()
        {
            return "Authenticated";
        }
    }
}
