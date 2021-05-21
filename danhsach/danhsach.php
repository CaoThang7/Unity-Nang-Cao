<?php

$dsn="mysql:host=localhost;dbname=lab1_lycaothang";
$user='root';
$pass='';
$db= new PDO($dsn,$user,$pass);

$sql = "select * from user";

$ketqua= $db->query($sql);

 while($row = $ketqua->fetch())
 {

    printf("%s-%s-%s-%s-%s-",$row[0],$row[1],$row[2],$row[3],$row[4],$row[5]);
    print(",");
 }
?>