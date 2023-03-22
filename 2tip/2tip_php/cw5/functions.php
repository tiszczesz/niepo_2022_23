<?php
function GetData():array {
    return  [
        "Roman Boman",
        "Ewlina Sprężyna",
        "Mariola Trudna",
        "Tomasz Bomasz"
    ];
}

function getColors():array {
    return [
        "white" => "biały",
        "black" => "czarny",
        "red" => "czerwomny",
        "green" => "zielony",
        "blue" => "niebieski",
        "yellow" => "żółty",
        "orange" => "pomarańczowy"
    ];
}

function getUsers():array {
    return [  // [login,email,accepted]
        ["user1","us1@gmail.com",true],       //tab[0][1] -> "us1@gmail.com"
        ["user2","us2@gmail.com",false],
        ["user3","us3@gmail.com",false],       //tab[key][2]
        ["user4","us4@gmail.com",true],
        ["user5","us5@gmail.com",false],
    ];
}
function userToTable(array $users):string{
    $html = "<table class='t1'>";
    //todo  th -> lp , login email użytkownicy którzy zaakceptowali regulamin wiersz na zielono foreach

    return $html."</table>";
}
function generSelect(array $dane):string {
    $html = "<select name='choice' class='select-dane'>\n";
    foreach($dane as $k => $elem){
        $html .= "\t<option value='{$k}'>{$elem}</option>\n";
    }
    return $html . "</select>\n";
}

function toList(array $data,string $type="ul"):string {
    $html = "<{$type}>";
    foreach($data as $item){
        $html .= "<li>{$item}</li>";
    }
    return $html."</{$type}>";
}