<?php 
    $fhw=fopen("m3.txt", "w");
    $fha=fopen("m3.txt", "a");
    if($fhw and $fha){
        echo "<h2>", ftell($fhw), "<h2>";
        echo "<p>1 fhw writing</p>";
        fputs($fhw, "writing");
        echo "<h2>", ftell($fhw), "<h2>";
        echo "<p>2 fhw writing</p>";
        fputs($fhw, "writing");
        echo "<h2>", ftell($fhw), "<h2>";
        // echo "<p>3 fha writing</p>";
        // fputs($fha, "writing");
        // echo "<h2>", ftell($fhw), "<h2>";
        // echo "<p>4 fha writing</p>";
        // fputs($fha, "writing");
        echo "Finish";
    }
?>