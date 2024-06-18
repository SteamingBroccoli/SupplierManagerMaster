using System.ComponentModel.DataAnnotations;

namespace SupplierManager.Service.DataObjects
{
	/// <summary>
	/// 由Supplier映射的dto，用于表示层展示需要展示的数据
	/// </summary>
	public class SupplierDto
	{
		[Display(Name = "供应商编号")]
		public string SupplierCode { get; set; } //供应商编号

		[Display(Name = "供应商名称")]
		public string Name { get; set; } //供应商名称

		[Display(Name = "简称")]
		public string Abbreviation { get; set; } //简称

		[Display(Name = "类型")]
		public string TypeName { get; set; } //类型

		[Display(Name = "省份")]
		public string Province { get; set; }//省份

		[Display(Name = "城市")]
		public string City { get;  set; } //城市

		[Display(Name = "联系地址")]
		public string Address { get;  set; } //联系地址

		[Display(Name = "备注")]
		public string Remark { get;  set; } //备注

		[Display(Name = "是否启用")]
		public bool IsValue { get;  set; }//是否启用
	}
}
