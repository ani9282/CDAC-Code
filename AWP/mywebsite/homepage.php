<html>
<head> <title> Homepage </title>
<style>
div{
position:absolute;
text-align:center;
left:500;
top:300;
width:300;
border: 1px solid red;
background-color:aqua;
}

</style>
</head>
<body>
<form action ="chklogin.php">
<div>
<br/>
<b> Login Panel </b>
<br/>
<br/>

<?php if(isset($_REQUEST["msg"])) echo "<p style='background-color:yellow; color:red'>". $_REQUEST["msg"] . "</p>";?>

<label for="txtname"> Usename: </label>
<input type="text" id="txtname" name="username"/>
<br/> <br/><label for="txtpass"> Password: </label>
<input type="password" id="txtpass" name="userpassword"/>
<br/>
<br/>
<input type="submit" value = "Login"/>
<br/>
<a href="signup.htm"> New User? </a>

</div>
</form>
</body>
</html>