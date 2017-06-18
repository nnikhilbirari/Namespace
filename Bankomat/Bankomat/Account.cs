using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bs = BankSpace;
using cs = ClientSpace;

namespace AccountSpace
{
    class Account
    {
        private Int64 BankAccount { get; set; }//номер счета
        private string BankPassword { get; set; }
        

        public Account()
        {
            Random r = new Random();
            this.BankAccount = r.Next(100000000, 999999999);
            this.BankPassword = "";
        }
        public Account(uint bankAccount, string bankPassword, bool putMoney)
        {
            this.BankAccount = bankAccount;
            this.BankPassword = bankPassword;
        }

        public Int64 bankAccount
        {
            get { return this.BankAccount; }
            set { this.BankAccount = value; }
        }
        public string bankPassword
        {
            get { return this.BankPassword; }
            set
            {
                if(value == "" || value  == " ")
                {
                    Console.WriteLine("Введите пароль!");
                }
                else
                {
                    this.BankPassword = value;
                    Console.WriteLine("Добро пожаловать в Cool Bank!\n\n");
                }
            }
        }
    }
}
