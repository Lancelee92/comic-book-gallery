using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using comic_book_gallery.Models;
using comic_book_gallery.Data;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);

/*
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
*/
            return View(comicBook);
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