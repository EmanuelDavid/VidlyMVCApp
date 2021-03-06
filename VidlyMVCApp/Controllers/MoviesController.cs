﻿using System;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using VidlyMVCApp.BL;
using VidlyMVCApp.DL;
using VidlyMVCApp.Models;
using VidlyMVCApp.ViewModels;

namespace VidlyMVCApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var blVidly = new VidlyBL(new VidlyDLContext());

            var viewModel = new ShowMoviesViewModel {AllMovies = blVidly.GetMovies()};
            //view with different name then action
            return View("Index", viewModel);
        }

        public ActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveMovie(Movie movieToBeSaved, string btnSubmit)
        {
            if (movieToBeSaved == null) throw new ArgumentNullException(nameof(movieToBeSaved));

            if (btnSubmit.IsNullOrWhiteSpace()) throw new ArgumentNullException(nameof(btnSubmit));

            if (btnSubmit.Equals("Add Movie"))
            {
                if (ModelState.IsValid)
                {
                    var blVidly = new VidlyBL(new VidlyDLContext());
                    blVidly.SaveMovie(movieToBeSaved);
                    return RedirectToAction("Index");
                }

                return RedirectToAction("AddNew");
            }

            return RedirectToAction("Index");
        }

        public ActionResult TestValidationAttibute(Movie model)
        {

            return View(model);
        }
    }
}