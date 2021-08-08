<?php include 'connection.php'?>

<?php
session_start();
$uname = $_SESSION["sname"];
$sql = "delete from registration where username='$uname'";
if(mysqli_query($conn,$sql))
{
//	echo "updated successfully";
	//echo "<script> alert('User Details updated' </script>";
	session_destroy();
	header("Location:http://localhost/mywebsite/homepage.php");
}
else
{
	echo "Error : " . $sql . "<br/>" . mysqli_error();
}
?>