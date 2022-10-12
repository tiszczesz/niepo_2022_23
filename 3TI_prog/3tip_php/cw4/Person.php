<?php
class Person
{
    private string $firstName;
    private string $lastName;
    private string $birthDay;
    public function __construct(string $firstName, string $lastName, string $birthDate)
    {
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->birthDay = $birthDate;
    }
    public function getAge(): int
    {
        return intval(date("Y"))-intval(
                date( "Y",strtotime(filter_input(INPUT_POST, 'birthDate'))
            ));
    }
}