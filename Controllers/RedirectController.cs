using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharkTDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Detection.Services;

namespace SharkTDS.Controllers
{
    public class RedirectController : Controller
    {  //https://localhost:44377/redirect?id=1
       //Request.Headers["User-Agent"].ToString()
       // var com = _detectionService.Device.Type.ToString();
        private UserContext db;
        private readonly IDetectionService _detectionService;
        public RedirectController(UserContext context, IDetectionService detectionService)
        {
            _detectionService = detectionService;
            db = context;
        }


        public IActionResult Index(string id, string key)
        {
            Group group = db.Groups.Include(u => u.Flows).Where(x => x.Identifier == id).FirstOrDefault();

            foreach (Flow fl in group.Flows) 
            {
                fl.Mobile;
               



            }
            
            if (!(id != null || group != null) || !group.GroupIsActive )
            {
                return Redirect(db.Settings.FirstOrDefault().TrashUrl);

            }

            
            

           





            return Content("ID="+id+" KEY="+key);


        }
    }
}
