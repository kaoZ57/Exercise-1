using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_1
{
    internal class Cash
    {
        public int type { get; private set; }
        public int amount { get; private set; }

        public Cash(int type, int amount)
        {
            this.type = type;
            this.amount = amount;
        }

        public override string ToString()
        {
            return "Cash" + type.ToString() + ": " + amount.ToString();
        }
    }
}
