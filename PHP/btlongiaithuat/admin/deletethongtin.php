<?php
    require_once("../db/dbhelper.php");

    if(!empty($_POST)){
        if(isset($_POST["nakrok"])){
            $nakrok = $_POST["nakrok"];

            switch($nakrok){
                case "delete":
                    if(isset($_POST["id"])){
                        $id = $_POST["id"];

                        $sql = "DELETE FROM thuattoan WHERE id = ".$id;
                        execute($sql);
                    }
                break;
            }
        }
    }

    if(!empty($_POST)){
        if(isset($_POST["vio"])){
            $vio = $_POST["vio"];

            switch($vio){
                case "delete":
                    if(isset($_POST["id"])){
                        $id = $_POST["id"];

                        $sql = "DELETE FROM phanloai WHERE id = ".$id;
                        execute($sql);
                    }
                break;
            }
        }
    }

    if(!empty($_POST)){
        if(isset($_POST["ngokhong"])){
            $ngokhong = $_POST["ngokhong"];

            switch($ngokhong){
                case "delete":
                    if(isset($_POST["id"])){
                        $id = $_POST["id"];

                        $sql = "DELETE FROM thuattoan2 WHERE id = ".$id;
                        execute($sql);
                    }
                break;
            }
        }
    }
?>