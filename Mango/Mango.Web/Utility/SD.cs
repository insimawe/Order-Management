namespace Mango.Web.Utility
{
    public class SD
    {
        public static string CouponAPIBase { get; set; } = "https://localhost:44300/";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
