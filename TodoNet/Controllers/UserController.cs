using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using TodoNet.Models;

namespace TodoNet.Controllers
{
    public class UserController : Controller
    {
        Context db = new Context();

        [Authorize]
        // logout handler
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Todo");
        }

        [HttpGet]
        // login form
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // login handler
        public ActionResult Login(Login login)
        {
            User user = null;

            if (ModelState.IsValid)
            {
                user = db.Users.FirstOrDefault(u => u.Email == login.Email && u.Password == login.Password);

                if (user != null)
                {
                    // login user & redirect
                    FormsAuthentication.SetAuthCookie(login.Email, true);
                    return RedirectToAction("Index", "Todo");
                }
                else
                {
                    ModelState.AddModelError("Email", "The selected Email is invalid");
                }
            }

            return View(login);
        }

        [HttpGet]
        // register form
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // register handler
        public ActionResult Register(Register register)
        {
            User user = null;

            // is valid model data
            if (ModelState.IsValid)
            {
                // search user in database by email
                user = db.Users.FirstOrDefault(u => u.Email == register.Email);

                if (user == null)
                {
                    // create new user
                    db.Users.Add(new User
                    {
                        Name = register.Name,
                        Email = register.Email,
                        Password = register.Password
                    });

                    db.SaveChanges();

                    // login user & redirect
                    FormsAuthentication.SetAuthCookie(register.Email, true);
                    return RedirectToAction("Index", "Todo");
                }
                else
                {
                    // user exists
                    ModelState.AddModelError("Email", "The selected Email is invalid or already taken");
                }
            }

            return View(register);
        }
    }
}