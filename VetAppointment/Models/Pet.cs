using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using VetAppointment.Models.Identity;
using Microsoft.AspNetCore.Mvc;
namespace VetAppointment.Models
{
    public enum PetTypeEnum
    {
        pies,kot,gad,płaz,koń,ryba,ptak
    }
    public class Pet
    {
        public int ID { get; set; }
        [DisplayName("Imię")]
        public string Name { get; set; }
        [DisplayName("Typ")]
        public PetTypeEnum PetType{ get ; set; }
        public AppUser Owner { get; set; }
        [DisplayName("Rok urodzenia")]
        public ushort YearOfBirth {get;set;}        
        public string Description { get; set; }
        
    }
}
