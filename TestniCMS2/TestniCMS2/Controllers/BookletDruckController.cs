using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestniCMS2.Models;

namespace TestniCMS2.Controllers
{
    public class BookletDruckController : Controller
    {
       // GET: BookletDruck
        public ActionResult Details()
        {
            //Bookletdruck bd = new Bookletdruck()
            //{
            //    PdfPath = null,
            //    Buchungsnummer = "No. 10744-2",
            //    BookletID = 4,
            //    LaufID = 4,
            //    Reisebeginn = Convert.ToDateTime("2016-06-02 00:00:00.000"),
            //    MessageTo = "m.foikis@lamberth.de",
            //    PassangerList = null,
            //    CreatedOn = Convert.ToDateTime("2016-05-11 13:56:22.210"),
            //    SentOn = Convert.ToDateTime("2016-05-11 13:56:22.210")
            //};
            BookletdruckContext bdc = new BookletdruckContext();
            List <Bookletdruck> bd = bdc.Booklets.ToList();

            return View(bd);
        }
    }
}