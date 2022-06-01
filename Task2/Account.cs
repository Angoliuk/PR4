using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Account
    {
        // Дає доступ до карт, ним керує користувач,
        // через нього проводяться транзакції. Є два класи, що наслідують його
        private string type { get; set; }
        private Customer owner { get; set; }

        public Account()
        {
        }
    }
}
