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

            if (db.Flows.Where(x => x.GroupId == model.GroupId).Count() == 0)
            {
                flow.Identifier = 1;
            }

            else 
            {
                flow.Identifier = db.Flows.Where(x => x.GroupId == model.GroupId).Count() + 1;
            }
            
            db.Flows.Add(flow);
            db.SaveChanges();
            return RedirectToAction("Edit", "Group", new { id = model.GroupId });
            
           
           

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
            return RedirectToAction("Edit", "Group", new { id = model.GroupId });


        }

        public IActionResult DeleteFlow(int groupid, int identifier)
        {
            var flow = db.Flows.Where(x => x.GroupId == groupid).Where(i=>i.Identifier == identifier).FirstOrDefault();
            db.Flows.Remove(flow);
            var flows = db.Flows.Where(x => x.GroupId == groupid).ToList();
            flows.Remove(flow);          
            
            for (int i = 0; i < flows.Count(); ++i) 
            {
                flows[i].Identifier = i+1;
            
            }

            db.Flows.UpdateRange(flows);
            db.SaveChanges();
            return RedirectToAction("Edit", "Group", new { id = groupid });

        }

        public IActionResult IdentifierUp(int groupid, int identifier)
        {           
            if (identifier <= 1) 
            {
                return RedirectToAction("Edit", "Group", new { id = groupid });
            }
            var NeedUp = db.Flows.Where(g => g.GroupId == groupid).Where(i => i.Identifier == identifier).FirstOrDefault();
            var NeedDown = db.Flows.Where(g => g.GroupId == groupid).Where(i => i.Identifier == identifier-1).FirstOrDefault();

            NeedUp.Identifier -= 1;
            NeedDown.Identifier += 1;
            db.Flows.UpdateRange(NeedUp, NeedDown);
            db.SaveChanges();
            return RedirectToAction("Edit", "Group", new { id = groupid });


        }



        public IActionResult IdentifierDown(int groupid, int identifier)
        {
            var count = db.Flows.Where(x => x.GroupId == groupid).Count();

            if (identifier >= count) 
            {
                return RedirectToAction("Edit", "Group", new { id = groupid });

            }
            var NeedDown = db.Flows.Where(g => g.GroupId == groupid).Where(i => i.Identifier == identifier).FirstOrDefault();

            var NeedUp = db.Flows.Where(g => g.GroupId == groupid).Where(i => i.Identifier == identifier +1).FirstOrDefault();

            NeedDown.Identifier += 1;
            NeedUp.Identifier -= 1;
            db.Flows.UpdateRange(NeedUp, NeedDown);
            db.SaveChanges();


            return RedirectToAction("Edit", "Group", new { id = groupid });

        }

    }
}
