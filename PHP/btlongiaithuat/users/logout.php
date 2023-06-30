<?php
    // Cách 1
    //setcookie("login", "true", time()-7*24*60*60, "/");

    // Cách 2
    $token = "";
    if(isset($_COOKIE["token"])){
        require_once("../db/dbhelper.php");
        require_once("../utils/utility.php");
        $token = $_COOKIE["token"];
        $sql = "UPDATE users SET token = null WHERE token = '$token'";
        execute($sql);
    }
    setcookie("token", "", time() - 7*24*60*60, "/");
    header("Location: login.php");
?>