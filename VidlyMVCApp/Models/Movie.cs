using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VidlyMVCApp.Validations;

namespace VidlyMVCApp.Models
{
    [Table("tblMovies")]
    public class Movie
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Name of the movie is mandatory!")]
        [NameValidationAttribute]
        public string Name { get; set; }
    }
}