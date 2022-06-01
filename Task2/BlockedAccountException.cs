using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [System.Serializable]
        public class AccountBlockedException : System.Exception
        {
            private static readonly string DefaultMessage = "The transaction cannot be performed on a blocked account";

            public string customerName { get; set; }
            public string transactionType { get; set; }

            public AccountBlockedException() : base(DefaultMessage) { }
            public AccountBlockedException(string CustomerName, string TransactionType)
            : base(DefaultMessage)
            {
                customerName = CustomerName;
                transactionType = TransactionType;
            }

            public AccountBlockedException(string CustomerName, string TransactionType, System.Exception innerException)
            : base(DefaultMessage, innerException)
            {
                customerName = CustomerName;
                transactionType = TransactionType;
            }

            public AccountBlockedException(string CustomerName, string TransactionType, string message)
            : base(message)
            {
                customerName = CustomerName;
                transactionType = TransactionType;
            }

            public AccountBlockedException(string CustomerName, string TransactionType, string message, System.Exception innerException)
            : base(message, innerException)
            {
                customerName = CustomerName;
                transactionType = TransactionType;
            }


            protected AccountBlockedException(
                System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
}
