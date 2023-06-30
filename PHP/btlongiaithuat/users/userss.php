<?php
    if(!isset($_COOKIE["token"])){
        header("Location: login.php");
        die();
    }
    require_once("../db/dbhelper.php");
    require_once("../utils/utility.php");

    $sql = "SELECT * FROM users";
    $usersList = executeResult($sql);
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
                <h2>User(<a href="logout.php">Đăng xuất</a>)</h2>
            </div>
            <div class="row2">
                <table>
                    <thead>
                        <tr>
                            <th>STT</th>
                            <th>Full name</th>
                            <th>Email</th>
                            <th>Birthday</th>
                            <th>Address</th>
                            <th style="width: 50px;"></th>
                            <th style="width: 50px;"></th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php
                            $cout = 0;
                            foreach($usersList as $item){
                                echo "<tr>
                                <td>".(++$cout)."</td>
                                <td>".$item["fullname"]."</td>
                                <td>".$item["email"]."</td>
                                <td>".$item["birthday"]."</td>
                                <td>".$item["address"]."</td>
                                <td><button>Sửa</button></td>
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