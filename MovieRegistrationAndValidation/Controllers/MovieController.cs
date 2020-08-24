using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRegistrationAndValidation.Models;

namespace MovieRegistrationAndValidation.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Registration()
        {
            return View(new Movie());
        }

        public IActionResult Summary(Movie movie)
        {
            if (ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return View("Registration", movie);
            }
        }
    }
}
