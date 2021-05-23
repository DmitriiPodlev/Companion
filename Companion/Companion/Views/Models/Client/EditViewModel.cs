using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Views.Models.Client
{
    public class EditViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Language { get; set; }
        public string Phone { get; set; }
        public bool Notifications { get; set; }
    }
}
