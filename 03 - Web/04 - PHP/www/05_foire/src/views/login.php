<form action="index.php?page=login" method="post" enctype="multipart/form-data">
    <label for="email">Email candidat:</label>
    <input type="email" id="email" name="email" required>
    <br>
    <label for="password">Mot de passe:</label>
    <input type="password" id="password" name="password" required>
    <br>
    <div><?php echo $msg; ?> </div>
    <button type="submit">S'authentifier</button>
</form>
