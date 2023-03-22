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
<div class="info">
            <?php
            if (isset($_SESSION["sesja1"])) {
                echo "Sesja otwarta";
               // echo "<a href='cw13.php?state=close'>Zamknij sesję</a>";
            } else {
                echo "Sesja zamknięta";
              //  echo "<a href='cw13.php?state=open'>Otwórz sesję</a>";
            }
            ?>
            </div>
</body>
</html>