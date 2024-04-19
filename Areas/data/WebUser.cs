using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Areas.data
{
    public class WebUser:IdentityUser
    {
        public string FirstName {  get; set; }  
        public string LastName { get; set; }    

    }
}
