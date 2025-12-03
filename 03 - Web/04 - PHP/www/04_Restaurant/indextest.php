<?php
require "./src/dao/Dbconnexion.php"; 

// Récupération de l'instance PDO
$pdo = Dbconnexion::getInstance();

// Récupération de la liste des restaurants pour le <select>
$stmt = $pdo->query("SELECT id, nom FROM restaurants ORDER BY nom");
$restaurants = $stmt->fetchAll();

// Récupération des infos d’un restaurant sélectionné
$restaurantDetails = null;
if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['restaurant_id'])) {
    $id = (int) $_POST['restaurant_id'];

    $stmtDetail = $pdo->prepare(
        "SELECT nom, adresse, prix, commentaire, note, visite 
         FROM restaurants 
         WHERE id = :id"
    );
    $stmtDetail->execute([':id' => $id]);
    $restaurantDetails = $stmtDetail->fetch();
}
?>

<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Guide des restaurants</title>
    <link rel="stylesheet" href="./assets/css/style.css">
</head>
<body>
<div class="page">
    <header class="header">
        <h1>Guide des restaurants</h1>
        <p>Sélectionne un restaurant pour afficher ses informations.</p>
    </header>

    <main class="content">
        <section class="card">
            <form method="post" class="form">
                <div class="form-group">
                    <label for="restaurant_id">Restaurant</label>
                    <select name="restaurant_id" id="restaurant_id" required>
                        <option value="">— Choisir un restaurant —</option>
                        <?php foreach ($restaurants as $rest) : ?>
                            <option value="<?php echo (int)$rest['id']; ?>"
                                <?php
                                if (isset($_POST['restaurant_id']) && (int)$_POST['restaurant_id'] === (int)$rest['id']) {
                                    echo ' selected';
                                }
                                ?>>
                                <?php echo htmlspecialchars($rest['nom'], ENT_QUOTES, 'UTF-8'); ?>
                            </option>
                        <?php endforeach; ?>
                    </select>
                </div>

                <button type="submit" class="btn-primary">Afficher les informations</button>
            </form>
        </section>

        <?php if ($restaurantDetails) : ?>
            <section class="card details">
                <h2><?php echo htmlspecialchars($restaurantDetails['nom'], ENT_QUOTES, 'UTF-8'); ?></h2>
                <p><span class="label">Adresse :</span>
                    <?php echo htmlspecialchars($restaurantDetails['adresse'], ENT_QUOTES, 'UTF-8'); ?>
                </p>
                <p><span class="label">Prix moyen :</span>
                    <?php echo number_format((float)$restaurantDetails['prix'], 2, ',', ' '); ?> €
                </p>
                <p><span class="label">Commentaire :</span></p>
                <p class="commentaire">
                    <?php echo nl2br(htmlspecialchars($restaurantDetails['commentaire'], ENT_QUOTES, 'UTF-8')); ?>
                </p>
                <p><span class="label">Note :</span>
                    <?php echo htmlspecialchars($restaurantDetails['note'], ENT_QUOTES, 'UTF-8'); ?>/10
                </p>
                <p><span class="label">Date de visite :</span>
                    <?php
                    $date = new DateTime($restaurantDetails['visite']);
                    echo $date->format('d/m/Y');
                    ?>
                </p>
            </section>
        <?php elseif ($_SERVER['REQUEST_METHOD'] === 'POST') : ?>
            <section class="card">
                <p>Aucun restaurant trouvé pour cette sélection.</p>
            </section>
        <?php endif; ?>
    </main>

    <footer class="footer">
        <p>Guide des restaurants &copy; <?php echo date('Y'); ?></p>
    </footer>
</div>
</body>
</html>