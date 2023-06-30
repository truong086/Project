<?php
    require_once("../db/dbhelper.php");

    $id = "";
    if(!empty($_GET)){
        if(isset($_GET["id"])){
            $id = $_GET["id"];
            $sql = "SELECT * FROM thuattoan WHERE id =".$id;
            $thuattoanList = executeSingleResult($sql);
        }
    }

    //if(!empty($_GET)){
        //if(isset($_GET["id"])){
            //$id = $_GET["id"];
            //$sql = "SELECT * FROM thuattoan2 WHERE id =".$id;
            //$thuattoanList1 = executeSingleResult($sql);
        //}
    //}
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="fontdetail3.css">
    <title>Document</title>
    <style>
        body{
            width: 100vw;
            height: 100vh;
            background: url("anh.jpg");
            background-position: center;
            background-size: cover;
        }
        p{
            color: green;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="row1">
                <?php
                    //if($thuattoanList != null){
                        echo '<h1>'.$thuattoanList['title'].'</h1>
                        <img src="'.$thuattoanList['thumbnail'].'" style="width: 500px">
                        <p>'.$thuattoanList['content'].'</p>';
                    //}elseif($thuattoanList1 != null){
                        //echo '<h1>'.$thuattoanList1['title'].'</h1>
                        //<img src="'.$thuattoanList1['thumbnail'].'" style="width: 500px">
                        //<p>'.$thuattoanList1['content'].'</p>';
                    //}
                ?>
            </div>
        </div>
    </div>
</body>
</html>