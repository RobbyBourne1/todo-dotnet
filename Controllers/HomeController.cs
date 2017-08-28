using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todoDotnet.Models;
using todoDotnet.DataContext;

namespace todoDotnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly todoListContext _context;

        public HomeController(todoListContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Todos.ToList()); 
        }
 
        [HttpPost]
        public IActionResult Index(string NewItem)
        {
            var currentToDo = new TodoModel{
                TaskName = NewItem
            }; 

            _context.Add(currentToDo);
            _context.SaveChanges();

            return View(_context.Todos.ToList());
        }

        [HttpPost]
        public IActionResult IsComplete(int Id)
        {
            var finished = _context.Todos.FirstOrDefault(m => m.Id == Id);
            finished.Complete();
            _context.SaveChanges();
            return Redirect("Index");
        } 

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
