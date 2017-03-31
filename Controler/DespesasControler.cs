using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DA2_2017_LABCOMPRAS.Models;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DA2_2017_LABCOMPRAS.Controler
{
    public class DespesasController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Entrada";
            return View();
        }

        [HttpGet]
        public IActionResult NovaDespesa()
        {
            //Models.Despesa product = new Models.Despesa("nova despesa",12,"Comida");
            return View();
        }
        [HttpPost]
        public IActionResult NovaDespesa(Despesa obj)
        {
          
            return View("Mostrar",obj);
        }
    }
}
