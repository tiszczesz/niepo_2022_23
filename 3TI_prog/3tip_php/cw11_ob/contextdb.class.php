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
        $sql = "SELECT firstname,lastname,email,roles.name as role FROM users INNER JOIN roles on users.role_id=roles.id";
        $result = $this->conn->query($sql);
       // var_dump($result);
       $usersWithRole = [];
        while($row = $result->fetch_assoc()){
            var_dump($row);
            $vm = new UserViewModel();
           // $vm->user = new User(-1,
           // $usersWithRole[] = 
        }
        return $usersWithRole;
    }
}