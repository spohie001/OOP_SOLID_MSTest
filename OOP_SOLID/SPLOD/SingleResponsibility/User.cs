using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.SingleResponsibility
{
    //"A class should have only one reason to change. meaning that it hould have only one responsibility or purpose
    
    internal class User //user has only one responsibility
    {
        public string Username {  get; set; }
        public string Email { get; set; }

    }
}
