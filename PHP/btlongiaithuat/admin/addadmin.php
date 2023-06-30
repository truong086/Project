<?php
    require_once("../db/dbhelper.php");

    $id = $name = $thumbnail = "";
    if(!empty($_POST)){
        if(isset($_POST["id"])){
            $id = $_POST["id"];
        }
        if(isset($_POST["name"])){
            $name = $_POST["name"];
            $name = str_replace("\"", "\\\"", $name);
        }
        if(isset($_POST["thumbnail"])){
            $thumbnail = $_POST["thumbnail"];
            $thumbnail = str_replace("\"", "\\\"", $thumbnail);
        }

        if(!empty($name)){
            $created_at = $updated_at = date("Y-m-d H:s:i");

           if($id == ""){
                $sql = "INSERT INTO phanloai(name, created_at, updated_at, thumbnail) VALUES ('".$name."', '".$created_at."', '".$updated_at."', '".$thumbnail."')";
           }else{
                $sql = "UPDATE phanloai SET name='".$name."', updated_at='".$updated_at."', thumbnail='".$thumbnail."' WHERE id = ".$id;
           }
            
           execute($sql);

            header("Location: ../fontend/index.php");
            die();
        }
    }
    if(!empty($_GET)){
        if(isset($_GET["id"])){
            $id = $_GET["id"];

            $sql = "SELECT * FROM phanloai WHERE id = ".$id;
            $thuattoan2= executeSingleResult($sql);
            if($thuattoan2 != null){
                $name = $thuattoan2["name"];
                $thumbnail = $thuattoan2["thumbnail"];
            }
        }
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="../fontend/addphanloai.css">
    <title>Document</title>
</head>
<body>
    <div class="container">
        <h2>Thêm thuật toán</h2>
        <div class="row">
            <form action="" method="POST">
                <div class="ten">
                    <label for="">Nhập thông tin</label>
                    <input type="text" name="id" id="id" value="<?=$id?>" hidden="true">
                    <input type="text" name="name" id="name" value="<?=$name?>">
                </div>
                <div class="hinhanh">
                    <label for="">Hình ảnh</label>
                    <input type="text" name="thumbnail" id="thumbnail" value="<?=$thumbnail?>" onchange="capnhat()">
                    <img src="<?=$thumbnail?>" alt="" id="anhcapnhat">
                </div>
                <div class="btn">
                    <button type="submit">Gửi</button>
                </div>
            </form>
        </div>
    </div>
    <script type="text/javascript">
        function capnhat(){
            $("#anhcapnhat").attr("src", $("#thumbnail").val())
        }
    </script>
</body>
</html>