<?php
class RoleToHtml{
    public static function GetRoleInList(array $roles,string $type="ul"){
       
        $html = "<{$type}>\n";
            foreach($roles as $r){
                $html .= "\t<li><a href='?id={$r[0]}'>{$r[1]}</a></li>";
            }

        return $html."</{$type}>";
    }
}