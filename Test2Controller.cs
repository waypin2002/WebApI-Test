using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restful.Service;

namespace Restful.Controllers
{
    public class Test2Controller : Controller
    {
        CustomStyle custom = new CustomStyle();
        // GET: /Test2/
        public ActionResult Index()
        {
            return View();
        }

        public string getdata(string input)
        {
            string colorName = custom.colorName();
            string content = "<p>這是由Controller 發出的資料</p>";
            string html = string.Format("<div class='alert alert-{0}'>{1}{2}</div>", colorName, content, input);
            return html;
        }

    }
}