<?php
require_once "Person.php";
require_once "FileOperations.php";
if (filter_has_var(INPUT_POST, 'firstName')) {
    $p1 = new Person(
        trim(filter_input(INPUT_POST, 'firstName')),
        trim(filter_input(INPUT_POST, 'lastName')),
        trim(filter_input(INPUT_POST, 'birthDate')),
    );
    //var_dump($p1);
    FileOperations::AddToFile("osoby.txt",$p1);
    echo $p1->getAge();
    if($p1->getAge()>=18){
        header("Location: dlaDoroslych.html");
    }else{
        header("Location: dlaMlodych.html");
    }
    echo date("Y-m-d", strtotime(filter_input(INPUT_POST, 'birthDate'))) . "<br>";
    echo date("Y",);
}
