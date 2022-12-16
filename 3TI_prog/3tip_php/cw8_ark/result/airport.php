<!DOCTYPE html>
<html lang="pl">

<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">

	<title>Odloty samolotów</title>


	<link rel="stylesheet" href="style6.css">
</head>

<body>
	<div class="baner1">
		<h2>Odloty z lotniska</h2>
	</div>
	<div class="baner2"><img src="logo.png" alt="logotyp"></div>
	<div class="main">
		<h4>Tabela odlotów</h4>
		<table>
			<tr>
				<th>lp.</th>
				<th>numer rejsu</th>
				<th>czas</th>
				<th>kierunek</th>
				<th>status</th>
			</tr>
			<?php
			require_once "functions.php";
			$dane = getAll();
			//var_dump($dane);
			foreach($dane as $d){
				echo "<tr>\n";
				echo "<td>{$d[0]}</td>";
				echo "<td>{$d[1]}</td>";
				echo "<td>{$d[2]}</td>";
				echo "<td>{$d[3]}</td>";
				echo "<td>{$d[4]}</td>";
				echo "</tr>\n";
			}
			?>
		</table>
	</div>

	<footer>
		<div class="pobierz">
			<a href="samolot.png">Pobierz obraz</a>
		</div>
		<div id="cookie">
			<p>
				<?php
				require_once "cookie.php";
				?>
			</p>
		</div >
		<div id="autor">Autor: XXXXXXXX</div>
	</footer>
</body>

</html>