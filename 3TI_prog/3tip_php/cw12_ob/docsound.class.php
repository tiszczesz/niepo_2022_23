<?php
class DocSound extends Document {
    public function __construct(string $name,string $content,
                private string $type)
    {
       parent::__construct($name,$content);      
    }
}