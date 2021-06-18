using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetAppointment.Data;
using VetAppointment.Models;
using VetAppointment.Models.Identity;

namespace VetAppointment.Controllers
{
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> userManager;
        private readonly AppUser _user;
        public MessageController(UserManager<AppUser> userManager, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            this.userManager = userManager;
            _context = context;
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _user = userManager.FindByIdAsync(userId).Result;

        }
        public IActionResult Index()
        {
            var messages = _context.Messages.Include(a => a.Sender).Where(a => a.Receiver == _user).OrderBy(a=>a.CreatedDate);
            //var vets=userManager.
            return View(messages);
        }
        public IActionResult SentIndex()
        {
            var messages = _context.Messages.Include(a => a.Receiver).Where(a => a.Sender == _user).OrderBy(a => a.CreatedDate);
            //var vets=userManager.
            return View(messages);
        }
        public IActionResult Create(string email)
        {
            return View(email);
        }
        [HttpPost]
        public IActionResult Create(Message message)
        {
            try
            {
                message.Sender = _user;
                message.Receiver = userManager.FindByEmailAsync(message.Receiver.Email).Result;
                if (message.Receiver == null)
                {
                    ModelState.AddModelError("Receiver", "Brak użytkownika o podanym e-mailu");
                    return View();
                }
                message.CreatedDate = DateTime.Now;

                if (ModelState.IsValid)
                {
                    _context.Add(message);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult SentDisplay(int id)
        {
            Message message = _context.Messages.Include(a => a.Receiver).FirstOrDefault(m => m.MessageID == id);
           
            return View(message);

        }
        public ActionResult Display(int id)
        {
            Message message = _context.Messages.Include(a => a.Sender).FirstOrDefault(m => m.MessageID==id);
            if(message.isViewed==false)
            {
                message.isViewed = true;
                message.ViewedDate = DateTime.Now;
                _context.SaveChanges();
            }  
            return View(message);

        }
    }
      
    
}