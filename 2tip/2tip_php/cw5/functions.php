<?php
function GetData():array {
    return  [
        "Roman Boman",
        "Ewlina Sprężyna",
        "Mariola Trudna",
        "Tomasz Bomasz"
    ];
}
function getUsers():array {
    return [  // [login,email,accepted]
        ["user1","us1@gmail.com",true],
        ["user2","us2@gmail.com",false],
        ["user3","us3@gmail.com",false],
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
