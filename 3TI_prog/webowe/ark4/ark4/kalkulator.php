<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Wynajem pokoi</title>
    <link rel="stylesheet" href="styl2.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script>
    
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
       
        <form id="form">
            <label for="typ">Typ pokoju</label>
            <select name="typ">
                <?php
                
                
                $conn = mysqli_connect("localhost", "root", "","bolek");

                $query = "SELECT nazwa FROM pokoje";

                $result = mysqli_query($conn, $query);

                

                while($row = mysqli_fetch_array($result)){
                    echo("<option value='".$row[0]."'>".$row[0]."</option>");
                }
                
                mysqli_close($conn);

                ?>
            </select>


            <label for="dni">Ilość dni</label>
            <input type="number" name="dni" min="0" oninput="validity.valid||(value='');">

            <div>
                <input type="submit" value="Oblicz"> <input type="reset" id="reset">
            </div>
            <span id="wynik">

            </span>
        </form>

        

    </section>
    <section id="prawy">
        <a href="kalkulator.html">KALKULATOR</a>
        <img src="3.bmp" alt="pokoje">
    </section>
    <section id="stopka">
        <p>Stronę opracował: Kacper Rogóż 3TIP</p>
    </section>


    
    <script type="text/javascript">
        // Variable to hold request
var request;


$("#form").submit(function(event){

    event.preventDefault();

    var $form = $(this);
   
    var $inputs = $form.find("input, select");

    var serializedData = $form.serialize();

    $inputs.prop("disabled", true);

  
    request = $.ajax({
        url: "kalkulus.php",
        type: "post",
        data: serializedData
    });

    request.done(function (response, textStatus, jqXHR){

        $("#wynik").text("Cena wynosi: " + response + "zł");
    });


    request.always(function () {
        $inputs.prop("disabled", false);
    });

});

$("#reset").click(function(){
    $("#wynik").text("");
});

    </script>

</body>
</html>