using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Global_Intern.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using System.Web;
namespace Global_Intern.Controllers
{
    public class AdminController : Controller
    {
        List<User> users = new List<User>();
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult UserList(List<User> users)
        {
           
            users.Add(new User() { UserId = 1, UserFirstName = "Jane", UserLastName = "Smith", UserEmail = "Jane@gamil.com", UserHomeCountry = "Nz", UserCurrentCountry = "nz", UserPhone = 12345, UserGender = "Female" });
            users.Add(new User() { UserId = 2, UserFirstName = "Mark", UserLastName = "Nick", UserEmail = "Jane@gamil.com", UserHomeCountry = "Nz", UserCurrentCountry = "nz", UserPhone = 12345, UserGender = "Female" });

            return View(users);
        }
        public ActionResult ViewUser(int id)
        {
            User user = users.FirstOrDefault(c => c.UserId == id);
            if(user==null)
            {
                return new HttpNotFoundResult();
            }
            else {
                return View(user);
            }
             
        }
    }

    public class HttpNotFoundResult : ActionResult
    {
        private const int NotFoundCode = 404;
        public override void ExecuteResult(ActionContext context)
        {
            if(context==null)
            {
                throw new ArgumentNullException("context");
            }
            context.HttpContext.Response.StatusCode = NotFoundCode;
        //    base.ExecuteResult(context);
        }
    }
}