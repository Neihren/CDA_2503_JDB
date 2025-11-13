<?php
    include "./Contribuable.php";

    $hulya = new Contribuable('hulya', 99999999);
    echo $hulya->calculImpot();
?>