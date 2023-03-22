<?php
class DocImage extends Document implements Printable {
    public function __construct(string $name,string $content,
                private int $width, private int $height)
    {
       parent::__construct($name,$content);      
    }
    public function Print():void
    {
        echo "<p>Drukowanie obrazka ".
               " szerokość: {$this->width} wysokość: {$this->height}</p>";
    }
    
}

