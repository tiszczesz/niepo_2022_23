<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw2.css">
    <title>Document</title>
</head>
<body>
    <h1>Ćwiczenie 2</h1>
    <?php
    var_dump($_GET);
    $day = isset($_GET['day']) ? $_GET['day']:2;
    switch($day){
        case 1: echo "<p>Poniedziałek</p>"; break;
        case 2: echo "<p>Wtorek</p>"; break;
        case 3: echo "<p>Środa</p>"; break;
        case 4: echo "<p>Czwartek</p>"; break;
        case 5: echo "<p>Piątek</p>"; break;
        case 6: echo "<p>Sobota</p>"; break;
        case 7: echo "<p>Niedziela</p>"; break;
        default: echo "<p>To nie jest numer dnia!!!</p>";
    }
    ?>
    <h3>Pętla for</h3>
    <?php
    $imiona = ["Alojzy","Monika","Renata","Piotr"];
    echo "<ul>";
    for($i=0; $i<count($imiona);$i++){
        echo "<li>{$imiona[$i]}</li>";
    }

    echo "</ul>";
    for($i=1; $i<=6 ;$i++){
        // if($i%2==0){
        //      echo "<h{$i} class='red'>Nagłówek nr {$i} </h{$i}>";
        // }else{
        //     echo "<h{$i}>Nagłówek nr {$i} </h{$i}>";
        // }
        $red = $i%2==0? " class='red'":"";
        echo "<h{$i} {$red}>Nagłówek nr {$i} </h{$i}>";
       
    }
    ?>
    <h3>Pętle zagnieżdżone</h3>
    <?php
        $rows = 45;
        $cols = 30;

?>

<h3>Pętla do{...}while(...)</h3>
<?php
    $sum = 0;
    $min = PHP_INT_MAX;
    $max = PHP_INT_MIN;
    do{
        $losowa = rand(0,50);
        echo $losowa.' ';
    }while($losowa!=0);

?>
</body>
</html>