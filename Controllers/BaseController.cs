using Microsoft.AspNetCore.Mvc;
using SharkTDS.Service;
using SharkTDS.ViewModels.BaseView;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SharkTDS.Controllers
{

    public class BaseController : Controller
    {
        private UserContext db;
        public BaseController(UserContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            BaseIndexModel model = new BaseIndexModel();

          
            return View(model);

        }

        public IActionResult UpdateMaxMind()
        {
            string path = @"Resourses";

            var key = db.Settings.FirstOrDefault().MaxMindKey;
            var url = "https://download.maxmind.com/app/geoip_download?edition_id=GeoLite2-City&license_key=" + key + "&suffix=tar.gz";
            using (var client = new WebClient())
            {
              
                client.DownloadFile(url, $@"{path}\GeoLite2.tar.gz");
            }
            string targetFile = "Resourses/GeoLite2.tar";
            string compressedFile = "Resourses/GeoLite2.tar.gz"; // сжатый файл
          
            Tar.UnzipGz(compressedFile, targetFile,path);
            string[] dirs = new string[1];
            if (Directory.Exists(path))
            {
                
                dirs = Directory.GetDirectories(path);
                FileInfo del = new FileInfo(path + @"\GeoLite2-City.mmdb");
                if (del.Exists)
                {
                    del.Delete();
                    // альтернатива с помощью класса File
                    // File.Delete(path);
                }


                FileInfo fileInf = new FileInfo(dirs[0]+ @"\GeoLite2-City.mmdb");
                if (fileInf.Exists)
                {
                    fileInf.CopyTo(path+ @"\GeoLite2-City.mmdb", true);
                    // альтернатива с помощью класса File
                    // File.Move(path, newPath);
                }
                
            }
            
            FileInfo fileInf1 = new FileInfo(path + @"\GeoLite2.tar.gz");
            if (fileInf1.Exists)
            {
                fileInf1.Delete();
                // альтернатива с помощью класса File
                // File.Delete(path);
            }

            FileInfo fileInf2 = new FileInfo(path + @"\GeoLite2.tar");
            if (fileInf2.Exists)
            {
                fileInf2.Delete();
                // альтернатива с помощью класса File
                // File.Delete(path);
            }
            
            Directory.Delete(dirs[0],true);
            

            return RedirectToAction("Index");

        }


    }
}
