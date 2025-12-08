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
    
    if (isset($_GET["page"])) {
      $path = $_GET["page"]??"home";
    } else {
      $path = "home";
    }
    switch ($path) {
      case 'inscription':
        CtrlInscription();
        break;
      case 'home':
        include './src/views/home.php';
        break;
      default:
        include './src/views/home.php';
        break;
    }

  ?>



</body>

</html>