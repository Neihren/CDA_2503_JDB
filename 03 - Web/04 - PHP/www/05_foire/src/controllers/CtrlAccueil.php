<?php
    namespace src\controllers;

    class CtrlAccueil {
        public function __construct()
        {
        }

        public function ctrlAccueil() : void {
            $objCandidat = new \src\dao\CandidateRepository();
            $dataCandidat = $objCandidat->searchAll();
            include "./src/views/home.php";
    }
}