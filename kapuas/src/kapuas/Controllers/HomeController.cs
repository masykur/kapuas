using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace kapuas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var categories = new[] {
                new Models.Category() { Id = 1, Name = "Literature & Fiction" },
                new Models.Category() { Id = 2, Name = "Computer & Technology" },
                new Models.Category() { Id = 3, Name = "Love & Romance" },
                new Models.Category() { Id = 4, Name = "Historical" },
                new Models.Category() { Id = 5, Name = "Fantacy" },
                new Models.Category() { Id = 6, Name = "Science Fiction" },
                new Models.Category() { Id = 7, Name = "Children's" },
                new Models.Category() { Id = 8, Name = "Thrillers & Suspense" },
                new Models.Category() { Id = 9, Name = "Automotive" },
                new Models.Category() { Id = 10, Name = "Electrical & Electronics" },
                new Models.Category() { Id=11, Name = "Radiology & Nuclear Medicine" },
                new Models.Category() { Id=11, Name = "Fiendship" }
            };
            var books = new List<Models.Book>(new Models.Book[] {
                new Models.Book() { Id=1, ISBN = "1503948412", Title = "Golden Age (The Shifting Tides)", Author="James Maxwell", Price = 8.26M, Category = categories.Where(c=>c.Name=="Fantacy").FirstOrDefault() },
                new Models.Book() { Id=2, ISBN = "080241270X", Title = "The 5 Love Languages: The Secret to Love that Last", Author=" Gary D. Chapman", Price = 9.59M, Category = categories.Where(c=>c.Name=="Love & Romance").FirstOrDefault() },
                new Models.Book() { Id=3, ISBN = "0399162437", Title = "The Last Star: The Final Book of The 5th Wave", Author="Rick Yancey", Price=11.61M, Category = categories.Where(c=>c.Name=="Science Fiction").FirstOrDefault()},
                new Models.Book() { Id=4, ISBN = "1338099132", Title = "Harry Potter and the Cursed Child - Parts One & Two (Special Rehearsal Edition Script): The Official Script Book of the Original West End Production", Author ="J.K. Rowling", Price=17.99M, Category = categories.Where(c=>c.Name=="Children's").FirstOrDefault() },
                new Models.Book() { Id=5, ISBN = "1594633665", Title = "The Girl on the Train", Author = "Paula Hawkins", Price = 16.17M, Category = categories.Where(c=>c.Name=="Thrillers & Suspense").FirstOrDefault()},
                new Models.Book() { Id=6, ISBN = "1594633665", Title = "Understanding Machine Learning: From Theory to Algorithms", Author = "Gyuri Pápay, Gyuri Pápay", Price = 19.8M, Category = categories.Where(c=>c.Name=="Computer & Technology").FirstOrDefault()},
                new Models.Book() { Id=7, ISBN = "0071770569", Title = "Build Your Own Electric Vehicle, Third Edition", Author = "Seth Leitman and Bob Brant", Price = 21.08M, Category = categories.Where(c=>c.Name=="Automotive").FirstOrDefault()},
                new Models.Book() { Id=8, ISBN = "1680450263", Title = "Make: Electronics: Learning Through Discovery", Author = "Charles Platt", Price = 14.78M, Category = categories.Where(c=>c.Name=="Electrical & Electronics").FirstOrDefault()},
                new Models.Book() { Id=9, ISBN = "1449363334", Title = "Getting Started with Arduino: The Open Source Electronics Prototyping Platform (Make)", Author = "Massimo Banzi, Michael Shiloh", Price = 13.87M, Category = categories.Where(c => c.Name=="Electrical & Electronics").FirstOrDefault()},
                new Models.Book() { Id=10, ISBN = "0345457684", Title = "Altered Carbon (Takeshi Kovacs Novels)", Author = "Richard K. Morgan", Price = 13.87M, Category = categories.Where(c => c.Name=="Science Fiction").FirstOrDefault()},
                new Models.Book() { Id=11, ISBN = "0323377548", Title = "Diagnostic Imaging: Brain, 3e", Author = "Miral D. Jhaveri, Karen L. Salzman, A. James Barkovich", Price = 322.99M, Category = categories.Where(c => c.Name=="Radiology & Nuclear Medicine").FirstOrDefault()},
                new Models.Book() { Id=12, ISBN = "8132209060", Title = "Pattern Recognition and Machine Learning (Information Science and Statistics)", Author = "Christopher Bishop", Price = 82.25M, Category = categories.Where(c => c.Name=="Computer & Technology").FirstOrDefault()},
                new Models.Book() { Id=13, ISBN = "0984782850", Title = "Cracking the Coding Interview, 6th Edition: 189 Programming Questions and Solutions 6th Edition", Author = "Gayle Laakmann McDowell", Price = 19.99M, Category = categories.Where(c => c.Name=="Computer & Technology").FirstOrDefault()},
                new Models.Book() { Id=14, ISBN = "1782162143", Title = "Machine Learning with R", Author = "Brett Lantz", Price = 54.99M, Category = categories.Where(c => c.Name=="Computer & Technology").FirstOrDefault()},
                new Models.Book() { Id=15, ISBN = "1848000693", Title = "The Algorithm Design Manual 2nd Edition", Author = "Steven S Skiena", Price = 85.45M, Category = categories.Where(c => c.Name=="Computer & Technology").FirstOrDefault()}
            });
            var gallery = new Models.Gallery() { Books = books };
            return View(gallery);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
