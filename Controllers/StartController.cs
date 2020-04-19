using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;
// Deploy https://docs.microsoft.com/en-us/azure-stack/user/azure-stack-dev-start-howto-vm-dotnet?view=azs-2002


namespace MvcMovie.Controllers
{
   public class StartController : Controller
    {
        //  kann als HTTP-Endpunkt aufgerufen werden. 
        // GET: /Start/

        public string Index()
        {
            return "Das ist eine nette kleine Zeile für Deinen MININT..";
        }

        //  kann als HTTP-Endpunkt aufgerufen werden. 
        // GET: /Start/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}