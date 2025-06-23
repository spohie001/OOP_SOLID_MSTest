using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using OOP_SOLID.OOP.Encapsulation;

namespace OOP_SOLID.Tests.OOP.Encapsulation
{
    [TestClass]
    public class GoodAccountTest
    {
        [TestMethod]
        public void GetBalance_GetBalanceTriggered_ReturnedCorrectBalance()
        {
            var goodAccount = new GoodAccount(0);
            decimal balance = goodAccount.GetBalance();
            Assert.AreEqual(0, balance);
        }
        [TestMethod]
        public void Deposit_DepositsPositiveAmount_AmountSuccsessfullyAddedToBalance()
        {
            var goodAccount = new GoodAccount(0);
            goodAccount.Deposit(10);
            decimal newBalance = goodAccount.GetBalance();
            Assert.AreEqual(10, newBalance);
        }
        [TestMethod]
        public void Deposit_DepositsNegativeAmount_ThrowExeption()
        {
            var goodAccount = new GoodAccount(0);
            Assert.ThrowsException<ArgumentException>(() => goodAccount.Deposit(-10));
        }
        [TestMethod]
        public void Deposit_DepositsNegativeAmount_BalanceUnchanged()
        {
            var goodAccount = new GoodAccount(0);
            try{  goodAccount.Deposit(-10); }
            catch(ArgumentException ex) {}
            decimal balance = goodAccount.GetBalance();
            Assert.AreEqual(0, balance);
        }
        [TestMethod]
        public void Deposit_DepositsZero_ThrowExeption()
        {
            var goodAccount = new GoodAccount(0);
            Assert.ThrowsException<ArgumentException>(() => goodAccount.Deposit(0));
        }
        [TestMethod]
        public void Deposit_DepositsZero_BalanceUnchanged()
        {
            var goodAccount = new GoodAccount(0);
            try { goodAccount.Deposit(0); }
            catch (ArgumentException ex) { }
            decimal balance = goodAccount.GetBalance();
            Assert.AreEqual(0, balance);
        }
    }
}
