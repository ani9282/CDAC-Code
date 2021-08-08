<?php
$uname=$_REQUEST["txtnm"];
$upass=$_REQUEST["txtpass"];
$uemail=$_REQUEST["email"];
$umob=$_REQUEST["mobile"];
$uaddr=$_REQUEST["txtadddr"];
$ugender=$_REQUEST["rdogender"];
$ucountry=$_REQUEST["selcountry"];
if($ugender=="M")
{
	$gender="Male";
}
elseif($ugender=="F")
{
	$gender="FeMale";
}
elseif($ugender=="T")
{
	$gender="Transgender";
}
else
{
	$gender="Unknown";
}

?>

<form action="confirm.php">
<table border="2" width="50%" align="center">
<tr>
<th colspan="2">Signup Details</th>
</tr>



<tr> 
<td> Username </td>
<td> <?php echo $uname; ?> </td>
</tr>



<tr> 
<td> Password </td>
<td> <?php echo $upass; ?> </td>
</tr>


<tr> 
<td> Email </td>
<td> <?php echo $uemail; ?> </td>
</tr>


<tr> 
<td> Mobile </td>
<td> <?php echo $umob; ?> </td>
</tr>


<tr> 
<td> Address </td>
<td> <?php echo trim($uaddr); ?> </td>
</tr>


<tr>
<td> Gender </td>
<td> <?php echo $gender; ?> </td>
</tr>


<tr> 
<td> Country </td>
<td> <?php echo $ucountry; ?> </td>
</tr>


<tr>
<Th colspan="2">
<button type="submit"> Confirm </button>
<button type="button" onclick="history.back();"> Edit </button>
</th></tr>
</table>
</form>