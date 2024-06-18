using System.Data.Entity.ModelConfiguration;
using SupplierManager.Domain.Entities;


namespace SupplierManager.Repository.Configs
{
	public class SupplierTypeConfig : EntityTypeConfiguration<SupplierType>
	{
		/// <summary>
		/// 配置SupplierType的实体表名为Sys_SupplierType
		/// </summary>
		public SupplierTypeConfig()
		{
			ToTable("Sys_SupplierType");
			HasKey(e => e.TypeCode);
			Property(e => e.TypeCode).HasMaxLength(6).IsRequired();
			Property(e => e.TypeName).HasMaxLength(4).IsRequired();
		}

	}
}
