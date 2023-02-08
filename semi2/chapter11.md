1/Feb/23 7:30-9:00

Chapter 11: Developing Models

    កូដខាងលើជាកេរដំណែលដែលជា Entity class ReleaseDate ហើយកំណត់ប្រភេទទិន្នន័យជាថ្មីដោយបញ្ជាក់ចំនួនក្រោយខ្បៀស២ខ្ជង់នឹងច្រើនបំផុតច្រើនខ្ទង

    * View មាន២:
        - View ប្រើរួមគ្នា​ Shared folder
        - View ដាច់ដោយឡែក ដាក់ក្នុង Controller

    *
        view ដែលមាន​​ @model នៅផ្នែកខាងលើ មានន័យថាប្រើ​Database បាន 
        view ដែលគ្មាន​​ @model នៅផ្នែកខាងលើ មានន័យថាប្រើ​Database បាន

    *
        មាន​​ IEmurable ប្រើ Data បានច្រើន 
        គ្មានមាន​​ IEmurable ប្រើ Data បានច្រើន

        បន្ទាត់ទេ៥មានន័យថា View រូម. បើសិនជាចង់ដូរ View រូមចូលទៅកែវា

    

--------------------------------------

1/Feb/23 7:30-9:00

Chapter 11: Developing Models

1). Creating Model classes.
    ក្នុង​Solution Explorer ចុច Mouse ស្តាំលើ Model folder ជ្រើសពាក្យ Add បន្ទាប់មកយកពាក្យបញ្ជាclassហើយដាក់ឈ្មោះសម្គាល់ថា​Movie.cs ​ដែលឈ្មោះនេះ​និងក្លាយទៅជាឈ្មោះTable ក្នុង Database ផងដែរ។


    កែអោយមានកូដដូចខាងក្រោម:
    using System.ComponentModel.DataAnnotation;

    namespace MvcMovie.Models;

    public class Movie{

        public int Id {get; set;}
        public string? Title { get; set;}
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

    }

    - សញ្ញាសួរនៅខាងមុខ dataType មានន៏យថាជួនមានតម្លៃ ជួនអត់តម្លៃ
    For instance: string?

    - ក្នុង tool menu នោះយកពាក្យបញ្ជា NuGet Package Mananger > Package Mananger Console (PMC) ដើម្បីបង្ហាញផ្ទាំង window ដែលអនុញ្ញាតអោយវាយពាក្យបញ្ជា ដើម្បីដំឡើងបញ្ចប់កម្មវិធីដូចខាងក្រោម

    => install Package Microsoft.VisualStudio.Web.CodeGeneration.Design
    កម្មវិធីជំនួយក្នុងការសរសេរកូដដោយស្វ៏យប្រវត្តិដោយគ្រាន់តែអ្នកផ្តល់នូវពត៌មាន១ចំនួនតែប៉ុណ្ណោះ​​ (Scaffoling)

    => install Package Microsoft.EntityFrameworkCore.Design
    ដំឡើងកម្មវិធីជំនួយដែលអាចអោយអ្នកប្រើប្រាប់ Database​ដោយតាមរយះវត្ថុ

    => install Package Microsoft.EntityFrameworkCore.SqlServer
    ដំឡើងកម្មវិធីជំនួយអោយអាចប្រើប្រាប់ Databaseរបស់Sql.server

    ក្នុង Build menu ជ្រើសរើសយក build solution
    Entity Framework (EF) គឺជា relation mapper (O/RM) ដែលអនុញ្ញាតអោយអ្នកអភិវឌ្ឍកម្មវិធីប្រើប្រាស់ database តាមរយះវត្ថុដែលជួយកាត់បន្ថយការសរសេរកូដដោយខ្លួនអែងបានយ៉ាងច្រើន

ស្វ៏យប្រវត្តិកម្មនិងការបង្កើតController view សម្រាប់អោយគេមើលពត៌មាន កែពត៌មាន និងលុបពត៌មានក្នុងតារាង Movie

    - ក្នុង solution explorer ចុចមកស្តាំមក controller ជ្រើសពាក្យបញ្ជា Add > New Scafolded Item.
    - នៅក្នុង New Scafolded Item dialog ជ្រើសរើស MVC Controller with views, using Entity Framework > Add
    - នៅក្នុង​ MVC controller Movie (MvcMovie.Models) ពី model.dropdown
    - នៅក្នុងជួរ Data context class ចុចលើ button ដែលមានសញ្ញា + 
    - Add Data Context dialog ចុច buttton add MvcMovie.Data.MvcMovieContext រក្សាឈ្មោះ View and Controller ដូចដើម​ហើយចុច​ Button add ដើម្បីផ្តើមដំណើរការ

    ក្នុង build menu ជ្រើសយក build solution

