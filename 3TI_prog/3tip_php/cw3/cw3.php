<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form method="post">
        <div>
            <label for="a">Podstawa:</label>
            <input type="text" name="a" id="a">
        </div>
        <div>
            <label for="b">Wykładnik:</label>
            <input type="text" name="b" id="b">
        </div>
        <div>
            <input type="submit" value="Oblicz">
        </div>
    </form>
    <?php
        if(filter_has_var(INPUT_POST,'a')){
             $a = filter_input(INPUT_POST,'a',FILTER_VALIDATE_FLOAT);
             //$a = intval($_POST['a']);
             $b = filter_input(INPUT_POST,'b',FILTER_VALIDATE_INT);
             $napis = "żółta";
             
             var_dump(strlen($napis));
        }
       

    ?>
</body>

</html>