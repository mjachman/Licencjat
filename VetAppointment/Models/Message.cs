using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using VetAppointment.Models.Identity;

namespace VetAppointment.Models
{
    public class Message
    {
        public int MessageID { get; set; }

        //public Message ParentMessage { get; set; }

        [DisplayName("Temat")]
        public string Topic { get; set; }
        [DisplayName("Treść")]
        public string MessageBody { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ViewedDate { get; set; }

        public AppUser Sender { get; set; }
        [DisplayName("Odbiorca")]
        public AppUser Receiver { get; set; }

        public bool isViewed { get; set; }
    }
}
