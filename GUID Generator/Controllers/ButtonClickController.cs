using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.InteropServices;

namespace GUID_Generator.Controllers
{
    public class ButtonClickController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Check(string button)
        {

            Guid g = Guid.NewGuid();
            System.Console.WriteLine(g);

            return View();
        }
    }
}
