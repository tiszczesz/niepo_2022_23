<?php
function GetFromFile(string $filename): array
{
    $dane = file($filename, FILE_IGNORE_NEW_LINES);
    $result = [];
    foreach ($dane as $item) {
        $result[] = explode('|', $item);
    }
    return $result;
}

function ToHTMLTab(array $dane): string
{
    $html = "<table class='table table-striped'>";
    $html .= "<tr><th>Lp</th><th>Imię</th><th>Nazwisko</th><th>Wiek</th><th>Pensja</th></tr>";
    $lp = 0;
    foreach ($dane as $row) {
        $lp++;
        $html .= "<tr><td>{$lp}</td><td>{$row[0]}</td><td>{$row[1]}</td>"
            . "<td>{$row[2]}</td><td>{$row[3]}</td></tr>";
    }
    return $html . "</table>";
}
function ToSelect(string $toSelect = 'all'): string
{
    $html = "<form method='post'>\n<select name='letter' id='letter' class='form-select'>\n";

    $html .= "<option value='all'>Wszystko</option>";
    foreach (range("a", "z") as $c) {
        $select = $toSelect === $c ?  " selected='true'" : "";
        $html .= "\t<option value='{$c}' {$select}>{$c}</option>\n";
    }
    return $html . "</select><input class='btn btn-primary w-100' type='submit' value='wybierz'></form>\n";
}

function StartWith(array $data, string $letter): array
{
    $result = [];
    foreach ($data as $elem) {
        if (strtolower($elem[0][0]) == $letter || strtolower($elem[1][0]) == $letter) {
            $result[] = $elem;
        }
    }
    return $result;
}
function StartWithFilter(array $data, string $letter): array
{
    return array_filter(
        $data,
        fn ($v) => strtolower($v[0][0]) == $letter || strtolower($v[1][0]) == $letter
    );
}
