using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;
using TodoNet.Models;

namespace TodoNet.Controllers
{
    public class TodoController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            // получить данные моделей совместно с отношениями
            IEnumerable<Todo> todos = db.Todos.Include(c => c.User);
            ViewBag.Todos = todos;

            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Create(Todo todo)
        {
            //  добавим данные в базу
            // @todo реализовать авторизацию
            todo.User = db.Users.Find(1);
            db.Todos.Add(todo);
            db.SaveChanges();

            // вернем назад
            return RedirectToAction("Index", "Todo");
        }
    }
}