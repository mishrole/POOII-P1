using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POOII_EL1_Rodríguez_León_Mitchell.Models;

namespace POOII_EL1_Rodríguez_León_Mitchell.Controllers
{
    public class ClientesController : Controller
    {

        static List<Cliente> Clientes = new List<Cliente>();

        // GET: Clientes
        public ActionResult Index()
        {
            return View(Clientes);
        }

        public ActionResult Create()
        {
            return View(new Cliente());
        }
    }
}