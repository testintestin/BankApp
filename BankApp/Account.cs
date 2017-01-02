using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    [Serializable]
    public class Account
    {
        public int accountid { get; set; }
        public double interestRate { get; set; }
        public double credit { get; set; }
        public double balance { get; set; }

        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount less than zero";

        // Constructors
        public Account() { }

        public Account(int accountid, double balance)
        {
            this.accountid = accountid;
            this.balance = balance;
        }

        public Account(int accountid, double interestRate, double balance)
        {
            this.accountid = accountid;
            this.interestRate = interestRate;
            this.balance = balance;
        }

        // Destructor
        ~Account() { }

        // Member methods
        public void deposit(double amount)
        {
            balance += amount;
        }

        public virtual void withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            balance -= amount;
        }

        public double getBalance()
        {
            return balance;
        }
    }

    [Serializable]
    class PrivateAccount : Account
    {
        // Constructor
        public PrivateAccount()
        {
            interestRate = 0.5;
        }

        public PrivateAccount(int _accountid, double _credit, double _balance)
            : base (_accountid, _balance)
        {
            credit = _credit;
            interestRate = 0.5;
        }
    }

    [Serializable]
    class FutureAccount : Account
    {
        private DateTime _next_withdrawal = new DateTime();
        public int fee { get; set; }

        // Constructors
        public FutureAccount()
        {
            interestRate = 3.5;
        }
        public FutureAccount(int _accountid, double _balance)
            : base (_accountid, _balance)
        {
            credit = 0;
            interestRate = 3.5;
        }

        // Setters & getters
        public DateTime next_withdrawal
        {
            get { return _next_withdrawal; }
            set { _next_withdrawal = value; }
        }

        // Member methods
        public override void withdraw(double _amount)
        {
            balance -= _amount;
            _next_withdrawal = DateTime.Parse(DateTime.Today.ToShortDateString());
        }
    }

    [Serializable]
    class ServiceAccount : Account
    {
        //public double interestRate { get; set; }

        public ServiceAccount()
        {
            interestRate = 1.5;
        }
        public ServiceAccount(int _accountid, double _balance)
            : base (_accountid, _balance)
        {
            credit = 0;
            interestRate = 1.5;
        }
    }
}
