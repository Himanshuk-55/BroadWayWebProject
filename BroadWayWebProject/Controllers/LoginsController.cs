using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BroadWayWebProject.Data;
using BroadWayWebProject.Models;

namespace BroadWayWebProject.Controllers
{
    public class LoginsController : Controller
    {
        private DBConfiguration db = new DBConfiguration();
        // GET: Logins
        public ActionResult Login()
        {
            return View();
        }
    }
}