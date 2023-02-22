<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php

    spl_autoload_register(function (string $classname) {
        require_once strtolower($classname) . '.class.php';
    });
    $db = new ContextDb();
    // $db->usersLoad();
    //var_dump($db->users);
    //echo UsersToHTML::toTable($db->users);
    //echo UsersToHTML::toTableUserRoles($db->usersLoadWithRole());
    echo RoleToHtml::GetRoleInList($db->getRole(),"ul")
    ?>

    <div>Operacje na uprawnieniach</div>
</body>

</html>