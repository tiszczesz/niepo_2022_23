<?php
class DocText extends Document implements Printable {
    public function Print():void
    {
        echo "<p>Drukowanie zawartośći dokumentu: {$this->content}</p>";
    }
}