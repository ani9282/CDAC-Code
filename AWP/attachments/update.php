<?php include 'connection.php'?>
<?php session_start();
$uname = $_SESSION["sname"];
$upass = $_REQUEST["txtpass"];
$uemail = $_REQUEST["email"];
$umobile = $_REQUEST["mobile"];

$sql = "Update registration 
set email = '$uemail',
mobile = $umobile,
password = '$upass'
where username = '$uname'
";



if(mysqli_query($conn,$sql))
{
//	echo "updated successfully";
	echo "<script> alert('User Details updated' </script>";
	header("Location:http://localhost/mywebsite/account.php");
}
else
{
	echo "Error : " . $sql . "<br/>" . mysqli_error();
}


mysqli_close($conn);
?>