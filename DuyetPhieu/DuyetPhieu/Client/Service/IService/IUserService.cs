using DuyetPhieu.Shared;
using DuyetPhieu.Shared.Model;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service.IService
{
	public interface IUserService
	{
		Task<ResultModel> Login(LoginModel model);
		Task<ResultModel> Logout(string username);
		Task<string> GetDecrypt();
		Task<ListThongTinNhanVien> ListThongTinNhanVien();
	}
}
