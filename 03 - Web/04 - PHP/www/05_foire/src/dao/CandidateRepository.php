<?php

class CandidateRepository
{
    private ?PDO $dbConnect;

    public function __construct()
    {
        $this->dbConnect = Dbconnection::getInstance();
    }


    public function searchAll(): array | bool
    {
        $query =       "SELECT
                            lastname_user AS Nom,
                            firstname_user AS Prenom,
                            mail_user AS Email,
                            departement_user AS Departement,
                            age_user AS Age
                        FROM
                            candidats;";
        $statement = $this->dbConnect->query($query);
        $data = $statement->fetchAll();
        return $data;
    }

    public function searchByEmail(string $_email): array | false
    {
        $email = filter_var($_email, FILTER_VALIDATE_EMAIL);
        $query =   "SELECT
                        lastname_user,
                        firstname_user,
                        mail_user,
                        pass_user,
                        departement_user,
                        age_user
                    FROM
                        candidats
                    WHERE
                        mail_user = :email;";
        $PDOstatement = $this->dbConnect->prepare($query);
        $PDOstatement->bindValue(":email", $email, PDO::PARAM_STR);
        $PDOstatement->execute();
        return $PDOstatement->fetch();
    }

    public function verifSignIn(string $_email, $_password) : array | bool {
    $email = filter_var($_email, FILTER_VALIDATE_EMAIL);
    $password = trim($_password);
    $query = "SELECT pass_user
              FROM candidats
              WHERE mail_user = :email;";
    $PDOstatement = $this->dbConnect->prepare($query);
    $PDOstatement->bindValue(":email", $email, PDO::PARAM_STR);
    if (! $PDOstatement->execute()) {
        return false;
    }
    $hash = $PDOstatement->fetchColumn();
    if ($hash === false) {
        return false;
    }
    if (password_verify($password, $hash)) {
        $query = "SELECT
                    lastname_user,
                    firstname_user,
                    mail_user,
                    departement_user,
                    age_user
                  FROM candidats
                  WHERE mail_user = :email;";
        $PDOstatement = $this->dbConnect->prepare($query);
        $PDOstatement->bindValue(":email", $email, PDO::PARAM_STR);
        if (! $PDOstatement->execute()) {
            return false;
        }
        return $PDOstatement->fetch(PDO::FETCH_ASSOC);
    }
    return false;
}

    public function createCandidate(string $_name, string $_firstname, string $_email, string $_password, int $_dep, int $_age): bool
    {
        $name = trim($_name);
        $firstname = trim($_firstname);
        $email = filter_var($_email, FILTER_VALIDATE_EMAIL);
        $password = trim($_password);
        $dep = filter_var($_dep, FILTER_VALIDATE_INT);
        $age = filter_var($_age, FILTER_VALIDATE_INT);   
        $query =   "INSERT INTO 
                        candidats ( lastname_user,
                                    firstname_user,
                                    mail_user,
                                    pass_user,
                                    departement_user,
                                    age_user,
                                    archive_user) 
                    VALUES 
                    (   :name,
                        :firstname,
                        :email,
                        :password,
                        :dep,
                        :age,
                        0)";
        $PDOstatement = $this->dbConnect->prepare($query);
        $PDOstatement->bindValue(":name", $name, PDO::PARAM_STR);
        $PDOstatement->bindValue(":firstname", $firstname, PDO::PARAM_STR);
        $PDOstatement->bindValue(":email", $email, PDO::PARAM_STR);
        $PDOstatement->bindValue(":password", password_hash($password, PASSWORD_ARGON2ID), PDO::PARAM_STR);
        $PDOstatement->bindValue(":dep", $dep, PDO::PARAM_INT);
        $PDOstatement->bindValue(":age", $age, PDO::PARAM_INT);
        return $PDOstatement->execute();        
    }
}
