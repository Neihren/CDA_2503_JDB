<?php

    function ctrlAccueil() {
        $objCandidat = new CandidateRepository();
        $dataCandidat = $objCandidat->searchAll();
        include "./src/views/home.php";
    }