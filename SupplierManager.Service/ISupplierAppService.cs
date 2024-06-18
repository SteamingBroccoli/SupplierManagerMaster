using SupplierManager.Service.DataObjects;
using SupplierManager.Service.Inputs;


//对仓储实体隔离


namespace SupplierManager.Service
{
	/// <summary>
	/// 用于定义SupplierAppService接口
	/// </summary>
	public interface ISupplierAppService
	{
		//分页查询
		QueryViewModel GetQueryViewModel(SupplierDtoQueryInput input);
		//增加供应商
		void AddSupplier(SupplierAddInput input);
		//更新供应商
		void UpdateSupplier(SupplierAddInput input);
		//删除供应商
		void DeleteSupplier(SupplierDeleteInput input);
		//根据Code查询是否重复
		bool IsCodeRepeat(string supplierCode);
		//根据Code获取Dto实体
		SupplierDto GetSupplierDtoByCode(string supplierCode);
	}
}