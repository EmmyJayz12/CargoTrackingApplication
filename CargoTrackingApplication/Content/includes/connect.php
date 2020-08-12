<?php
$connect = mysqli_connect('localhost','root' ,'','delight_freight_db');
$_SESSION['connect']  =  $connect;
 if(!$connect){
 die('Could not connect to database'); 
     }
?>