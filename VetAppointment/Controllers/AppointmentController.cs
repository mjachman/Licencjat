using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetAppointment.Data;
using VetAppointment.Models;
using VetAppointment.Models.Identity;

namespace VetAppointment.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> userManager;
        private readonly AppUser _user;
        public AppointmentController(UserManager<AppUser> userManager, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            this.userManager = userManager;
            _context = context;
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _user = userManager.FindByIdAsync(userId).Result;

        }
        [Authorize(Roles = "Vet")]
        public IActionResult DoctorDates()
        {
            var availableDates = _context.Appointments.Where(a => a.Vet == _user).Where(a => a.Available == true).OrderBy(a => a.Date).ToList();
            return View(availableDates);
        }
        public ActionResult AddDate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Vet")]
        public ActionResult AddDate(Appointment appointment)
        {
            try
            {
                appointment.Vet = _user;
                appointment.Available = true;
                
                if (ModelState.IsValid)
                {
                    _context.Add(appointment);
                    _context.SaveChanges();
                    return RedirectToAction("DoctorDates");
                }


                return RedirectToAction(nameof(DoctorDates));
            }
            catch
            {
         
                return View();
            }
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
           
                Appointment appointment = _context.Appointments.Find(id);
                _context.Appointments.Remove(appointment);
                _context.SaveChanges();
       
                return RedirectToAction(nameof(DoctorDates));
        }
        public ActionResult VetList(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var appointments = _context.Appointments.Include(a => a.Vet).Where(a => a.Available == true);//.Where(a=>a.Date>=DateTime.Now);
            if (!string.IsNullOrEmpty(searchString))
            {
               appointments = appointments.Where(a => a.Vet.Name.Contains(searchString) || a.Vet.Address.Contains(searchString) || a.Vet.Surname.Contains(searchString) || a.Date.ToString().Contains(searchString));
            }
            return View(appointments.ToList().OrderBy(a => a.Date));     
        }
        public ActionResult VetsList()
        {
            var vets = userManager.GetUsersInRoleAsync("Vet").Result;
            return View(vets);
            
        }
        public ActionResult MakeAppointment(int? id)
        {
    
            Appointment appointment = _context.Appointments.Find(id);

            return View(appointment);

        }
        [HttpPost]
        public ActionResult MakeAppointment(int id)
        {          
                Appointment appointment = _context.Appointments.Find(id);
                appointment.Available = false;
                appointment.Client = _user;
                _context.Appointments.Update(appointment);
                _context.SaveChanges();
                return RedirectToAction(nameof(VetList));
          
        }
        [Authorize(Roles = "User")]
        public ActionResult UserAppointmentList()
        {
            var appointments = _context.Appointments.Include(a => a.Vet).Where(a => a.Client == _user).Where(a=>a.Date>=DateTime.Now).OrderBy(a=>a.Date);
            return View(appointments);
        }

        public ActionResult Cancel(int? id)
        {     
            Appointment appointment = _context.Appointments.Find(id);
            return View(appointment);
        }
        [HttpPost, ActionName("Cancel")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appointment appointment = _context.Appointments.Include(a => a.Client).Include(a => a.Vet).Where(a => a.AppointmentID == id).FirstOrDefault();
            //var client = _context.Appointments.Include(a => a.Client).Where(a => a.AppointmentID == id).FirstOrDefault();
            //var vet = _context.Appointments.Include(a => a.Vet).Where(a => a.AppointmentID == id).FirstOrDefault();
            Message message = new Message();
            message.CreatedDate = DateTime.Now;
            if(User.IsInRole("Vet"))
            {
                message.Sender = appointment.Vet;
                message.Receiver = appointment.Client;
            }
            else
            {
                message.Sender = appointment.Client;
                message.Receiver = appointment.Vet;
            }
            message.Topic = $"Odwołano wizytę {appointment.Date}";
            message.MessageBody = "";
            _context.Messages.Add(message);
            _context.Appointments.Remove(appointment);
            _context.SaveChanges();
            return RedirectToAction("UserAppointmentList");
        }

        [Authorize(Roles = "Vet")]
        public ActionResult VetAppointmentList()
        {
            var appointments = _context.Appointments.Include(a => a.Client).Where(a => a.Vet == _user).Where(a=>a.Available==false).OrderBy(a => a.Date);
            return View(appointments);
        }
        public ActionResult UserPastAppointmentList()
        {
            var appointments = _context.Appointments.Include(a => a.Vet).Where(a => a.Client == _user).Where(a => a.Date <= DateTime.Now).OrderBy(a => a.Date);
            return View(appointments);
        }
        public ActionResult VetPastAppointmentList(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var appointments = _context.Appointments.Include(a => a.Client).Where(a => a.Vet == _user).Where(a => a.Date <= DateTime.Now && a.Client != null);//.OrderBy(a => a.Date);
            if (!string.IsNullOrEmpty(searchString))
            {
                appointments = appointments.Where(a => a.Client.Name.Contains(searchString) || a.Client.Surname.Contains(searchString) || a.Client.Email.Contains(searchString) || a.Date.ToString().Contains(searchString));
            }
            return View(appointments.OrderBy(a=>a.Date));
        }
        public ActionResult Details(int id)
        {
            Appointment appointment = _context.Appointments.Include(a=>a.Vet).Where(a=>a.AppointmentID==id).Single();

            return View(appointment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(int id,int rating)
        {
            var appointmentToUpdate = _context.Appointments.FirstOrDefault(a => a.AppointmentID == id);
            if (ModelState.IsValid)
            {
                appointmentToUpdate.Rating = rating;

                _context.SaveChanges();
                return RedirectToAction(nameof(UserPastAppointmentList));
            }
            return View(appointmentToUpdate);

            //return View(appointment);
        }
        public ActionResult Edit(int id)
        {
            Appointment appointment= _context.Appointments.Include(a => a.Vet).Where(a => a.AppointmentID == id).Single();
            return View(appointment);
        }    
        // POST: Pet/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string description)
        {
            var appointmentToUpdate = _context.Appointments.FirstOrDefault(a => a.AppointmentID == id);
            if (ModelState.IsValid)
            {
                appointmentToUpdate.Description = description;

                _context.SaveChanges();
                return RedirectToAction(nameof(VetPastAppointmentList));
            }
            return View(appointmentToUpdate);
        }
        

    }
}