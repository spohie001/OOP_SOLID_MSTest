using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.SingleResponsibility
{
    internal class EmailSender
    {
        public string SendEmail(string email, string msg)
        {
            return $"Sending email to {email}: {msg}";
        }
    }
}
