using DuyetPhieu.Shared;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service.IService
{
	public interface IUserService
	{
		Task<ResultModel> Login(LoginModel model);
		Task<ResultModel> Logout(string username);
		Task<string> GiaiNen(string password);
	}
}
