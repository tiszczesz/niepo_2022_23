<?php

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $dni = isset($_POST["dni"]) ? $_POST["dni"] : null;
    $typ = isset($_POST["typ"]) ? $_POST["typ"] : null;
    
    if($dni == null || $typ == null) echo("Brak danych");

    $conn = mysqli_connect("localhost", "root", "","bolek");

    $query = "SELECT nazwa, cena FROM pokoje";

    $result = mysqli_query($conn, $query);

    $cena = null;

    while($row = $result->fetch_assoc()){
        if($row["nazwa"] == $typ) $cena = $row["cena"]*$dni;
    }

    echo($cena);

    mysqli_close($conn);
}