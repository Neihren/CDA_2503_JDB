<?php

function isMajor(int $age): bool
{
    if ($age > 17) {
        return true;
    }
    return false;
}

echo isMajor(12);
echo "\n";
echo isMajor(18);
echo "\n";
echo isMajor(42);
echo "\n";

function getRetired(int $age): string
{
    if ($age == 60) {
        return "Vous êtes à la retraite cette année.";
    } elseif ($age > 60) {
        return "Vous êtes à la retraite depuis " . ($age - 60) . " ans.";
    } elseif ($age < 60 && $age > -1) {
        return "Il vous reste " . (60 - $age) . " ans avant la retraite.";
    }
    return "Vous n'êtes pas encore né.";
}

echo getRetired(12);
echo "\n";
echo getRetired(60);
echo "\n";
echo getRetired(72);
echo "\n";
echo getRetired(-2);
echo "\n";

function getMax(float $a, float $b, float $c): float
{
    $a = round($a, 3);
    $b = round($b, 3);
    $c = round($c, 3);
    if ($a == $b || $a == $c || $b == $c) {
        return 0;
    }
    if ($a > $b && $a > $c) {
        return $a;
    }
    if ($b > $a && $b > $c) {
        return $b;
    }
    return $c;
}

echo "\n";
echo getMax(1.1, 1.1, 2.2);         // 0 (égalité a,b)
echo "\n";
echo getMax(1.1, 2.2, 1.1);         // 0 (égalité a,c)
echo "\n";
echo getMax(2.2, 1.1, 1.1);         // 0 (égalité b,c)
echo "\n";
echo getMax(5.5, 5.5, 5.5);         // 0 (égalité totale)
echo "\n";
echo getMax(3.33, 2.22, 1.11);      // 3.33 (a max)
echo "\n";
echo getMax(10.01, 5.99, 10.01);    // 0 (égalité a,c)
echo "\n";
echo getMax(2.7, 4.8, 3.5);         // 4.8 (b max)
echo "\n";
echo getMax(4.4, 7.7, 7.7);         // 0 (égalité b,c)
echo "\n";
echo getMax(1.05, 2.1, 3.15);       // 3.15 (c max)
echo "\n";
echo getMax(3.3, 3.3, 5.5);         // 0 (c max, b égal a)
echo "\n";
echo getMax(-1.1, -2.2, -3.3);      // -1.1 (a max négatif)
echo "\n";
echo getMax(-3.3, -1.1, -2.2);      // -1.1 (b max négatif)
echo "\n";
echo getMax(-3.3, -4.4, -1.1);      // -1.1 (c max négatif)
echo "\n";
echo getMax(12.5546, 4.15, 8.12);   // 12.5546 (exemple précis)
echo "\n";

function capitalCity(string $country): string
{
    $capital = "";
    switch ($country) {
        case "France":
            $capital = "Paris";
            break;
        case "Allemagne":
            $capital = "Berlin";
            break;
        case "Italie":
            $capital = "Rome";
            break;
        case "Maroc":
            $capital = "Rabat";
            break;
        case "Espagne":
            $capital = "Madrid";
            break;
        case "Portugal":
            $capital = "Lisbonne";
            break;
        case "Angleterre":
            $capital = "Londres";
            break;
        default:
            $capital = "Capitale inconnue";
    }
    return $capital;
}


