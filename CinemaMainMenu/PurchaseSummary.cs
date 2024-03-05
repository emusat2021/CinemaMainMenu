using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaMainMenu
{
    public class PurchaseSummary
    {
        public int NumberOfPersons { get; set; }
        public int Quantity { get; set; }
        public int PricePerTicket { get; set; }

        public int TotalPrice => Quantity * PricePerTicket;

    }
}
