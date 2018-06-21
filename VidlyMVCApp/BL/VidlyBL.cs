using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMVCApp.DL;
using VidlyMVCApp.Models;

namespace VidlyMVCApp.BL
{
    public class VidlyBL
    {
        private VidlyDLContext _dlContext;

        //TODO: guess this should be done in DL
        public VidlyBL(VidlyDLContext dlContext)
        {
            _dlContext = dlContext;
        }
        internal List<Movie> GetMovies()
        {
            return _dlContext.Movies.ToList();
        }
    }
}