<?php
session_start();
include("connect.php"); // Ensure this file contains your database connection code

// Check if user is logged in
if (!isset($_SESSION['email'])) {
    header("Location: index.php"); // Redirect to login page if not logged in
    exit();
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>GuessGrid Game</title>
    <!-- Link to your Wordle CSS file -->
    <link rel="stylesheet" href="css/wordle.css">
    <!-- Link to your Wordle JavaScript file -->
    <script src="js/wordle.js" defer></script>
</head>
<body>
    <!-- Game Section -->
    <h1 id="title">GuessGrid</h1>
    <hr>
    <br>
    <div id="board"></div> <!-- Game board container -->
    <br>
    <h1 id="answer"></h1> <!-- Area to display feedback for the user's guess -->
</body>
</html>
