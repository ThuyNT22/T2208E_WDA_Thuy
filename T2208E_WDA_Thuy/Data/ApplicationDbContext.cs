using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using T2208E_WDA_Thuy.Models;

namespace T2208E_WDA_Thuy.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<T2208E_WDA_Thuy.Models.Department>? Department { get; set; }
		public DbSet<T2208E_WDA_Thuy.Models.Employee>? Employee { get; set; }
	}
}