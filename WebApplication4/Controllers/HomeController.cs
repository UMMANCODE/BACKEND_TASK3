using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Data;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers {
	public class HomeController : Controller {
		private readonly DataContext _dataContext;

		public HomeController() {
			_dataContext = new DataContext();
		}

		public IActionResult Index() {
			HomeIndexViewModel viewModel = new HomeIndexViewModel(_dataContext.Services, _dataContext.Features);
			return View(viewModel);
		}

		public IActionResult Team() {
			return View(_dataContext.TeamMembers);
		}

		public IActionResult About() {
			return View();
		}

	}
}
