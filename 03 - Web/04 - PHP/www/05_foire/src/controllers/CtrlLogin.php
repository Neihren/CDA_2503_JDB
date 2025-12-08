<?php
    function ctrlLogin() {
        $msg = "";
        if ($_SERVER['REQUEST_METHOD'] === 'POST') {
            $email = $_POST['email'] ?? '';
            $password = $_POST['password'] ?? '';

            $objCandidat = new CandidateRepository();
            $candidat = $objCandidat->verifSignIn($email, $password);
            if ($candidat) {
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