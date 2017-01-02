using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankApp;

namespace BankAppTest
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void WithdrawMoreThanBalance()
        {
            // arrange
            int ID = 1;
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            Account account = new Account(ID, beginningBalance);

            // act
            try
            {
                account.withdraw(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // assert  
                StringAssert.Contains(e.Message, Account.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }
    }
}
