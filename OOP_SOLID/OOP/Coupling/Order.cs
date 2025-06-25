using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.OOP.Coupling
{
    public class Order
    {
        private IMsgSender _sender;
        public Order(IMsgSender msgSender) => _sender = msgSender;
        public string PlaceOrder()
        {
            return _sender.Send();
        }
    }
}
