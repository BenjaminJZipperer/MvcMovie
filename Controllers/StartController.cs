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