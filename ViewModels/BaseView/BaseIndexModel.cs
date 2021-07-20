using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.ViewModels.BaseView
{
    public class BaseIndexModel
    {
        public string MaxMindTime { get; set; }



        public BaseIndexModel() 
        {

            string path = @"Resourses\GeoLite2-City.mmdb";
            FileInfo fileInf = new FileInfo(path);

            if (!fileInf.Exists)
            {
                MaxMindTime = null;


            }

            MaxMindTime = fileInf.LastWriteTime.ToLongDateString() + " " + fileInf.LastWriteTime.ToLongTimeString();

        }
    }
}
