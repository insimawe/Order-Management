
using Microsoft.AspNetCore.Identity;

namespace Mango.Services.CouponAPI.Model
{
    public class ApplicationUser : IdentityUser
    {
       public string Name {  get; set; }
         
    }
}
