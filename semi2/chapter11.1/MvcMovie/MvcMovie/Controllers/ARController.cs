using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class ARController : Controller
    {
        public IActionResult M3(){ return View(); }
        /* return View(); របស់ M3 action method នឹងផ្តល់ត្រលប់ទៅវិញនូវ view
         * មួយដែលមានឈ្មោះដូចវាគឺ M3 view។ ដូច្នេះដើម្បីដំណើរការវាយើងត្រូវបង្កើត
         * M3 view (M3.cshtml) ជាមុនសិន។
         */
        public IActionResult ReturnSpecifiedView()
        { return View("M Three"); }
        /* return View("M Three"); របស់ ReturnSpecifiedView 
         * action method នឹងផ្តល់ត្រលប់ទៅវិញនូវ view មួយដែលមានឈ្មោះថា 
         * M Three view។  ដូច្នេះយើងត្រូវបង្កើត M3 Three view (M​ Three.cshtml) 
         * មុនដំណើរការវា។
         */
        /*ធម្មតា controller តែងទទួលការស្នើតាមរយៈ browswer ទៅការស្នើនោះ
         * ទាក់ទងឬមិនទាក់ទងទៅនឹងការប្រើប្រាស់មូលទិន្នន័យក៏ដោយ ហើយពេលដែល
         * cotroller ត្រូវបញ្ជូនទិន្នន័យឱ្យ View ប្រាស់ប្រាស់នោះមាន វត្ថុពីរដែលជ្រើស
         * យកមកប្រើគឺ ViewData និង ViewBag។
         *  ផ្ទុកទិន្នន័យក្នុង ViewData និង ViewBag
         *      ViewData[key]=ទិន្នន័យ;
         *      ViewBag.property=ទិន្នន័យ;
         *  ទាញទិន្នន័យពី ViewData និង ViewBag មកប្រើ
         *      ViewData[key]
         *      ViewBag.property
         *      ***សម្គាល់ 
         *             ករណីប្រើជាផ្នែកមួយនៃភាសាHTML ត្រូវសរសេរ @ នៅពីមុខ
                        ViewData ឬ ViewBag
                        Key គឺជាឈ្មោះសម្គាល់ធាតុនៃ associative array
                        property គឺលក្ខណៈសម្បត្តិដែលបង្កើតហើយអាចប្រើភ្លាមៗ
         */
        public IActionResult ControllerPassDataToView(int id,
            string name){
            ViewData["StuID"] = id; // ផ្ទុកទិន្នន័យក្នុង ViewData
            ViewData["StuName"] = name;
            ViewBag.StuID = id; //​ ផ្ទុកទិន្នន័យក្នុង ViewBag
            ViewBag.StuName = name;
            return View("Data"); }
        public IActionResult helper() {return View();}
    }
        
}
