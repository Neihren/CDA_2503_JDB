<?php
    function ctrlInscription() {
        $objDept = new DepartmentRepository();
        $objCandidat = new CandidateRepository();

        $tabData = $objDept->searchAll();
        $msg = "";

        if($_SERVER["REQUEST_METHOD"]=="POST"){
            if (!empty($_POST["lastname"])
                && !empty($_POST["firstname"]) 
                && !empty($_POST["email"]) 
                && !empty($_POST["password"]) 
                && !empty($_POST["confirmPassword"]) 
                && !empty($_POST["department"]) 
                && !empty($_POST["age"])) {
                    try {
                        if ($_POST["password"] != $_POST["confirmPassword"]) {
                            throw new Exception("Le mot de passe et sa confinmation ne correspondent pas");
                        } else {
                            $test = $objCandidat->createCandidate(  $_POST["lastname"],
                                                                    $_POST["firstname"],
                                                                    $_POST["email"],
                                                                    $_POST["password"],
                                                                    $_POST["department"],
                                                                    $_POST["age"]);
                            if ($test) {
                                header('Location:http://localhost/05_foire/index.php');
                                exit;
                            } else {
                                $msg = "Erreur d'intégration dans la table";
                            }
                        }
                    } catch (\Throwable $th) {
                        $msg = "Erreur : " . $th->getMessage();
                    }
            } else {
                $msg ="Veuillez remplir toutes les zones";
            }
        }
        require "./src/views/inscription.php";
    }