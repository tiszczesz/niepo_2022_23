<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>dodawanie plików graficznych na serwer</h1>
    <form action="cw7upload.php" method="post" enctype="multipart/form-data">
        <label for="image">Wybierz plik graficzny:</label>
        <input type="file" name="image" id="image">
        <input type="submit" value="Zapisz plik" name="submit">
    </form>
</body>
</html>