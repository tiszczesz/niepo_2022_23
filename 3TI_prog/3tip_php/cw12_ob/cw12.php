<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    spl_autoload_register(function(string $classname){
        require_once strtolower($classname).'.class.php';
    });
    $docs = [new Document("ggg","ggggg"),
            new DocText("tt","yyyy"),
            new DocImage("obrazek1","gg",200,400),
            new DocSound("utwór1","....","mp3")];
    
    foreach($docs as $d){
        if($d instanceof Printable){
            $d->Print();
        }else{
            echo "Brak możliwości drukowania obiektu...<br>";
        }
    }
    var_dump($docs[3]);
    ?>
</body>
</html>