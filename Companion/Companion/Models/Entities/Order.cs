using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Models.Entities
{
    public class Order
    {
        public Order(string name, string adres, string date, string qr_code)
        {
            Name = name;
            Adres = adres;
            Date = date;
            Qr_code = qr_code;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adres { get; set; }
        public string Date { get; set; }
        public string Qr_code { get; set; }
        public string ClientId { get; set; }
        public int ActivityId { get; set; }
    }
}
