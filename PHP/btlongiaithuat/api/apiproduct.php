<?php
    session_start();

    if(!empty($_POST)){
        require_once("../db/dbhelper.php");
        require_once("../utils/utility.php");
        $action = getPost("action");
        $id = getPost("id");

        switch ($action){
            case "add":
                addToCart($id);
                break;
            case "delete":
                deleteItem($id);
                break;
        }
    }

    function deleteItem($id){ // Đây là hàm xóa sản phẩm
        $cart = [];
        if(isset($_SESSION["cart"])){
            $cart = $_SESSION["cart"];
        }

        for($i = 0; $i < count($cart); $i++){
            if($cart[$i]["id"] == $id){
                array_splice($cart, $i, 1); // Câu lệnh này có nghĩa là: ở cái giỏ hàng tên là "$cart" tìm ở vị trí tìm thấy là "$i (của vòng lặp, duyệt qua các sản phẩm trong giỏ hàng)", xong xóa đi 1 sản phẩm (1 phần tử) 
                break;
            }
        }

        // update session
        $_SESSION["cart"] = $cart;
    }

    function addToCart($id){
        $cart = [];
        if(isset($_SESSION["cart"])){// Kiểm tra "$_SESSION" này có dữ liệu chưa, nếu mà chưa có thì xét dữ liệu

            // xét dự liệu cho biến
            // $_SESSION["cart"] = []; Cách 1

            $cart = $_SESSION["cart"];
        }
        $isFind = false; // Biến này kiểm tra xem sản phẩm đã được thêm vào giỏ hàng hay chưa

        for($i = 0; $i < count($cart); $i++){
            if($cart[$i]["id"] == $id){ // Câu lệnh này có nghĩa là: Nếu giỏ hàng($cart) tại vị trí [$i] (của vòng lặp for), xem dữ liệu "id" của nó xem có tìm thấy "$id" này không, câu lệnh này là cộng thêm số lượng của 1 sản phẩm đã có trong giỏ hàng
                // Nếu tìm thấy
                $cart[$i]["num"]++;
                $isFind = true;
                break;
            }
        }
        if(!$isFind){ // Trường hợp nếu sản phẩm này chưa được thêm vào giỏ hàng
            $product = executeResult("SELECT * FROM products WHERE id = ".$id, true);
            $product["num"] = 1;
            $cart[] = $product;
        }

        // update session
        $_SESSION["cart"] = $cart;
    }
?>