<?php
    require_once("../db/dbhelper.php");
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="row1">
                <table>
                    <thead>
                        <tr>
                            <th>STT</th>
                            <th>Name</th>
                            <th>Hình ảnh</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php
                            $sql = "SELECT * FROM phanloai";
                            $phanloai = executeResult($sql);
                            $index = 1;
                            foreach($phanloai as $item){
                                echo "<tr>
                                <td>".($index++)."</td>
                                <td>".$item["name"]."</td>
                                <td><img src='".$item["thumbnail"]."' style='width: 100px'></td>
                                <td><a href='addadmin.php?id=".$item["id"]."'><button>Sửa</button></a></td>
                                <td><button>Xóa</button></td>
                            </tr>";
                            }
                        ?>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</body>
</html>