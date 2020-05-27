using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Global_Intern.Models;

namespace Global_Intern.Controllers
{
    public class UserController : Controller
    {
       [HttpGet]
       public ActionResult Registeration()
        {
            return View();
        }

    }
}