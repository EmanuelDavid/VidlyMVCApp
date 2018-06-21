using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VidlyMVCApp.Models;

namespace VidlyMVCApp.DL
{
    public class VidlyDLContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}