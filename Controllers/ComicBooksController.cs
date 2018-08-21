using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();
            /*if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday){
                return new RedirectResult("/");
            }
            return new ContentResult(){
                Content = "Hello from the comic book controller"
            };*/
            //return "Hello from the comic book controller";
        }
    }
}