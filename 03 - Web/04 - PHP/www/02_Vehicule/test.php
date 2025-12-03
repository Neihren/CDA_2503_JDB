<?php

require_once "./Moteur.php";
require_once "./Voiture.php";
require_once "./VoitureDeCourse.php";

$v1 = new Voiture ("Peugeot", "e208", "Stellantis", 150, 1000);
echo $v1;
echo "<br>";

try {
    $v2 = new VoitureDeCourse("Peugeot", "e208", "Peugeot", 150, 1000);
} catch (InvalidArgumentException $e) {
    echo $e->getMessage();
    die();
}

echo "<br>";
echo $v2;