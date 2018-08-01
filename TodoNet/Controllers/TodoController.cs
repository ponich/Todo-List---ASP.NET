using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web.Mvc;
using TodoNet.Models;

namespace TodoNet.Controllers
{
    public class TodoController : Controller
    {
        Context db = new Context();

        [HttpGet]
        // home
        public ActionResult Index()
        {
            // get models data with relations
            IEnumerable<Todo> todos = db.Todos.Include(c => c.User);
            ViewBag.Todos = todos;

            return View();
        }

        [HttpGet]
        // get form
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        // form handler
        public ActionResult Create(Todo todo)
        {
            // model not valide
            if (!ModelState.IsValid)
            {
                // show form with errors
                return View("Form");
            }

            // @todo make auth
            todo.User = db.Users.Find(1);
            db.Todos.Add(todo);
            db.SaveChanges();

            // go back
            return RedirectToAction("Index", "Todo");
        }
    }
}