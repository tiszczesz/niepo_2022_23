<?php
class User
{
    public int $id;
    public string $firstname;
    public string $lastname;
    public string $email;
    public int $role_id;
    public function __construct(
        int $id = -1,
        string $firstname = "Damian",
        string $lastname = "Nowak",
        string $email = "nowak@gmail.com",
        int $role_id = -1
    ) {
        $this->id = $id;
        $this->firstname = $firstname;
        $this->lastname = $lastname;
        $this->email = $email;
        $this->role_id = $role_id;

    }
    public function __toString():string
    {
        return "<div>{$this->firstname} {$this->lastname} email: {$this->email}</div>";
    }
    
}
