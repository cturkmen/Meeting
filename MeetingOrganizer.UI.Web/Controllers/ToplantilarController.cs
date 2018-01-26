using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeetingOrganizer.UI.Web;
using MeetingOrganizer.UI.Web.Repo;

namespace MeetingOrganizer.UI.Web.Controllers
{
    public class ToplantilarController : Controller
    {
        private RepoBase _repoBase;

        public ToplantilarController() : this(new RepoBase()) { }

        public ToplantilarController(RepoBase repoBase)
        {
           _repoBase = repoBase;
        }

        // GET: Toplantilar
        public ActionResult Index()
        {
            var toplantilar = _repoBase.FindAll();
            return View(toplantilar);
        }
    }
}