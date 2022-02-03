using Microsoft.AspNetCore.Mvc;
using SeminarMgmt.Data;
using SeminarMgmt.Models;
using System.Collections.Generic;
using System.Linq;

namespace SeminarMgmt.Controllers
{
    public class SeminarController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SeminarController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Seminar> objList = _db.Seminars;
            return View(objList);
        }


        [HttpGet]
        public IActionResult Details(int? id)
        {
            //Get product details
            Seminar detail = _db.Seminars.Find(id);

            return View(detail);    

        }

        [HttpGet]
        public IActionResult ViewAttendeeDetails(int? Id)
        {
            //Get Attendee details
            List<Attendee> model = (from pd in _db.Attendees
                                    where pd.SeminarId == Id
                                    orderby pd.UserID
                                    select pd).ToList();

            return View(model);

        }

        //GET-Create 
        public IActionResult Create()
        {

            return View();
        }

        //POST-Create 
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Seminar obj)
        {
            if (ModelState.IsValid)
            {
                _db.Seminars.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET-Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Seminars.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST-Edit
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Seminar obj)
        {
            if (ModelState.IsValid)
            {
                _db.Seminars.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //GET-Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Seminars.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST-Delete
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Seminars.Find(id);
            _db.Seminars.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
