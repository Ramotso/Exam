using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace ExamProject.Controllers
{
    public class DropController : Controller
    {
        // GET: Drop
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFiles(IEnumerable<HttpPostedFileBase> files)
        {
            foreach (var file in files)
            {
                string filePath = Guid.NewGuid() + Path.GetExtension(file.FileName);
                file.SaveAs(Path.Combine(Server.MapPath("~/UploadedFiles"), filePath));
                //Here you can write code for save this information in your database later
            }

            return Json("file uploaded successfully");
        }
    }
}