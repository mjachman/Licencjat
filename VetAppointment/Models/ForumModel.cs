using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetAppointment.Models.Identity;

namespace VetAppointment.Models
{
    public class ForumModel
    {
        public Dictionary<int,int> CommentCount { get; set; }
        public Entry Entry { get; set; }
        public int EntryID { get; set; } //id wpisu
        public Entry ParentEntry { get; set; } //wpis, na który dany wpis odpowiada
        public string EntryBody { get; set; } //treść wiadomości
        public DateTime CreatedDate { get; set; } //data utworzenia
        public AppUser Author { get; set; } //autor wpisu
        public IEnumerable<Entry> Entries { get; set; }
    }
}
