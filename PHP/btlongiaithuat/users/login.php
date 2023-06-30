<?php
    // Cách 1
    //if(isset($_COOKIE["login"]) && $_COOKIE["login"] == "true"){
        //header("Location: userss.php");
        //die();
    //}
    require_once("../db/dbhelper.php");
    require_once("../utils/utility.php");
    // Cách 2: Bắt buộc phải viết dưới thư viện này
    $user = validateToken();
    if($user != null){
        header("Location: userss.php");
        die();
    }
    require_once("form-login.php");
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <title>Document</title>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="row1">
                <h2>Đăng nhập</h2>
            </div>
            <div class="row2">
                <form action="" method="POST" id="row2s">
                    <div class="row3">
                        <label for="">Email:</label>
                        <input type="email" id="email" name="email">
                    </div>
                    <div class="row4">
                        <label for="">Password:</label>
                        <input type="password" id="pwd" name="password">
                    </div>
                    <div class="row5">
                        <button id="btn">Login</button>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <script>
        $(function(){
            $("#row2s").submit(function(){
                if($("[name=password]").val() == ""){
                    alert("Mật khẩu không được bỏ trống");
                    return false;
                }
                return true;
            })
        })
    </script>
</body>
</html>