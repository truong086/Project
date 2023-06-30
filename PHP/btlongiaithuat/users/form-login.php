<?php
    $email = $password = "";
    if(!empty($_POST)){
        $email = getPOST("email");
        $password = getPOST("password");

        if($email != "" && $password != ""){
            $password = getPwdSecurity($password);
            $sql = "SELECT * FROM users WHERE email = '$email' AND password = '$password'"; // Kiểm tra xem "email" và "password" có tồn tại trong database không
            $data = executeResult($sql);
            if($data != null && count($data) > 0){// Kiểm tra xem tài khoản có tồn tại hay không, nếu "count(data)" lớn hơn 0 nghĩa là có giá trị và cũng đồng nghĩa là tài khoản có tồn tại
                // Cách 1: Cơ bản
                //setcookie("login", "true", time() + 7*24*60*60, "/");

                // Cách 2: Nâng cao
                $token = getPwdSecurity(time().$data[0]["email"]); // Lấy thời gian hiện tại với email của người dùng đó để join ra mã token để đang nhập
                setcookie("token", $token, time() + 7*24*60*60, "/"); // Lưu token đó vào đây

                // Lưu dữ liệu vào database
                $sql = "UPDATE users SET token = '$token' WHERE id = ".$data[0]["id"]; // Lưu ý cái "token" này phải là duy nhất nó sẽ không chung đâu
                execute($sql);
                // Đăng nhập thành công thì chuyển sang trang index.php
                header("Location: userss.php");
                die();
            }
        }
    }
?>