<?php		//var_dump($_COOKIE);
			if (isset($_COOKIE["cookie"])) {
				echo "<b>Miło nam, że nas znowu odwiedziłeś</b>";
			} else {
				$cookie_name = "cookie";
				$cookie_value = "cookie";
				$cookie_time = time() + 60*60;				
				setcookie($cookie_name, $cookie_value, $cookie_time,);				
			}
