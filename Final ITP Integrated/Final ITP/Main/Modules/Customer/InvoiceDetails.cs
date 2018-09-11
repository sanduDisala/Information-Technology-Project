using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Modules.Customer
{
    class InvoiceDetails
    {
        public string item { get; set; }

        public int quantity { get; set; }

        public double unitPrice { get; set; }

        public double total { get; set; }

        public double totalAmount { get; set; }
    }
}


