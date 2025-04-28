using Mango.Web.CouponAPI.Model.Dto;
using Mango.Web.Models;
using Mango.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;
        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }
        public async Task<IActionResult> CouponIndex()
        {
            List<CouponDto>? couponList = new List<CouponDto>();

            //we need to call the API to get the list of coupons
            ResponseDto? response = await _couponService.GetAllCouponAsync();

            if(response != null && response.IsSuccess)
            {
                couponList = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(response.Result));
            }
            /*else
            {
                //if the API call fails, we need to show the error message
                TempData["error"] = response.ErrorMessages;
            }*/
            return View(couponList);
        }
    }
}
