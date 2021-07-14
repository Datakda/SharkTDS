using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharkTDS.Models;
using SharkTDS.Service;
using SharkTDS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.Controllers
{
    public class GroupController : Controller
    {
        private UserContext db;
        public GroupController(UserContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            AllGroupsModel model = new AllGroupsModel();
            model.Groups = db.Groups.ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Add(GroupAddModel modelAdd)
        {

            Group group = new Group();
            group = ViewModelToModel.ConvertGroupAddModelToGroup(modelAdd);
            db.Groups.Add(group);
            db.SaveChanges();

            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult Edit(int id)
        {
            Group group = new Group();
            group = db.Groups.Where(x => x.Id == id).FirstOrDefault();
           


            var model = ViewModelToModel.ConvertGroupToEditGroupModel(group);
            return View(model);

        }


        [HttpPost]
        public IActionResult Edit(EditGroupModel model)
        {
            Group group = new Group();

            group = ViewModelToModel.Convert(model);

            db.Groups.Update(group);
            db.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}
