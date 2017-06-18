using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs = ClientSpace;
using ac = AccountSpace;

namespace BankSpace
{
    class Bank
    {
        private const string BankName = "Cool Bank";

        public static string bankName
        {
            get { return Bank.BankName; }
        }
    }
}
