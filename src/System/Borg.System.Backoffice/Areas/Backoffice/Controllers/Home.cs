﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Borg.System.Backoffice.Areas.Backoffice.Controllers
{

    public class HomeController : BackOfficeController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
