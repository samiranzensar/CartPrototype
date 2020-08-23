using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMvcTill22Aug.Models
{
	public class Movie
	{
		
		public int Id { get; set; }
		[Required]
		[StringLength(40)]
		public string MName { get; set; }
		public Genre Genre { get; set; }
		public int GenreId { get; set; }
	}
}