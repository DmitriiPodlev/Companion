using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Views.Models.Login
{
    public class PartnerLogin
    {
        [Required]
        public string AboutSelf { get; set; }
    }
}
