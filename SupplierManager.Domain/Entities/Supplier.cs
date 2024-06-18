
using System;

namespace SupplierManager.Domain.Entities
{
	/// <summary>
	/// 供应商实体类
	/// </summary>
	public class Supplier
	{
		public string SupplierCode { get;  set; } //供应商编号
		public string Name { get;  set; } //供应商名称
		public string Abbreviation { get;  set; } //简称
		public string TypeCode { get;  set; } //类型编号
		public string Province { get;  set; } //省份
		public string City { get;  set; } //城市
		public string Address { get;  set; } //联系地址
		public string Remark { get;  set; } //备注
		public bool IsValue { get;  set; }//是否启用


		/// <summary>
		/// 修改实体
		/// </summary>
		/// <param name="supplierCode"></param>
		/// <param name="name"></param>
		/// <param name="abbreviation"></param>
		/// <param name="typeCode"></param>
		/// <param name="province"></param>
		/// <param name="city"></param>
		/// <param name="address"></param>
		/// <param name="remark"></param>
		/// <param name="isValue"></param>
		public void Update(string supplierCode, string name, string abbreviation, string typeCode,
			string province, string city, string address, string remark, bool isValue)
		{
			SupplierCode = supplierCode;
			Name = name;
			Abbreviation = abbreviation;
			TypeCode = typeCode;
			SupplierCode = supplierCode;
			City = city;
			Remark = remark;
			IsValue = isValue;
			Address = address;
			Province = province;
		}
	}
}
