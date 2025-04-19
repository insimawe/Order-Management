using System.Security.AccessControl;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Models
{
    public class RequestDto
    {
        /// This class is used to create a request object for API calls (we create enums for the type of request)
        public ApiType ApiType { get; set; } = ApiType.GET;
        //This is used to passed URL Link
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; } 
    }
}
