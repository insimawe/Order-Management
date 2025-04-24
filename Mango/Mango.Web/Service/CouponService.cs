using Mango.Web.Models;
using Mango.Web.Service.IService;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        //we need to inject the BaseService to call the API
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
        };
        public Task<ResponseDto?> GetAllCouponAsync();
        public Task<ResponseDto?> GetCouponByIdsAsync(int id);
        public Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);
        public Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);
        public Task<ResponseDto?> DeleteCouponsAsync(int id);
    }
}
