using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Pass_Value.Controllers
{
    public class PassValueFromJavascriptToActionController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult OnSubmit()
        {
            var hiddenValue =Convert.ToString(HttpContext.Request.Form["hiddenValue"][0]);

            ViewBag.Data = hiddenValue;

            return View("Index");
        }
    }
}