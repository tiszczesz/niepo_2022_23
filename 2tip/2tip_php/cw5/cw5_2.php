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
    include_once "functions.php";
    $dane = GetData();
    echo toList($dane);
    echo toList($dane, "ol");
    ?>
    <div>
        <form method="post">
            <input type="radio" name="choice" id="choice1" value="asc" checked>
            <label for="choice1">Sortowanie rosnąco</label> <br />
            <input type="radio" name="choice" id="choice2" value="desc">
            <label for="choice1">Sortowanie malejąco</label> <br />
            <input type="submit" value="Sortuj" />
        </form>
    </div>
    <?php
    if (filter_has_var(INPUT_POST, "choice")) {
        echo "sortowanie...";
        $choice = filter_input(INPUT_POST, "choice");
        echo "Sortowanie: " . ($choice === "asc" ? " rosnąco" : " malejąco");
        if($choice==="asc") sort($dane); else rsort($dane);
        echo toList($dane,"ol");
        $colors = getColors();
       /* var_dump($colors);
            //sort($colors);
            //rsort($colors);
            ksort($colors); //sortuje po kluczach
            var_dump($colors);
            asort($colors);
            var_dump($colors);
        */
        //todo select z kolorami polskimi posortowany rosnąco
        // js ożywienie select aby zmieniał kolor tła strony na wybrany
    }
    ?>
</body>

</html>