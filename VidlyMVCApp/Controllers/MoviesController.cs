using System.Web.Mvc;
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
            VidlyBL blVidly = new VidlyBL(new VidlyDLContext());

            ShowMoviesViewModel viewModel = new ShowMoviesViewModel{AllMovies = blVidly.GetMovies()};
            //view with different name then action
            return View("Index", viewModel);
        }

        public ActionResult AddNew()
        {
            return View();
        }
        [HttpPost]
        public void SaveMovie(Movie movieToBeSaved)
        {
            //return movieToBeSaved.Name;
        }
    }
}