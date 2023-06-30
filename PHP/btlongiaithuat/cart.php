<?php
    session_start();
    
    $title = "Cart Page";
    include_once("layouts/header.php");
    require_once("db/dbhelper.php");
    require_once("utils/utility.php");
?>
    <!-- body Start -->
        <div class="row" style="display: flex;">
            <div class="row1">
                <table class="row2">
                    <thead>
                        <tr>
                            <th>STT</th>
                            <th>Thumbnail</th>
                            <th>title</th>
                            <th>price</th>
                            <th>Num</th>
                            <th>total</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php
                            $cart = [];
                            if(isset($_SESSION["cart"])){
                                $cart = $_SESSION["cart"];
                            }
                            $count = 0;
                            $total = 0;
                            foreach($cart as $item){
                                $total += $item["num"] * $item["price"];
                                echo '<tr>
                                <td>'.(++$count).'</td>
                                <td><img src="'.$item['thumbnail'].'" style="width: 100px;" alt=""></td>
                                <td>'.$item['title'].'</td>
                                <td>'.number_format($item['price'], 0, '', '.').'VND</td>
                                <td>'.$item['num'].'</td>
                                <td>'.number_format($item['num'] * $item['price'], 0, '', '.').'VND</td>
                                <td><button class="btn" onclick="deleteItem('.$item["id"].')">Delete</button></td>
                            </tr>';
                            }
                        ?>
                    </tbody>
                </table>
                <p style="color: red; font-size: 26px;">
                    <?=number_format($total, 0, '', '.')?>VND
                </p>
                <a href="checkout.php">
                    <button class="btn" style="width: 300px; font-size: 30px;">continue</button>
                </a>
            </div>
        </div>
    <!-- body END -->
    <script>
        function deleteItem(id){
            $.post("api/apiproduct.php", {
                "action": "delete",
                "id": id
            }, function(data){
                location.reload();
            })
        }
    </script>
<?php
    include_once("layouts/footer.php");
?>