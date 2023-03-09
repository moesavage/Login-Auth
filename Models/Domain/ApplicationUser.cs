using System;
using Microsoft.AspNetCore.Identity;

namespace Authorole.Models.Domain
{
	public class ApplicationUser : IdentityUser
	{
		public string Name { get; set; }

		public string ? ProfilePicture {get; set; }
	}
}

