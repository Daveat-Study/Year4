Date 22/Feb/23
Time: 7:30am

<center><h1>Developing Model</h1></center>

<center><h2>Working with LINQ to SQL</h2></center>

    * Language Integrated Query (LINQ): គឺជាបណ្តុំបច្ចេកវិទ្យាដែលអនុញ្ញាតអោយស្នើពត៌មាន (ថែម កែ លុប ទាញយក) ទៅDatabaseដោយប្រើប្រាស់ភាសាសរសេរកម្មវិធីរបស់ Microsoft។

    |---------------------------------------------------------------------------------------------------|
    |SQL VS SQL Server                                                                                  |
    |                                                                                                   |
    |     - SQL (Structure Query Language) ជាសម្រាប់ធ្វើការស្នើថែមកែលុបទាញយកពត៌មានឬបង្កើតនិងកែរចនាសម្ព័ន្ធ  |
    |       Database ឬជាភាសា Database។                                                                 |
    |    - SQL Server ជាឈ្មោះរបស់ DBMS ល្បីមួយ។                                                             | 
    |    - DBMS (Database Management System) ប្រភេទកម្មវិធីប្រើជំនួយដល់ការបង្កើតនិងគ្រប់គ្រង Database។           |
    |____________________________________________________________________________________________________|

    |---------------------------------------------------------------------------------------------------|
    |SQL VS LINQ                                                                                        |
    |                                                                                                   |
    |    - SQL (Structure Query Language) ជាសម្រាប់ធ្វើការស្នើថែមកែលុបទាញយកពត៌មានឬបង្កើតនិងកែរចនាសម្ព័ន្ធ    |
    |       Database ឬជាភាសា Database។                                                                  |
    |    - SQL Server ជាឈ្មោះរបស់ DBMS ល្បីមួយ។                                                             | 
    |    - DBMS (Database Management System) ប្រភេទកម្មវិធីប្រើជំនួយដល់ការបង្កើតនិងគ្រប់គ្រង Database។           |
    |____________________________________________________________________________________________________|

    Example:
        - កែ Index action method អោយមាន Parameter ដែលទទួលយកទិន្នន័យដែលជាលក្ខខណ្ឌនៃការស្វែងរកភាពយន្តដែលស្គាល់ផ្នែកខ្លះនៃចំណងជើង

        Where keyword: choose horizontal

    * កែ Index view ដើម្បីបន្ថែម Form 1 ដែលមាន Textbox សម្រាប់អោយគេបញ្ចលលក្ខខណ្ឌព្រមទាំងដាក់ Button​ អោយគេស្វែងរកដូចខាងក្រោម:

    

-----------------------------------------

Date 17/Feb/23
Time: 7:30am

<center><h1>Add new field</h1></center>

<h2> Add validation </h2>

    DataAnnotations namespaceផ្តល់នូវគុណលក្ខណះ (Attributes) សម្រាប់ធ្វើការផ្ទៀងផ្ទាត់ភាពត្រឹមត្រូវនៃទិន្នន៍យ ដូចជា:
        - Required នឹងបង្ហាញឃ្លាកំហុសឆ្គងនៅពេលគេរំលងទិន្នន៍យចាំបាច់.
        - StringLength នឹងបង្ហាញឃ្លាកំហុសឆ្គងនៅពេលគេបញ្ចូលលើសឬខ្វះអក្សរ។
        - RegularExpression នឹងបង្ហាញឃ្លាកំហុសឆ្គងនៅពេលទិន្នន៍យបានបញ្ចូលខុសពីកន្សោមផ្ទៀងផ្ទាត់បានកំណត់ដូចជាផ្តើមដោយអក្សរធំ(Capital letter) បន្ទាប់មកអាចអក្សរលេខឬសញ្ញាយ៉ាងហើចណាស់១

<center><h1>Add new field</h1></center>

    ដើម្បីបន្ថែមជួរឈរថ្មីទៅក្នុងតារាងឬPropertyថ្មីទៅក្នុង Modal classតម្រូវអោយកែ Movie.cs បន្ទាប់មកកែ Viewដែលមាន User Interface​សម្រាប់អោយគេបញ្ចូលទិន្នន៍យថ្នីនឹងបង្ហាញទិន្នន៍យថ្មី

    បន្ទាប់មកកែ Action method របស់ controllerព្រមទាំងធ្វី Migrationដើម្បីកែ Database.

        - កែDocs Movie.cs បន្ថែម Rating Propery:
            public string? Rating { get; set; }

        - កែ Create.cshtml ដើម្បីអោយគេបញ្ចូលTextbox តម្លៃថ្មី

            <th>តម្លៃ</th>

            <div class="form-group">
                <label asp-for="Price" class="control-label"></label>
                <label asp-for="Price" class="form-label"></label>
                <span asp-validation-for="Rating" class="text-danger"></span>
            </div>

        - កែ Edit.cshtml ដើម្បីថែម TextBox សម្រាប់អោយគេកែ Rating.
            <div class="form-group">
                <label asp-for="Rating" class="control-label"></label>
                <label asp-for="Rating" class="form-label"></label>
                <span asp-validation-for="Rating" class="text-danger"></span>
            </div>

        
        - កែ Index.cshtml ដើម្បីថែម ក្បាលតារាងនឹងក្រឡាប្រឡោះ សម្រាប់បង្ហាញRating.

            <th>ការវាយតម្លៃ</th>

            @foreach(var movie in Model){

                <tr>
                    <td>@Html.DisplayFor(m => movie.Title)</td>
                    <td>@Html.DisplayFor(m => movie.ReleaseDate)</td>
                    <td>@Html.DisplayFor(m => movie.Genre)</td>
                    <td>@Html.DisplayFor(m => movie.Price)</td>
                    <td>@Html.DisplayFor(m => movie.Rating)</td>
                </tr>
            }

        - កែ Action method Create(Movie) : Task<IActionResult> នឹង Edit movieដើម្បីបន្ថែម Parameter Rating.

            * ថែម Rating into parameter:
                Create([Bind("Id, Title, ReleaseDate, Genre, Price, Rating")] Movie)
                Edit(int id, [Bind("Id, Title, ReleaseDate, Genre, Price, Rating")] Movie)

        - ធ្វើ Migration ដើម្បីថែមជួរឈរ Rating ទៅក្នុងតារាង Movie របស់ Database
        ដោយប្រើប្រាប់ Package Mananger Console វាយពាក្យបញ្ជាម្តងមួយៗដូចខាងក្រោម:

            Add-Migration Rating
            Update-Database.

        
