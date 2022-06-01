using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ATMTransaction
    {
        // модифікує рахунок, два класи його наслідують
        private int transactionId { get; set; }
        private DateTime date { get; set; }
        private string type { get; set; }

        public ATMTransaction(int startTransactionId, DateTime startDate, string startType)
        {
            transactionId = startTransactionId;
            date = startDate;
            type = startType;
        }
        public void modifies(bool isBlockedAccount)
        {
            if (isBlockedAccount)
                throw new AccountBlockedException();
            Console.WriteLine("Success");

        }
    }
}
