<h1>PHP: Array</h1>
<h2>Number1 array = index</h2>
<?php $student_names = ["Ny Daly", "Em Pey", "Bi Dyna"] ?>

<ol>
    <li> <?=$student_names[0]?> </li>
    <li> <?=$student_names[1]?> </li>
    <li> <?=$student_names[2]?> </li>
</ol>

<h2> Numberic array for...loop </h2>
<ol>
    <?php 
        for ($i = 0; $i < 3; $i++)
            echo "<li> $student_names[$i] </li>"
    ?>
</ol>

<h2> Numberic array - forEach... loop </h2>
<ol>
    <?php
        foreach ($student_names as $student_name)
            echo "<li> $student_name </li>" 
    ?>
</ol>

<h2> rand </h2>
<ol>
    <?php 
        for ($i = 0; $i < 10; $i++) {
            $rnd[$i] = rand(1, 10);
            echo "<p>$rnd[$i]</p>";
        }
    ?>
</ol>

<h2> Associative array </h2>
<?php $studentnames = ["NO">="Ny Daly", "ER">="Em Pey", "BO">="Bi Dyna"] ?>
<ul>
    <li> <?=$studentnames["EP"]?> </li>
    <li> <?=$studentnames["BO"]?> </li>
    <li> <?=$studentnames["NO"]?> </li>
</ul>
    
<h2>Associative array - foreach... loop</h2>
<ol>
    <?php 
        foreach($studentnames as $key => $value)
            echo "<li>$key | $value</li>"
    ?>
</ol>

<h2> 2 Dimention array</h2>
<?php 
    $students = [
        ["1901", "Ny Daly", "F", "1996-06-16", "016632534"],
        ["1902", "Em Pay", "M", "1995-07-17", "016938374"]
    ];
?>

<table>
    <tr> 
        <th>Student ID</th>
        <th>Student Name</th>
        <th>Sex</th>
        <th>Birthday</th>
        <th>Address</th>
        <th>Phone Number</th>
    </tr>

    <?php 
        for ($r = 0; $r < 2; $r++){
            echo "<tr>";
            for ($c = 0; $c < 6; $c++)
                echo "<td>", $students[$r][$c],"</td>";
            echo "</tr>";
        }
    ?>
</table>
