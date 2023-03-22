<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Wynajem pokoi</title>
    <link rel="stylesheet" href="styl2.css">

</head>
<body>
    
    <section id="baner">
        <h1>Pensjonat pod dobrym humorem</h1>
    </section>
    <section id="lewy">
        <a href="index.html">GŁÓWNA</a>
        <img src="1.bmp" alt="pokoje">
    </section>
    <section id="srodkowy">
        <a href="cennik.php">CENNIK</a>
        <table>
            
                <?php
                
                
                $conn = mysqli_connect("localhost", "root", "","bolek");

                $query = "SELECT * FROM pokoje";

                $result = mysqli_query($conn, $query);

                

                while($row = mysqli_fetch_array($result)){
                    echo("<tr><td>".$row[0]."</td><td>".$row[1]."</td><td>".$row[2]."</td></tr>");
                }
                
                mysqli_close($conn);

                ?>
            
        </table>
    </section>
    <section id="prawy">
        <a href="kalkulator.html">KALKULATOR</a>
        <img src="3.bmp" alt="pokoje">
    </section>
    <section id="stopka">
        <p>Stronę opracował: Kacper Rogóż 3TIP</p>
    </section>
</body>
</html>