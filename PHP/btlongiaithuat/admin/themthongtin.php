<?php
    require_once("../db/dbhelper.php");

    $id = $name = $thumbnail = "";
    
    if(!empty($_POST)){
        if(isset($_POST["name"])){
            $name = $_POST["name"];
        }
        if(isset($_POST["thumbnail"])){
            $thumbnail = $_POST["thumbnail"];
        }
        if(isset($_POST["id"])){
            $id = $_POST["id"];
        }

        if(!empty($name)){
            $created_at = $updated_at = date("Y-m-d H:s:i");

            if($id == ""){
                $sql = "INSERT INTO phanloai(name, created_at, updated_at, thumbnail) VALUES ('".$name."', '".$created_at."', '".$updated_at."', '".$thumbnail."')";
            }else{
                $sql = "UPDATE phanloai SET name='".$name."', updated_at='".$updated_at."', thumbnail='".$thumbnail."' WHERE id = ".$id;
            }

            execute($sql);
        }
    }

    if(isset($_GET["id"])){
        $id = $_GET["id"];

        $sql = "SELECT * FROM phanloai WHERE id = ".$id;
        $kiemtra = executeSingleResult($sql);
        if($kiemtra != null){
            $name = $kiemtra["name"];
            $thumbnail = $kiemtra["thumbnail"];
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
    <title>Document</title>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="row1">
                <form action="" method="POST">
                    <div class="row2">
                        <label for="">Tên</label>
                        <input type="text" name="name" id="name" value="<?=$name?>">
                    </div>
                    <div class="row2">
                        <label for="">Hình ảnh</label>
                        <input type="text" name="thumbnail" id="thumbnail" value="<?=$thumbnail?>" onchange="hienthi()">
                        <img src="<?=$thumbnail?>" id="anhupdate">
                    </div>
                    <div class="row3">
                        <button class="btn">Gửi</button>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <script>
        function hienthi(){
            $("#anhupdate").attr("src", $("#thumbnail").val())
        }
    </script>
</body>
</html>