<?php

function GetData():array {
    $data =  [];
    $lines =  file("dane.txt",FILE_IGNORE_NEW_LINES);
    foreach($lines as $row){
        $data[] = explode('|',$row);
    }
    return $data;
}
function ToTable(array $data):string {
    $html = "<table class='table table-stripped'>";
    $html .= "<tr><th>Lp</th><th>Nazwa kursu</th><th>Miejsce</th>"
         ."<th>Cena</th><th>Data</th></tr>";
    $lp = 0;
    foreach($data as $row){
        $lp++;
        $html .= "<tr><td>{$lp}</td><td>{$row[0]}</td> <td>{$row[1]}</td>"
               ."<td>{$row[2]}</td><td>{$row[3]}</td></tr>";//todo
    }
    return $html."</table>";
}
function AddToFile(array $data,string $fileName = "dane.txt"): bool{
    if(count($data)!=4) return false;
    
}