<HTML>
<HEAD> 
<TITLE> NEW USER REGISTRATION </TITLE> 
<!--<link rel="stylesheet" href="styles.css">-->
<style>
input{
border-radius:8px;
}

#sample
{
	background-color:yellow;
	color:red;
}

.txtfont
{
	font-size:16;
	font-family:ARIAL;
}

tr:hover
{
	background-color:blue;
}



table{	/*border-bottom : 2px dotted blue;
	border-top : 2px dotted blue;*/
}

table{
border-collapse:collapse;
}

th,td
{
	text-align:left;
	padding:6px;
}


tr:nth-child(even){
background-color:gray;
}



</style>
</HEAD>
<BODY>
<?php include 'connection.php'?>
<?php
session_start();
$uname = $_SESSION["sname"];

$sql = "select password,email,mobile from registration
where username = '$uname'";

$upass="";
$uemail="";
$umobile="";

$result = mysqli_query($conn,$sql);

if(mysqli_num_rows($result)>0)
{
	while($row = mysqli_fetch_assoc($result))
	{
		
		$upass = $row["password"];
		$uemail = $row["email"] ;
		$umobile = $row["mobile"];
	}
}

mysqli_close($conn);


?>



<center
<h1 class="txtfont"> My Account </h1>
</center>
<form action="update.php" method="get" name="frmregister">
<TABLE  WIDTH="40%" ALIGN="CENTER">
<tr>
<th colspan="2"> Registraion Form </th>
</tr>
<Tr> 
<td>
Username 
</td>
<td> <input id="sample" style="color:blue;" placeholder="Enter Username" type="text" name="txtname" value=<?php echo $uname?> readonly maxlength="10" autofocus required/> </td>
</tr>
<Tr> 
<td>
Password
</td>
<td> <input id="sample" 
	value = "<?php echo $upass ; ?>"
 type="password" name="txtpass" placeholder="Enter Password" required/> </td>
</tr>
<Tr> 
<td nowrap>
Confirm Password
</td>
<td> <input value = "<?php echo $upass ; ?>" type="password" name="txtcpass" placeholder="Retype Password" required/> </td>
</tr>
<Tr> 
<td>
Email
</td>
<td> <input type="email" name="email"
value = "<?php echo $uemail ; ?>"
 placeholder="Enter Email" required/> </td>
</tr>
<Tr> 
<td>
Mobile
</td>
<td> <input type="number" 
value = "<?php echo $umobile ; ?>"
name="mobile" placeholder="Enter Mobile 10 Digits" required/> </td>
</tr>
<tr>
<Td align="right"> <input type="submit" value="Update"/> </td> 
<Td> <a style="background-color:lightgray; color:black;padding:5;margin:10;
text-decoration:none" href="delete.php"> Delete </a> </td> 
</tr>
</TABLE>
</form>
<!--
<div> 
My Favouraite Song 
<audio controls autoplay>
<source src= "resources/samplemusic.mp3" type="audio/mpeg"/>
</audio>
</div>
<div> My Favouraite Video
<video controls autoplay loop>
<source src= "resources/video.mp4" type="video/mp4"/>
</video>
</div>
-->
</Body>
</HTML>