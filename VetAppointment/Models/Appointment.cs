using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using VetAppointment.Models.Identity;

namespace VetAppointment.Models
{
    
   
    public class Appointment
    {
        public int AppointmentID { get; set; }
        [DisplayName("Data")]
        public DateTime Date { get; set; }
        public AppUser Client { get; set; }
        public AppUser Vet { get; set; }
        public bool Available { get; set; }

        [DisplayName("Uwagi weterynarza")]
        public string Description { get; set; }

        [DisplayName("Ocena")]
        public int Rating { get; set; }
    }
}
