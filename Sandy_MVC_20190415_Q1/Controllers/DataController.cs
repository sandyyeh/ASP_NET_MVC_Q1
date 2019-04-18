using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandy_MVC_20190415_Q1.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(string name, string phone, string email)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);        
            string targetPath = Server.MapPath(@"~/App_Data");
            
            if (Directory.Exists(targetPath))
            {
                for (int i = 1; i >=1; i++)
                {
                    string fileName = "WriteLines"+i+".txt";
                    string targetFile = Path.Combine(targetPath, fileName);

                    if (System.IO.File.Exists(targetFile))
                    {                        
                        continue;                       
                    }
                    
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, Server.MapPath(@"~/App_Data/WriteLines" + i + ".txt"))))
                    {
                            outputFile.WriteLine("Name:" + name);
                            outputFile.WriteLine("Phone:" + phone);
                            outputFile.WriteLine("Email:" + email);
                            outputFile.WriteLine("----------------");  
                    }
                    string str = "WriteLines"+i+".txt";
                    ViewBag.Str = str;
                    break;                  
                }
            }
            
            return View();
        }
    }
}