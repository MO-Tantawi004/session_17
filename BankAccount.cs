using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
       


        public const string BankCode = "BNK001";

     
        public readonly DateTime CreatedDate;

       
        private int _accountNumber;
        private string _fullName;
        private string _nationalID;
        private string _phoneNumber;
        private string _address;
        private double _balance;

        public BankAccount(int accountNumber, string fullName, string nationalID, string phoneNumber, string address, double balance)
        {
            CreatedDate = DateTime.Now; 
            AccountNumber = accountNumber;
            FullName = fullName;
            NationalID = nationalID;
            PhoneNumber = phoneNumber;
            Address = address;
            Balance = balance;
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("NAME CAN'T BE EMPTY");
                _fullName = value;
            }
        }

        public string NationalID
        {
            get { return _nationalID; }
            set
            {
                if (value.Length != 14 || !long.TryParse(value, out _))
                    throw new ArgumentException("ID NUMBER MUST BE 14 NUMBER");
                _nationalID = value;
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (!value.StartsWith("01") || value.Length != 11)
                    throw new ArgumentException("THE NUMBER MUST START WITH 01 AND BE 11 NUMBER ");
                _phoneNumber = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Balance can't be Nagative");
                _balance = value;
            }
        }

        
        public void ShowAccountDetails()
        {
            Console.WriteLine($" Code_BANK: {BankCode}");
            Console.WriteLine($"Date: {CreatedDate}");
            Console.WriteLine($"Account_Number: {AccountNumber}");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"ID: {NationalID}");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine("---------------------------");
        }
    }

}

