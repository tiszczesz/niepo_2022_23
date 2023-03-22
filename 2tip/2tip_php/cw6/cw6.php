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
    $file = fopen("data.txt", 'r');
    var_dump($file);
    if($file){
        while($line = fgets($file)){
            echo "<p>{$line}</p>";
        }
        fclose($file);
    }
    ?>
    <form  method="post">
        <textarea name="text" id="text" cols="30" rows="10"></textarea>
        <input type="submit" value="Zapisz do pliku">
    </form>
    <?php
    if(filter_has_var(INPUT_POST,'text')){  //if(isset($_POST['text'])){}
        $text = trim(filter_input(INPUT_POST,'text'));
        if($text!=''){
            $file = fopen("result.txt",'w');
            fwrite($file,$text);
            fclose($file);
        }
    }
    ?>
</body>

</html>