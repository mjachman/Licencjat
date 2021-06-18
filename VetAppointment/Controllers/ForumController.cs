using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using VetAppointment.Data;
using VetAppointment.Models;
using VetAppointment.Models.Identity;

namespace VetAppointment.Controllers
{
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> userManager;
        private readonly AppUser _user;
        private bool ok;
        public ForumController(UserManager<AppUser> userManager, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            this.userManager = userManager;
            _context = context;
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _user = userManager.FindByIdAsync(userId).Result;

        }
        public IActionResult Forum()
        {
            

            var model = new ForumModel();
            //mymodel.entry = new Entry();
            model.Entries = _context.Entries.Where(p=>p.ParentEntry==null).Include("Author").OrderByDescending(x => x.CreatedDate);
            //model.Count = model.Entries.Where(e => e.ParentEntry.EntryID == en).Count();
            model.CommentCount = new Dictionary<int, int>();
            foreach(var ent in _context.Entries)
            {
                model.CommentCount[ent.EntryID] = _context.Entries.Where(p => p.ParentEntry.EntryID == ent.EntryID).Count();
            }
            //var vets=userManager.
            return View(model);
        }
        [Authorize(Roles = "Vet")]
        public IActionResult Reply(int id)
        {

            var model = new ForumModel();
            //var model = new ForumModel();
            model.Entry = _context.Entries.Include("Author").FirstOrDefault(e => e.EntryID == id);
            model.Entries = _context.Entries.Include("Author").Where(e => e.ParentEntry.EntryID == id);
            return View(model);

        }
        [Authorize(Roles = "Vet")]
        [HttpPost]
        public IActionResult Reply(Entry entry,int id)
        {
            try
            {
                entry.Author = _user;
                entry.CreatedDate = DateTime.Now;
                entry.ParentEntry= _context.Entries.Include(e=>e.Author).FirstOrDefault(e => e.EntryID == id);
                //if (entry.EntryBody.Length < 20)
                //{
                //    ModelState.AddModelError("EntryBody", "Pytanie musi zawierać przynajmniej 20 znaków.");
                //    return RedirectToAction("Forum");
                //}
                if (ModelState.IsValid)
                {
                    _context.Add(entry);
                    _context.SaveChanges();
                    return RedirectToAction("DisplayThread",new {id=id});
                }

                return RedirectToAction("DisplayThread", new { id = id });
            }
            catch
            {
                return RedirectToAction(nameof(DisplayThread));
            }

        }
        public IActionResult DisplayThread(int id)
        {
            var model = new ForumModel();

            model.Entry = _context.Entries.Include("Author").FirstOrDefault(e => e.EntryID == id);

            model.Entries = _context.Entries.Include("Author").Where(e => e.ParentEntry.EntryID == id).OrderByDescending(d=>d.CreatedDate);

            return View(model);

        }

        [HttpPost]
        public IActionResult Post(Entry entry)
        {
            try
            {
                entry.Author = _user;
                entry.CreatedDate = DateTime.Now;
                //if (entry.EntryBody.Length < 20)
                //{
                //    ModelState.AddModelError("EntryBody", "Pytanie musi zawierać przynajmniej 20 znaków.");
                //    return RedirectToAction("Forum");
                //}
                if (ModelState.IsValid)
                {
                    _context.Add(entry);
                    _context.SaveChanges();
                    return RedirectToAction("Forum");
                }

                return RedirectToAction(nameof(Forum));
            }
            catch
            {
                return RedirectToAction(nameof(Forum));
            }
        }
    }
}