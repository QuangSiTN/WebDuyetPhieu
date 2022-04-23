using DuyetPhieu.Shared.Model.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service.IService
{
	public interface ILoaiHangBHService
	{
		Task<IEnumerable<MnLoaiHangBhModel>> ListLoaiBaoHanh();
	}
}
