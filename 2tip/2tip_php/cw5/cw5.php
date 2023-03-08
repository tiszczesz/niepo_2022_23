<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Tablice w php</h1>
    <?php
        $t1 = [];
        var_dump($t1);
        $t1[] = "ala ma kota";
        $t1[] = 345;
       
        var_dump($t1);
        $t1[5] = 555;
        var_dump($t1);
        $t1["fajny"] = "naprawdę fajny";
        var_dump($t1);
        // for($i=0;$i<count($t1);$i++){
        //     echo $t1[$i].' ';
        // }
        foreach($t1 as $elem){
            echo $elem.' ';
        }
   ?>
</body>
</html>