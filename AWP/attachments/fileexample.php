<?php
$fl =  fopen("sample.txt","r");
//echo fread($fl,filesize("sample.txt"));
//$txt = fread($fl,filesize("sample.txt"));

while(!feof($fl)){
	echo "<h1>";
echo fgets($fl);
}
fclose($fl);

$wfl = fopen("newfile.txt","w");
$txt = "Hello we are writing the file using filestream";
fwrite($wfl,$txt);
fclose($wfl);
?>