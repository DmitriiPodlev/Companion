using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Views.Models.Business
{
    public class PlatformViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Form { get; set; }
        public List<string> Forms { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
