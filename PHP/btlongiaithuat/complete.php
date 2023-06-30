<?php
    session_start();
    
    $title = "Complete Page";
    include_once("layouts/header.php");
    require_once("db/dbhelper.php");
    require_once("utils/utility.php");
?>
    <!-- body Start -->
        <div class="row" style="display: flex;">
            <div class="row1" style="text-align: center;">
                <h1>Complete Checkout</h1>
            </div>
        </div>
    <!-- body END -->
<?php
    include_once("layouts/footer.php");
?>