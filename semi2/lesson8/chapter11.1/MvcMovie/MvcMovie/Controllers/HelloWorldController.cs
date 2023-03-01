using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "នេះជាដំណោះស្រាយដើម។";
        }
        public string Welcome()
        {
            return "សូមស្វាគមន៍មកកាន់ពិភព MVC app!";
        }
        public string Introduction(int ID, string Name)
        {
            return "I'm Mr. " + Name + " . My ID is " + ID;
        }
        /*ដើម្បីដំណើរវាយើងត្រូវវាយសញ្ញា?នៅក្រោយឈ្មោះ action ទើបបន្តសរសេរ
         * បញ្ជីប៉ារ៉ាម៉ែត្រដែលមានសញ្ញា&សម្រាប់ខណ្ឌចែកបា៉រា៉ម៉ែត្រនីមួយៗ។ រីឯប៉ារ៉ាម៉ែត្រ
         * ត្រូវសរសេរឈ្មោះប៉ារ៉ាម៉ែត្រ=តម្លៃរបស់ប៉ារ៉ាម៉ែត្រ។
         * ឧ. https://localhost:7251/helloworld/introduction
                ?id=777&name=chamroeun
         */
    }
}
