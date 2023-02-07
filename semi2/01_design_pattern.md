#### 31/Jan/2023, 7:30-9:00am

## <center> <u> Design Patterns </u> </center>

#### <u> II) Creational Patterns (ការបង្កើត Object) </u>
##### <u> 6) The Factory Method Pattern </u>

- Easy maintenence in one place

-----------------------------

#### 31/Jan/2023, 7:30-9:00am

## <center> <u> Design Patterns </u> </center>

#### <u> II) Creational Patterns (ការបង្កើត Object) </u>
##### <u> 5) The Prototype Pattern </u>

=> Clone ជាការ copy data ដែលមានស្រាប់នៅក្នុង memory ហើយ (លឿន)
=> Copy ជាការ copy data.

* Shallow Copy: ជារបៀប copy data ហើយ object នឹង original refer to the member, change one will affect other.
* Deep Copy: ជារបៀប copy data ដាច់ដោយឡែក, change one will not affect other.

---------------------------------------

#### 9/Jan/2023, 7:30-9:00am

## <center> <u> Design Patterns </u> </center>

#### <u> Bridge Pattern </u>

* Design 

---------------------------------------

#### 9/Jan/2023, 7:30-9:00am

## <center> <u> Design Patterns </u> </center>

#### <u> Bridge Pattern </u>

ជាវិធីធ្វើអោយប្រើជារួមបាន

Abstraction: ជាការហៅ function តាមរយៈ object
Ex: A obj = new A();
    string t = obj.MA(100);
               --Abstraction--

Implementation: ជាការអនុវត្តឬកូដនៅក្នុង function 
Ex: Class A {

    public string MA(int x){
        // Implementation;
    }
}

Design:

| Client |      | Abstraction |      | <<Interface>> IBridge |
                | + operation |      | + opt Imp() |
                                             ^
        _____________________________________|
        |                       |
| ImplementationA |     | ImplementationB |
| + Opt Imp()     |     | + Opt Imp()     |

        Car                     Bike
    Assembling              Assembling

---------------------------------------

#### 3/Jan/2023, 7:30-9:00am

## <center> <u> Design Patterns </u> </center>

#### <u> Decorator Pattern </u>

#### <u> Role </u>

=> ជារបៀបភ្ជាប់ឬដោះស្រាយបញ្ហាណាមួយដែលមិនអោយប៉ះពាល់របស់ដែលមានស្រាប់.

Component:
- ជារបស់ដែលយើងត្រូវយកទៅតុបតែងឬថែម.