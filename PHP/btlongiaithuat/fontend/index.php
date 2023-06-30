<?php
    require_once("../db/dbhelper.php");
    require_once("../../webhoaqua/common/baitoanphantrang.php");
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="fontthuattoan1.css">
    <title>Document</title>
</head>
<body>
            <div class="row1">
                <div class="row2">
                    <div class="row3">
                        <h1>Thuật toán C++</h1>
                    </div>
                </div>
            </div>
            <div class="row4">
                <div class="row5">
                    <div class="row6">
                        <button onclick="window.open('addthongtin.php', '_self')">Thêm</button>
                        <?php
                            $sql = "SELECT thuattoan.id, thuattoan.title, thuattoan.thumbnail, thuattoan.content, 
                            thuattoan.updated_at, phanloai.name phanloai_name 
                            FROM thuattoan LEFT JOIN phanloai ON thuattoan.id_phanloai = phanloai.id";
                            $giaithuat6 = executeSingleResult($sql);
                            echo "<a href='addthongtin.php?id=".$giaithuat6["id"]."'><button>Sửa</button></a>";
                        ?>
                        <ul>
                            <?php
                                $id = $name = "";
                                $sql = "SELECT * FROM phanloai";
                                $phanloai3 = executeResult($sql);

                                foreach($phanloai3 as $item3){
                                    echo "<li><a href='phanloai.php?id=".$item3["id"]."'>".$item3["name"]."</a></li>";
                                }
                            ?>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="row7">
                <div class="row8">
                    <div class="row9" style="display: flex;justify-content: center;border: none; flex-wrap: wrap;max-width: 1200px;width: 1200px;height: auto;">
                        <div class="row10" style="width: 590px;text-align: center; height: 420px; overflow: hidden;">
                            <?php

                                $sql = "SELECT thuattoan.id, thuattoan.title, thuattoan.thumbnail, thuattoan.content, 
                                thuattoan.updated_at, phanloai.name phanloai_name 
                                FROM thuattoan LEFT JOIN phanloai ON thuattoan.id_phanloai = phanloai.id";
                                $giaithuat = executeResult($sql);

                                foreach($giaithuat as $item){
                                    echo " <div class='baoquanh' style='width: 590px; height: 420px; overflow: hidden;'>
                                    <div class='thumbnail'>
                                        <img src='".$item["thumbnail"]."' style='width: 500px; height: 200px' />
                                    </div>
                                    <div class='title'>
                                        <div>
                                            <a href='detail.php?id=".$item["id"]."'><h2>".$item["title"]."</h2></a>
                                        </div>
                                    </div>
                                        <div class='icon' style='width: 590px;height:110px;overflow: hidden;text-overflow: ellipsis;'>
                                            <div style='display: flex; justify-content: center;'>
                                                <p style='width: 420px; height:110px;overflow: hidden; text-overflow: ellipsis;'>".$item["content"]."</p>
                                            </div>
                                        </div>
                                        <div class='xemthem1'>
                                            <a href='detail.php?id=".$item["id"]."'><button class='btn'>Xem thêm</button><a/>
                                        </div>
                                    </div>";
                                }
                            ?>
                            </div>
                            <div class="row10s">
                                <div class="test">
                                    <?php
                                        $limit = 5;
                                        $page = 1;
                                        
                                        if(isset($_GET["page"])){
                                            $page = $_GET["page"];
                                        }
                                        if($page <= 0){
                                            $page = 1;
                                        }
                                        $phantrang3 = ($page - 1) * $limit;
                                        $sql = "SELECT thuattoan.id, thuattoan.title, thuattoan.thumbnail, thuattoan.content, 
                                        thuattoan.updated_at, phanloai.name phanloai_name 
                                        FROM thuattoan LEFT JOIN phanloai ON thuattoan.id_phanloai = phanloai.id"." limit ".$phantrang3.", ".$limit;
                                        $gt2 = executeResult($sql);

                                        $sql = "SELECT count(id) AS total FROM thuattoan";
                                        $phantrang3 = executeSingleResult($sql);
                                        $number = 0;
                                        if($phantrang3 != null){
                                            $count1 = $phantrang3["total"];
                                            $number = ceil($count1/$limit);
                                        }

                                        foreach($gt2 as $item2){
                                            echo " <div class='baoquanh2' style='display: flex; margin-bottom: 10px;'>
                                            <div class='thumbnail2'>
                                                <img src='".$item2["thumbnail"]."' style='width: 90px' />
                                            </div>
                                            <div class='resall'>
                                                <div class='title2' style='margin: 0 10px'>
                                                    <div><h5 style='color: white;'>".$item2["title"]."</h5></div>
                                                </div>
                                                <div class='icon2' style='margin: 0 10px;'>
                                                    <div class='gt'  style='width: 400px; height:auto;'>
                                                        <p style='width: 400px; color: white; height:auto;overflow: hidden;margin: 5px 0;text-overflow: ellipsis;white-space: nowrap;'>".$item2["content"]."</p>
                                                    </div>
                                                </div>
                                                <div class='btn' style='margin: 0 10px; display: flex;'>
                                                    <a style='margin-right: 10px' href='detail.php?id=".$item2["id"]."'><button>Xem Thêm</button></a>
                                                    <a href='addthongtin.php?id=".$item2["id"]."'><button>Sửa</button></a>
                                                    <button style='margin-left: 10px' onclick='deletetadd(".$item2["id"].")'>Xóa</button>
                                                </div>
                                            </div>
                                            </div>";
                                        }
                                        
                                    ?>
                                </div>
                                <div class="phantrangtt" style="width: 600px; text-align: center; margin: 30px -30px;">
                                    <?=phantrang($number, $page, "")?>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
            <div class="row11">
                <div class="row12">
                    <h2>Thuật toán</h2>
                    <div class="row13">
                        <?php
                            $limit1 = 4; 
                            $page1 = 1;

                            if(isset($_GET["page1"])){
                                $page1 = $_GET["page1"];
                            }
                            if($page1 <= 0){
                                $page1 = 1;
                            }
                            $phantrang12 = ($page1  - 1) * $limit1;
                            $sql = "SELECT * FROM phanloai"." limit ".$phantrang12.", ".$limit1;
                            $phanloai = executeResult($sql);

                            $sql = "SELECT count(id) AS total FROM phanloai";
                            $phantrang12 = executeSingleResult($sql);
                            $number1 = 0;
                            if($phantrang12 != null){
                                $count22 = $phantrang12["total"];
                                $number1 = ceil($count22/$limit1);
                            }

                            foreach($phanloai as $item5){
                                echo "<div class='row14' style='margin: 0 20px'>
                                <div class='row15'>
                                    <img src='".$item5["thumbnail"]."' width = 250px/>
                                </div>
                                <div class='row16'>
                                    <a href='phanloai.php?id=".$item5["id"]."'>".$item5["name"]."</a>
                                </div>
                                <a href='detail2.php?id=".$item5["id"]."'><button>Xem hết</button></a>
                                <a href='../admin/addadmin.php?id=".$item5["id"]."'><button>Sửa</button></a>
                                <a href='../admin/addadmin.php'><button>thêm</button></a>
                                <button onclick='phanloaidelete(".$item5["id"].")'>xóa</button>
                            </div>";
                            }
                        ?>
                        
                    </div>
                    <div class="phantrangtt5" style="width: 1200px; text-align: center; margin: 30px 0;">
                        <?=phantrang2($number1, $page1, "")?>
                    </div>
                </div>
            </div>
            <div class="row17">
                <div class="row18">
                     <div class="danhsach">
                        <h2>Danh sách</h2>
                     </div>
                    <div class="row19">
                        <div class="row20">
                            <div class="row21">
                                <div class="row22">
                                    <?php
                                        $sql = "SELECT thuattoan.id, thuattoan.title, thuattoan.thumbnail, thuattoan.content, thuattoan.updated_at, 
                                        phanloai.name phanloai_name FROM thuattoan LEFT JOIN phanloai ON thuattoan.id_phanloai = phanloai.id";
                                        $thuattoanList2 = executeResult($sql);
                                        
                                        foreach($thuattoanList2 as $item6){
                                            echo '<div class="row23">
                                            <div class="row24">
                                                <div class="row25">
                                                <a href="detail.php?id='.$item6['id'].'"><img src="'.$item6['thumbnail'].'" style="width: 380px" /></a>
                                                </div>
                                                <div class="row26">
                                                    <h2>'.$item6['title'].'</h2>
                                                </div>
                                                <div class="row27">
                                                    <p>'.$item6['content'].'</p>
                                                </div>
                                                <div class="chuabut1" style="display: flex">
                                                    <a href="addthongtin.php?id='.$item6['id'].'"><button style="margin: 0 10px" class="btn">Sửa</button></a>
                                                </div>
                                            </div>
                                        </div>';
                                        }
                                    ?>
                                </div>
                                <div class="row6s">
                                    <a href="addthongtin.php"><button class="btn">Thêm</button></a>
                                </div>
                                <div class="row28">
                                    <div class="row29">
                                        <?php
                                            $limit = 4;
                                            $page2 = 5;
                                            if(isset($_GET["page2"])){
                                                $page2 = $_GET["page2"];
                                            }
                                            if($page2 <= 0){
                                                $page2 = 1;
                                            }
                                            $tinhtrang = ($page2 - 1) * $limit;
                                            $sql = "SELECT thuattoan.id, thuattoan.title, thuattoan.thumbnail, thuattoan.content, thuattoan.updated_at,
                                            phanloai.name phanloai_name FROM thuattoan LEFT JOIN phanloai ON thuattoan.id_phanloai = phanloai.id"." limit ".$tinhtrang.", ".$limit;
                                            $thuattoanList3 = executeResult($sql);

                                            $sql = "SELECT count(id) AS total FROM thuattoan";
                                            $phantrangList = executeSingleResult($sql);
                                            $number2 = 0;
                                            if($phantrangList != null){
                                                $count2 = $phantrangList["total"];
                                                $number2 = ceil($count2/$limit);
                                            }
                                            foreach($thuattoanList3 as $item8){
                                                echo '<div class="row28s">
                                                <div class="row29s">
                                                    <div class="row30">
                                                        <img src="'.$item8['thumbnail'].'" style="width: 100px" />
                                                    </div>
                                                    <div class="row31">
                                                        <div class="row32">
                                                            <h1>'.$item8['title'].'</h1>
                                                        </div>
                                                        <div class="row33">
                                                            <p>'.$item8['content'].'</p>
                                                        </div>
                                                        <div class="chuabut" style="display: flex">
                                                            <a href="detail.php?id='.$item8['id'].'"><button class="btn">Xem thêm</button></a>
                                                            <a href="addthongtin.php?id='.$item8['id'].'"><button style="margin: 0 10px" class="btn">Sửa</button></a>
                                                            <button class="btn" onclick="deletefont('.$item8['id'].')">Xóa</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>';
                                            }
                                        ?>
                                    </div>
                                </div>
                                <div class="phantrang1">
                                    <?=phantrang3($number2, $page2, "")?>
                                </div>
                            </div>
                        </div>
                        <div class="row34">
                            <div class="row35">
                                <div class="row36">
                                    <h2>Danh sách được truy cập nhiều nhất</h2>
                                </div>
                                <div class="row37">
                                    <?php
                                        $sql = "SELECT thuattoan.id, thuattoan.title, thuattoan.thumbnail, thuattoan.content, thuattoan.updated_at,
                                        phanloai.name phanloai_name FROM thuattoan LEFT JOIN phanloai ON thuattoan.id_phanloai = phanloai.id";
                                        $thuattoanList1 = executeResult($sql);

                                        foreach($thuattoanList1 as $item9){
                                            echo "<div class='row38'>
                                            <a href='detail.php?id=".$item9["id"]."'>".$item9["title"]."</a>
                                        </div>";
                                        }
                                    ?>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <script>
                function deletetadd(id){
                    var option = confirm("Bạn có chắc muốn xóa");
                    if(!option){
                        return;
                    }
                    $.post("../admin/deletethongtin.php", {
                        "id": id,
                        "nakrok": "delete"
                    },function(data){
                        location.reload();
                    })
                }
                function phanloaidelete(id){
                    var option = confirm("Bạn có chắc muốn xóa");
                    if(!option){
                        return;
                    }
                    $.post("../admin/deletethongtin.php", {
                        "id": id,
                        "vio": "delete"
                    }, function(data){
                        location.reload();
                    })
                }
                function deletefont(id){
                    var option = confirm("Bạn có chắc muốn xóa");
                    if(!option){
                        return;
                    }
                    $.post("../admin/deletethongtin.php", {
                        "id": id,
                        "ngokhong": "delete"
                    }, function(data){
                        location.reload();
                    })
                }
            </script>
</body>
</html>