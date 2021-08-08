<?php include 'connection.php'?>

<?php
$uname = $_REQUEST["username"];
$upass = $_REQUEST["userpassword"];

//$sql = "select username,password,email from registration where username like 'r%'";

$sql = "select count(*) as cnt from registration where username = '$uname' 
and password ='$upass'";
//echo $sql."<br/>";

$result = mysqli_query($conn,$sql);
$loginflag = 0;
if(mysqli_num_rows($result)>0)
{
	while($row = mysqli_fetch_assoc($result))
	{
		$loginflag = $row["cnt"];
		/*echo $row["username"] . "  " .$row["password"] . " " . $row["email"] . "<br/>";*/
	}
}
else
{
	echo "No records found";
}
if($loginflag == 0)
{
		$errmsg =  "User Credentials are incorrect";
		header("Location:http://localhost/mywebsite/homepage.php?msg=$errmsg");
}
else{
?>

<ul style="list-style : none;">
<li style="float:left;padding:5"> <a href=""> MyAccount <a></li>
<li style="float:left;padding:5"> <a href=""> MyOrders </a> </li>
<li style="float:left;padding:5"> <a href="">  MyMessages </a></li>
</ul>	
<?php	
}












mysqli_close($conn);
?>