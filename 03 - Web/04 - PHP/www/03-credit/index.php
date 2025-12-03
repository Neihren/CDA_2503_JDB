<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <title>Calculatrice de prêt</title>
    <link rel="stylesheet" href="./assets/css/style.css">
</head>

<body>

    <?php
    include "./models/Pret.php";

    $message = "";
    if (isset($_GET['send'])) {
        if (!empty($_GET['capital']) && !empty($_GET['taux']) && !empty($_GET['duree'])) {
            $capital = intval($_GET['capital']);
            $taux = floatval($_GET['taux']);
            $duree = intval($_GET['duree']);
            $objPret = new Pret($capital, $taux, $duree);
            $result = round($objPret->calculMensualite(), 2);
            $tab = $objPret->tableauAmortissement();
        } else {
            $message = "Veuillez saisir tous les champs";
        }
    }
    ?>

    <div class="container">
        <form class="loan-form" method="GET" action="<?php echo $_SERVER['PHP_SELF'] ?>" enctype="multipart/form-data" >
            <h2>Calculatrice de prêt</h2>
            <?php echo $message ?>
            <div class="input-group">
                <label for="capital">Capital emprunté</label>
                <input type="number" id="capital" name="capital" value="<?php echo $capital ?? 0 ?>">
            </div>
            <div class="input-group">
                <label for="taux">Taux intérêt en %</label>
                <input type="number" step="0.01" id="taux" name="taux" value="<?php echo $taux ?? 0 ?>">
            </div>
            <div class="input-group">
                <label for="duree">Durée en années</label>
                <input type="number" id="duree" name="duree" value="<?php echo $duree ?? 0 ?>">
            </div>
            <div class="actions">
                <button type="submit" name="send">Valider</button>
                <div class="mensualite-group">
                    <label for="mensualite">Mensualité</label>
                    <input type="text" id="mensualite" name="mensualite" readonly value="<?php echo $result ?? '0' ?>">
                </div>
            </div>
        </form>

        <section class="table-section">
            <h3>Tableau d'amortissement du prêt</h3>
            <?php echo $tab ?? '' ?>
        </section>
    </div>
</body>

</html>