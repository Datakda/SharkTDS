using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.Controllers
{
    public class RedirectController : Controller
    {  //https://localhost:44377/redirect?id=ssdsf&key=KEYWORDS
        //Request.Headers["User-Agent"].ToString()
        public IActionResult Index(string id,string key)
        {
            var ds3 = Request.Cookies.Count();

            if (id == null) 
            {
                return StatusCode(404);
                
            }





            return Content("ID="+id+" KEY="+key);


        }
    }
}
