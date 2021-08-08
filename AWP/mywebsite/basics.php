<html>
<head> <title> PHP Basics </title> </head>
<body>

<?php
/*$str = "Hi";
$greet = "Good Morning";
echo "<b> $str </b> " . $greet ;*/
$num=0;
?>

<br/>

<?php
//print($num);
//string functions
/*
$info = "PHP is a server side scripting language. that is used to develop Static websites or Dynamic websites or Web applications. PHP stands for Hypertext Pre-processor, that earlier stood for Personal Home Pages.";

$str = "   Hello World !!     ";
echo strlen($str) . "<br/>";
echo strToLower($str) . "<br/>";
echo strToUpper($str) . "<br/>";
echo str_word_count($str) . "<br/>";
echo strrev($str) . "<br/>";
echo strpos($str,"World") . "<br/>";
echo str_replace("World","Universe",$str). "<br/>";
echo substr($str,strpos($str,"World"),2) . "<br/>";

echo substr($str,-4) . "<br/>";
echo strlen(trim($str)) . "<br/>";
echo wordwrap($info,57,"<br>\n") . "<br/>";*/

//PHP Arrays
/*
$cars[0] = "BMW";
$cars[1] = "MERCEDEZ";
$cars[2] = "VOLVO";
$cars[3] = "TOYOTA";
*/

$cars = array("BMW","VOLVO","MERCEDEZ","TOYOTA");
//echo $cars[2];

/*
for($i=0;$i<count($cars);$i++)
{
	echo $i+1 . ")". $cars[$i] . "<br/>";
}*/

//sort($cars)
rsort($cars);

foreach($cars as $car)
{
	echo $car . "<br/>";
}

//Associative Array
$employee["Parag"] = 1005;
$employee["Prachi"] = 1002;
$employee["Manas"] = 1003;
$employee["Daesha"] = 1004;

//echo "Employee id of Manas is " , $employee["Manas"];

//asort($employee);
//arsort($employee);
krsort($employee);
foreach($employee as $emp => $empid)
{
	echo "Employee " . $emp . " has employee id " . $empid ."<br/>";
}

echo $_COOKIE["cname"];























?>
















<body>
