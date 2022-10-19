<?php
require_once "Person.php";
class FileOperations{
    public static function AddToFile(string $filename,Person $p):void {
       $file = fopen($filename,'a');
        var_dump($p->toFileLine());
        if($file){
            fwrite($file,$p->toFileLine().PHP_EOL);
            fclose($file);
        }        
    }
    public static function LoadFromFile(string $filename):array{
        $lines = file($filename,FILE_IGNORE_NEW_LINES);
        $persons = [];
        foreach($lines as $line){
            $data = explode('|',$line);
            if(count($data)===3){
                $persons[] = new Person($data[0],$data[1],$data[2]);
            }            
        }
        return $persons;
    }
}