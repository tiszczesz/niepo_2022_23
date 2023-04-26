<?php 

class User{
    private string $firstname;
    private string $lastname;
    private int $age;

    public function __construct()
    {
        $this->firstname = "Alan";
        $this->lastname = "Fabiak";
        $this->age = 34;
    }
    public function __toString():string
    {
        return "User: {$this->firstname} {$this->lastname} wiek: {$this->age}";
    }
}