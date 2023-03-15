using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buoi6_2.ViewModels
{
	public class CourseViewModel
	{
		[Required]
		public string Place { get; set; }
		[Required]
		public string Date { get; set; }
		[Required]
		public string Time { get; set; }
		[Required]
		public byte Category { get; set; }
		public IEnumerable<Models.Category> Categories { get; set; }

		public DateTime GetDateTime()
		{
			return DateTime.Parse(string.Format("{0} {1}", Date, Time));
		}
	}
}