Working with Cookie in PHP

    Cookie តាមរយះ Browser ទុកទិន្នន័យនៅលើmachineអ្នកទស្សនាដោយកំណត់រយះពេលដែលទិន្នន័លេងប្រើការបានហៅថា Expiresដែលត្រូវគណនាដោយប្រើរូបមន្តដូចខាងក្រោម:

        time() + seconds * minutes * hours * days 
    ដើម្បីអោយ cookies ចង់ចាំទិន្នន័យរយះពេល ៣០ថ្ងៃ expired ត្រូវបានគណនាដោយប្រើ
        time() + 60*60*24*30

    Create a cookie

        setcookie( "name"[,"value"[, expires=0]] ) : bool
        Ex: setcookie( "color", "Yellow", time()+86400 );

    Access a cookie
        
        $_COOKIE["name"]
        Ex: $_COOKIE["color]

    Delete a cookie

        setcookie("Name", "", time()-1 ) : bool
        Ex: setcookie("color", "", time()-1 ),