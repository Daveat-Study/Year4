25/Jan/23 7:30-9:00
- ក្នុងsolution explorer ចុច​មកស្តាំលើ port កសារviewហើយជ្រើសយក Add បន្ទាប់មកពាក្យបញ្ចា New folder ដាក់ឈ្មោះអោយដូចទៅនឹងឈ្មោះ Controller
- ក្នុង Add New Item ជ្រើសយក Razor View - Empty នឹងដាក់ឈ្មោះសម្គាល់ View តាមសេចក្តីត្រូវការជាក់ស្តែងព្រមទាំងចុច Btn​ add ជាការស្រេច

17/Jan/23 7:30-9:00

ដើម្បីបង្កើត MVC.net ក្នុង VS អ្នកអាចជ្រើសយក Project Templete ដូចខាងក្រោម:
    - Web Application (Model-View-Controller)
    - ASP.NET Core Web App (Model-View-Controller)
    - ASP.NET Core Web App (Model-View-Controller)

* Multi line
@*  *@

* Single Line
@ {

}

Developing Controllers

* Creating Controllers

    បន្ទាប់ពីបង្កើត ASP.net application អ្នកអាចបង្កើត Controller ថ្មី ដោយអនុវត្តជំហានដូចខាងក្រោម:
    
    - ក្នុង Solution explorer របស់ គម្រោងដែលបានបើក ចុចមកស្តាំ Controller រើសយកពាក្យបញ្ជា App បន្ទាប់មករើសយកពាក្យបញ្ជា Controller។

    នៅក្នុង add new Scaffolded item ជ្រើសយក MVC Controller បន្ទាប់មកចុចលើ Btn add.

    នៅក្នុង add new item ដាក់ឈ្មោះអោយ Controller ថា Hello World ហើយចុចលើ Btn add ជាការស្រេច.

* Defining Action Methods

* Mapping URLs To Action Methods
    កាលណាចុច F5 ដើម្បី run application នោះវានឹងដំណើរការ Index action របស់ Home Controller

    ដូច្នេះដើម្បីដំណើរការ Index ឬ Welcome របស់ Helloworld Controller ត្រូវវាយបន្ថែមខាងក្រោយ Web address \ ឈ្មោះ Controller \ឈ្មោះ action method

    For Ex: https://localhost:7251/helloworld/welcome

    ដើម្បីអោយ action method របស់ controller ណាមួយ ដំណើរការដោយស្វ័យប្រវត្តិ ចូរបើកឯកសាររបស់ cs ដែលនៅខាងក្បាល Solution Explorer ហើយឆ្ពោះទៅកាន់ផ្នែក app.MapControllerRoute ដោយកែ Home ជា hellworld ឯ Index ជា welcome

--------------------------------------

11/Jan/23 7:30-9:00

* Understanding MVC Execution Process

--(request)-> Controller --(response)-> View

-----------------------------------------------
--(request)-> Controller <--(response)-> Model |
-----------------------------------------------|
                  |
                  \                  
                   \> View

* Building an ASP.NET MVC Applicatioin Using Visual Studio

Visual Studio

Choose: MVC
1. 
2. Download ASP.NET Core Web App (Model-View-Controller)

Note:
- អត់ Core .netframework
- មan Core .net
- ការដាក់ឈ្មោះ project គឺជាការជ្រើសរើសឈ្មោះ namespace ដែលវាតំណាងអោយការចាប់ផ្តើមកម្មវិធី

--------------------------------------

ASP.NET MVC Application Architecture

- The MVC separates the user interface (UI) of an application into three main aspects.
- The Model: A set of classes that describes the data you're working with as well as the business rules for how the data can be changed and manipulated
- The View: Defines how the applicatioin's UI will be displayed.
- The Controller: A set of classes that handles communication from the user, overall application flow, and application-specific logic.

* Class ជា

* View ជា webpage ដែលអាចបន្ថែម code C# គឺត្រង់ណាមាន database ត្រង់នោះថែមកូដ C#.

* Controller ជាវត្ថុដែលទទួលដោះស្រាយសំណើហើយអោយលទ្ធផលតាមរយៈ user-interface.

Virtual host allow us store website out of drive c and work on wamp as normal.