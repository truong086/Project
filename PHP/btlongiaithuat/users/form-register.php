<?php
    $fullname = $email = $birthday = $password = $address = "";
    if(!empty($_POST)){
        $fullname = getPOST("fullname");
        $email = getPOST("email");
        $birthday = getPOST("birthday");
        $password = getPOST("password");
        $address = getPOST("address");

        if($fullname != "" && $email != "" && $password != ""){
            $password = getPwdSecurity($password);

            $sql = "INSERT INTO users (fullname, email, birthday, password, address) VALUES ('$fullname', '$email', '$birthday', '$password', '$address')";
            execute($sql);

            header("Location: login.php");
            die();
        }
    }
?>