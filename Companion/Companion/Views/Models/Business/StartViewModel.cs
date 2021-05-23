using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Views.Models.Business
{
    public class StartViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }
        public List<string> Categories { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string AboutIt { get; set; }

    }
}
