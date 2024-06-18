using SupplierManager.Domain.Entities;
using System.Collections.Generic;
using System.Linq;


/*
 * 直接操作实体
 */

namespace SupplierManager.Repository
{
	/// <summary>
	/// 用来定于demo仓储功能的接口
	/// </summary>
	public interface ISupplierRepository
	{
        //获取分页后的Supplier实体表(未执行的sql)
        IQueryable<Supplier> GetSuppliersPagedList(int pageNumber, int pageSize);
        //获取Supplier实体表待查逻辑(未执行的sql)
        IQueryable<Supplier> GetSuppliers();
        //获取SupplierType实体表待查逻辑(未执行的sql)
        IQueryable<SupplierType> GetSupplierTypes();
        //根据supplierCode查询实体
        Supplier GetSupplierByCode(string supplierCode);
		//更新supplier
		void UpdateSupplier(Supplier supplier);
		//插入supplier
		void InsertSupplier(Supplier supplier);
		//根据supplierCode删除supplier
		void DeleteSupplierByCode(string supplierCode);


    }
}
