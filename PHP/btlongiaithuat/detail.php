<?php
    session_start();

    $title = "Detail Page";
    include_once("layouts/header.php");
    require_once("db/dbhelper.php");
    require_once("utils/utility.php");

    $id = getGet("id");
    $product = executeResult("SELECT * FROM products WHERE id = ".$id, true);
?>
    <!-- body Start -->
        <div class="row">
            <div class="row1">
                <img src="<?=$product['thumbnail']?>" style="width: 100px;" alt="">
            </div>
            <div class="row2">
                <p style="font-size: 26px;"><?=$product["title"]?></p>
                <p style="font-size: 26px; color: red;"><?=number_format($product["price"], 0, '', '.')?>VND</p>
                <button style="width: 150px;" class="btn" onclick="addToCart(<?=$id?>)">Add to cart</button>
                <a href="checkout.php">
                    <button style="width: 150px; margin-top: 10px;" class="btn">Checkout</button>
                </a>
            </div>
            <div class="row3">
                <div class="row4">
                    <p><?=$product["content"]?></p>
                </div>
            </div>
        </div>
    <!-- body END -->
    <script>
        function addToCart(id){
            $.post("api/apiproduct.php", {
                "action": "add",
                "id": id
            }, function(data){
                location.reload();
            })
        }
    </script>
<?php
    include_once("layouts/footer.php");
?>