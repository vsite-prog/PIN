<!DOCTYPE html>
<html>
<head>
<title> Kalkulator izračunao </title>
</head>
<body>
<h4> Izracun </h4>
<?php 
	print_r($_GET);
	echo('<p>');
	$a = $_GET['a'];
	$b = $_GET['b'];
	$c = intval($a) + intval($b);
	echo('Rezultat zbroja ' . $a . ' i ' . $b . ' je ' . strval($c));
	echo('</p>');
?>
</body>
</html>