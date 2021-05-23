using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Models.Entities
{
    public class Client
    {
        public Client(string id, string phone, string firstName, string lastName,
            string language, bool notifications)
        {
            Id = id;
            Phone = phone;
            FirstName = firstName;
            LastName = lastName;
            Language = language;
            Notifications = notifications;
        }

        public string Id { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Language { get; set; }
        public bool Notifications { get; set; }
    }
}
