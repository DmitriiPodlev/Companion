using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Models.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string AboutActivity { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public List<string> Locations { get; set; }
        public string PeriodOfWork { get; set; }
        public string Description { get; set; }
        public string Form { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
