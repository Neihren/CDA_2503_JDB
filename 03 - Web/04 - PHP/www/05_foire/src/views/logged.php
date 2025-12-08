<?php
    $var_value = $_SESSION['user'];
?>

<div>Bonjour <?php echo htmlspecialchars($_SESSION['firstname']) . ' ' . htmlspecialchars($_SESSION['lastname']); ?> vous êtes loggué en tant que <?php echo htmlspecialchars($_SESSION['mail']); ?> </div>