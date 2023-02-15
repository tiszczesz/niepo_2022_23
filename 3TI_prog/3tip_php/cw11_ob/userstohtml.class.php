<?php
class UsersToHTML{
    public static function toTable(array $users):string {
        $html = "<table class='table table-striped'><tr><th>Imię</th><th>Nazwisko</th><th>Email</th></tr>";
        foreach($users as $u){
            $html .= "<tr>"
               ."\t<td>{$u->firstname}</td>\n"
               ."\t<td>{$u->lastname}</td>\n"
               ."\t<td>{$u->email}</td>\n</tr>\n";               
        }

        return $html."</table>";
    }
    public static function toTableUserRoles(array $users):string {
        $html = "<table class='table table-striped'><tr><th>Imię</th><th>Nazwisko</th><th>Email</th><th>Rola</th></tr>";
        foreach($users as $u){
            $html .= "<tr>"
               ."\t<td>{$u->user->firstname}</td>\n"
               ."\t<td>{$u->user->lastname}</td>\n"
               ."\t<td>{$u->user->email}</td>\n</tr>\n";               
        }

        return $html."</table>";
    }
}