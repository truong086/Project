<?php
    session_start();
    
    $title = "Product Page";
    include_once("layouts/header.php");
    require_once("db/dbhelper.php");
    require_once("utils/utility.php");

    $productList = executeResult("SELECT * FROM products");
?>
    <!-- body Start -->
        <div class="row" style="display: flex;">
        <?php
            foreach($productList as $item){
                echo '<div class="row1" style="border: 2px solid black; margin: 10px 10px; width: 300px;">
                <a href="detail.php?id='.$item["id"].'"><img src="'.$item["thumbnail"].'" style="width: 100px;" alt=""></a>
                <a href="detail.php?id='.$item["id"].'"><p style="font-size: 26px;">'.$item["title"].'</p></a>
                <p style="font-size: 26px; color: red;">'.number_format($item["price"], 0, '', '.').'VND</p>
            </div>';
            }
        ?>
        </div>
    <!-- body END -->
<?php
    include_once("layouts/footer.php");
?>