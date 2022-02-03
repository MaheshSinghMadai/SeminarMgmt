using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeminarMgmt.Data;
using SeminarMgmt.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarMgmt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            List<Seminar> model = (from p in _db.Seminars
                                    orderby p.SeminarId
                                    select p).ToList();
            return View(model);

        }

        public IActionResult About()
        {

            return View();

        }

    }
}
