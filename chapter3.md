##### Date 29/Nov/22, Time: 9:15-10:45am

#### <center> Chapter 3 </center>

* Open SSH is open source SSH(Seucre SHELL) protocols

* Why SSH?
    - Security for computer.
    - Password has encrypted.

* We use:
    - Private Key
    - Public Key

--------------------------------------
##### Date 11/Oct/22, Time: 9:15-10:45am

#### <center> Chapter 3 </center>

+ AWK programming is a script lanaguage 
    - Small size and fast
    - syntax like C programming

    + Option -F ប្រើដើម្បីអោយ awak ស្គាល់ symbol ( : )

+ ប្រៀបធៀប String

--------------------------------------

##### Date 11/Oct/22, Time: 9:15-10:45am

#### <center> Chapter 3 </center>

+ Basic command:

    - firewall-cmd
    - rpm: install packages that downloaded 
    - yum: install packages online
    - tar: compress & decompress
    - service: for start, stop service
    - pgrep: search service or process that processing
    - pkill: end service or process that processing
    - kill: terminate processing
    - id: to show id user
    - wget: to download 

+ Editor:
    - vim/vi editor

    - Press i to insert

    | command | action |
    | ------- | ------ |
    | q       | save and exit ( save old content )|     
    | q!      | exit and save |    
    | x      | same as wq ( Save edited file ) |    
    | x      | same as wq ( Save edited file ) |

+ Permissions:

    - Command and permission

        - chmod - កែសិទ្ធិ or ប្តូរ permission នៃ Files
        - su - ក្លាយជា Super User ជាបណ្តោះអាសន្ន
        - chown - ប្តូរភាពជាម្ចាស់ នៃ directory
        - chgrop - ប្តូរម្ចាស់របស់ group នៃ directory

+ File permissions:
    - ជាការកំណត់សិទ្ធិប្រើប្រាស់

    - r w x rw- r--
    1 2 3 4  5   6
    
    1. File type.
    2. 
    c
    b
    l

+ Absolute Permission (Octal number)

    - Example:

        - Chmod : Absolute or Relative => file
```
[--] $ chomd 765 test1.txt

[--] $ chomd u+rwx test2.txt

[--] $ chomd g+r, 0+w test3.txt

[--] $ chomd a+rx test4.txt
```

+ Relative Permission
    - rwx rwx rwx = 111 111 111

+ Binary and octal and relative permission

>User have 3:
>- Owner (u) |
>- Group (g) | => a
>- Other (o) |