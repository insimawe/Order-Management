namespace Mango.Services.ShoppingCartAPI.Model.Dto
{
    public class CartDetails
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
