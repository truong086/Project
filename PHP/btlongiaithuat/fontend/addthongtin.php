<?php
    require_once("../db/dbhelper.php");

    $id = $title = $thumbnail = $content = $id_phanloai = "";
    if(!empty($_POST)){
        if(isset($_POST["id"])){
            $id = $_POST["id"];
        }
        if(isset($_POST["title"])){
            $title = $_POST["title"];
            $title = str_replace('"', '\\"', $title);
        }
        if(isset($_POST["thumbnail"])){
            $thumbnail = $_POST["thumbnail"];
            $thumbnail = str_replace('"', '\\"', $thumbnail);
        }
        if(isset($_POST["id_phanloai"])){
            $id_phanloai = $_POST["id_phanloai"];
            $id_phanloai = str_replace('"', '\\"', $id_phanloai);
        }
        if(isset($_POST["content"])){
            $content = $_POST["content"];
            $content = str_replace('"', '\\"', $content);
        }

        if(!empty($title)){
            $created_at = $updated_at = date("Y-m-d H:s:i");

           if($id == ""){
                $sql = "INSERT INTO thuattoan(title, thumbnail, content, id_phanloai, created_at, updated_at) VALUES ('".$title."', '".$thumbnail."', '".$content."', '".$id_phanloai."', '".$created_at."', '".$updated_at."')";
           }else{
                $sql = "UPDATE thuattoan SET title='".$title."', thumbnail='".$thumbnail."', content='".$content."', id_phanloai='".$id_phanloai."', updated_at='".$updated_at."' WHERE id = ".$id;
           }
            execute($sql);

            header("Location: index.php");
            die();
        }
    }


    if(!empty($_GET)){
        if(isset($_GET["id"])){
            $id = $_GET["id"];

            $sql = "SELECT * FROM thuattoan WHERE id = ".$id;
            $thuattoan = executeSingleResult($sql);
            if($thuattoan != null){
                $title = $thuattoan["title"];
                $thumbnail = $thuattoan["thumbnail"];
                $content = $thuattoan["content"];
                $id_phanloai = $thuattoan["id_phanloai"];
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

    <!-- include summernote css/js -->
    <link href="https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote.min.js"></script>
    <link rel="stylesheet" href="addthuattoan2.css">
    <title>Document</title>
</head>
<body>
    <div class="container">
        <div class="row">
            <h2>Thêm thông tin</h2>
        </div>
    </div>
    <div class="row1">
        <div class="row2">
            <form action="" method="POST">
                <div class="ten">
                    <label for="">Nhập tiêu đề *</label>
                    <input type="text" name="id" value="<?=$id?>" hidden="true">
                    <input type="text" name="title" id="title" value="<?=$title?>">
                </div>
                <div class="hinhanh">
                    <label for="">Hình ảnh *</label>
                    <input type="text" style="border: 1px solid rebeccapurple;" name="thumbnail" id="thumbnail" value="<?=$thumbnail?>" onchange="updatehinhanh()">
                    <!--<input type="file" style="border: none;" name="thumbnail" id="thumbnail" value="<?=$thumbnail?>" onchange="updatehinhanh()" accept=".jpg, .png, .jpeg, .gif,bmp, .tif, .tiff|image/*" hidden="true"> -->
                    <img src="<?=$thumbnail?>" id="capnhathinhanh">
                </div>
                <div class="luachon">
                    <label for="">Chon thuật toán *</label>
                    <select name="id_phanloai" id="id_phanloai">
                    <option value="">---Chọn thuật toán---</option>
                    <?php
                        $sql = "SELECT * FROM phanloai";
                        $phanloai = executeResult($sql);

                        foreach($phanloai as $item){
                            if($item["id"] == $id_phanloai){
                                // Câu lệnh này là khi có ($id_phanloai) thì sẽ là sửa thông tin, còn không có ($id_phanloai) thì là thêm thông tin
                                echo "<option selected value='".$item["id"]."'>".$item["name"]."</option>";
                            }else{ // Trường hợp không nhận được thông tin của ($id_phanloai) thì sẽ là thêm thông tin
                                echo "<option value='".$item["id"]."'>".$item["name"]."</option>";
                            }
                        }
                    ?>
                    </select>
                </div>
                <div class="noidung">
                    <label for="">Nội dung *</label>
                    <textarea name="content" id="content" rows="5"><?=$content?></textarea>
                </div>
                <button type="submit">Gửi</button>
            </form>
        </div>
    </div>

    <script>
        function updatehinhanh(){
            $("#capnhathinhanh").attr("src", $("#thumbnail"). val())
        }

        $(function(){
            // Phần này là đợi website load xong thì mới bắt đầu xử lý phần này
            $('#content').summernote({
                width: 600,
                height: 150,   //set editable area's height
                codemirror: { // codemirror options
                    theme: 'monokai'
                }
            });
        })
    </script>
</body>
</html>