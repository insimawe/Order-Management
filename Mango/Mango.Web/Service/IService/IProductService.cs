using Mango.Web.Model.Dto;
using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IProductService
    {
        //what will be the return type when we invoke the API?
        Task<ResponseDto?> GetProductAsync(string couponCode);
        Task<ResponseDto?> GetAllProductAsync();
        Task<ResponseDto?> GetProductByIdsAsync(int id);
        Task<ResponseDto?> CreateProductsAsync(ProductDto couponDto);
        Task<ResponseDto?> UpdateProductsAsync(ProductDto couponDto);
        Task<ResponseDto?> DeleteProductsAsync(int id);
    }
}
