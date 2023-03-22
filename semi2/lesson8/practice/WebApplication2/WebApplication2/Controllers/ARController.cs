using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ARController : Controller
    {
        public IActionResult M3()
        {
            return View();

        }

        // return View(); របស់M3 action method និងផ្តល់ត្រលប់ទៅវិញនូវ​View
        // មួយដែលមានឈ្មោះដូចវាគឺ M3View។ ដូច្នេះដើម្បីឌំណើរការវាយើងត្រូវបង្កើត
        // M3 view (M3.cshtml) ជាមុនសិន។

        public IActionResult M33()
        {
            return View("Really Nigga");
        }

        // return View("Really nigga") របស់ ReturnSpecifiedView 
        // action method នឹងផ្តល់ត្រលប់ទៅវិញនូវ​ View មួយដែលមានឈ្មោះថា
        // Really Nigga view។ ដូច្នេះយើង្តរូវបង្កើត​ M3 Three view (M Three.cshtml)
        // មុនដំណើរការវា។

    }
}
