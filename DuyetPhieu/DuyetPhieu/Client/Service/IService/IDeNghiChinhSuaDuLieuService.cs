using BlazorInputFile;
using DuyetPhieu.Shared;
using DuyetPhieu.Shared.ChinhSuaDuLieu.Details;
using DuyetPhieu.Shared.ChinhSuaDuLieu.In;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service.IService
{
	public interface IDeNghiChinhSuaDuLieuService
	{
		Task<ResultModel> InsertPhieuDeNghiChinhSua(EmsDeNghiChinhSuaDuLieuInModel model);
		Task<IEnumerable<EmsDeNghiChinhSuaDuLieuModel>> ListPhieuDeNghiChinhSua();
		Task<IEnumerable<UploadedFile>> getFile();
	}
}
