<form action="index.php?page=inscription" method="post" enctype="multipart/form-data">
    <label for="lastname">Nom candidat:</label>
    <input type="text" id="lastname" name="lastname" required>
    <br>
    <label for="firstname">Prénom candidat:</label>
    <input type="text" id="firstname" name="firstname" required>
    <br>
    <label for="email">Email candidat:</label>
    <input type="email" id="email" name="email" required>
    <br>
    <label for="password">Mot de passe:</label>
    <input type="password" id="password" name="password" required>
    <br>
    <label for="confirmPassword">Confirmation du Mot de passe:</label>
    <input type="password" id="confirmPassword" name="confirmPassword" required>
    <br>
    <select name="department" id="department">
        <?php
        for ($i = 0; $i < count($tabData); $i++) {
            echo "<option value='" . $tabData[$i]["Id"] . "' >" . $tabData[$i]["Nom"] . "</option>";
        }
        ?>
    </select>
    <br>
    <label for="age"> Votre age :*</label>
    <input type="number" name="age" id="age" step="1" min="18" max="122">
    <br>
    <div id="summary">*vous devez avoir plus de 18 ans pour participer</div>
    <div><?php echo $msg; ?> </div>
    <button type="submit">Register</button>
</form>


