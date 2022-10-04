##### Date 4/Oct/22, Time: 9:15-10:45am

#### <center> សេចក្តីចំពោះ Linux System</center>

+ Basic command:

    - cd:
    - ls: 
    - &&:
    - & : process run background
    - pwd: display current directory path
    - cp: copy

    - rm: delete file or directory.
    - mkdir: create directory.
    - rmdir: delete empty directory.
    - man: used to display the user manual of any command that we can run on the terminal.
    - more: មើលពត៌មានម្តង១screen.
    - cat: មើល view នៅក្នុង file.
    - echo: used to display line of text/string that are passed as an argument 
    - Grep: search with specific word
    - Who: 
    - who am I: បង្ហាញ user ដែល loggin ផ្ទាល់.
    - exit: logout ឬផ្តាច់ user ពី system.
    - ps: បង្ហាញ process ដែលកំពុងដំណើរការ.

---------------------------------------------

##### Date 13/Sep/22, Time: 9:15-10:45am

####<center>+ សេចក្តីចំពោះ Linux System</center>

    + File System Structure:

        - /usr/Directory

        - /var/Directory

        + Partition: ជាផ្នែក១នៃHard disk ដែលវាត្រូវបានចែកដោយយើងផ្ទាល់.

    + លក្ខណៈពិសេសរប់ស ext, ext4, Btrf and XFS.

        - ext3 prevent lost data 
    
    + File Systems and instruction of CentOS:

        + 3 Partitions Mount Point:

            - |/boot | -> Kernel
            - |/root | -> OS
            - |/Swap | -> Virtual Memory

        

---------------------------------------------
##### Date 13/Sep/22, Time: 9:15-10:45am

####<center>+ សេចក្តីចំពោះ Linux System</center>

    + តួអក្សរពិសេស:
        - \ Backslash = if use like "Royal Universy".
        - / Forwardslash = សម្រាប់ចែកឬញែករវាង Folder និង Sub folder.
        - . = Current Directory
        - .. (refer to parent)= Back to Previous directory
        - ~ (tise) = Back To home
        - * (asterisk) = Get all
        - ? (question mark) = រក១តួអក្សរ
        - [] (refer range) =
        - | = យកលទ្ធផល command ១ ទៅបង្ហាញនៅក្នុង command 1 ទៀត
        - > (right-angle) = រកfile ដែលmatch បើមានoverride file else create new one.
        - >> = append
        - < =
        ##### - ; = ls ;date;cal;who

        [Student@Centos ~] $
         ___1__ 2__3___ 4  5

        1. UserName
        2. Hostname
        3. Home
        4. Directory
        5. User 
 
---------------------------------------------
##### Date 7/Sep/22, Time: 9:15-10:45am

####<center>+ សេចក្តីចំពោះ Linux System</center>
    
    +  GUI and Kernel:
        -

    + Network Neightborhood

    + Registry vs TEXT files
        - Window regedit.exe
        - Linux have no registry

    + Domain
        ##### - Window have domain to validate user login.
        - Linux: nis.

    + Active Directory:
        - Window (AD)
        - Linux doesn't have active Directory but use (LDAP)

    + What is Command?
        - Command is instruction that typer type on command line and press enter to do something and computer know that command on Unix.
        - Command គឺជា file មួយដូចជា ls, cal, ping

    + Binary file: is a executable file after compile.

    + Shell Prompt Basic:

        - $ for user
            - [student@linux root] $
            - can only access to system can't manage the whole system.
            - can use what have in system.

        - # for root.
            - [root@linux root] #
            - can only access to system can't manage the whole system.

    + Shells and commands

        + Shell 
            - ជា Interface for user interact with kernel.
            - Shell is not OS

        + Command is a programme that translate and allow user to execute command via terminal or program.

    + Permission and User Right:
        + Permission: 
            - read, write execute, and delete

        + User Right or Privilege: is user right control the entire system.

            - Privilege: 

---------------------------------------------

##### Date 6/Sep/22, Time: 9:15-10:45am

####<center>+ សេចក្តីចំពោះ Linux System</center>

    + សង្ខេបពី Free Open Source Software
        - Open Source Software/ Free (OSS/FS  ដែលគេសរសេរកាត់ថា FLOSS ឬ FOSS មានការកើនឡើងពីសមត្ថភាពរបស់វាខ្ពស់).
        - និយាយអោយខ្លីមកOSS/FS programs គឺជាកម្មវិធីដែលអាជ្ញាប័ណ្ណរបស់វាបានផ្តល់អោយអ្នកប្រើប្រាស់នូវសិទ្ធិសេរីភាពក្នុងការ
          ប្រើប្រាស់កម្មវិធីតាមគោលបំណងរបស់គេហើយអាចសិក្សារនិងកែប្រែកម្មវិធីបានហើយអាចចែកចាយបន្តទៀតបានចំពោះកម្មវិធីច្បាប់ដើម្បីគេកែប្រែដោយមិនចាំបាច់សុំសិទ្ធិពីអ្នកបង្កើតវានោះទេ.

    + Keyword
        - GNU GNU's not Unix ( a project to creat na OSS/FS )
        - GPL (licence)
        - OS, OSes
        - OSS/FS

    + Windows and Linux System:

        + Linux and Linux Distribution:
            - Linux is kernel of System.
            - Linux distribution is a company that manage and distribute Linux OS.

    + Linux Distribution such as: Red Hat
        - CentOS
        - SuSE
        - Kali
        - FreeBSD
        - Fedora
        - IPOOP

    + Linux (Kali) : Pen testing.

    + Component Linux/ Unix System

        - Kernel (Unix Kernel)

        - Shell ជា Interface for user interact with kernel.
        
        + នៅក្នុងLinuxមានShellsមួយចំនួន:

            - bash
            - csh
            - ksh
            - sh
            - tcsh
            - zsh
            - dash
            
    + Free Software and GNU licence:

        - Richard Statllman think should free OS.
        + GNU project ជាមួយ GNU public licence (GPL) បញ្ចាក់ថា
            - Software ដែលកំពុងប្រើត្រូវតែ free.
            - ក្មាននរណាម្នាក់អាចយកសេរីភាពនោះចេញពីវាបានទេ
            - គេអាចលក់វាបន្តទៀតបាន
            - អ្នកលក់ត្រូវតែលក់ទាំង source code.

    + Open source meaning:

        - Free Redistribution.
        - Source code
        - Derived Works
        - Integrity of the Author's Source Code.
        - No Discrimination Against Person or Group.
        - No Discrimination Against Field or Endeavor.
        - Distribution of licence
        - License Must Not Be Specific to a Product
        - License Must Not Contaminate Other Software.

    + Difference Windows 2012/2016 and Linux:
        - User តែមួយនាក់ប្រៀបធៀបជាមួយ Users ច្រើននាក់និង Network Users
        - Linux បានខ្ចីទស្សនះវិជ្ជាពី UNIX.
        - ចាប់តាំងពីការចាប់កំណើតរបស់វានៅដើមទស្សវត្សឆ្នាំ1990អាចប្រើជាមួយUsersជាច្រើនបាន
        - សព្វថ្ងៃនេះភាពប្រើភាគច្រើនបំផុតរបស់ Users ជាច្រើនគឺជាការបង្កើតជាម៉ាសុីន Server ទាំង Linux and Window 2012/2016 មានសមត្ថភាពក្នុងការផ្តល់អោយនូវសេវាដូចជា Databases តាមប្រព័ន្ធ Network.

    - Unix who create Linux system

    + MS-DOS

---------------------------------------------

##### Date 24/Aug/22

+ Task: Install server 2019 on virtual machine
