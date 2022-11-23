#### Date 23/Nov/22 - 7:30:9am 

### <center> Chapter V: Bootstrap </center>

#### Bootstrap Typography

    Head (ចំណងជើង)
    ថ្នាក់បងប្អូនត្រកូល h1 - h6
    ថ្នាក់បងប្អូនត្រកូល display-1 ដល់ display-6

#### Formatting Text
    ធាតុem, strong, mark, del, s, ins, u
    Text align អត្ថបទនៅកណ្តាល, ឆ្វេង, ឬ ស្តាំ.
        text-center កណ្តាល
        text-start ឆ្វេង
        text-end ស្តាំ

#### List
    list-unstyled ដូច list-style-type: none ក្នុង css។

    * Description List (dl) បញ្ជីរាយអ្វីជាកូនៗដែលម្ខាងប្រើកូនធាតុ dt ( data term ) ហើយម្ខាងទៀតប្រើកូនធាតុ dd (data description)

#### Bootstrap image
    ថ្នាក់ img-fluid សម្រាប់ responsive image
    ថ្នាក់ img-thumbnail ដាក់ស៊ុមអោយរូបភាពដោយពត់កែងស៊ុម

#### Image align
    mx-auto d-block ផ្តុំពីថ្នាក់អោយរូបភាពនៅចំកណ្តាល (mx គឺ margin-left និង margin-right ឯ d-block គឺ display-block float-start រូបភាពនៅជាប់ជ្រុងខាងឆ្វេង float-end រូបភាពនៅជាប់ជ្រុងខាងស្តាំ)

#### * * * Utilites 
margin និង padding
ផ្តើមដោយ m គឺ margin ឬ ដោយ p គឺ padding
+ បន្ទាប់មកគឺជ្រុងដូច:
    t គឺ top, 
    b គឺ bottom, 
    s គឺ start (left), 
    e គឺ end(right), 
    x គឺ ឆ្វេងស្តាំ
    y គឺ លើ ក្រោម

    បញ្ចប់ដោយសញ្ញា - លេខពី0ដល់៥បញ្ចាក់ចម្ងាយជិតឆ្ងាយ ឬ auto
    ឧ. 1 pt-3 គឺ padding top ប្រវែងល្មម
    ឧ. 2 pt-5 គឺ padding top padding bottom ប្រវែងឆ្ងាយជាងគេ

+ border:
    border ស៊ុមទាំងបួនជ្រុង
    border-ជ្រុង ស៊ុមជ្រុងណាមួយដូចជា top, bottom, start, end
    border-ជ្រុង-0 ដកស៊ុមជ្រុងណាមួយ
    border-លេខពី១ដល់៥ បញ្ចាក់ពីកម្រាស់ស៊ុម
    border-ឈ្មោះពណ ដូចជា primary, secondary, sucess, danger. warning, info, light, dark, white
    rounded ពត់កែងស៊ុមទាំងបួន
    rounded-ជ្រុងមាន top, bottom, start, end, circle, pill
    rounded-លេខពី 0 ដល់ ៥ បញ្ចាក់ការពត់កែងស៊ុម
+ Background color និង color
    primary ខៀវ, secondary ប្រផេះដិត, success មៃតង, danger ក្រហម, warning ទឹកក្រុច, info ផ្ទៃមេឃ, lgith ប្រផេះស្រាយ, dark ខ្មៅ, white ស-bg-ពណ ពណរបស់ផ្ទៃខាងក្រោយ text-ពណអក្សរ

--------------------------

#### Date 18/Nov/22 - 7:30:9am 

### <center> Chapter V: Bootstrap </center>

#### Bootstrap Grid System

ក្នុង Bootstrap ប្រព័ន្ធក្រឡាចត្រង្គត្រង់ អាចមាន Container ជាច្រើន។ Container និមួយៗ អាចមានជួរដេកជាច្រើន (Row)។ ក្នុងជួរដេកនិមួយៗអាចមានជួរឈរជាច្រើន (Column) ក្នុងជួរឈរនិមួយៗអាចប្រើប្រាស់ក្រឡាចត្រង្គ១ឬច្រើន (Grid) 

1. Container ឬ Container-fluid

    - ជាមេធាតុដែលផ្ទុកនូវអ្វីៗដែលត្រូវរៀបចំចេញជាច្រើនជួរដេកនិងច្រើនជួរឈរ។ធាតុមេ Containerមានគម្លាតអមសងខាងខ្លឹមសារដែលបានបង្ហាញ។ រីឯ Container-fluid ខ្លឹមសារដែលត្រូវបង្ហាញអាចប្រើបានផ្ទៃធំបំផុតព្រោះគ្មានគម្លាតសងខាងដូចមេធាតុ Containerនោះទេ

1. Row

    - Row និមួយៗមាន១២ក្រឡាចត្រង្គដែលអាចយកទៅប្រើប្រាស់ក្នុងការបង្កើតជួរឈរជាច្រើន
    - Column និមួយៗអាចមានក្រឡាចត្រង្គ១ឬច្រើនក្នុងចំណោម១២ក្រឡាចត្រង្គរបស់ជួរដេក១ ពោលគឺទទឹងរបស់ជួរឈរអាចប្រែប្រួលវែងខ្លីទៅតាមការកំណត់ចំនួនក្រឡាចត្រង្គទៅតាមប្រភេទផ្ទៃបង្ហាញដែលមានថ្នាក់សំគាល់ផ្សេងៗគ្នាដូចខាងក្រោម:
        | Extra small | none | <576px
        | Small | sm | >=576px
        | Medium | md | >=768px
        | Large | lg | >=992px
        | Extra large | xl | >= 1200px
        | Extra extra large | xxl | >= 1400px

--------------------------

#### Date 16/Nov/22 - 7:30:9am 

### <center> Chapter V: Bootstrap </center>

#### Introduction to BootStrap

BootStrap គឺជាឈុតឧករណ៍ (HTML, CSS, JAVASCRIPT) សម្រាប់បង្កើត Responsive website ដែលទ្រង់ទ្រាយរបស់វាអាចបត់បែនប្រែប្រួលតបទៅនឹងឧបករណ៍ដែលបើកវា.

+ បច្ចប្បន្ន BootStrap ត្រូវការឯកសារមូលដ្នាន២គឺ៖
    - bootstrap.css
    - bootstrap.bundle.js
    ដែលអាចប្រើតាមរយៈ CDN ឬ Download ឬ ចំលងចូល Website តែម្តងក៏បាន.

+ ក្នុងធាតុ Head ប្រើធាតុ link ភ្ជាប់ទៅកាន់ឯកសារ CSS ហើយនៅបាតធាតុ body ប្រើធាតុ Script ដើម្បីភ្ជាប់ទៅកាន់ឯកសារ Javascript