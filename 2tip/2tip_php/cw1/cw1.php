<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ćwiczenie 1</title>
</head>

<body>
    <h1>Ćwiczenie 1</h1>
    <?php
    $imie = "Franek";
    $nazwisko = "Gryk";
    $klasa = "2TIP";
    $niewiem = true;
    var_dump($niewiem);
    var_dump($klasa);
    echo '<h3>Imię: ' . $imie . '</h3>';
    echo "<h3>Nazwisko: {$nazwisko}</h3>";
    echo "<h3>Klasa: $klasa</h3>";
    $klasa = 2;
    var_dump($klasa);
    ?>
    <h3>Obliczenia</h3>
    <?php
    $a = 12.8;
    $b = 0;
    echo "<div>{$a} + {$b} = " . ($a + $b) . "</div>";
    echo "<div>{$a} - {$b} = " . ($a - $b) . "</div>";
    echo "<div>{$a} * {$b} = " . ($a * $b) . "</div>";
    echo "<div>{$a} / {$b} = "
        . ($b == 0 ? "brak wyniku" : ($a / $b)) . "</div>";
    ?>
    <h3>Instrukcja warunkowa</h3>
    <?php
    $firstname = "łóżko";
    if(strlen($firstname)>6){
        echo "<div style='color:red;'>Długie imię</div>";
    }elseif(strlen($firstname)<6){
        echo "<div style='color:green;'>Krótkie imię</div>";
    }else{
        echo "<div style='color:blue;'>długość ok imię</div>";
    }
    echo "<p>Ilość znaków {$firstname}: ".mb_strlen($firstname)."</p>"
     ?>
</body>

</html>