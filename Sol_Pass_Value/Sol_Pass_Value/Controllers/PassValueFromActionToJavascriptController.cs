using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Pass_Value.Models;

namespace Sol_Pass_Value.Controllers
{
    public class PassValueFromActionToJavascriptController : Controller
    {

        public PassValueFromActionToJavascriptController()
        {
            Demo = new DemoModel();
        }

        [BindProperty]
        public DemoModel Demo { get; set; }

        public IActionResult Index()
        {
           Demo.Message = "Kishor Naik";

            return View(Demo);
        }
    }
}