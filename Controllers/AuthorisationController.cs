using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Global_Intern.Models;

namespace Global_Intern.Controllers
{
    public class AuthorisationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ViewUser(User postedUser)
        {
            User users = new User();
            users.UserId = Guid.NewGuid().ToString();
            users.UserFirstName = postedUser.UserFirstName;
            users.UserLastName = postedUser.UserLastName;
            users.UserEmail = postedUser.UserEmail;
            users.UserPassword = postedUser.UserPassword;
            users.UserHomeCountry = postedUser.UserHomeCountry;
            users.UserCurrentCountry = postedUser.UserCurrentCountry;
            users.UserPhone = postedUser.UserPhone;
            users.UserGender = postedUser.UserGender;
            return View(users);



        }
        public ActionResult AddUser()
        {
            return View();
        }
    }
}