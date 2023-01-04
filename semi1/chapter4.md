#### Date 2/Nov/22 - 7:30:9am 

### <center> Chapter IV: JQuery </center>

#### JQuery and DOM

ទាញយកខ្លឹមសារពីធាតុបានជ្រើសរើស
$(selector).text();

ដាក់ខ្លឹមសារថ្មីអោយធាតុបានជ្រើសរើស
$(selector).text(ខ្លឹមសារ);

ទាញយកខ្លឹមសារឬកូនធាតុពីធាតុបានជ្រើសរើស
$(selector).html();

ដាក់ខ្លឹមសារថ្មីឬកូនធាតុអោយធាតុបានជ្រើសរើស
$(selector).html(ខ្លឹមសារឬកូដHTML);

ទាញយកតម្លៃគុណលក្ខណៈធាតុបានជ្រើសរើស
$(selector).attr("ឈ្មោះគុណលក្ខណះ");

ដាក់តម្លៃថ្មីអោយគុណលក្ខណៈធាតុបានជ្រើសរើស
$(selector).attr("ឈ្មោះគុណលក្ខណះ", "តម្លៃ");

ទាញយកvalue នៃ css property របស់ធាតុបានជ្រើសរើស
$(selector).css("ឈ្មោះproperty");

ដាក់ value នៃ css property នៃធាតុបានជ្រើសរើស
$(selector).css("ឈ្មោះproperty", "value");

#### JQuery and Selector

- សញ្ញា $ សម្គាល់ថា ជាកូដរបស់ JQuery.

- selector សម្រាប់ជ្រើសរើសផ្នែកនៃ Webpage.

- Document ជ្រើសយក webpage.

Example:
    <script>
        $(document)
        $(this)
        $("CSS selector")
    </script>

ជ្រើសយកធាតុបច្ចប្បន្ន ដែលកំពុងប្រើ

Notes: ធាតុដែលមាន focus cursor ធាតុនោះជា Current element.

* កូដ JQuery តែងផ្តើមដោយ **ready event** ដែលមានរបៀបសរសេរ២ដូចខាងក្រោម:
    1.  $(document).read(function(){
            // កូដ Javascript  ឬ កូដ jquery
        })

    2. $(function(){
        // កូដ Javascript  ឬ កូដ jquery
    })

ព្រោះថា ready event ធានាថា script ដំណើរការនៅពេលដែល webpage បានផ្ទុករូចរាល់ប៉ុណ្ណោះ.

#### Introduction to JQuery