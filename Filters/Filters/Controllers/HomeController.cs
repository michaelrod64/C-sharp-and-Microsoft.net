using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {



        [SimpleMessage(Message="A")]
        [SimpleMessage(Message="B")]
        public string Indexs() {
            return "This is the controller";
        }






       [Authorize(Users= "adam, steve, jacqui", Roles = "admin")]
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }

       [HandleError(ExceptionType= typeof(ArgumentOutOfRangeException), View = "RangeError"]
       public string RangeTest(int id)
       {
           if (id > 100)
           {
               return String.Format("The id value is: {0}", id);
           }
           else
           {
               throw new ArgumentOutOfRangeException("id", id, ""); 
           }
       }
        [ProfileAction]
        [ProfileResult]
        [ProfileAll]
        public string FilterTest() {
            return "This is the FilterTest action";
        }


    }
}
