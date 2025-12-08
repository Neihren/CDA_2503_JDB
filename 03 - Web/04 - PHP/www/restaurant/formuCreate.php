<?php
    require "./src/dao/Dbconnexion.php";
    require "./src/dao/RestaurantRepository.php";
    $objResto = new RestaurantRepository();

    $msg = "";
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        if (!empty($_POST["nom"]) && !empty($_POST["adresse"]) && !empty($_POST["prix"]) && !empty($_POST["commentaire"]) && !empty($_POST["note"]) && !empty($_POST["visite"])) {
            try {
                $ddate = new DateTime($_POST["visite"]);
                $currentDate = new DateTime();
                if ($ddate > $currentDate) {
                    throw new Exception('La date saisie doit être avant aujourd\'hui !');
                };
            } catch (Exception $e) {
                throw new Exception('Erreur de format de la date : ' . $e->getMessage());
            }
            $test = $objResto->createRestaurant($_POST["nom"], $_POST["adresse"], $_POST["prix"], $_POST["commentaire"], $_POST["note"], $ddate);
            if ($test) {
                header('Location:http://localhost/restaurant/index.php');
                exit;
            } else {
                $msg = "erreur d'intégration dans la table";
            }
        } else {
            $msg = "Veuillez remplir toutes les zones du formulaire :";
        }
    } else {
        $msg = "Veuillez utiliser le formulaire suivant :";
    }
?>

<!DOCTYPE html>
<html lang="fr-FR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>gestion listes des critiques de restaurants</title>
    <link rel="stylesheet" href="assets/css/formu.css">
</head>
<body>
 <div class="container">
        <h1>Ajouter un Restaurant</h1>
        <?php  echo $msg; ?>
        <form action="#" method="POST" >
            
            <div class="form-group">
                <label for="nom">Nom du Restaurant :</label>
                <input type="text" id="nom" name="nom" required maxlength="100">
            </div>

            <div class="form-group">
                <label for="adresse">Adresse :</label>
                <input type="text" id="adresse" name="adresse" required maxlength="250">
            </div>

            <div class="form-group">
                <label for="prix">Prix Moyen (€) :</label>
                <input type="number" id="prix" name="prix" required min="0" step="0.01">
            </div>

            <div class="form-group">
                <label for="commentaire">Commentaire :</label>
                <textarea id="commentaire" name="commentaire" required rows="5"></textarea>
            </div>

            <div class="form-group">
                <label for="note">Note (/10) :</label>
                <input type="number" id="note" name="note" required min="0" max="10" step="0.1">
            </div>

            <div class="form-group">
                <label for="visite">Date de Visite :</label>
                <input type="date" id="visite" name="visite" required>
            </div>

            <button type="submit">Enregistrer le Restaurant</button>

        </form>
</div>