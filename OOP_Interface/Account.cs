using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    public class Account : ISavingAccount, ICurrentAccount
    {
        public double GetCurrentAccountBalance()
        {
            return 2000;
        }

        public double GetSavingAccountBalance()
        {
            return 200000;
        }
    }
}
