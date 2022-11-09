<?php
function getConnection() :?mysqli {
    $conn = new mysqli("localhost","root",null,"3ti_prog_cw1");
    if($conn->connect_errno!=0) return null;
    $conn->set_charset('utf8');
    return $conn;
}
function getBooks():array {
    $conn = getConnection();
    if($conn==null) die("ERROR SQL");
    $books = [];
    $sql = "SELECT * FROM books";
    $result = $conn->query($sql);
    if($result==false) return [];
    while($row = $result->fetch_row()){
        $books[] = $row;
    }
    $conn->close();
    return $books;
}
function booksToTab(array $books):string {
    $html = "<table>\n";
    $html .= "<tr><th>Lp</th><th>Tytuł</th><th>Cena</th><th>Autor</th></tr>\n";
    $lp=0;
    foreach($books as $b){
        $lp++;
        $html .= "<tr>\n";
        $html .= "\t<td>{$lp}</td>\n";
        $html .= "\t<td>{$b[1]}</td>\n";
        $html .= "\t<td>{$b[2]}</td>\n";
        $html .= "\t<td>{$b[3]}</td>\n";
        $html .= "</tr>\n";
    }
    return $html."</table>\n";
}