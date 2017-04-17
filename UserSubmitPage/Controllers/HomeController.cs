using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserSubmitPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Upload()
        {
            foreach (string file in Request.Files)
            {
                var hpf = this.Request.Files[file];
                if (hpf.ContentLength == 0)
                {
                    continue;
                }

                string savedFileName = Path.Combine(
                         AppDomain.CurrentDomain.BaseDirectory, "PutYourUploadDirectoryHere");
                savedFileName = Path.Combine(savedFileName, Path.GetFileName(hpf.FileName));

                hpf.SaveAs(savedFileName);
            }
            return View();
        }
    }

}