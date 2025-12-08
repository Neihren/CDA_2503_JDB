<?php
  session_start();
?>
<!DOCTYPE html>
<html lang="fr-FR">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Inscription Candidat Foire aux Vins </title>
  <link rel="stylesheet" href="./assets/css/style.css">
</head>


<body>
  <?php
    require './src/dao/Dbconnection.php';
    require './src/dao/DepartmentRepository.php';
    require './src/dao/CandidateRepository.php';
    require './src/controllers/CtrlInscription.php';
    require './src/controllers/CtrlAccueil.php';
    require './src/controllers/CtrlLogin.php';

    //require './src/views/home.php'
    
    if (isset($_GET["page"])) {
      $path = $_GET["page"]??"home";
    } else {
      $path = "home";
    }

    switch ($path) {
      case 'inscription':
        ctrlInscription();
        break;
      case 'home':
        ctrlAccueil();
        break;
      case 'login':
        ctrlLogin();
        break;
      case 'logged':
        include "./src/views/logged.php";
        break;
      default:
        ctrlAccueil();
        break;
    }

  ?>



</body>

</html>