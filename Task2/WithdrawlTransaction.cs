using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class WithdrawlTransaction : ATMTransaction
    {
        private float amount { get; set; }

        public WithdrawlTransaction(int startTransactionId, DateTime startDate, string startType)
        : base(
            startTransactionId,
            startDate,
            startType
        )
        {

        }

        public void withdrawl()
        {

        }
    }
}
