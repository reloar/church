using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class UploadsController : Controller
    {
        // GET: Uploads
        public ActionResult FileUpload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase[] files)
        {
            if (ModelState.IsValid)
            {
                foreach (HttpPostedFileBase file in files)
                {
                    if (file != null)
                    {
                        var inputfilename = Path.GetFileName(file.FileName);
                        var serverpath = Path.Combine(Server.MapPath("~/UploadedFiles/") + inputfilename);
                        file.SaveAs(serverpath);
                        ViewBag.UploadStatus = files.Count().ToString() + "files uploaded successfully.";
                    }
                }
            }
            return View();
        }
    }
}