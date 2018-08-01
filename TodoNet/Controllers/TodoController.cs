using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TodoNet.Models;

namespace TodoNet.Controllers
{
    public class TodoController : Controller
    {
        Context db = new Context();

        // GET
        public ActionResult Index()
        {
            IEnumerable<Todo> todos = db.Todos;
            ViewBag.Todos = todos;

            return View();
        }
    }
}