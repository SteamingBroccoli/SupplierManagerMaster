using System.Data.Entity.ModelConfiguration;
using SupplierManager.Domain.Entities;

namespace SupplierManager.Repository.Configs
{
	/// <summary>
	/// 配置supplier实体的表配置
	/// </summary>
	class SupplierConfig : EntityTypeConfiguration<Supplier>
	{
		public SupplierConfig()
		{
			ToTable("Sys_Supplier");
			HasKey(e => e.SupplierCode);
			Property(e => e.SupplierCode).IsRequired().HasMaxLength(6);
			Property(e => e.Name).IsRequired().HasMaxLength(10);
			Property(e => e.TypeCode).IsRequired().HasMaxLength(2);
			Property(e => e.Abbreviation).HasMaxLength(10);
			Property(e => e.City).HasMaxLength(8);
			Property(e => e.Province).HasMaxLength(8);
			Property(e => e.Address).HasMaxLength(20);
			Property(e => e.Remark).HasMaxLength(50);
		}
	}
}
