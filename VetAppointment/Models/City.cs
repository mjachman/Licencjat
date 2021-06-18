using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetAppointment.Models.Identity;

namespace VetAppointment.Models
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; } 
        public ICollection<AppUser> Users { get; set; }
    }
}
