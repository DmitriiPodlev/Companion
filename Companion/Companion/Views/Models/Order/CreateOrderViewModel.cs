using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Views.Models.Order
{
    public class CreateOrderViewModel
    {
        public string Name { get; set; }
        public string Adres { get; set; }
        public string Adress { get; set; }
        public string Date { get; set; }
        public int ActivityId { get; set; }
    }
}
