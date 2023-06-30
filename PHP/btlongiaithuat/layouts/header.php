<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <title><?=$title?></title>
    <style>
        .main{
            min-height: 560px;
        }
        nav{
            width: 100vw;
            height: 80px;
            background-color: cornflowerblue;
            display: flex;
            justify-content: space-around;
        }
        nav ul li{
            list-style: none;
            display: inline-block;
            line-height: 80px;
        }
        nav ul li a{
            text-decoration: none;
            display: block;
            color: white;
            font-family: arial;
            font-weight: 500;
            font-size: 18px;
            margin: 0 15px;
        }
    </style>
</head>
<body>
    <!-- header start-->
    <nav>
       <div class="container1" style="padding: 0px !important; dispay: flex">
       <ul>
            <li>
                <a href="">Home</a>
            </li>
            <li>
                <a href="">Shop</a>
            </li>
            <li>
                <a href="">About</a>
            </li>
            <li>
                <a href="">Track Order</a>
            </li>
            <li>
                <a href="">Contact us</a>
            </li>
        </ul>
        <?php
            $cart = [];
            if(isset($_SESSION["cart"])){
                $cart = $_SESSION["cart"];
            }

            $count = 0;
            
            foreach($cart as $item){
                $count += $item["num"];
            }
        ?>
       </div>
       <a href="cart.php">
            <button class="btn" type="button">
                Cart <span class="badge badge-light"><?=$count?></span>
            </button>
        </a>
    </nav>
    <!-- header END -->

    <div class="container main">