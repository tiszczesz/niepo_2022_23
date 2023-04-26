<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-aFq/bzH65dt+w6FI2ooMVUpc+21e0SRygnTpmBvdBgSdnuTN7QbdgL+OapgHtvPp" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha2/dist/js/bootstrap.bundle.min.js" integrity="sha384-qKXV1j0HvMUeCBQ+QVp7JcfGl760yU08IQ+GpUo5hlbpg51QRiuqHAJz8+BrxE/N" crossorigin="anonymous"></script>

    <title>Document</title>
</head>

<body>
    <div class="container">
        <div class="d-flex ">
            <nav class="me-4 col-4">
                <ul class="list-group">
                <ul class="list-group">
                    <li class="list-group-item">
                        <a href="cw7.php">Strona główna</a>
                    </li>
                    <li class="list-group-item"><a href="addcourse.html">Dodaj kurs</a></li>
                    <li class="list-group-item">dfgdf</li>
                </ul>
                </ul>
            </nav>
            <section class="content col-8">
                <h1>Zbiór kursów</h1>
                <!-- <pre> -->
                <?php
                require_once "functions.php";
                //var_dump(GetData());
                $data = GetData();
                echo ToTable($data);
                ?>
            </section>
        </div>


        <!-- </pre> -->
    </div>
</body>

</html>