
namespace demo.Service.Inputs
{
	/// <summary>
	/// 用于更新供应商的实体信息的请求输入
	/// </summary>
	public class SupplierUpdateInput
	{

		public string SupplierId { get; set; }
		public string Name { get; set; }

		public string Abbreviation { get; set; }

		public string SupplierType { get; set; }

		public string SupplierCode { get; set; }

		public string City { get; set; }

		public string Address { get; set; }

		public string Remark { get; set; }

		public string MainProduct { get; set; }

		public bool IsValue { get; private set; }
	};
}