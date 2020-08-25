using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRegistrationAndValidation.Models;


namespace MovieRegistrationAndValidation.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> favoritesList = new List<Movie>(); 
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
        public IActionResult SaveMovieToFavoritesList(Movie movie)
        {
            string movieListJSON = HttpContext.Session.GetString("MovieListSession") ?? "EmptySession";
            if (movieListJSON != "EmptySession")
            {
                favoritesList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
            } 
            favoritesList.Add(movie);

            movieListJSON = JsonSerializer.Serialize(favoritesList);

            HttpContext.Session.SetString("MovieListSession", movieListJSON);

                return View(favoritesList); 
        }
    }
}
