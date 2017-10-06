using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Restful.Service;

namespace Restful.Controllers
{
    public class Test1Controller : ApiController
    {
        CustomStyle custom = new CustomStyle();

        public string getData()
        {
            string colorhtml = custom.colorName();
            string content = "<p>這是由Web Api 發出的資料</p>";
            string html = string.Format("<div class='alert alert-{0}'>{1}</div>", colorhtml, content);
            return html;
        }
    }
}
