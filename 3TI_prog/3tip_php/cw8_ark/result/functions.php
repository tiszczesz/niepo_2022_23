<?php
function getConnection():?mysqli{
    $conn = new mysqli("localhost","root",null,"3ti_prog_ark3odloty" );
    if($conn->connect_errno!=0) return null;
    return $conn;
}
function getAll(){
    $conn = getConnection();
    if($conn==null) return [];
    $dane = [];
    $sql = "SELECT id,nr_rejsu,czas,kierunek,status_lotu FROM odloty ORDER BY  czas DESC";
    $result = $conn->query($sql);
    while($row=$result->fetch_array()){
        $dane[] = $row;
    }
    $conn->close();
    return $dane;
}


