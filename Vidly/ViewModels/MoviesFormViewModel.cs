using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MoviesFormViewModel
    {
        // List<Genre> not used because it only needs to be iterated through
        public IEnumerable<Genre> Genre { get; set; }
        
        // Movie
        public Movie Movie { get; set; }

        // Title
        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
        }
    }
}