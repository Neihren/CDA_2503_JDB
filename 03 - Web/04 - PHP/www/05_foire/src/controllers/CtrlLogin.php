<?php
    namespace src\controllers;
  
    class CtrlLogin {
        
        public function  __construct()
        {
        }
        
        public function ctrlLogin() {
            $msg = "";
            if ($_SERVER['REQUEST_METHOD'] === 'POST') {
                $email = trim($_POST['email']);
                $password = $_POST['password'];

                $objCandidat = new \src\dao\CandidateRepository();
                $candidat = $objCandidat->verifSignIn($email, $password);
                if ($candidat) {
                    $_SESSION['id'] = $candidat['id'];
                    $_SESSION['lastname'] = $candidat['lastname_user'];
                    $_SESSION['firstname'] = $candidat['firstname_user'];
                    $_SESSION['mail'] = $candidat['mail_user'];
                    //var_dump($_SESSION['lastname']);
                    header("Location: index.php?page=logged");
                    exit();
                } else {
                    $msg = "Email ou mot de passe incorrect.";
                }
            }
            include "./src/views/login.php";
        }
    }