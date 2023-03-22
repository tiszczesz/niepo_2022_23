<?php
session_start();
?>

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
    const SESSION = 'sesja1';
    if (filter_has_var(INPUT_GET, 'state')) {
        $state = filter_input(INPUT_GET, 'state');
        if ($state === 'open') {

            $_SESSION[SESSION] = 'fajna';
            //$name = session_name();
            // var_dump($_SESSION);
            //$value = "dd";//$_SESSION[$name];
            echo "<span style='color:red'>Nazwa sesji: " . SESSION . " wartość: " . $_SESSION[SESSION] . "</span>";
        } else {
            session_unset();
            session_destroy();
        }
    }
    ?>
    <div class="flex">
        <h1>Strona pierwsza</h1>

        <div class="info">
            <?php
            if (isset($_SESSION["sesja1"])) {
                echo "Sesja otwarta";
                echo "<a href='cw13.php?state=close'>Zamknij sesję</a>";
            } else {
                echo "Sesja zamknięta";
                echo "<a href='cw13.php?state=open'>Otwórz sesję</a>";
            }
            ?>
            </div>
    </div>



    <div>
        <a href="cw13_1.php">Druga strona</a>
    </div>
</body>

</html>