using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SupplierManager.Domain.Entities;

namespace SupplierManager.Repository
{
    /// <summary>
    /// 实现demo仓储接口功能
    /// </summary>
    public class SupplierRepository : ISupplierRepository
	{
		private readonly SupplierDbContext _dbContext;

		public SupplierRepository(SupplierDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public IQueryable<Supplier> GetSuppliersPagedList(int pageNumber, int pageSize)
		{
			var result = _dbContext.Suppliers.OrderByDescending(p => p.SupplierCode).Skip((pageNumber - 1) * pageSize).Take(pageSize);
			return result;
		}

		/// <summary>
		/// 根据供应商编号查询获取对象
		/// </summary>
		/// <param name="supplierCode"></param>
		/// <returns>根据id查出来的对象</returns>
		public Supplier GetSupplierByCode(string supplierCode)
		{
			return _dbContext.Suppliers.FirstOrDefault(e => e.SupplierCode == supplierCode);
		}

		/// <summary>
		/// 更新供应商实体
		/// </summary>
		/// <param name="supplier"></param>
		public void UpdateSupplier(Supplier supplier)
		{
            _dbContext.Entry(supplier).State = EntityState.Modified;
			_dbContext.SaveChangesAsync();
        }

		/// <summary>
		/// 插入Supplier实体
		/// </summary>
		/// <param name="supplier"></param>
		public void InsertSupplier(Supplier supplier)
		{
			_dbContext.Suppliers.Add(supplier);
			_dbContext.SaveChangesAsync();
			return;
		}

		/// <summary>
		/// 根据编号删除supplier
		/// </summary>
		/// <param name="supplierCode"></param>
		public void DeleteSupplierByCode(string supplierCode)
		{
			_dbContext.Suppliers.Remove(GetSupplierByCode(supplierCode));
			_dbContext.SaveChangesAsync();
			return;
		}

		/// <summary>
		/// 获取suppliers实体表待查询逻辑
		/// </summary>
		/// <returns></returns>
        public IQueryable<Supplier> GetSuppliers()
        {
			return _dbContext.Suppliers;
        }
        /// <summary>
        /// 获取supplierTypes实体表待查询逻辑
        /// </summary>
        /// <returns></returns>
        public IQueryable<SupplierType> GetSupplierTypes()
        {
			return _dbContext.SupplierTypes;
        }
     
    }
}