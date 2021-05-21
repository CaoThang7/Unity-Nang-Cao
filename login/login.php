<?php

//connect database

$dsn="mysql:host=localhost;dbname=lab1_lycaothang";
$user ='root';
$pass='';
$dn =new PDO($dsn,$user,$pass);

//Khai bao bien de nhan gia tri tu unity dua qua

$id_nhan=$_POST['id_chuyen'];
$user_nhan=$_POST['user_chuyen'];
$pass_nhan=$_POST['pass_chuyen'];
$level_nhan=$_POST['level_chuyen'];
$point_nhan=$_POST['point_chuyen'];
// $pass_nhan=$_POST['password_chuyen'];


// $sql="insert into user value('2','abc','0123','QuangTrung','abc@gmail.com','123')";

$sql="insert into user value('$id_nhan','$user_nhan','$pass_nhan','$level_nhan','$point_nhan')";
if($dn->exec($sql)==TRUE){
    echo "Thanh cong";
}
else{
    echo "That bai";
}


?>