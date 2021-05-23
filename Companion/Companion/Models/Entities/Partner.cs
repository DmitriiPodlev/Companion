using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Models.Entities
{
    public class Partner
    {
        public Partner(string information)
        {
            Information = information;
        }

        public int Id { get; set; }
        public string Information { get; set; }
    }
}
