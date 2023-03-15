using Buoi6_2.Models;
using Buoi6_2.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Buoi6_2.Controllers
{
	public class CoursesController : Controller
	{
		private readonly ApplicationDbContext _dbContext;
		// GET: Courses

		public CoursesController() {
			_dbContext = new ApplicationDbContext();
		}
		[Authorize]
		public ActionResult Create()
		{
			var viewModel = new CourseViewModel
			{
				Categories = _dbContext.Categories.ToList()
			};
			return View(viewModel);
		}
		[Authorize]
		[HttpPost]
		public ActionResult Create(CourseViewModel viewModel)
		{
			if (!ModelState.IsValid)
			{
				viewModel.Categories = _dbContext.Categories.ToList();
				return View("Create", viewModel);
			}
			var course = new Course
			{
				LecturerID = User.Identity.GetUserId(),
				DateTime = viewModel.GetDateTime(),
				CategoryId = viewModel.Category,
				Place = viewModel.Place

			};
			_dbContext.Courses.Add(course);
			_dbContext.SaveChanges();
			return RedirectToAction("Index", "Home");
		}
	}
}