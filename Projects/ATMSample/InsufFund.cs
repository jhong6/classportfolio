using System;
using System.Collections.Generic;
using System.Text;

namespace ATMforCsharp
{
    class InsufFund : Exception
    {
        private double total;
        public InsufFund(double total)
        {
            this.total = total;
        }
    }
}
