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
    require_once("form-register.php");
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
                <div class="row2">
                    <h2>Đăng ký</h2>
                </div>
                <div class="row3">
                    <form action="" method="POST" id="row3s">
                        <div class="row4">
                            <label for="">Full name:</label>
                            <input type="text" id="urs" name="fullname">
                        </div>
                        <div class="row5">
                            <label for="">Email:</label>
                            <input type="email" id="email" name="email">
                        </div>
                        <div class="row6">
                            <label for="">Birthday:</label>
                            <input type="date" id="birthday" name="birthday">
                        </div>
                        <div class="row7">
                            <label for="">Password:</label>
                            <input type="password" id="pwd" name="password">
                        </div>
                        <div class="row8">
                            <label for="">Confirmation Password:</label>
                            <input type="password" name="confirmation_pwd" id="confirmation_pwd">
                        </div>
                        <div class="row9">
                            <label for="">Address</label>
                            <input type="text" name="address" id="address">
                        </div>
                        <div class="row10">
                            <button class="btn btn-success">Register</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(function(){
            $('#row3s').submit(function(){ // Bắt sự kiện khi người dùng ấn nút submit
            // Kiểm tra "password" có khớp với "confirmation_pwd" hay không nếu không khớp thì đưa ra 1 thông báo lỗi
                if($('[name=password]').val() != $('[name=confirmation_pwd]').val()){ 
                    alert("Thông tin không chính xác"); // Đưa ra thông báo lỗi và không cho đẩy dữ liệu lên
                    return false;
                }
                return true;
            })
        })
    </script>
</body>
</html>