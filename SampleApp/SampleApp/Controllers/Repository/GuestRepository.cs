using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Controllers.Repository
{
    public static class GuestRepository
    {
        private static List<Guest> guests = new List<Guest>();

        public static IEnumerable<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }

        public static void AddGuest(Guest guest)
        {
            guests.Add(guest);
        }
            

    }
}
