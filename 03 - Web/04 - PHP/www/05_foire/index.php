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
    use src\dao\CandidateRepository;
    use src\dao\DepartmentRepository;
    use src\dao\Dbconnection;
    use src\controllers\CtrlAccueil;
    use src\controllers\CtrlCompte;
    use src\controllers\CtrlInscription;
    use src\controllers\CtrlLogin;
    require './vendor/autoload.php';
    
    if (isset($_GET["page"])) {
      $path = $_GET["page"]??"home";
    } else {
      $path = "home";
    }

    switch ($path) {
      case 'inscription':
        $objIns = new CtrlInscription();
        $objIns->ctrlInscription();
        break;
      case 'home':
        $objHome = new CtrlAccueil();
        $objHome->ctrlAccueil();
        break;
      case 'login':
        $objLogin = new CtrlLogin();
        $objLogin->ctrlLogin();
        break;
      case 'logged':
        $objCompte = new CtrlCompte();
        $objCompte->ctrlCompte();
        break;
      default:
        $objHome = new CtrlAccueil();
        $objHome->ctrlAccueil();
        break;
    }

  ?>



</body>

</html>