<?php include 'connection.php'?>
<?php
session_start();
if(isset($_COOKIE["cname"]))
{
$uname = $_COOKIE["cname"];
}
else
{
	$uname = "Guest";
}
$upass = $_COOKIE["cpass"];
$email = $_SESSION["semail"];
$mobile = $_SESSION["smobile"];

//echo "Connection is successfull";

$sql = "Insert into registration (username,password,email,mobile) 
values ('$uname','$upass','$email',$mobile)";

//echo "<br/>" .  $sql . "<br/>";

//echo mysqli_query($conn,$sql);
if(mysqli_query($conn,$sql))
{
	echo "User registered successfully in database";
}
else
{
	echo "Error : " . $sql . "<br/>" . mysqli_error();
}



mysqli_close($conn);


?>

<h1> <?php echo $uname; ?> have successfully registered with our website you will get authorization email on your registered email id <?php echo $email ?> and sms on your registered mobile <?php echo $mobile ?> to activate your account 
</h1>

<H3>

Please <a href="homepage.htm">click here</a> to go to homepage

</H3>
<?php
//setcookie("cname","",time()-3600);
//session_destroy();
//session_unset("semail")
?>













