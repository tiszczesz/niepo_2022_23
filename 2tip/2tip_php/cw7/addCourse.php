<?php
if(filter_has_var(INPUT_POST,'CourseName')){
 //pobrać dane z formularza
 $CourseName = trim(filter_input(INPUT_POST,"CourseName"));
 $CoursePlace = trim(filter_input(INPUT_POST,"CoursePlace"));
 $CoursePrice = trim(filter_input(INPUT_POST,"CoursePrice",FILTER_VALIDATE_FLOAT));
 var_dump($_POST);
 //sprawdzić poprawność
 //dopisać do pliku dane.txt
}else{
   // header("Location: cw7.php");
}