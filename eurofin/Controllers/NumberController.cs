using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using eurofin.Models;

namespace eurofin.Controllers
{
    public class NumberController : Controller
    {
        private readonly AppDbContext _context;

        public NumberController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int startNumber = 1, int endNumber = 100)
        {
            List<string> result = new List<string>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("Eurofins");
                else if (i % 3 == 0)
                    result.Add("Three");
                else if (i % 5 == 0)
                    result.Add("Five");
                else
                    result.Add(i.ToString());
            }

            _context.NumberDisplays.Add(new NumberDisplay { StartNumber = startNumber, EndNumber = endNumber, Timestamp = DateTime.Now });
            _context.SaveChanges();

            return View(result);
        }
    }
}
