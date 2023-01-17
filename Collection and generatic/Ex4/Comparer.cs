using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class IDComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
    class FNameComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.FName.CompareTo(y.FName);
        }
    }

    class LNameComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.LName.CompareTo(y.LName);
        }
    }

    class BalanceComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.Balance.CompareTo(y.Balance);
        }
    }
}
