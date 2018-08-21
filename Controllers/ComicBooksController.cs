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
            if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday){
                return new RedirectResult("/");
            }
            return new ContentResult(){
                Content = "Hello from the comic book controller"
            };
            //return "Hello from the comic book controller";
        }
    }
}