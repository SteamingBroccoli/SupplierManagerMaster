using System.Collections.Generic;

namespace SupplierManager.Service.DataObjects
{
	/// <summary>
	/// 用于表示供应商实体表的视图模型
	/// </summary>
	public class QueryViewModel
	{
		/// <summary>
		/// 存储SupplierDto的列表
		/// </summary>
		public List<SupplierDto> List { get; set; }
		/// <summary>
		/// 当前页数
		/// </summary>
		public int PageNumber { get; set; }
		/// <summary>
		/// 分页大小
		/// </summary>
		public int PageSize { get; set; }
	}
}
