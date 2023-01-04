#### Date 21/Oct/22 - 7:30:9am 

### <center> Chapter 3: Javascript </center>

ជ្រើសធាតុមួយដែលមានអាយឌីសម្គាល់ ***feature***
> document.getElementById("#feature")

ជ្រើសរើសធាតុទាំងឡាយដែលាមានថ្នាក់សម្គាល់ next-image
> document.getElementyClassName("next-imag")

ជ្រើសរើសធាតុដែលគុណលក្ខណ៽ name មានតម្លៃ image-feature
> document.getElementByName("image-feature")

ជ្រើសធាតុ img ទំាអសស់
> document.getElementByTagName("img")

ជ្រើសធាតុមួយដូចដែលបានបញ្ជាក់ដោយ css selector
> document.querySelectorAll("ul-li")

ទាញយកតម្លៃគុណលក្ខណ៽នៃធាតុបានជ្រើសរើស
> អថេរតំណាងធាតុ.getAttribute("ឈ្មោះគុណលក្ខណះ")

ដាក់តម្លៃថ្មីអោយគុណលក្ខណះនៃធាតុបានជ្រើសរើស
> អថេរតំណាងធាតុ.getAttribute("ឈ្មោះគុណលក្ខណះ", "តម្លៃថ្មី")

TextContent:
innerHtml: សរសេរខ្លឹមសារក៏បាន

param ទី១:   ធាតុនៃArray
param ទី2:   ធាតុនៃArray
param ទី3:   ធាតុនៃArray


----------------------------------------------

#### Date 12/Oct/22 - 7:30:9am 

### <center> Chapter 3: Javascript </center>

- Box-sizing
- z-index and position

--------------------------------------------------

#### Date 12/Oct/22 - 7:30:9am 

### <center> Chapter 3: Javascript </center>

បង្កើតអឺរ៉េ (Array object)

> var | let | const ឈ្មោះអឺរ៉េ = [ទិន្នន័យទី១ ទិន្នន័យទី២ ទិន្នន័យទី៣]។ល។

ឬ

> var | let | const ឈ្មោះអឺរ៉េ = new Array (ទិន្នន័យទី១ ទិន្នន័យទី២ ទិន្នន័យទី៣)។ល។

បង្កើតកាលបរិច្ឆេទនិងពេលវេលា (Date object)
****

> var | let | const ឈ្មោះអឺរ៉េ = new Date();

ឬ

> var | let | const ឈ្មោះអឺរ៉េ = new Array (ឆ្នាំ, ខែកិតពីសូន្យ, ថ្ងៃ, ម៉ោង, នាទី, វិនាទី, មីលីវិនាទី);

var = global, function variable.

const reference
const value

ខែគិតពី Index 0

- កំណត់ width និង height ជាការកំណត់ស្នូល

- Anonymous function ឬ អនុគមន៏គ្មានឈ្មោះ :   ប្រើបានម្តងដើរដោយមិនបាច់ហៅ

* <b> Math object </b>

    - Math.round(លេខទសភាគ) បង្គត់ឡើងបើផ្នែកទសភាគចាប់ពី៥ឡើង
                             បង្គត់ចុះបើផ្នែកទសភាគតូចជាង5

    - Math.cell(លេខទសភាគ) បង្កត់ឡើង
    - Math.floor(លេខទសភាគ) បង្កត់ចុះ
    - Math.random() ផ្តល់លេខទសភាគដោយចៃដន្យចាប់សូន្យដល់តូចជាងមួយ។

* <b>  រូបមន្តបង្កើតលេខចៃដន្យចន្លោះminនិងmax </b>
    - Math.floor(Math.random() * (max - min + 1)) + min;

* ខ. បង្កើតលេខចៃដន្យចន្លោះ៥និង១៤
    - Math.floor(Math.random() * (14 - 5 + 1)) + 5 ឬ Math.floor(Math.random() * (14 - 5 + 1)) + 5

-----------------------------------

ធនធានរបស់អ្នកទស្សនាគឺជា RAM.
#### Date 12/Oct/22 - 7:30:9am 

### <center> Chapter 3: Javascript </center>

#### <u> JavaScript Overview </u>

<b> <u> + Javascript of Javascript: </u> </b>

<b> <u> + Javascript Usage: </u> </b>

    1. Dynamic Content:
    2. Dynamic Attribute
    3. Dynamic Style
    4. Dynamic Structure
    5. Animation
    6. Graphic

> ការសរសេរ javascript ដាក់ខាងក្រោម body ជាការសរសេរដែលល្អជាងគេ