using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class QueryTransaction : ATMTransaction
    {
        private string query { get; set; }
        private string type { get; set; }

        public QueryTransaction(int startTransactionId, DateTime startDate, string startType)
        :base( 
            startTransactionId,
            startDate,
            startType
        ){
            
        }

        public void queryprocessing()
        {

        }
    }
}
