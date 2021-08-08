<?php
session_start();
//$uname = $_POST["txtname"];
//$uname = $_GET["txtname"];
$uname = $_REQUEST["txtname"];
$upass = $_REQUEST["txtpass"];
$uemail = $_REQUEST["email"];
$umobile = $_REQUEST["mobile"];
$ugender = $_REQUEST["rdogender"];
$uaddress =  $_REQUEST["txaaddr"];
$uedu = $_REQUEST["chkedu"];
$ucountry = $_REQUEST["selcountry"];
if(isset($_REQUEST["selhobbies"]))
{
$uhobbies = $_REQUEST["selhobbies"];
}
$uhobbies = "";

$uhobbies = "";
$uhobbies = "";
$uexperience = $_REQUEST["experience"];
$dob = $_REQUEST["dob"];
$profile = $_REQUEST["profile"];
//echo $profile;
$education = "";
$hobbies  = "";

setcookie("cname",$uname,time()+3600);
$_SESSION["semail"] = $uemail;
$_SESSION["smobile"] = $umobile; 
setcookie("cpass",$upass,time()+3600);



foreach($uedu as $edu)
{
	$education.= $edu.","; 
}

$education = substr($education,0,strlen($education)-1);

if($uhobbies!="")
{
foreach($uhobbies as $hobby)
{
	$hobbies.= $hobby.","; 
}
}

$hobbies = substr($hobbies,0,strlen($hobbies)-1);


if($ugender == "M")
{
	$gender = "Male";
}
elseif($ugender == "F")
{
	$gender = "Female";
}
elseif($ugender == "T")
{
	$gender = "Transgender";
}
else
{
	$gender = "Unknown";
}


?>
<form action ="userregister.php">
<table border=1 width="50%" align="center">
<tr>
<th colspan="2"> Signup Form </th>
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
<td> Gender </td>
<td> <?php echo $gender; ?> </td>
</tr>
<tr> 
<td> Mobile </td>
<td> <?php echo $umobile; ?> </td>
</tr>
<tr> 
<td> Address </td>
<td> <?php echo trim($uaddress); ?> </td>
</tr>
<tr> 
<td> Education </td>
<td> <?php echo $education; ?> </td>
</tr>
<tr> 
<td> Country </td>
<td> <?php echo $ucountry; ?> </td>
</tr>
<tr> 
<td> Hobbies </td>
<td> <?php echo $hobbies; ?> </td>
</tr>
<tr> 
<td> Experience </td>
<td> <?php echo $uexperience . " years"; ?> </td>
</tr>
<tr> 
<td> DOB </td>
<td> <?php echo $dob; ?> </td>
</tr>
<tr> 
<td > Profile Photo </td>
<td> <img width="100" src="images/<?php echo $profile; ?>"/> </td>
</tr>
<tr>
<Th colspan="2">
<button type="submit"> Confirm </button>
<button type="button" onclick="history.back();"> Edit </button>
</th>

</table>
</form>







