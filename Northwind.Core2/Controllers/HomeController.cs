using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Core2.Controllers
{
    public class HomeController : Controller
    {
        public string Index() => "This is Lambda";
    }
}