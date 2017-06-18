using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bs = BankSpace;
using ac = AccountSpace;

namespace ClientSpace
{
    class Client
    {
        private string ClientName { get; set; }
        private string ClientSurname { get; set; }
        private int ClientAge { get; set; }
        private int ClientMoney { get; set; }
        private bool PutMoney;

        public Client()
        {
            this.ClientName = "";
            this.ClientSurname = "";
            this.ClientAge = 0;
            this.ClientMoney = 0;
            this.PutMoney = false;
        }
        public Client(string name, string surname, int age, int clientMoney, bool putMoney)
        {
            this.ClientName = name;
            this.ClientSurname = surname;
            this.ClientAge = age;
            this.ClientMoney = clientMoney;
            this.PutMoney = putMoney;
        }

        public string clientName
        {
            get { return this.ClientName; }
            set
            {
                if (value == "" || value == " ")
                {
                    Console.WriteLine("Неверно введено имя");
                }
                else
                {
                    this.ClientName = value;
                }
            }
        }
        public string clienSurname
        {
            get { return this.ClientSurname; }
            set
            {
                if (value == "" || value == " ")
                {
                    Console.WriteLine("Неверно введена фамилия");
                }
                else
                {
                    this.ClientSurname = value;
                }
                
            }
        }
        public int clientAge
        {
            get { return this.ClientAge; }
            set
            {
                if (value < 18)  
                {
                    Console.WriteLine("Рано еще карту заводить, ну да пофиг");
                }
                else
                {
                    this.ClientAge = value;
                }
            }
        }
        public int clientMoney
        {
            get { return this.ClientMoney; }
            set
            {
                if (value < 100)
                {
                    Console.WriteLine("Не хватает средств");
                }
                else
                {
                    this.ClientMoney = value;
                }
            }
        }
        public bool putMoney
        {
            get { return this.PutMoney; }
            set { this.PutMoney = value; }
        }
    }
}
