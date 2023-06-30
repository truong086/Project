<?php
    require_once("../db/dbhelper.php");

    $id = "";
        if(isset($_GET["id"])){
            $id = $_GET["id"];
            $sql = "SELECT * FROM phanloai WHERE id = ".$id;
            $phanloaiList = executeSingleResult($sql);
            if($phanloaiList != null){
                $name = $phanloaiList["name"];
            }
        }
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="fontdetail2.css">
    <title>Document</title>
    <style>
        body{
            width: 100vw;
            height: 100vh;
            background: url('anh.jpg');
            background-position: center;
            background-size: cover;
        }
    </style>
</head>
<body>
    <div class="container" style="width: 100vw;
    height: 100vh;
    background: url('anh.jpg');
    background-position: center;
    background-size: cover;">
        <div class="row">
            <div class="rows">
                <h2><?=$name?></h2>
            </div>
            <div class="row1">
                <?php
                
                    $sql = "SELECT thuattoan.id, thuattoan.title, thuattoan.thumbnail, thuattoan.content, thuattoan.updated_at, phanloai.name phanloai_name FROM thuattoan LEFT JOIN phanloai ON thuattoan.id_phanloai = phanloai.id WHERE phanloai.id = ".$id;
                    $thuattoanList = executeResult($sql);

                    foreach($thuattoanList as $item){
                        echo " <div class='row2' style='margin: 10px 10px'>
                        <div class='row3'>
                            <a href='detail.php?id=".$item["id"]."'><img src='".$item["thumbnail"]."' /></a>
                        </div>
                        <div class='row4'>
                            <h2>".$item["title"]."</h2>
                        </div>
                        <div class='row5'>
                            <p>".$item["content"]."</p>
                        </div>
                        <div class='row6'>
                            <a href='detail.php?id=".$item["id"]."'><button>Xem thêm</button></a>
                        </div>
                    </div>";
                    }
                ?>
            </div>
        </div>
    </div>
</body>
</html>