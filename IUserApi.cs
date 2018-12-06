using ExpenseManager.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFClient
{
	public interface IUserApi
	{
		[Get("/api/Users/GetUser/{user}")]
		Task<User> GetUser(string user);

		[Get("/api/Users/GetUsers/")]
		Task<User> GetAllUsers();

		[Get("/api/Users/GetUserByLogin/{loginname}")]
		Task<User> GetUserByLoginName(string loginName);
	}
}
