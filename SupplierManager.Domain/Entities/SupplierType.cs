using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierManager.Domain.Entities
{
	/// <summary>
	///  供应商类型实体类，供应商的一个值对象
	/// </summary>
	public class SupplierType
	{
		public string TypeName { get; set; } //类型名称
		public string TypeCode { get; set; } //类型编号
	}
}
