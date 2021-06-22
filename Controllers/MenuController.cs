using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Header()
        {
            #region MenuBar
            List<Models.Menu> headerList = new List<Models.Menu>
            {
                new Models.Menu{Header="Kurumsal Üyelik"},
                new Models.Menu{Header="Haberler"},
                new Models.Menu{Header="Projeler"},
            };
            return PartialView("_MenuHeader",headerList);
            #endregion
        }
    }
}