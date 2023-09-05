using Research_Gate_1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Research_Gate_1._1.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Author(int id)
        {
            var context = new ResearchGateEntities();
            var author = context.Authors.Find(id);
            return View(author);
        }
    }
}