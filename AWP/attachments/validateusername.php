<?php include 'connection.php'?>
<?php
$uname = $_REQUEST["username"];
$sql = "select count(*) as userexists from registration where username='$uname'";

$result = mysqli_query($conn,$sql);

while($row = mysqli_fetch_assoc($result))
{
	if($row["userexists"])
	{
		echo "UserName Already Exists";
	}
	else
	{
		echo "UserName is Available";
	}
}

mysqli_close($conn);
?>