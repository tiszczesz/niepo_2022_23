<?php
class Role{
    public function __construct(private string $name,private array $permissions)
    { 
    }
    public function __toString():string
    {
        $html = "Uprawnienia: <ul class='list-group'>";
            foreach($this->permissions as $p){
                $html .= "<li class='list-group-item'>{$p}</li>";
            }
        $html .= "</ul>";
        return "<div>nazwa roli: {$this->name}</div>\n{$html}";
    }
    public function getRoleName(){
        return $this->name;
    }
}