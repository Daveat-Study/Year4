<?php
    session_start();

    $_SESSION["username"] = "john_doe";

    echo $_SESSION["username"];
?>