<?php

class ContextDb{
    public array $users = [];
    public array $roles = [];
    public array $permisions = [];
    public mysqli $conn;
    public function __construct()
    {
        $this->conn = new mysqli("localhost","root",null,"3ti_users_v1");
    }
    public function usersLoad(){
        $sql = "SELECT * FROM users";
        $result = $this->conn->query($sql);
       // var_dump($result);
        $this->users = [];
        while($row = $result->fetch_row()){
         //   var_dump($row);
            $this->users[] = new User($row[0],$row[1],$row[2],$row[3],$row[4]);
        }
    }
    public function __destruct()
    {
        $this->conn->close();
    }
    public function usersLoadWithRole():array{
        $sql = "SELECT firstname,lastname,email,roles.name,roles.id as role FROM users INNER JOIN roles on users.role_id=roles.id";
        $result = $this->conn->query($sql);
       // var_dump($result);
       $usersWithRole = [];
        while($row = $result->fetch_row()){
           // var_dump($row);
            $vm = new UserViewModel();
            $vm->user = new User(-1,$row[0],$row[1],$row[2],$row[4]);
            $vm->role = new Role($row[3],[]);
            $usersWithRole[] = $vm;
        }
       // var_dump($usersWithRole);
        return $usersWithRole;
    }
    public function getRole(){
        $sql1 = "SELECT roles.id,roles.name from roles";
        $roles = [];        
        $result1 = $this->conn->query($sql1);
        while($row = $result1->fetch_row()){
            $roles[] = $row;
        }
     //   var_dump($roles);
        return $roles;
    }
    public function getRoleById(int $id):Role{
        $sql1 = "SELECT roles.name from roles where roles.id={$id}";            
        $sql2 = "SELECT permisions.name from permisions inner join role_permisions ".
            " on role_permisions.permision_id=permisions.id WHERE role_permisions.role_id={$id}";
        //echo $sql2;
        $result = $this->conn->query($sql2);
        $permisions = [];
        while($row=$result->fetch_row()){
            $permisions[] = $row[0];
        }
        $name = $this->conn->query($sql1)->fetch_row()[0];
        $role = new Role($name,$permisions);
        return $role ;
    }
}