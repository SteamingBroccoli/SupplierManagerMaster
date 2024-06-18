namespace SupplierManager.Service.Inputs
{
	/// <summary>
	/// 编辑Supplier实体的请求输入
	/// </summary>
	public class SupplierAddInput
	{
		public string SupplierCode { get; private set; } //供应商编号
		public string Name { get; private set; } //供应商名称
		public string Abbreviation { get; private set; } //简称
		public string TypeCode { get; private set; } //类型编码
		public string Province { get; private set; } //省份
		public string City { get; private set; } //城市
		public string Address { get; private set; } //联系地址
		public string Remark { get; private set; } //备注
		public bool IsValue { get; private set; }//是否启用
	};
}