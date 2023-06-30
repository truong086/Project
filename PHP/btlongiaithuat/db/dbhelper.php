<?php
    require_once("config.php");
    
    function execute($sql){
        $conn = mysqli_connect(HOST, USERNAME, PASSWORD, DATABASE);
        mysqli_set_charset($conn, 'utf8');
        mysqli_query($conn, $sql);

        mysqli_close($conn);
    }

    function executeResult($sql, $isSingle = false){ // "$isSingle = false" là hàm lấy ra 1 sản phẩm (hoặc 1 giá trị)
        $conn = mysqli_connect(HOST, USERNAME, PASSWORD, DATABASE);
        mysqli_set_charset($conn, 'utf8');
        $result = mysqli_query($conn, $sql);

        $data = [];
        if($isSingle){ // Kiểm tra nếu tồn tại "$isSingle" thì lấy ra 1 sản phẩm (hoặc 1 giá trị)
            $data = mysqli_fetch_array($result, 1); // Lấy ra 1 sản phẩm (hoặc 1 giá trị)
        }else{
            while(($row = mysqli_fetch_array($result, 1)) != null){
                $data[] = $row;
            }
        }

        mysqli_close($conn);

        return $data;
    }

    function executeSingleResult($sql){
        $conn = mysqli_connect(HOST, USERNAME, PASSWORD, DATABASE);
        mysqli_set_charset($conn, 'utf8');
        $result = mysqli_query($conn, $sql);

        $row = null;
        if($result != null){
            $row = mysqli_fetch_array($result, 1);
        }

        mysqli_close($conn);

        return $row;
    }
?>