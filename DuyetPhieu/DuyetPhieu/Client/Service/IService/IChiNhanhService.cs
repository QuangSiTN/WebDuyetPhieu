using DuyetPhieu.Shared.Model;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service.IService
{
	public interface IChiNhanhService 
	{
		Task<ListInformationChiNhanh> GetAllChiNhanh();
	}
}
