<?php
require "./src/dao/DBconnexion.php";
require "./src/dao/RestaurantRepository.php";

// $ObjDbconnect = Dbconnexion::getInstance();
// var_export($ObjDbconnect);

$objResto = new RestaurantRepository();

// var_dump($objResto->searchAll());
// var_export($objResto->searchAll());

// var_export($objResto->searchById(3));

// var_export($objResto->searchByName("LADRIATIC"));

// var_export($objResto->searchByNote(9));

// var_export($objResto->searchByPrice(20, 50));



?>

<!DOCTYPE html>
<html lang="fr-FR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Guide des restaurants</title>
    <link rel="stylesheet" href="./assets/css/style.css">
    
</head>

<body>
    <?php echo $objResto->afficherTableau($objResto->searchAll()); ?>
</body>

</html>