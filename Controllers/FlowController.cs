using Microsoft.AspNetCore.Mvc;
using SharkTDS.Models;
using SharkTDS.Service;
using SharkTDS.ViewModels;
using SharkTDS.ViewModels.Flow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.Controllers
{
    public class FlowController : Controller
    {

        private UserContext db;
        public FlowController(UserContext context)
        {
            db = context;
        }


 

        [HttpGet]
        public IActionResult Add(int id)
        {
            ViewBag.id = id;

            return View();


        }

        [HttpPost]
        public IActionResult Add(FlowAddModel model)
        {
            Flow flow = new Flow();
            flow = ViewModelToModel.ConvertFlowAddModelToFlow(model);
            db.Flows.Add(flow);
            db.SaveChanges();
            return LocalRedirect($"~/Group/Edit/"+model.GroupId);
           
           

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var res = db.Flows.Where(x => x.Id == id).FirstOrDefault();
           var model = ViewModelToModel.ConvertFlowToFlowEditModel(res);
            return View(model);


        }

        [HttpPost]
        public IActionResult Edit(FlowEditModel model)
        {
            var result = ViewModelToModel.ConvertFlowEditModelToFlow(model);
            db.Flows.Update(result);
            db.SaveChanges();
            return LocalRedirect($"~/Group/Edit/" + model.GroupId);


        }

    }
}
