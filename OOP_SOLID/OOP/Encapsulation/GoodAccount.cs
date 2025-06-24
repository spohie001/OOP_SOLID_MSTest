using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.OOP.Encapsulation
{
    public class GoodAccount
    {
        //allowing access to only funcionalities in a secure way 
        private decimal _balance;
        public GoodAccount(decimal balance)
        {
            _balance = balance;
        }
        public decimal GetBalance()
        {
            return _balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than 0.");
            }
            _balance += amount;
        }

        public void Withdraw(decimal amount) 
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than 0.");
            }

            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            _balance -= amount;
        }
    }
}
