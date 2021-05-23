using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Views.Models.Business
{
    public class LocationsViewModel
    {
        public int Id { get; set; }

        [Required]
        public List<string> Adress { get; set; }

        [Required]
        public string PeriodOfWork { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
