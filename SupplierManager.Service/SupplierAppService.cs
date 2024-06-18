using System.Linq;
using SupplierManager.Domain.Entities;
using SupplierManager.Repository;
using SupplierManager.Service.DataObjects;
using SupplierManager.Service.Inputs;

namespace SupplierManager.Service
{
	public class SupplierAppService : ISupplierAppService
	{
		private readonly SupplierRepository _repository;

		public SupplierAppService(SupplierRepository repository)
		{
			_repository = repository;
		}


		/// <summary>
		/// 先分页后进行映射得到分页表
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public QueryViewModel GetQueryViewModel(SupplierDtoQueryInput input)
		{
			int pageNumber = input.PageNumber;
			int pageSize = input.PageSize;
			var suppliers = _repository.GetSuppliersPagedList(pageNumber, pageSize);
			var supplierTypes = _repository.GetSupplierTypes();
            var query = from supplier in suppliers
							join supplierType in supplierTypes on supplier.TypeCode 
								equals supplierType.TypeCode
                        select new SupplierDto
                        {
                            SupplierCode = supplier.SupplierCode,
                            Name = supplier.Name,
                            Abbreviation = supplier.Abbreviation,
                            TypeName = supplierType.TypeName,
                            Province = supplier.Province,
                            City = supplier.City,
                            Address = supplier.Address,
                            Remark = supplier.Remark,
                            IsValue = supplier.IsValue
                        };
			QueryViewModel queryViewModel = new QueryViewModel
			{
				List = query.ToList(),
				PageNumber = pageNumber,
				PageSize = pageSize,
			};
			return queryViewModel;
		}

		/// <summary>
		/// 创建供应商
		/// </summary>
		/// <param name="input"></param>
		public void AddSupplier(SupplierAddInput input)
		{
			Supplier supplier = new Supplier
			{
				SupplierCode = input.SupplierCode,
				Name = input.Name,
				Abbreviation = input.Abbreviation,
				City = input.City,
				Province = input.Province,
				Remark = input.Remark,
				Address = input.Address,
				IsValue = input.IsValue,
				TypeCode = input.TypeCode
			};
			_repository.InsertSupplier(supplier);
			return;
		}

		/// <summary>
		/// 更新供应商
		/// </summary>
		/// <param name="input"></param>
		public void UpdateSupplier(SupplierAddInput input)
		{
			Supplier supplier = _repository.GetSupplierByCode(input.SupplierCode);
			supplier.Update(input.SupplierCode, input.Name, input.Abbreviation, input.TypeCode, input.Province, input.City, input.Address, input.Remark, input.IsValue);
			_repository.UpdateSupplier(supplier);
			return;
		}

		/// <summary>
		/// 根据编号删除供应商
		/// </summary>
		/// <param name="input"></param>
		public void DeleteSupplier(SupplierDeleteInput input)
		{
			_repository.DeleteSupplierByCode(input.SupplierCode);
			return;
		}

		/// <summary>
		/// 根据SupplierCode查询是否除了该SupplierCode外还有相同SupplierCode的实体
		/// </summary>
		/// <param name="supplierCode"></param>
		/// <returns></returns>
		public bool IsCodeRepeat(string supplierCode)
		{
            var count = _repository.GetSuppliers().Count(e => e.SupplierCode == supplierCode);
			return count > 1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="supplierCode"></param>
		/// <returns></returns>
        public SupplierDto GetSupplierDtoByCode(string supplierCode)
        {
            var supplierDto = (from supplier in _repository.GetSuppliers()
								join supplierType in _repository.GetSupplierTypes() 
									on supplier.TypeCode equals supplierType.TypeCode
										where supplier.SupplierCode == supplierCode
                               select new SupplierDto
                               {
                                   SupplierCode = supplier.SupplierCode,
                                   Name = supplier.Name,
                                   Abbreviation = supplier.Abbreviation,
                                   TypeName = supplierType.TypeName,
                                   Province = supplier.Province,
                                   City = supplier.City,
                                   Address = supplier.Address,
                                   Remark = supplier.Remark,
                                   IsValue = supplier.IsValue
                               }).FirstOrDefault();
            return supplierDto;
        }
    }
}
