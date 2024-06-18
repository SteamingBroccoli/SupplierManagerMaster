using System.Data.Entity;
using SupplierManager.Domain.Entities;
using SupplierManager.Repository.Configs;


namespace SupplierManager.Repository
{
	public class SupplierDbContext : DbContext
	{
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<SupplierType> SupplierTypes { get; set; }

		public SupplierDbContext()
			: base("MyConnectionString")
		{ }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			// Moved all Student related configuration to StudentEntityConfiguration class
			modelBuilder.Configurations.Add(new SupplierConfig());
			modelBuilder.Configurations.Add(new SupplierTypeConfig());
		}
	}
}
