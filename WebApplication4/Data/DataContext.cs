using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Data {
	public class DataContext {
		public readonly List<Feature> Features;
		public readonly List<Service> Services;
		public readonly List<TeamMember> TeamMembers;

		public DataContext() {
			Features = new List<Feature> {
				new Feature {
					Title = "Lorem Ipsum",
					Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
				},
				new Feature {
					Title = "Dolor Sitema",
					Description = "Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"
				},
				new Feature {
					Title = "Sed ut perspiciatis",
					Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
				}
			};

			Services = new List<Service> {
				new Service {
					Title = "Lorem Ipsum",
					Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
				},
				new Service {
					Title = "Sed ut perspiciatis",
					Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"
				},
				new Service {
					Title = "Magni Dolores",
					Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"
				},
				new Service {
					Title = "Nemo Enim",
					Description = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"
				},
				new Service {
					Title = "Dele cardo",
					Description = "Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"
				},
				new Service {
					Title = "Divera don",
					Description = "Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"
				},

			};

			TeamMembers = new List<TeamMember> {
				new TeamMember {
					Name = "Walter White",
					Role = "Chief Executive Officer",
					Description = "Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut",
					Image = "team-1.jpg"
				},
				new TeamMember {
					Name = "Sarah Jhinson",
					Role = "Product Manager",
					Description = "Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus",
					Image = "team-2.jpg"
				},
				new TeamMember {
					Name = "William Anderson",
					Role = "CTO",
					Description = "Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara",
					Image = "team-3.jpg"
				}
			};
		}
	}
}
