using Microsoft.AspNetCore.Mvc;
using SharkTDS.Service;
using SharkTDS.ViewModels.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.Controllers
{
    public class SettingController : Controller
    {
        private UserContext db;
        public SettingController(UserContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var setting = db.Settings.FirstOrDefault();

            SettingIndexModel model = new SettingIndexModel();
            if (setting != null) 
            {
                model = ViewModelToModel.ConvertSettingToSettingIndexModel(setting);
            }

           

            return View(model);


        }

        [HttpPost]
        public IActionResult Index(SettingIndexModel model)
        {

            var setting = ViewModelToModel.ConvertSettingIndexModelToSetting(model);

            db.Settings.Update(setting);


            db.SaveChanges();
            return View(model);


        }

    }
}
