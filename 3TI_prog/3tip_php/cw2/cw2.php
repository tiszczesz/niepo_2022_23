<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

    <title>Document</title>
</head>

<body>

    <div class="container">
        <h1>Lista pracowników</h1>
        <div>
            <?php
            require_once "functions.php";
            
            $data = GetFromFile("dane.txt");
            if (isset($_POST['letter']) && $_POST['letter']!='all') {
               
                $letter = $_POST['letter'];
                echo ToSelect($letter);
               // var_dump($_POST);
               // var_dump(StartWith($data,$letter));
                echo ToHTMLTab(StartWith($data,$letter));
                var_dump(StartWithFilter($data,$letter));
            } else {
                echo ToSelect();
                echo ToHTMLTab($data);
                
            }

            
            ?>
        </div>
    </div>
    <div><a href="">Dodaj pracownika</a></div>
</body>

</html>