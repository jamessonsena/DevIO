﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Areas.Pedidos.Controllers
{
    [Area("Pedidos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Busca()
        {
            return View("Busca");
        }
    }
}