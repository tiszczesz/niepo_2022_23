<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <div class="container">
        <form method="post">
            <div>
                <input type="text" name="firstname" id="firstname" placeholder="Podaj imię">
                <span class="error"></span><br>
                <input type="text" name="lastname" id="lastname" placeholder="Podaj nazwisko">
                <span class="error"></span><br>
                <input type="number" name="age" id="age" placeholder="Podaj wiek" min="1" max="200" >
                <span class="error"></span>
            </div>
            <div>
                <label for="">Czy się podobało:</label><br>
            <input type="radio" name="enjoy" value="OK" checked="true">Było OK<br>
            <input type="radio" name="enjoy" value="NOOK">Było do ...<br>
            </div>
            <div>
            <label for="">Co było fajne: </label><br>
            <input type="checkbox" name="info[]" id=""> Fajne towarzystwo<br>
            <input type="checkbox" name="info[]" id="">Fajne towarzystwo<br>
            <input type="checkbox" name="info[]" id="">Fajne towarzystwo<br>
            <input type="checkbox" name="info[]" id="">Fajne towarzystwo<br>
            <input type="checkbox" name="info[]" id="">Fajne towarzystwo<br>
                
            </div>
            <input type="submit" value="Wyślij">
        </form>
        <form action="" method="get"></form>
    </div>
    <?php
        if(isset($_POST['enjoy'])){
            $firstname = trim($_POST['firstname']);
            $lastname = trim($_POST['lastname']);
            $age = intval(trim($_POST['age']));
            if($firstname!=="" && $lastname!==""){
                
                echo "<p>Witaj {$firstname} {$lastname} pełnoletni OK</p>";
            }else{
                echo "<p>Witaj {$firstname} {$lastname} niepełnoletni OK</p>";
            }
        }

    ?>
    <script src="cw1.js" defer></script>
</body>
</html>