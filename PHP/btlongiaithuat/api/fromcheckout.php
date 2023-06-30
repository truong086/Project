<?php
    if(!empty($_POST)){
        $id = getPost("id");
        $fullname = getPost("fullname");
        $email = getPost("email");
        $address = getPost("address");
        $phone_number = getPost("phone_number");
        $order_date = date("Y-m-d H:i:s");

        $cart = [];
        if(isset($_SESSION["cart"])){
            $cart = $_SESSION["cart"];
        }

        if($cart == null || count($cart) == 0){ // Kiểm tra nếu giỏ hàng mà không có sản phẩm nào (giỏ hàng chưa có sản phẩm nào) thì chuyển sang trang khác
            header("Location: products.php");
            die();
        }
        // Viết câu truy vấn lưu dữ liệu vào database
        $sql = "INSERT INTO orders (fullname, address, email, phone_number, order_date) VALUES ('$fullname', '$address', '$email', '$phone_number', '$order_date')";
        execute($sql);

        $sql = "SELECT id FROM orders WHERE order_date = '$order_date'";
        $order = executeResult($sql, true);

        $orderId = $order["id"];

        foreach($cart as $item){
            $product_id = $item["id"];
            $num = $item["num"];
            $price = $item["price"];
            $sql = "INSERT INTO order_details(order_id, product_id, num, price) VALUES ($orderId, $product_id, $num, $price)";
            execute($sql);
        }

        // Cách 1: Khi người dùng hoàn thành thanh toán thì sẽ xóa "session" đi, nếu sợ ảnh hưởng đến dữ liệu sau này thì dùng cách 2
        // session_destroy();

        // cách 2
        unset($_SESSION["cart"]);

        header("Location: complete.php");
        die();
    }
?>