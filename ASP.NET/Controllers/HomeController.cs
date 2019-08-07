using ASP.NET.Models;
using ASP.NET.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        FolderRepository _folders;

        public HomeController()
        {
            _folders = new FolderRepository();
        }

        public ActionResult Root()
        {
            return View(_folders.GetRoot());
        }

        [HttpPost]
        public ActionResult GetFolder()
        {
            int id = Convert.ToInt32( Request.Form["ID"]);
            Folder fold = _folders.GetFolderWithChilds(id);
            return View("Root",fold);
        }

    }
}