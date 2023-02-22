<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <title>Document</title>
</head>
<body>
    <div class="container">
         <?php
        spl_autoload_register(function (string $classname){
            require_once strtolower($classname).'.class.php';
        });
        $db = new ContextDb();
       // $db->usersLoad();
        //var_dump($db->users);
        //echo UsersToHTML::toTable($db->users);
        echo UsersToHTML::toTableUserRoles($db->usersLoadWithRole());
    ?>
    <div class="row">
        <div class="col-4">
            <?php
                echo RoleToHtml::GetRoleInList($db->getRole(),"ol")
            ?>
        </div>
        <div class="col-8">
            <?php
            if(filter_has_var(INPUT_GET,'id')){
                $id = filter_input(INPUT_GET,'id');
                echo $db->getRoleById($id);
            }else{
                echo "<div>Tu będą uprawnienia dla danej roli....po kliknięciu w rolę</div>";
            }
            ?>
        </div>
        <div>
            <a href="cw11_admin.php">Operacje na uprawnieniach</a>
        </div>
    </div>
    </div>
   
</body>
</html>