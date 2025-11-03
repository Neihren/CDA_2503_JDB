<?php
    function getSum(int $a, int $b) : int
    {
        return $a + $b;
    }

    function getSub(int $a, int $b) : int
    {
        return $a - $b;
    }

    function getMulti(float $a, $b) : float
    {
        return round($a * $b, 2);
    }

    function getDiv(int $a, $b) : float
    {   
        if ($b == 0) {
            return 0;
        }
        return round($a / $b, 2);
    }

    echo getSum(5, 3);
    echo "\n";
    echo getSub(5, 3);
    echo "\n";
    echo getSum(3, 5);
    echo "\n";
    echo getMulti(5.6, 3);
    echo "\n";
    echo getMulti(5.6, -3.7);
    echo "\n";
    echo getDiv(20, 3);
    echo "\n";
    echo getDiv(20, 0);
    echo "\n";
?>