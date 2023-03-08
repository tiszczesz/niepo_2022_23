<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw3.css">
    <title>Document</title>
</head>
<body>
    <div>
        <form method="post">
            <div class="line">
                <label for="tekst">Podaj tekst: </label>
                <input type="text" name="tekst" id="tekst">
                <span class="error"></span>
            </div>
            <div class="line">
                <label for="list">wybierz rodzaj listy:</label>
                <select name="list" id="list">
                    <option value="ol">Lista numerowana</option>
                    <option value="ul">Lista nienumerowana</option>
                </select>
            </div>
            <div class="line">
                <label for="quantity">Ile elementów:</label>
                <input type="number" name="quantity" id="quantity" min="2" max="30" value="5">
                <span class="error"></span>
            </div>
            <div class="line">
                <input type="submit" value="Generuj" id="gener">
            </div>
        </form>
    </div>
    <?php
    function TextToHtml(string $text,string $mark):string {
        return "<{$mark}>{$text}</{$mark}>";
    }
    function TextToList(string $text,int $count,string $type = "ul"):string {
        $html = "<{$type}>";
        for($i=0;$i<$count;$i++){
            $html .= "<li>{$text}</li>";
        }

        return $html."</{$type}>";
    }
    echo TextToHtml("ala ma kota","h2");
    var_dump($_POST);
    if(isset($_POST['tekst'])){
        echo "działamy";
        $tekst = trim($_POST['tekst']);
        $list = trim($_POST['list']);
        $quantity = trim($_POST['quantity']);
        echo TextToList($tekst,$quantity,$list);
    }else{
        echo "nie działamy";
    }
    //echo TextToList("ala ma kota",6,"ol");
   ?>
   <script src="cw3.js" defer></script>
</body>
</html>