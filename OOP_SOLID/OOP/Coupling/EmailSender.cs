using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.OOP.Coupling
{
    public class EmailSender : IMsgSender
    {
        public string Send()
        {
            return "Email sent.";
        }
    }
}
