<?php
$qt1=$_REQUEST["qty1"];
$sqt1=$_REQUEST["selqty1"];
$qt2=$_REQUEST["qty2"];
$sqt2=$_REQUEST["selqty2"];
$qt3=$_REQUEST["qty3"];
$sqt3=$_REQUEST["selqty3"];
$qt4=$_REQUEST["qty4"];
$sqt4=$_REQUEST["selqty4"];
$qt5=$_REQUEST["qty5"];
$sqt5=$_REQUEST["selqty5"];
$qt6=$_REQUEST["qty6"];
$sqt6=$_REQUEST["selqty6"];
$qt7=$_REQUEST["qty7"];
$sqt7=$_REQUEST["selqty7"];
$qt8=$_REQUEST["qty8"];
$sqt8=$_REQUEST["selqty8"];
$qt9=$_REQUEST["qty9"];
$sqt9=$_REQUEST["selqty9"];
$cake=""



foreach($cake as $ck)
{
	$cake= $ck.","; 
}
?>


<form action="ord.php">
<table border="2" width="50%" align="center">
<tr>
<th colspan="2">Order Details</th>
</tr>



<tr> 
<td>Princess Strawberry </td>

<td> <?php echo $uname; ?> </td>
</tr>