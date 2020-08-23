using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMvcTill22Aug.Models;

namespace WebMvcTill22Aug.ViewModel
{
	public class MovieGenreViewModel
	{
		public IEnumerable<Genre> Genres;
		public Movie Movie { get; set; }

	}
}