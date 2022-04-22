using Microsoft.EntityFrameworkCore;

namespace DuyetPhieu.Server.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(
		  DbContextOptions options) : base(options)
		{
		}
	}
}
