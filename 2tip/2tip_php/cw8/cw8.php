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
    $d1 = new DateTime();
    $bd = (new DateTime())->SetDate(2006,10,12);
    $d2 = date("d/m/Y");
    echo "<p>{$d1->format('Y-m-d')}</p>";
    echo "<p>{$bd->format('Y-m-d')}</p>";
    echo "<p>{$d2}</p>";
    ?>
    <form action="result.php" method="post">
        <div class="line">
            <input type="text" name="f" id="nn" placeholder="podaj imie">
        </div>
        <div class="line">
            <input type="text" name="last" id="nn" placeholder="podaj nazwisko">
        </div>
        <div class="line">
            <input type="date" name="bd" id="nn" >
            data urodzenia
        </div>
        <div class="line">
            <select name="" id="">
                <option value="">w latach</option>
                <option value="">w dniach</option>
                <option value="">w sekundach</option>
            </select>
        </div>
        <input type="submit" value="Oblicz">
    </form>
</body>
</html>