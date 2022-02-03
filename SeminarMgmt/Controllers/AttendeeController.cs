using Microsoft.AspNetCore.Mvc;
using SeminarMgmt.Data;
using SeminarMgmt.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarMgmt.Controllers
{
    public class AttendeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AttendeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET-Create 
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //POST-Create 
        [HttpPost]
      
        public IActionResult Register(int Id, string Fn,string Ln, string Ph, string email)
        {
            Attendee a = new Attendee
            {
               SeminarId = Id,
               Firstname = Fn,
               Lastname = Ln,
               Phonenumber = Ph,
               Emailaddress = email
            };

            _db.Add(a);
            _db.SaveChanges();
            
            //AddParticipant(a);

            return View(a);
        }

        //public bool AddParticipant(Attendee a)
        //{
        //    _db.Attendees.Add(a);
        //    return _db.SaveChanges() > 0;
        //}

        [HttpGet]
        public IActionResult ViewAttendeeDetails()
        {
            //Get Attendee details
            List<Attendee> model = (from pd in _db.Attendees
                                    join od in _db.Seminars on pd.SeminarId equals od.SeminarId
                                    orderby pd.UserID
                                    select pd).ToList();

            return View(model);

        }
    }
}
