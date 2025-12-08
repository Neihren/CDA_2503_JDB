
  
  <?php 

if($_SERVER['REQUEST_METHOD']==='POST'){
    $username=htmlspecialchars($_POST['username']);
    $email=htmlspecialchars($_POST['email']);
    $password=htmlspecialchars($_POST['password']);
    $confirmPassword=htmlspecialchars($_POST['confirmPassword']);
    $department=htmlspecialchars($_POST['department']);
    $age=htmlspecialchars($_POST['age']);

    $errors=[];

    if(empty($username) || empty($email) || empty($password) || empty($confirmPassword) || empty($department) || empty($age)){
        $errors[]="Tous les champs sont obligatoires.";
    }

    if(!filter_var($email,FILTER_VALIDATE_EMAIL)){
        $errors[]="L'adresse email n'est pas valide.";
    }

    if($password !== $confirmPassword){
        $errors[]="Les mots de passe ne correspondent pas.";
    }

    if($age < 18){
        $errors[]="Vous devez avoir au moins 18 ans pour vous inscrire.";
    }

    $candidateRepo=new CandidateRepository();
    if($candidateRepo->searchByEmail($email)){
        $errors[]="Un candidat avec cet email existe déjà.";
    }

    if(empty($errors)){
        $hashedPassword=password_hash($password,PASSWORD_BCRYPT);
        $data=[
            'username'=>$username,
            'email'=>$email,
            'password'=>$hashedPassword,
            'department'=>$department,
            'age'=>$age
        ];
        if($candidateRepo->insert($data)){
            echo "<p>Inscription réussie !</p>";
        }else{
            echo "<p>Erreur lors de l'inscription. Veuillez réessayer.</p>";
        }
    }else{
        foreach($errors as $error){
            echo "<p style='color:red;'>$error</p>";
        }
    }
}


?>
  <!-- <form action="" method="post" enctype="multipart/form-data">
        <label for="username">Nom candidat:</label>
        <input type="text" id="username" name="username" required>
        <br>
        <label for="email">Email candidat:</label>
        <input type="email" id="email" name="email" required>
        <br>
        <label for="password">Mot de passe:</label>
        <input type="password" id="password" name="password" required>
        <br>
        <label for="confirmPassword">Confirmation du mot de passe:</label>
        <input type="password" id="confirmPassword" name="confirmPassword" required>
        <br>
        <select name="department" id="department">
            <?php
          
            // $objDept = new departmentRepository();
            // $tabData = $objDept->searchAll();
            // for ($i = 0; $i < count($tabData); $i++) {

            //     echo "<option value='" . $tabData[$i]["id_dep"] . "' >" . $tabData[$i]["Name"] . "</option>";
            // }

            ?>
        </select><br>

        <label for="age"> Votre age: *</label>
        <input type="number" name="age" id="age" step="1" min="18" max="120">
        <br>
         <div id="summary">* Vous devez avoir plus de 18 ans pour participer au jeu-concours</div>       
        <button type="submit">Register</button>
    </form> -->
    <form action="" method="post" enctype="multipart/form-data">
    <div>
        <label for="username">Nom candidat:</label>
        <input type="text" id="username" name="username" required>
    </div>
    <div>
        <label for="email">Email candidat:</label>
        <input type="email" id="email" name="email" required>
    </div>
    <div>
        <label for="password">Mot de passe:</label>
        <input type="password" id="password" name="password" required>
    </div>
    <div>
        <label for="confirmPassword">Confirmation du mot de passe:</label>
        <input type="password" id="confirmPassword" name="confirmPassword" required>
    </div>
    <select name="department" id="department">
        <?php
        $objDept = new departmentRepository();
        $tabData = $objDept->searchAll();
        for ($i = 0; $i < count($tabData); $i++) {
            echo "<option value='" . $tabData[$i]["id_dep"] . "' >" . $tabData[$i]["Name"] . "</option>";
        }
        ?>
    </select>
    <div>
        <label for="age"> Votre age: *</label>
        <input type="number" name="age" id="age" step="1" min="18" max="120">
    </div>
    <div id="summary">* Vous devez avoir plus de 18 ans pour participer au jeu-concours</div>
    <button type="submit">Register</button>
</form>