<?php
var_dump($_POST);
$d = (new DateTime())->createFromFormat('Y-m-d',$_POST['bd']);
echo "<p>{$d->format('Y-m-d')}</p>";