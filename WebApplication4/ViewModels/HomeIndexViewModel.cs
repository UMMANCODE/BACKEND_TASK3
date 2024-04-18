using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.ViewModels {
	public class HomeIndexViewModel {
		public readonly List<Service> Services;
		public readonly List<Feature> Features;

		public HomeIndexViewModel(List<Service> services, List<Feature> features) {
			Services = services;
			Features = features;
		}
	}
}
