<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="cw5.css">
</head>
<body>
    <?php
        require_once "functions.php";        
       // var_dump($conn);
       echo booksToTab(getBooks());
    ?>
</body>
</html>