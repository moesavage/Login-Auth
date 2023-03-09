using System;
using Authorole.Models.DTO;

namespace Authorole.Repositories.Abstract
{
	public interface IUserAuthenticationService
	{

		Task<Status> LoginAsync(LoginModel model);

		Task<Status> RegisterAsync(RegistrationModel model);

		Task LogoutAsync();
	}
}

