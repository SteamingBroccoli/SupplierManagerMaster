
namespace SupplierManager.Service.Inputs
{
	/// <summary>
	/// 用于查询供应商实体分页表的请求输入
	/// </summary>
	public class SupplierDtoQueryInput
	{
		//当前分页页数
		public int PageNumber { get; set; }
		//分页大小
		public int PageSize { get; set; }

	}
}
