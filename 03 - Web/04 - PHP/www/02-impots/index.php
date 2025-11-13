<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calcul Impôt</title>
    <link rel="stylesheet" href="assets/css/style.css">
    <script src="./assets/js/script.js"></script>
</head>
<body>

<?php
    include "./models/Contribuable.php";

    $message = "";
    if (isset($_GET['send'])) {
        if (!empty($_GET['nom']) && !empty($_GET['revenu']))
        {
            $name = htmlspecialchars($_GET['nom']);
            $income = floatval($_GET['revenu']);
            $objContribuable = new Contribuable($name, $income);
            $result = $objContribuable->calculImpot();
        } else {
            $message = "Veuillez saisir tous les champs";
        }

    }
?>
    <div class="container">
        <form method="GET" action="<?php echo $_SERVER['PHP_SELF']?>" enctype="multipart/form-data" >
            
            <fieldset>
                <div id="summary">
                <?php echo $message ?>
            </div>
                <legend>Calcul de l'Impôt sur le Revenu</legend>

                <label for="nom">Nom Contribuable</label>
                <input type="text" id="nom" name="nom" value="<?php echo $name??'' ?>">

                <label for="revenu">Revenu Annuel</label>
                <input type="number" id="revenu" name="revenu" min="0" value="<?php echo $income??0 ?>">

                <button type="submit" name="send">Calculer</button>

                <label for="impot">Impôt sur le revenu annuel</label>
                <input type="text" id="impot" name="impot" readonly value="<?php echo $result??'0' ?>">
            </fieldset>
        </form>
    </div>
</body>
</html>