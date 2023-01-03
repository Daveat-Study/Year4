#### Date: 29/Nov/22 - Time: 7:00-10:00am

1. ប្រាប់ឈ្មោះ Relationships:

  => Customer:
     + Class Customer is associate with Order
        - | Customer |________________| Order |

  => Order:
    1. Class Order is composition with OrderDetial
      - | Order |___________<>| OrderDetails |

    2. Class Order is associate with Payment:
      - | Order |______________| Payment |

  => Order Detail:

    + Class Detail is associate with Item
      - | OrderDetail |________________| Item |

  => Payment:
    + Class Payment Inherit from class (Cash, Check, CreditCard)
      - | Payment |_____________|> | Cash |
      - | Payment |_____________|> | Check |
      - | Payment |_____________|> | CreditCard |

-----------------------------------------------

#### Date: 25/Nov/22 - Time: 9:00-10:45am

* Relationships

1). | A |_________________| B | Association
2). | C |_______________|>| D | Inheritance ( or Generalization) 
3). | E |---------------|>| F | Realization
4). | G |---------------->| H | Dependency
5). | I |_______________<>| J | Aggregation
6). | K |_______________<>| L | Composition

1). Association
ដែលមិនមែន inheritance
ដែលមិនមែន Dependency
ដែលមិនមែន Aggragation
ខុសពី៣ហ្នឹង វាជា association
ជា class ដែលមានទំនាក់ទំនងជាមួយ class ធម្មតា.

2).     | Person | (class)

             ^
             |
    |------------------|
------------     ------------
| student  |     | Lecherer |
------------     ------------

3). 

4). Dependency
វាអាស្រ័យគ្នា
វាប្រែប្រួលតាមគ្នា

5). Aggregation

មាន១អត់១ក៏បាន មានទាំអពីរក៏បាន

Class I is a part of class

| Mouse |___________<>| Computer |

6). Composition

ត្រូវតែមានទាំងពីរ

-----------------------------------------------

#### Date: 22/Nov/22 - Time: 7:30-9:00am

2). Class diagram

Class diagram is a graphical notation used to construct and visualize object-oriented system and is a type of static structure diagram that describe the structure of the system by showing system's
+ classes & interfaces
+ Their attributes
+ Operations
+ And relatonships among the classes.

* Class Notation

| Class Name |  | ClassName |
| Attributes |  | Attributes |
| Operation |
                | ClassName |

- Attributes map onto the member's variables (data members)
- Operations map onto the Class's methods.

* Class Visibility
+: denotes public
-: denotes private
#: denotes protected

underline denotes Static

* Parameters & Return Type:
- The return type of a method is shown after a colon at the end of the method signature.
- The type of the method's parameters are shown after a colon following the parameter's name.

++ Example

- Class (regular)
  + Name: Bold, enter
- Abstract class
  + Name: Italic, Center

- interfact

|  <<Interfac>>  |
|  InterfactName |

|       MyClass 1     |
| - Attribute 1 : int |
| + Attribute 2 : string |
| # Attribute 3 : boolean |
| + Attribute 4 : float |
-------------------------
| + Opt 1 ( p1: int ) : void |
| + Opt 2 ( p1: string, p2: int ) : float |

-----------------------------------------------

#### Date: 15/Nov/22 - Time: 7:30-9:00am

2). use cases diagram

  - use cases diagram describe how external entities will use the system. External can be either a humans or other system and are referred to as an actor in UML terminology.
  - This description emphaisizes the user view of the system and the interacton between the users and the system.

-----------------------------------------------

#### Date: 1/Nov/22 - Time: 7:30-9:00am

+ UML មាន Models ច្រើន:
  - Software Requirement Specification (SRS)
  - User cases diagram
  - Class diagram

+ SRS 

  + Nonregistered web users can browe to the website to view flight info, but they can't book flight.
  + New customer wanting to book flight must complete registration form providing their name, address, company name, phonenumber, e-mail, ...
  + Customer is classified as either a corporate customer or a retail customer.
  + Customer can serach for flight based on destination and departure times.
  + Customer can book flight indecating the flight number and number of seadts requested.
  + The system sends customer a confirmation via e-mail when the flight is booked.
  + Corporate customers receive frequesnt flier miles when their employees book flight.
  + Ticket reservation can be canceled up to one week in advance for 80% refund.
  + Ticking agents can view and update flight information.

* Purpose:
  1. កំណត់ functional of the system.
  2. កំណត់ user of the system.
  3. កំណត់ boundary of the system.
  4. -||- interaction between users and the system.

- browe to the website for non registered user.
- registration form for new customer
- Search for flight based on destination
- book flight that indicate (flight number and number seated requested).
- send confirmation via e-mail when flight booked.
- Cor-customer receive frequent flier miles when employee book
- Canceled book and get refund in canceled.
- View update flight information.

-----------------------------------------------

#### Date: 25/Oct/22 - Time: 7:30-9:00am

### <center> Chapter II: UML ( Unified Modeling Language ) </center>

ជាភាសាដែលយើងអាចធ្វើជាគំរូហើយគេអាចយល់រួមគ្នាបាន។