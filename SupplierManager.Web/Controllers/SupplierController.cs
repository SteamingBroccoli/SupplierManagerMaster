using System.Web.Mvc;
using SupplierManager.Service;
using SupplierManager.Service.Inputs;

namespace SupplierManager.Web.Controllers
{
    public class SupplierController : Controller
    {
		private readonly SupplierAppService _supplierAppService;

		public SupplierController(SupplierAppService supplierAppService)
		{
			_supplierAppService = supplierAppService;
		}

		// GET: Supplier
        public ActionResult Index()
        {
            return View();
        }

		/// <summary>
		/// 导航到Update页面并且携带原id参数
		/// </summary>
		/// <param name="supplierCode"></param>
		/// <returns></returns>
		public ActionResult Update(string supplierCode)
        {
	        TempData["supplierCode"] = supplierCode;
	        return View();
        }

		/// <summary>
		/// 修改供应商实体并重定向回展示页面
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[HttpPost]
        public ActionResult Update(SupplierAddInput input)
		{
			//Model验证通过
			if()
			{

                //重复
                if (_supplierAppService.IsCodeRepeat((string)TempData["supplierCode"]))
                {
					//返回失败信息
                }
                else
                {
                    _supplierAppService.UpdateSupplier(input);
					//重定向
                }
            }
			//返回验证失败信息
			return View();
		}

	}
}