<?php
class Role{
    public function __construct(private string $name,private array $permissions)
    {
        
    }
    public function __toString():string
    {
        $html = "Uprawnienia: <ul>";
            foreach($this->permissions as $p){
                $html .= "<li>{$p}</li>";
            }
        $html .= "</ul>";
        return "<div>nazwa roli: {$this->name}</div>\n{$html}";
    }
}