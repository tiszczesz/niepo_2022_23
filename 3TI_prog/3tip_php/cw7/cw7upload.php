<?php
$dir = __DIR__;
echo $dir."<br>";
$targetDir = "/images/";
echo $dir.$targetDir;
const SIZE = 1000000;
//echo "<pre>";
var_dump($_POST);
var_dump($_FILES);
$targetFile = $dir.$targetDir.basename($_FILES["image"]["name"]);
var_dump($targetFile);
$fileType = strtolower(pathinfo($targetFile,PATHINFO_EXTENSION));
var_dump($fileType);
$uploadOK = true;
if(isset($_POST["submit"])){
    $check = getimagesize($_FILES['image']['tmp_name']);
    if($check!==false){
        echo "To jest obrazek typu; ".$check["mime"];
        $uploadOK = true;
    }else{
        echo "Wybrano zły plik!!!!";
        $uploadOK = false;
    }
    
}
if(file_exists($targetFile)){
    echo "Niestety taki obrazek juz istnieje!!!";
    $uploadOK = false;
}
if($_FILES['image']['size']>SIZE){
    echo "Obrazek ma za duży rozmiar (Maksymalny rozmiar: ".SIZE.")";
    $uploadOK = false;
}
if($fileType!="jpg" && $fileType!="png" && $fileType!="jpeg" && $fileType!="gif"){
    echo "ERROR: zły typ obrazka";
    $uploadOK = false;
}

if($uploadOK){
    if(move_uploaded_file($_FILES['image']['tmp_name'],$targetFile)){
        echo "Plik: ".htmlspecialchars(basename($_FILES['image']['name']))." pobrano";
    }else{
        echo "niestety błąd przy pobraniu pliku!!!";
    }
}else{
    echo "Nie przeszło walidacji!!!!";
}