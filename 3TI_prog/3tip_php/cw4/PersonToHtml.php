<?php
require_once "Person.php";
class PersonToHtml{
    public static function ToTable(array $persons):string {
        $html = "<table class='table'>";
        $html .= "<tr><th>Lp</th><th>Imię</th><th>Nazwisko</th><th>Data urodzenia</th></tr>";
        $lp = 0;
        foreach($persons as $p){
            $lp++;
            $html .= "<tr>\n";
            $html .= "\t<td>{$lp}</td>\n";
            $html .= "\t<td>{$p->getFirstName()}</td>\n";
            $html .= "\t<td>{$p->getLastName()}</td>\n";
            $html .= "\t<td>{$p->getBirthDay()}</td>\n";  
            $html .= "</tr>\n";          
        }
        return $html."</table>\n";
    }
}