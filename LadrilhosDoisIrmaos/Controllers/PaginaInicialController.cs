using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LadrilhosDoisIrmaos.Controllers
{
    public class PaginaInicialController : Controller
    {
        // GET: PaginaInicial
        public ActionResult Index()
        {
            return View();
        }
    }
}