using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountClass
{
    public class BankAccount
    {
        #region fields
        //Fields
        private decimal balance;
        private string customerName;
        private string accountNumber;
        private string accountType;
        #endregion

        #region properties
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public string AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                accountType = value;
            }
        }
        #endregion

        #region Constructors
        public BankAccount()
        {
            accountType = "savings";
            accountNumber = "555-555-555";
            customerName = "John Doe";
            balance = 1000m;
        }
        public BankAccount(decimal _balance, string _accountNumber, string _customerName, string _accountType)
        {
            balance = _balance;
            accountNumber = _accountNumber;
            customerName = _customerName;
            accountType = _accountType;
        }
        #endregion

        #region Methods
        public void PrintInfo()
        {
            Console.WriteLine("Balance is: " + Balance);
            Console.WriteLine("Account number is: " + AccountNumber);
            Console.WriteLine("Customer name is: " + CustomerName);
            Console.WriteLine("Account type is: " + AccountType);
        }

        public bool ApproveWithdrawal(decimal amount)
        {
            //ABSTRACTION - shows only the essential details to the user
            //in this method, the user only needs to know if their withdrawal
            //was valid or not valid
            if (amount <= balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
        

        
                
          
        
        

