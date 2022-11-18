#### Date 18/Nov/22 - 7:30:9am 

### <center> Chapter V: Bootstrap </center>

#### Bootstrap Grid System

ក្នុង Bootstrap ប្រព័ន្ធក្រឡាចត្រង្គត្រង់ អាចមាន Container ជាច្រើន។ Container និមួយៗ អាចមានជួរដេកជាច្រើន (Row)។ ក្នុងជួរដេកនិមួយៗអាចមានជួរឈរជាច្រើន (Column) ក្នុងជួរឈរនិមួយៗអាចប្រើប្រាស់ក្រឡាចត្រង្គ១ឬច្រើន (Grid) 

1. Container ឬ Container-fluid

    - ជាមេធាតុដែលផ្ទុកនូវអ្វីៗដែលត្រូវរៀបចំចេញជាច្រើនជួរដេកនិងច្រើនជួរឈរ។ធាតុមេ Containerមានគម្លាតអមសងខាងខ្លឹមសារដែលបានបង្ហាញ។ រីឯ Container-fluid ខ្លឹមសារដែលត្រូវបង្ហាញអាចប្រើបានផ្ទៃធំបំផុតព្រោះគ្មានគម្លាតសងខាងដូចមេធាតុ Containerនោះទេ

2. Row

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